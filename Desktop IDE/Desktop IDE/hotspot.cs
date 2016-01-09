using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Desktop_IDE
{
    public static class hotspot
    {
        private static Process newprocess = new Process();

        public static IMain main;
        
        public static void initialize()
        {
            newprocess.StartInfo.UseShellExecute = false;
            newprocess.StartInfo.CreateNoWindow = true;
            newprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        }
        private static void start()
        {
            newprocess.StartInfo.FileName = "netsh";
            newprocess.StartInfo.Arguments = "wlan stop hostednetwork";
            try
            {
                using (Process execute = Process.Start(newprocess.StartInfo))
                {
                    execute.WaitForExit();
                    Process_2();
                }
            }
            catch
            {
                //Nothing
            }
        }
        private static void Process_2()
        {
            newprocess.StartInfo.FileName = "netsh";
            newprocess.StartInfo.Arguments = "wlan set hostednetwork mode=allow ssid=MEGA key=x8743k0J";
            try
            {
                using (Process execute = Process.Start(newprocess.StartInfo))
                {
                    execute.WaitForExit();
                    Process_3();

                }
            }
            catch
            {
                //Nothing
            }
        }
        private static void Process_3()
        {
            newprocess.StartInfo.FileName = "netsh";
            newprocess.StartInfo.Arguments = "wlan start hostednetwork";
            try
            {
                using (Process execute = Process.Start(newprocess.StartInfo))
                {
                    execute.WaitForExit();
                    main.Hotspot = "Stop Hotspot";

                }
            }
            catch
            {
                //Nothing
            }
        }
        private static void stop()
        {
            newprocess.StartInfo.FileName = "netsh";
            newprocess.StartInfo.Arguments = "wlan stop hostednetwork";
            try
            {
                using (Process execute = Process.Start(newprocess.StartInfo))
                {
                    execute.WaitForExit();
                    main.Hotspot = "Start Hotspot";

                }
            }
            catch
            {
                //Nothing
            }
        }
        public static void startStop()
        {
            if (main.Hotspot.Equals("Start Hotspot"))
                start();
            else if (main.Hotspot.Equals("Stop Hotspot"))
                stop();
        }
        public static void exit()
        {
            stop();
        }
    }
}
