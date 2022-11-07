namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Panel rightdockpanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.frmlevelrestart = new System.Windows.Forms.PictureBox();
            this.frmlevelplaypause = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picWall14 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall13 = new System.Windows.Forms.PictureBox();
            this.windowpic = new System.Windows.Forms.PictureBox();
            this.leftdockpanel = new System.Windows.Forms.Panel();
            this.windowplaypause = new System.Windows.Forms.PictureBox();
            this.centerdockpanel = new System.Windows.Forms.Panel();
            this.windowrestart = new System.Windows.Forms.PictureBox();
            this.controlswindow = new System.Windows.Forms.Panel();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.poisionHealth = new System.Windows.Forms.Label();
            this.playerHealthBar = new System.Windows.Forms.Label();
            this.cheetoHealthbar = new System.Windows.Forms.Label();
            this.BossHealthbar = new System.Windows.Forms.Label();
            rightdockpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.frmlevelrestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmlevelplaypause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowplaypause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowrestart)).BeginInit();
            this.controlswindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            this.SuspendLayout();
            // 
            // rightdockpanel
            // 
            rightdockpanel.Dock = System.Windows.Forms.DockStyle.Right;
            rightdockpanel.Location = new System.Drawing.Point(895, 516);
            rightdockpanel.Name = "rightdockpanel";
            rightdockpanel.Size = new System.Drawing.Size(281, 210);
            rightdockpanel.TabIndex = 7;
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.Red;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 9);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(54, 18);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "timmer";
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // frmlevelrestart
            // 
            this.frmlevelrestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frmlevelrestart.BackColor = System.Drawing.Color.Transparent;
            this.frmlevelrestart.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.restart_button;
            this.frmlevelrestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.frmlevelrestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmlevelrestart.Location = new System.Drawing.Point(1100, 6);
            this.frmlevelrestart.Name = "frmlevelrestart";
            this.frmlevelrestart.Size = new System.Drawing.Size(64, 59);
            this.frmlevelrestart.TabIndex = 19;
            this.frmlevelrestart.TabStop = false;
            this.frmlevelrestart.Click += new System.EventHandler(this.restarrt_Click);
            // 
            // frmlevelplaypause
            // 
            this.frmlevelplaypause.BackColor = System.Drawing.Color.Transparent;
            this.frmlevelplaypause.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.pause_button;
            this.frmlevelplaypause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.frmlevelplaypause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmlevelplaypause.Location = new System.Drawing.Point(1033, 6);
            this.frmlevelplaypause.Name = "frmlevelplaypause";
            this.frmlevelplaypause.Size = new System.Drawing.Size(61, 59);
            this.frmlevelplaypause.TabIndex = 18;
            this.frmlevelplaypause.TabStop = false;
            this.frmlevelplaypause.Click += new System.EventHandler(this.playpause_Click);
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(551, 474);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(114, 183);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(551, 1);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(469, 67);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1093, 294);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(82, 429);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(714, 656);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(380, 67);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(83, 1);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(469, 67);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(2, 1);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(82, 388);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(357, 656);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(358, 67);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(2, 454);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(82, 203);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(2, 656);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(358, 67);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(1000, 530);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(64, 107);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(110, 98);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(63, 96);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(2, 388);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(314, 67);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(971, 74);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(193, 194);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(119, 510);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(54, 106);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picWall14
            // 
            this.picWall14.BackColor = System.Drawing.Color.Transparent;
            this.picWall14.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall14.Location = new System.Drawing.Point(662, 388);
            this.picWall14.Name = "picWall14";
            this.picWall14.Size = new System.Drawing.Size(230, 67);
            this.picWall14.TabIndex = 12;
            this.picWall14.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(551, 64);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(114, 237);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(551, 298);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(114, 179);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            // 
            // picWall13
            // 
            this.picWall13.BackColor = System.Drawing.Color.Transparent;
            this.picWall13.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall13.Location = new System.Drawing.Point(316, 388);
            this.picWall13.Name = "picWall13";
            this.picWall13.Size = new System.Drawing.Size(236, 67);
            this.picWall13.TabIndex = 13;
            this.picWall13.TabStop = false;
            // 
            // windowpic
            // 
            this.windowpic.BackColor = System.Drawing.Color.IndianRed;
            this.windowpic.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.gamepaused;
            this.windowpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.windowpic.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowpic.Location = new System.Drawing.Point(0, 0);
            this.windowpic.Name = "windowpic";
            this.windowpic.Size = new System.Drawing.Size(1176, 516);
            this.windowpic.TabIndex = 2;
            this.windowpic.TabStop = false;
            // 
            // leftdockpanel
            // 
            this.leftdockpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftdockpanel.Location = new System.Drawing.Point(0, 516);
            this.leftdockpanel.Name = "leftdockpanel";
            this.leftdockpanel.Size = new System.Drawing.Size(291, 210);
            this.leftdockpanel.TabIndex = 3;
            // 
            // windowplaypause
            // 
            this.windowplaypause.BackColor = System.Drawing.Color.Transparent;
            this.windowplaypause.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.play_button;
            this.windowplaypause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.windowplaypause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowplaypause.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowplaypause.Location = new System.Drawing.Point(291, 516);
            this.windowplaypause.Name = "windowplaypause";
            this.windowplaypause.Size = new System.Drawing.Size(179, 210);
            this.windowplaypause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.windowplaypause.TabIndex = 4;
            this.windowplaypause.TabStop = false;
            this.windowplaypause.Click += new System.EventHandler(this.windowplaypause_Click);
            // 
            // centerdockpanel
            // 
            this.centerdockpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.centerdockpanel.Location = new System.Drawing.Point(470, 516);
            this.centerdockpanel.Name = "centerdockpanel";
            this.centerdockpanel.Size = new System.Drawing.Size(231, 210);
            this.centerdockpanel.TabIndex = 5;
            // 
            // windowrestart
            // 
            this.windowrestart.BackColor = System.Drawing.Color.Transparent;
            this.windowrestart.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.restart_button;
            this.windowrestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.windowrestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowrestart.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowrestart.Location = new System.Drawing.Point(701, 516);
            this.windowrestart.Name = "windowrestart";
            this.windowrestart.Size = new System.Drawing.Size(191, 210);
            this.windowrestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.windowrestart.TabIndex = 6;
            this.windowrestart.TabStop = false;
            this.windowrestart.Click += new System.EventHandler(this.restarrt_Click);
            // 
            // controlswindow
            // 
            this.controlswindow.BackColor = System.Drawing.Color.Transparent;
            this.controlswindow.Controls.Add(rightdockpanel);
            this.controlswindow.Controls.Add(this.windowrestart);
            this.controlswindow.Controls.Add(this.centerdockpanel);
            this.controlswindow.Controls.Add(this.windowplaypause);
            this.controlswindow.Controls.Add(this.leftdockpanel);
            this.controlswindow.Controls.Add(this.windowpic);
            this.controlswindow.Enabled = false;
            this.controlswindow.Location = new System.Drawing.Point(0, 0);
            this.controlswindow.Name = "controlswindow";
            this.controlswindow.Size = new System.Drawing.Size(1176, 726);
            this.controlswindow.TabIndex = 20;
            this.controlswindow.Visible = false;
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(891, 388);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(203, 67);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            // 
            // poisionHealth
            // 
            this.poisionHealth.BackColor = System.Drawing.Color.Green;
            this.poisionHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poisionHealth.ForeColor = System.Drawing.Color.White;
            this.poisionHealth.Location = new System.Drawing.Point(90, 74);
            this.poisionHealth.Name = "poisionHealth";
            this.poisionHealth.Size = new System.Drawing.Size(226, 20);
            this.poisionHealth.TabIndex = 21;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.BackColor = System.Drawing.Color.Yellow;
            this.playerHealthBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealthBar.ForeColor = System.Drawing.Color.White;
            this.playerHealthBar.Location = new System.Drawing.Point(501, 74);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(226, 20);
            this.playerHealthBar.TabIndex = 22;
            // 
            // cheetoHealthbar
            // 
            this.cheetoHealthbar.BackColor = System.Drawing.Color.OrangeRed;
            this.cheetoHealthbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheetoHealthbar.ForeColor = System.Drawing.Color.White;
            this.cheetoHealthbar.Location = new System.Drawing.Point(861, 474);
            this.cheetoHealthbar.Name = "cheetoHealthbar";
            this.cheetoHealthbar.Size = new System.Drawing.Size(226, 20);
            this.cheetoHealthbar.TabIndex = 23;
            // 
            // BossHealthbar
            // 
            this.BossHealthbar.BackColor = System.Drawing.Color.Red;
            this.BossHealthbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BossHealthbar.ForeColor = System.Drawing.Color.White;
            this.BossHealthbar.Location = new System.Drawing.Point(947, 271);
            this.BossHealthbar.Name = "BossHealthbar";
            this.BossHealthbar.Size = new System.Drawing.Size(226, 20);
            this.BossHealthbar.TabIndex = 24;
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.frmlevelrestart);
            this.Controls.Add(this.frmlevelplaypause);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picWall13);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall14);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.poisionHealth);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.cheetoHealthbar);
            this.Controls.Add(this.BossHealthbar);
            this.Controls.Add(this.controlswindow);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.frmlevelrestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmlevelplaypause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowplaypause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowrestart)).EndInit();
            this.controlswindow.ResumeLayout(false);
            this.controlswindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picWall3;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picWall11;
        private System.Windows.Forms.PictureBox frmlevelplaypause;
        private System.Windows.Forms.PictureBox frmlevelrestart;
        private System.Windows.Forms.PictureBox picWall14;
        private System.Windows.Forms.PictureBox picWall10;
        private System.Windows.Forms.PictureBox picWall9;
        private System.Windows.Forms.PictureBox picWall13;
        private System.Windows.Forms.PictureBox windowpic;
        private System.Windows.Forms.Panel leftdockpanel;
        private System.Windows.Forms.PictureBox windowplaypause;
        private System.Windows.Forms.Panel centerdockpanel;
        private System.Windows.Forms.PictureBox windowrestart;
        private System.Windows.Forms.Panel controlswindow;
        private System.Windows.Forms.PictureBox picWall12;
        private System.Windows.Forms.Label poisionHealth;
        private System.Windows.Forms.Label playerHealthBar;
        private System.Windows.Forms.Label cheetoHealthbar;
        private System.Windows.Forms.Label BossHealthbar;
    }
}

