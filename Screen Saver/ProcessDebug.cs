using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Screen_Saver
{
    class ProcessDebug
    {



        public static void PrintLine(DebugType type, string location, string line)
        {
            if (type == DebugType.File)
            {
                StreamWriter sw = File.AppendText(location);
                sw.WriteLine("[" + DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString() + "] " + line); 
                sw.Flush(); 
                sw.Close();

                //Application.ExecutablePath.ToString();
                //Application.StartupPath.ToString();
            }



        }



        public enum DebugType
        {

            File,
            FormItem


        }

    }
}
