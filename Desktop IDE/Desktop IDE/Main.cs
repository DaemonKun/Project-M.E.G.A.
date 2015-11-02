using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;
using System.Security.Principal;

namespace Desktop_IDE
{
    public partial class Main : MetroForm
    {
        Process newprocess = new Process();

        public Main()
        {
            //hotspot
            newprocess.StartInfo.UseShellExecute = false;
            newprocess.StartInfo.CreateNoWindow = true;
            newprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            InitializeComponent();
            this.StyleManager = msmMain;
            tabMenu.SelectedTab = tabTitle;
        }

        #region Hotspot
        
        public void Process_1()
        {
            pb.Value = 0;
            pb.Increment(25);
            newprocess.StartInfo.FileName = "netsh";
            newprocess.StartInfo.Arguments = "wlan stop hostednetwork";
            try
            {
                using(Process execute = Process.Start(newprocess.StartInfo))
                {
                    execute.WaitForExit();
                    pb.Increment(25);
                    Process_2();
                }
            }
            catch
            {
                //Nothing
            }
        }
        public void Process_2()
        {
            newprocess.StartInfo.FileName = "netsh";
            newprocess.StartInfo.Arguments = "wlan set hostednetwork mode=allow ssid=MEGA key=x8743k0J";
            try
            {
                using (Process execute = Process.Start(newprocess.StartInfo))
                {
                    execute.WaitForExit();
                    pb.Increment(25);
                    Process_3();

                }
            }
            catch
            {
                //Nothing
            }
        }
        public void Process_3()
        {
            newprocess.StartInfo.FileName = "netsh";
            newprocess.StartInfo.Arguments = "wlan start hostednetwork";
            try
            {
                using (Process execute = Process.Start(newprocess.StartInfo))
                {
                    execute.WaitForExit();
                    pb.Increment(25);
                    butHotspot.Text = "Stop Hotspot";
                    
                }
            }
            catch
            {
                //Nothing
            }
        }
        public void Process_stop()
        {
            pb.Value = 0;
            newprocess.StartInfo.FileName = "netsh";
            newprocess.StartInfo.Arguments = "wlan stop hostednetwork";
            try
            {
                pb.Increment(50);
                using (Process execute = Process.Start(newprocess.StartInfo))
                {
                    execute.WaitForExit();
                    pb.Increment(50);
                    butHotspot.Text = "Start Hotspot";
                    
                }
            }
            catch
            {
                //Nothing
            }
        }
        private void clickHotspot(object sender, EventArgs e)
        {
            if (butHotspot.Text == "Start Hotspot")
            {
                Process_1();
            }
            else if(butHotspot.Text == "Stop Hotspot")
            {
                Process_stop();
            }
                
        }
        #endregion

        private void checkTheme(object sender, EventArgs e)
        {
            if (chkTheme.Checked)
            {
                msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
                msmMain.Style = MetroFramework.MetroColorStyle.Green;
                
            }
            else
            {
                msmMain.Style = MetroFramework.MetroColorStyle.Blue;
                msmMain.Theme = MetroFramework.MetroThemeStyle.Light;
               
                
            }
        }

        

       

        

       
    }
}
