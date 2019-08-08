namespace Restart_Servises_and_Disk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.menu = new DevExpress.XtraBars.BarSubItem();
            this.MenuExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.statusOpenVPN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusDisk = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.restartDisk = new System.Windows.Forms.Button();
            this.restartOpenVPN = new System.Windows.Forms.Button();
            this.exitProgramm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusInet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusServeraOVPN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpd = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.menu,
            this.MenuExit,
            this.checkUpd});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.menu)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // menu
            // 
            this.menu.Caption = "Меню";
            this.menu.Id = 0;
            this.menu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuExit),
            new DevExpress.XtraBars.LinkPersistInfo(this.checkUpd)});
            this.menu.Name = "menu";
            // 
            // MenuExit
            // 
            this.MenuExit.Caption = "Выход";
            this.MenuExit.Id = 1;
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(350, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 233);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(350, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 213);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(350, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 213);
            // 
            // statusOpenVPN
            // 
            this.statusOpenVPN.AutoSize = true;
            this.statusOpenVPN.Location = new System.Drawing.Point(12, 91);
            this.statusOpenVPN.Name = "statusOpenVPN";
            this.statusOpenVPN.Size = new System.Drawing.Size(140, 13);
            this.statusOpenVPN.TabIndex = 4;
            this.statusOpenVPN.Text = " Статус службы OpenVPN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тест...";
            // 
            // statusDisk
            // 
            this.statusDisk.AutoSize = true;
            this.statusDisk.Location = new System.Drawing.Point(15, 119);
            this.statusDisk.Name = "statusDisk";
            this.statusDisk.Size = new System.Drawing.Size(124, 13);
            this.statusDisk.TabIndex = 6;
            this.statusDisk.Text = "Статус Общего Диска:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тест...";
            // 
            // restartDisk
            // 
            this.restartDisk.Location = new System.Drawing.Point(18, 165);
            this.restartDisk.Name = "restartDisk";
            this.restartDisk.Size = new System.Drawing.Size(121, 48);
            this.restartDisk.TabIndex = 8;
            this.restartDisk.Text = "Переподключиться к общему диску";
            this.restartDisk.UseVisualStyleBackColor = true;
            this.restartDisk.Click += new System.EventHandler(this.restartDisk_Click);
            // 
            // restartOpenVPN
            // 
            this.restartOpenVPN.Location = new System.Drawing.Point(145, 165);
            this.restartOpenVPN.Name = "restartOpenVPN";
            this.restartOpenVPN.Size = new System.Drawing.Size(102, 48);
            this.restartOpenVPN.TabIndex = 9;
            this.restartOpenVPN.Text = "Перезапустить службу OpenVPN";
            this.restartOpenVPN.UseVisualStyleBackColor = true;
            this.restartOpenVPN.Click += new System.EventHandler(this.restartOpenVPN_Click);
            // 
            // exitProgramm
            // 
            this.exitProgramm.Location = new System.Drawing.Point(253, 165);
            this.exitProgramm.Name = "exitProgramm";
            this.exitProgramm.Size = new System.Drawing.Size(87, 48);
            this.exitProgramm.TabIndex = 10;
            this.exitProgramm.Text = "Закрыть программу";
            this.exitProgramm.UseVisualStyleBackColor = true;
            this.exitProgramm.Click += new System.EventHandler(this.exitProgramm_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusInet
            // 
            this.statusInet.AutoSize = true;
            this.statusInet.Location = new System.Drawing.Point(15, 34);
            this.statusInet.Name = "statusInet";
            this.statusInet.Size = new System.Drawing.Size(104, 13);
            this.statusInet.TabIndex = 11;
            this.statusInet.Text = "Статус интернета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Тест...";
            // 
            // statusServeraOVPN
            // 
            this.statusServeraOVPN.AutoSize = true;
            this.statusServeraOVPN.Location = new System.Drawing.Point(15, 61);
            this.statusServeraOVPN.Name = "statusServeraOVPN";
            this.statusServeraOVPN.Size = new System.Drawing.Size(139, 13);
            this.statusServeraOVPN.TabIndex = 13;
            this.statusServeraOVPN.Text = "Статус сервера OpenVPN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Тест...";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Restart Servises and Disk";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.открытьToolStripMenuItem.Text = "Развернуть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // checkUpd
            // 
            this.checkUpd.Caption = "Проверить на наличие \r\nобновлений";
            this.checkUpd.Id = 2;
            this.checkUpd.Name = "checkUpd";
            this.checkUpd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.checkUpd_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 233);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusServeraOVPN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusInet);
            this.Controls.Add(this.exitProgramm);
            this.Controls.Add(this.restartOpenVPN);
            this.Controls.Add(this.restartDisk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusDisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusOpenVPN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restart Servise and Disk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem menu;
        private DevExpress.XtraBars.BarButtonItem MenuExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Button exitProgramm;
        private System.Windows.Forms.Button restartOpenVPN;
        private System.Windows.Forms.Button restartDisk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label statusDisk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusOpenVPN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label statusServeraOVPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusInet;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem checkUpd;
    }
}

