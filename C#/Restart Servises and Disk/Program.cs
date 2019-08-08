using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using System.Reflection;
using System.Diagnostics;

namespace Restart_Servises_and_Disk
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BonusSkins.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Process pr = RI();
            if (pr != null)
                MessageBox.Show("Приложение уже запущено!", "Ошибка");
            else
                Application.Run(new Form1());


        }
        public static Process RI()
        {
            Process current = Process.GetCurrentProcess();
            Process[] pr = Process.GetProcessesByName(current.ProcessName);
            foreach (Process i in pr)
            {
                if (i.Id != current.Id)
                {
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                    {
                        return i;
                    }
                }
            }
            return null;
        }
    }
}
