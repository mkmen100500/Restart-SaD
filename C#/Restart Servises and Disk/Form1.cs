using System;
using System.Drawing;
using System.ServiceProcess;
using System.Net.NetworkInformation;
using IWshRuntimeLibrary;
using System.IO;
using System.Security.Principal;
using System.Diagnostics;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace Restart_Servises_and_Disk
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();

            // делаем невидимой нашу иконку в трее
            notifyIcon1.Visible = false;
        }
        string addressYA = "77.88.8.8";
        string addressSERV = "10.7.0.1";
        string serviceName = "OpenVPNService";



        private void Form1_Load(object sender, EventArgs e)
        {
            AutoUpdater.Start("https://raw.githubusercontent.com/mkmen100500/Restart-SaD/master/Updater.xml");
            timer1.Start();
            restartDisk_Click(sender, e);
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;

            ServiceController service = new ServiceController(serviceName);
            // Проверяем не запущена ли служба
            if (service.Status != ServiceControllerStatus.Running)
            {
                label2.Text = "Остановлена";
                label2.ForeColor = Color.Red;

            }
            else
            {
                label2.Text = "Запущена";
                label2.ForeColor = Color.Green;
            }

            try
            {
                Ping pngSERV = new Ping();
                PingReply replictSERV = await pngSERV.SendPingAsync(addressSERV);
                if (replictSERV.Status == IPStatus.Success)
                {
                    foreach (DriveInfo d in DriveInfo.GetDrives())
                    {
                        if (d.DriveType == DriveType.Network && d.Name == "Z" + @":\")
                        {
                            label4.Text = "Подключен";
                            label4.ForeColor = Color.Green;
                        }
                        else
                        {
                            label4.Text = "Отключен";
                            label4.ForeColor = Color.Red;
                        }
                    }
                    label5.Text = "Сервер Online";
                    label5.ForeColor = Color.Green;
                }
                else
                {
                    label5.Text = "Сервер Offline";
                    label5.ForeColor = Color.Red;
                    label4.Text = "Отключен";
                    label4.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                label5.Text = "Сервер Offline";
                label5.ForeColor = Color.Red;
            }

            try
            {
                Ping pngYA = new Ping();
                PingReply replictYA = await pngYA.SendPingAsync(addressYA);
                if (replictYA.Status == IPStatus.Success)
                {
                    label1.Text = "Online";
                    label1.ForeColor = Color.Green;
                }
                else
                {
                    label1.Text = "Offline";
                    label1.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                label1.Text = "Offline";
                label1.ForeColor = Color.Red;
            }
    }

        private void MenuExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void exitProgramm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void restartOpenVPN_Click(object sender, EventArgs e)
        {
            //string [] s = { "Echo Off","Net Stop OpenVPNService","PING - n 1 - w 10000 192.168.253.253 > nul",":ReStartService","Net Start OpenVPNService" , "SC query OpenVPNService | find / i ""1  STOPPED"" > nul","if % errorlevel %== 0 echo GoTo ReStartService","EXIT" };

            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
            ProcessStartInfo processInfo = new ProcessStartInfo(); //создаем новый процесс
            processInfo.Verb = "runas"; //в данном случае указываем, что процесс должен быть запущен с правами администратора
            processInfo.FileName = "reloadVPN.bat";
            //processInfo.FileName = "sc";
            //processInfo.Arguments = "restart OpenVPNService";
            //processInfo.UseShellExecute = true;
            if (hasAdministrativeRight == false)
            {
                try
                {
                    Process.Start(processInfo);
                }
                catch (Win32Exception)
                {
                    XtraMessageBox.Show("Данная операция должна выполняться от имени администратора!");//Ничего не делаем, потому что пользователь, возможно, нажал кнопку "Нет" в ответ на вопрос о запуске программы в окне предупреждения UAC (для Windows 7)
                }
            }
            else
            {
                Process.Start(processInfo);
            }
        }

        private async void restartDisk_Click(object sender, EventArgs e)
        {
            try
            {
                WshNetwork network = new WshNetwork();
                Ping pngSERV = new Ping();
                PingReply replictSERV = await pngSERV.SendPingAsync(addressSERV);
                if (replictSERV.Status == IPStatus.Success)
                {
                    //поиск сетевого диска
                    foreach (DriveInfo d in DriveInfo.GetDrives())
                    {


                        if (d.DriveType == DriveType.Network && d.Name == "Z" + @":\")
                        {
                            network.RemoveNetworkDrive("Z:", true, true); //Отключение найденного сетевого диска
                        }

                    }
                    //Подключение сетевого диска
                    object save = false;
                    object user = "user", pass = "1q2w3e914x";
                    network.MapNetworkDrive("Z:", @"\\10.7.0.1\share500gb", ref save, ref user, ref pass);
                }
                else
                {
                    XtraMessageBox.Show("Сервер не доступен! Проверьте подключение VPN!");
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Сервер не доступен! Проверьте подключение VPN!");
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // делаем нашу иконку скрытой
            notifyIcon1.Visible = false;
            // возвращаем отображение окна в панели
            ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие        
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                ShowInTaskbar = false;
                // делаем нашу иконку в трее активной
                notifyIcon1.Visible = true;

            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)//Меню iconnotify
        {
            Close();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // делаем нашу иконку скрытой
            notifyIcon1.Visible = false;
            // возвращаем отображение окна в панели
            ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                if (MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                else
                    e.Cancel = false;
            }
        }
    }
}
