/*
 Name:		MEGA.ino
 Created:	1/1/2016 9:27:02 PM
 Author:	artwin
*/


/*
Name:		MEGA.ino
Created:	11/18/2015 5:07:29 PM
Author:	DaemonKun
*/

#include <Adafruit_CC3000.h>
#include <ccspi.h>
#include <UTFT.h>
#include <memorysaver.h>
#include <UTouch.h>
#include <UTouchCD.h>
#include <SPI.h>
#include <SD.h>
#include <TFT_ExtensionV2.h>




#pragma region CC3000_Define

#define ADAFRUIT_CC3000_IRQ   3  
#define ADAFRUIT_CC3000_VBAT  5
#define ADAFRUIT_CC3000_CS    10


#define WLAN_SSID       "MEGA"   
#define WLAN_PASS       "x8743k0J"
#define WLAN_SECURITY   WLAN_SEC_WPA2

Adafruit_CC3000 cc3000 = Adafruit_CC3000(ADAFRUIT_CC3000_CS, ADAFRUIT_CC3000_IRQ, ADAFRUIT_CC3000_VBAT,
	SPI_CLOCK_DIVIDER);
Adafruit_CC3000_Client client;
#define IDLE_TIMEOUT_MS  700
#pragma endregion
#pragma region UTFT_define
UTFT LCD(SSD1963_480, 38, 39, 40, 41);
UTouch touch(48, 47, 46, 45, 44);
Base B(&LCD, &touch);
Box _butA(&B), _butB(&B), _butC(&B), _butD(&B),_butOK(&B),_butPrev(&B), _butNext(&B),goBack(&B),finish(&B);
extern uint8_t SmallFont[];
byte texty_center;
bool isIncrement;
#pragma endregion



void setup(){

	startup();
	Question();
  fin();


}
void loop(){
	delay(1000);
}

#pragma region Initializations
bool initializeWIFI(){
	uint32_t ip = cc3000.IP2U32(192, 168, 173, 1);
	if (!cc3000.begin())
	{
		return false;
	}
	if (!cc3000.connectToAP(WLAN_SSID, WLAN_PASS, WLAN_SECURITY)) {
		return false;
	}
	while (!cc3000.checkDHCP())
	{
		delay(20); // ToDo: Insert a DHCP timeout!
	}
	while (!client.connected()){
		client = cc3000.connectTCP(ip, 100);
	}
	return true;
}
bool initializeTFT(){

	LCD.InitLCD(LANDSCAPE);
	LCD.clrScr();
	LCD.setFont(SmallFont);
	LCD.fillScr(VGA_BLUE);
	LCD.setColor(VGA_WHITE);
	LCD.setBackColor(VGA_BLUE);

	texty_center = (272 / 2) - 6;

	touch.InitTouch();
	touch.setPrecision(PREC_MEDIUM);

	


	//_butOK = buttons.addButton(220, (272 / 2) + 9, 40, 20, "OK");
  _butOK.Coords(220,(272/2)+9,260,(272/2)+29);
  _butOK.Colors(BLUE,BLACK,ROUNDED,FILL);
  _butOK.Text("OK",WHITE,Small);
  
  _butPrev.Coords(120,230,210,250);
  _butPrev.Colors(BLUE,BLACK,ROUNDED,FILL);
  _butPrev.Text("Previous",WHITE,Small);

  _butNext.Coords(270,230,360,250);
  _butNext.Colors(BLUE,BLACK,ROUNDED,FILL);
  _butNext.Text("Next",WHITE,Small);
	
  _butA.Coords(14, 142, 234, 172);
  _butA.Colors(BLUE, RED, ROUNDED, NOFILL);

  _butB.Coords(246, 142, 466, 172);
  _butB.Colors(BLUE, RED, ROUNDED, NOFILL);
  
  _butC.Coords(14, 186, 234, 216);
  _butC.Colors(BLUE, RED, ROUNDED, NOFILL);

  _butD.Coords(246, 186, 466, 216);
  _butD.Colors(BLUE, RED, ROUNDED, NOFILL);

  

  
	return true;

}
bool initializeSD(){
	if (!SD.begin(4)){
		return false;
	}
	if (SD.exists("answers.tmp")){
		SD.remove(("answers.tmp"));
	}
	SD.remove(("question.tmp"));
	delay(100);
	return true;
}

bool initializeRFID(){
	Serial1.begin(9600);
	String scanned;
	while (Serial1.available() <= 0){
		delay(10);
	}
	if (Serial1.available() > 0) {
		for (byte i = 0; i < 14; i++){
			char read = Serial1.read();
			scanned += read;
			delay(50);
		}
		scanned = "RFID:" + scanned.substring(1, 13);
    delay(500);
		if (checkRequest(scanned) == false){
			Serial1.end();
			return false;
		}
    else{
      Serial.end();
      return true;
    }

	}
}
#pragma endregion


void startup(){
	//Serial.begin(9600);

	while (!initializeSD()){
		delay(10);
	}
	while (!initializeTFT()){
		delay(10);
	}
	LCD.print(F("Connecting..."), CENTER, texty_center);
	while (!initializeWIFI()){
		delay(10);
	}
  LCD.print(F("                      "), CENTER, texty_center);
	LCD.print(F("Connected!"), CENTER, texty_center);
	/*delay(1000);
	LCD.print(F("                      "), CENTER, texty_center);
	LCD.print(F("Scanning for ID..."), CENTER, texty_center);
	while (!initializeRFID()){
	LCD.print(F("                              "), CENTER, texty_center);
	LCD.print(F("Not valid ID"), CENTER, texty_center);
	delay(500);
	LCD.print(F("                      "), CENTER, texty_center);
	LCD.print(F("Scanning for ID..."), CENTER, texty_center);
	delay(50);
	}
  delay(1000);
	LCD.print(F("                              "), CENTER, texty_center);
	LCD.print(F("Valid!"), CENTER, texty_center);*/
  delay(1000);
	LCD.print(F("                              "), CENTER, texty_center);
	LCD.print(F("Downloading the question file..."), CENTER, texty_center);

	while (!sendRequest(F("get file"))){
		delay(10);
	}

}
void checkMiss(char* ans, uint8_t limit){
  int countx = 0;
  LCD.fillScr(VGA_BLUE);
  LCD.setColor(VGA_WHITE);
  LCD.setBackColor(VGA_BLUE);
  LCD.print(F("Checking for unanswered items..."),CENTER,texty_center - 5);
  for(uint8_t i = 1; i <= limit;i++){
    if(ans[i] == NULL){
      countx++;
      continue;
    }
  }
  if(countx > 0){
    String sentence = "Found " + (String)countx + " unanswered items.";
    LCD.print(sentence,CENTER,texty_center+5);
    LCD.print(F("Do you wish to answer those?"),CENTER,texty_center+10);
      goBack.Coords(120,200,210,220);
      goBack.Colors(BLUE,BLACK,ROUNDED,FILL);
      goBack.Text("Go Back",WHITE,Small);
      goBack.Draw();
      finish.Coords(270,200,360,220);
      finish.Colors(BLUE,BLACK,ROUNDED,FILL);
      finish.Text("Finish",WHITE,Small);
      finish.Draw();
        
      while(true){
        if(goBack.Touch()){
          for(uint8_t i = 1; i <=limit;i++){
            if(ans[i] != NULL){
              continue;
            }
            else{
              dispQuestion(i,limit);
              while(checkAnswers(i,ans)){
                delay(50);
              }
            }
          }
        break;
        }
        else if(finish.Touch()){
          break;
        }
          
      }
  }
  delay(100);
    
}

bool checkButtons(uint8_t i,uint8_t limit, char* ans){
  if( i == 1){
    
      if(_butNext.Touch()){
      isIncrement = true;
      return false;
      }
      else{
        checkAnswers(i, ans);
        return true;
     }    
  }
  else if((i==limit)&&(limit==1)){
    
    if(_butNext.Touch()){
        isIncrement = true;
        return false;
    }  
    else{
        checkAnswers(i, ans);
        return true;
    }  
  }
  else if(i==limit){
    
    
      if(_butNext.Touch()){
        isIncrement = true;
        return false;
      }
      else if(_butPrev.Touch()){
        isIncrement = false;
        return false;
      }
      else{
        checkAnswers(i, ans);
        return true;
      } 
  }
  else{
      if(_butNext.Touch()){
        isIncrement = true;
        return false;
      }
      else if(_butPrev.Touch()){
        isIncrement = false;
        return false;
      }
      else{
        checkAnswers(i, ans);
        return true;
      } 
  }
}

bool checkAnswers(uint8_t i, char* ans){
  if(_butA.Touch()){
    ans[i] = 'A';
    return false;
  }
  else if(_butB.Touch()){
    ans[i] = 'B';
    return false;
  }
  else if(_butC.Touch()){
    ans[i] = 'C';
    return false;
  }
  else if(_butD.Touch()){
    ans[i] = 'D';
    return false;
  }
  else
    return true;
}

void Question()
{

	uint8_t limit = getLimit();
  char ans[limit+1];
  for(uint8_t i = 0; i <= limit; i++){
    ans[i] = NULL;
  }
	uint8_t i = 1;
	while (i <= limit){
		dispQuestion(i, limit);
    if(i==1){
      _butNext.Text("Next",WHITE,Small);
      _butNext.ReDraw();
    }
    else if((i==1)&&(i==limit)){
      _butNext.Text("Finish",WHITE,Small);
      _butNext.ReDraw();
    }
    else if(i==limit){
      _butPrev.ReDraw();
      _butNext.Text("Finish",WHITE,Small);
      _butNext.ReDraw();
    }
    else{
      _butNext.Text("Next",WHITE,Small);
      _butPrev.Text("Previous",WHITE,Small);
      _butPrev.ReDraw();
      _butNext.ReDraw();
    }
		while(checkButtons(i,limit,ans)){
      delay(10);
		}
    if(isIncrement == true){
      i++;
    }
    else
      i--;
		delay(100);
	}
  checkMiss(ans,limit);
  Answers(ans,limit);
  
}


bool sendRequest(String request)
{
	if (request == F("get file")){
		if (client.connected()){
			client.fastrprintln(F("get file"));
			if (client.available()){
				File myfile = SD.open("question.tmp", FILE_WRITE);
				saveFile(&myfile);
				myfile.close();
				LCD.print(F("                                 "), CENTER, ((272 / 2) - 6) - 5);
				LCD.print(F("                                 "), CENTER, ((272 / 2) - 6));
				LCD.print(F("File Received"), CENTER, ((272 / 2) - 6) - 5);
				_butOK.Draw();
				client.flush();
				while(true){
          if(_butOK.Touch()){
            break;
          }
          delay(10);
				}
			}
			else
				return false;
		}
		return true;
	}
	else{
		if (client.connected()){
			client.print(request);
			return true;
		}
		else
			return false;
	}
}

void saveFile(File* file)
{
	unsigned long lastRead = millis();
	while (client.connected() && (millis() - lastRead < IDLE_TIMEOUT_MS)){
		while (client.available()) {
			byte c = client.read();
			file->write(c);
		}
	}
}

uint8_t getLimit()
{
	File questionFile = SD.open("question.tmp", FILE_READ);
	uint8_t lim = 1;
	String LimitStr = String(lim);
	String readLimit = questionFile.readStringUntil('\n');
	while (LimitStr != readLimit){
		lim++;
		LimitStr = String(lim);
	}
	questionFile.close();
	return lim;
}

void dispQuestion(uint8_t limNum, uint8_t limit)
{
	File file = SD.open("question.tmp", FILE_READ);
	LCD.fillScr(VGA_BLUE);
	LCD.setColor(VGA_WHITE);
	LCD.setBackColor(VGA_BLUE);
	String question;
	String Answer[5];
	String lim = "<" + String(limNum) + ">";
	lim.reserve(10);
  Answer[0].reserve(50);
  Answer[1].reserve(50);
  Answer[2].reserve(50);
  Answer[3].reserve(50);
  question.reserve(50);
	while (file.available()){
		if (file.find(strstr(lim.c_str(), lim.c_str()))){
			question = file.readStringUntil('\n');
			for (uint8_t j = 0; j < 4; j++){
				Answer[j] = file.readStringUntil('\n');
			}
			break;
		}
	}
	file.close();
	question.remove(0, question.indexOf(":")+1);
	question = String(limNum) + ". " + question;
	for (uint8_t j = 0; j < 4; j++){
		Answer[j].remove(0, Answer[j].indexOf(":")+1);
	}
	Answer[0] = "A." + Answer[0];
	Answer[1] = "B." + Answer[1];
	Answer[2] = "C." + Answer[2];
	Answer[3] = "D." + Answer[3];

	LCDdispQuestion(question);
  
	_butA.Text(strstr(Answer[0].c_str(), Answer[0].c_str()), WHITE, Small);
	_butA.ReDraw();

  
  _butB.Text(strstr(Answer[1].c_str(), Answer[1].c_str()), WHITE, Small);
  _butB.ReDraw();

 
  _butC.Text(strstr(Answer[2].c_str(), Answer[2].c_str()), WHITE, Small);
  _butC.ReDraw();

  
  _butD.Text(strstr(Answer[3].c_str(), Answer[3].c_str()), WHITE, Small);
  _butD.ReDraw();

}

void LCDdispQuestion(String question){
	String temp;
	temp.reserve(10);
	uint8_t prev = 0, newY, current = 0, numLines = question.length() / 59;
	newY = (272 / 4) - 49;
	if (numLines > 4){
		LCD.print(F("Question too long"), CENTER, 272 / 4);
	}

	if (numLines == 0){
		LCD.print(question, CENTER, 272 / 4);
	}
	else{
		while (prev != (question.length())){
			if (current == numLines){
				LCD.print(question.substring(prev, question.length() - 1), CENTER, newY += 14);
				prev = question.length();
			}
			else{
				for (uint8_t i = prev + 58; i >= prev; i--){
					if (question.charAt(i) == ' '){
						temp = question.substring(prev, i);
						LCD.print(temp, CENTER, newY += 14);
						break;
					}
				}
				prev = prev + temp.length();
				current++;
			}
		}
	}
}

bool checkRequest(String RFID){
	String response;
	while (!sendRequest(RFID)){
		delay(10);
	}
	unsigned long lastRead = millis();
	while (client.connected() && (millis() - lastRead < IDLE_TIMEOUT_MS)){
		while (client.available()) {
			char c = client.read();
			response += c;
      
		}
	}
  client.flush();
  delay(50);
	if (response == F("valid")){
		return true;
	}
	else if (response == F("not valid")){
		return false;
	}

}
void Answers(char* ans,uint8_t limit){
  File answers = SD.open("answers.tmp", FILE_WRITE);
  answers.print(F("<Answers>:\n"));
  delay(50);
  for(uint8_t i = 1;i <= (limit);i++){
    if(ans[i]!=NULL){
      answers.print("<" + (String)i+ ">:" + (String)ans[i] + "\n");  
    }
    delay(50);
  }
  answers.print(F("?"));
  answers.close();
}

void fin(){
  LCD.fillScr(VGA_BLUE);
  LCD.setColor(VGA_WHITE);
  LCD.setBackColor(VGA_BLUE);

  LCD.print(F("Sending your answers to the server for checking..."),CENTER,texty_center);
  sendAnswers();
  LCD.print(F("                                                         "),CENTER,texty_center);
  LCD.print(F("Answers sent. Waiting for score.."),CENTER,texty_center);
  while(!getScore()){
    delay(50);
  }
  
  
}

void sendAnswers(){
  File answer = SD.open("answers.tmp",FILE_READ);
  String request = answer.readStringUntil('?');
  while(!sendRequest(request)){
    delay(50);
  }
}

bool getScore(){
  String response;
  client.flush();
  if(client.connected()){
    sendRequest(F("get score"));
    unsigned long lastRead = millis();
    while (client.connected() && (millis() - lastRead < IDLE_TIMEOUT_MS)){
      while (client.available()) {
        char c = client.read();
        response += c;
        delay(10);
      }
      client.flush();
    }
    if(response.startsWith("<score>:")){
      response = response.substring(response.indexOf(":")+1,response.length());
      LCD.print(F("                                                         "),CENTER,texty_center);
      LCD.print("Your score is " + response,CENTER,texty_center);
      return true;
    }
    else{
      return false;
    }
  }
  else
     return false;
}
/* RFID TAGS:
4800EC808EAA
4800EC1E912B
4800EC45EA0B
*/
