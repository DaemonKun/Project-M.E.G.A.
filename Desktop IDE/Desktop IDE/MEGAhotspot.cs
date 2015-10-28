using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Desktop_IDE
{
    class MEGAhotspot
    {
        public static void hotspot(String ssid,String key,bool status)
        {
           ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
           processStartInfo.RedirectStandardInput = true;
           processStartInfo.RedirectStandardOutput = true;
           processStartInfo.CreateNoWindow = true;
           processStartInfo.UseShellExecute = false;
           Process process = Process.Start(processStartInfo);

           if (process != null)
           {
               if (status)
               {
                   process.StandardInput.WriteLine("netsh wlan set hostednetwork mode=allow ssid=" + ssid + " key=" + key);
                   process.StandardInput.WriteLine("netsh wlan start hosted network");
                   process.StandardInput.Close();
               }
               else
               {
                   process.StandardInput.WriteLine("netsh wlan stop hostednetwork");
                   process.StandardInput.Close();
               }
           }
        }
    }
}
