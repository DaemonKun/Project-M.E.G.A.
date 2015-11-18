
/*
Name:		MEGA.ino
Created:	11/18/2015 5:07:29 PM
Author:	DaemonKun
*/

#pragma region Include<>
#include <UTFT_Buttons.h>
#include <UTouch.h>
#include <UTouchCD.h>
#include <memorysaver.h>
#include <UTFT.h>
#include <SD.h>
#include <SPI.h>
#include <Adafruit_CC3000.h>
#include <ccspi.h>
#pragma endregion
#pragma region CC3000_Define
#define ADAFRUIT_CC3000_IRQ   3  
#define ADAFRUIT_CC3000_VBAT  5
#define ADAFRUIT_CC3000_CS    10
#define IDLE_TIMEOUT_MS  500

#define WLAN_SSID       "Tejada"   
#define WLAN_PASS       "tejadaonly"
#define WLAN_SECURITY   WLAN_SEC_WPA2

Adafruit_CC3000 cc3000 = Adafruit_CC3000(ADAFRUIT_CC3000_CS, ADAFRUIT_CC3000_IRQ, ADAFRUIT_CC3000_VBAT,
                                         SPI_CLOCK_DIVIDER);
Adafruit_CC3000_Client client;
#pragma endregion
#pragma region UTFT_define
UTFT LCD(SSD1963_480,38,39,40,41);
UTouch touch(48,47,46,45,44);
extern uint8_t SmallFont[];
int texty_center, dispx,dispy,prevY;
UTFT_Buttons buttons(&LCD,&touch);
#pragma endregion

void setup(){
  Serial.begin(9600);
  pinMode(4, INPUT_PULLUP);  // SD Card
  pinMode(10, INPUT_PULLUP); // CC3000
  

  if(!SD.begin(4)){
  Serial.println(F("SD Error!"));
  while(1);
  }
  while(!initializeTFT()){
	  //nothing
  }
  LCD.print(F("Connecting..."),CENTER,texty_center);
  while(!initializeWIFI()){
    //nothing
  }
  LCD.print(F("              "),CENTER,texty_center);
  LCD.print(F("Connected!"),CENTER,texty_center - 5);
  LCD.print(F("Downloading the question file..."),CENTER,texty_center+5);
  while(!Sendrequest("get file")){
    //nothing
  }
  Question();
  delay(2000);
  
  
}
void loop(){
  delay(1000);
}
#pragma region Initializations
bool initializeWIFI(){
  uint32_t ip = cc3000.IP2U32(192,168,16,105);
  if(!cc3000.begin())
  {
	  //nothing
    while(1);
  }
  if (!cc3000.connectToAP(WLAN_SSID, WLAN_PASS, WLAN_SECURITY)) {
    //nothing
    while(1);
  }
  while (!cc3000.checkDHCP())
  {
    delay(100); // ToDo: Insert a DHCP timeout!
  }
  client = cc3000.connectTCP(ip,100);
  return true;
}
bool initializeTFT(){
  LCD.InitLCD(LANDSCAPE);
  LCD.clrScr();
  LCD.setFont(SmallFont);
  LCD.fillScr(VGA_BLUE);
  LCD.setColor(VGA_WHITE);
  LCD.setBackColor(VGA_BLUE);

  dispx = LCD.getDisplayXSize();
  dispy = LCD.getDisplayYSize();
  texty_center = (dispy/2)-6;
  
  touch.InitTouch();
  touch.setPrecision(PREC_MEDIUM);

  buttons.setButtonColors(VGA_WHITE, VGA_WHITE, VGA_WHITE, VGA_RED, 0x515151);
  buttons.setTextFont(SmallFont);
  return true;
  
}
#pragma endregion
bool Sendrequest(String x){
  
  if(x == "get file"){
    File myFile;
	int butOK, pressed_but;
	butOK = buttons.addButton(228, texty_center + 15, 24, 20,"OK");

    if(client.connected()){
      client.fastrprintln(F("get file"));
      if(!SD.exists("example.mgq")){ 
        myFile = SD.open("example.mgq", FILE_WRITE);
        myFile.close();
       }
      else{
      SD.remove("example.mgq");
      }
      if(client.available()){
        myFile = SD.open("example.mgq", FILE_WRITE);
        Serial.println(myFile.size());
        unsigned long lastRead = millis();
        while(client.connected() && (millis() - lastRead < IDLE_TIMEOUT_MS)){
          while (client.available()) {
            byte c = client.read();
            myFile.write(c);
          }
        }
        LCD.print(F("                                 "),CENTER,texty_center-5);
        LCD.print(F("                                 "),CENTER,texty_center+5);
        LCD.print(F("File Received"),CENTER,texty_center-5);
		buttons.drawButton(butOK);
        Serial.println(myFile.size());
        myFile.close();
        client.flush();
		while (1){
			if (touch.dataAvailable() == true){
				pressed_but = buttons.checkButtons();
				if (pressed_but == butOK){
					break;
				}
			}
		}
      }
      else
        return false;
    }
	return true;
  }
  else
    return false;
}


void Question(){
  LCD.fillScr(VGA_BLUE);
  LCD.setColor(VGA_WHITE);
  LCD.setBackColor(VGA_BLUE);

  File questionFile;
  String question;
  String answer[4];
  bool isFinish = false;
  questionFile = SD.open("example.mgq",FILE_READ);
  while(questionFile.available()){
    
  }
  
  /*do
  {
    
  }
  while(!isFinish);
*/
  
}

