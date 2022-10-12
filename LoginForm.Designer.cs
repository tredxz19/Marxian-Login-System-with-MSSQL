namespace Marxian_Login_System
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
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.loginPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.lockiconPb = new FontAwesome.Sharp.IconPictureBox();
            this.humaniconPb = new FontAwesome.Sharp.IconPictureBox();
            this.forgotLbl = new System.Windows.Forms.Label();
            this.registrationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MA = new System.Windows.Forms.Label();
            this.rememberChkb = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.registerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.registerPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.userregisterTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passregisterTb = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.loginPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockiconPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humaniconPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.registerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 10;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(63, 216);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(152, 33);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginPnl
            // 
            this.loginPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.loginPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(2)))));
            this.loginPnl.BorderRadius = 5;
            this.loginPnl.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.loginPnl.BorderThickness = 2;
            this.loginPnl.Controls.Add(this.MA);
            this.loginPnl.Controls.Add(this.label6);
            this.loginPnl.Controls.Add(this.iconPictureBox1);
            this.loginPnl.Controls.Add(this.label5);
            this.loginPnl.Controls.Add(this.label1);
            this.loginPnl.Controls.Add(this.lockiconPb);
            this.loginPnl.Controls.Add(this.humaniconPb);
            this.loginPnl.Controls.Add(this.forgotLbl);
            this.loginPnl.Controls.Add(this.registrationBtn);
            this.loginPnl.Controls.Add(this.rememberChkb);
            this.loginPnl.Controls.Add(this.passTb);
            this.loginPnl.Controls.Add(this.usernameTb);
            this.loginPnl.Controls.Add(this.loginBtn);
            this.loginPnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginPnl.Location = new System.Drawing.Point(10, 10);
            this.loginPnl.Name = "loginPnl";
            this.loginPnl.Size = new System.Drawing.Size(300, 374);
            this.loginPnl.TabIndex = 1;
            // 
            // lockiconPb
            // 
            this.lockiconPb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.lockiconPb.ForeColor = System.Drawing.Color.DarkGray;
            this.lockiconPb.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.lockiconPb.IconColor = System.Drawing.Color.DarkGray;
            this.lockiconPb.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.lockiconPb.IconSize = 20;
            this.lockiconPb.Location = new System.Drawing.Point(52, 175);
            this.lockiconPb.Name = "lockiconPb";
            this.lockiconPb.Size = new System.Drawing.Size(20, 20);
            this.lockiconPb.TabIndex = 12;
            this.lockiconPb.TabStop = false;
            // 
            // humaniconPb
            // 
            this.humaniconPb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.humaniconPb.ForeColor = System.Drawing.Color.DarkGray;
            this.humaniconPb.IconChar = FontAwesome.Sharp.IconChar.User;
            this.humaniconPb.IconColor = System.Drawing.Color.DarkGray;
            this.humaniconPb.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.humaniconPb.IconSize = 20;
            this.humaniconPb.Location = new System.Drawing.Point(52, 125);
            this.humaniconPb.Name = "humaniconPb";
            this.humaniconPb.Size = new System.Drawing.Size(20, 20);
            this.humaniconPb.TabIndex = 11;
            this.humaniconPb.TabStop = false;
            // 
            // forgotLbl
            // 
            this.forgotLbl.AutoSize = true;
            this.forgotLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.forgotLbl.Location = new System.Drawing.Point(162, 271);
            this.forgotLbl.Name = "forgotLbl";
            this.forgotLbl.Size = new System.Drawing.Size(105, 15);
            this.forgotLbl.TabIndex = 10;
            this.forgotLbl.Text = "Forgot password?";
            // 
            // registrationBtn
            // 
            this.registrationBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(40)))));
            this.registrationBtn.BorderRadius = 10;
            this.registrationBtn.BorderThickness = 2;
            this.registrationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registrationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registrationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registrationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registrationBtn.FillColor = System.Drawing.Color.Transparent;
            this.registrationBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registrationBtn.ForeColor = System.Drawing.Color.White;
            this.registrationBtn.Location = new System.Drawing.Point(165, 310);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(99, 33);
            this.registrationBtn.TabIndex = 0;
            this.registrationBtn.Text = "Register Now";
            this.registrationBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // MA
            // 
            this.MA.AutoSize = true;
            this.MA.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(2)))));
            this.MA.Location = new System.Drawing.Point(45, 8);
            this.MA.Name = "MA";
            this.MA.Size = new System.Drawing.Size(60, 24);
            this.MA.TabIndex = 3;
            this.MA.Text = "M A";
            // 
            // rememberChkb
            // 
            this.rememberChkb.AutoSize = true;
            this.rememberChkb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberChkb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rememberChkb.Location = new System.Drawing.Point(35, 271);
            this.rememberChkb.Name = "rememberChkb";
            this.rememberChkb.Size = new System.Drawing.Size(102, 19);
            this.rememberChkb.TabIndex = 5;
            this.rememberChkb.Text = "Remember me";
            this.rememberChkb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(2)))));
            this.label6.Location = new System.Drawing.Point(192, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "N \' S";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(2)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Monero;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(2)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 74;
            this.iconPictureBox1.Location = new System.Drawing.Point(105, 35);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(80, 74);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(2)))));
            this.label5.Location = new System.Drawing.Point(149, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "I A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(2)))));
            this.label1.Location = new System.Drawing.Point(103, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "R X";
            // 
            // passTb
            // 
            this.passTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.passTb.BorderRadius = 5;
            this.passTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTb.DefaultText = "Password";
            this.passTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.passTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passTb.ForeColor = System.Drawing.Color.DarkGray;
            this.passTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTb.Location = new System.Drawing.Point(47, 172);
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '\0';
            this.passTb.PlaceholderText = "";
            this.passTb.SelectedText = "";
            this.passTb.Size = new System.Drawing.Size(180, 26);
            this.passTb.TabIndex = 3;
            this.passTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passTb.Enter += new System.EventHandler(this.passTb_Enter);
            this.passTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTb_KeyDown);
            this.passTb.Leave += new System.EventHandler(this.passTb_Leave);
            // 
            // usernameTb
            // 
            this.usernameTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.usernameTb.BorderRadius = 5;
            this.usernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTb.DefaultText = "Username";
            this.usernameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.usernameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTb.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTb.Location = new System.Drawing.Point(47, 122);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.PasswordChar = '\0';
            this.usernameTb.PlaceholderText = "";
            this.usernameTb.SelectedText = "";
            this.usernameTb.Size = new System.Drawing.Size(180, 26);
            this.usernameTb.TabIndex = 2;
            this.usernameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTb.TextChanged += new System.EventHandler(this.usernameTb_TextChanged);
            this.usernameTb.Enter += new System.EventHandler(this.usernameTb_Enter);
            this.usernameTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTb_KeyDown);
            this.usernameTb.Leave += new System.EventHandler(this.usernameTb_Leave);
            // 
            // registerBtn
            // 
            this.registerBtn.BorderRadius = 10;
            this.registerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerBtn.FillColor = System.Drawing.Color.Red;
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(51, 234);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(198, 35);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "Register";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // registerPnl
            // 
            this.registerPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(40)))));
            this.registerPnl.BorderRadius = 5;
            this.registerPnl.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.registerPnl.BorderThickness = 2;
            this.registerPnl.Controls.Add(this.pictureBox1);
            this.registerPnl.Controls.Add(this.label4);
            this.registerPnl.Controls.Add(this.label3);
            this.registerPnl.Controls.Add(this.registerBtn);
            this.registerPnl.Controls.Add(this.userLbl);
            this.registerPnl.Controls.Add(this.userregisterTb);
            this.registerPnl.Controls.Add(this.label2);
            this.registerPnl.Controls.Add(this.passregisterTb);
            this.registerPnl.Controls.Add(this.guna2Button1);
            this.registerPnl.Location = new System.Drawing.Point(335, 10);
            this.registerPnl.Name = "registerPnl";
            this.registerPnl.Size = new System.Drawing.Size(541, 374);
            this.registerPnl.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marxian_Login_System.Properties.Resources._1_pkbfYlkBFldlLyXG9EMbQQ;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(49, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 1);
            this.label4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(49, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 1);
            this.label3.TabIndex = 7;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(40)))));
            this.userLbl.Location = new System.Drawing.Point(122, 43);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(65, 15);
            this.userLbl.TabIndex = 6;
            this.userLbl.Text = "UserName";
            // 
            // userregisterTb
            // 
            this.userregisterTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.userregisterTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userregisterTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userregisterTb.ForeColor = System.Drawing.Color.White;
            this.userregisterTb.Location = new System.Drawing.Point(4, 68);
            this.userregisterTb.Multiline = true;
            this.userregisterTb.Name = "userregisterTb";
            this.userregisterTb.Size = new System.Drawing.Size(291, 41);
            this.userregisterTb.TabIndex = 1;
            this.userregisterTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userregisterTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userregisterTb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(122, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // passregisterTb
            // 
            this.passregisterTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.passregisterTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passregisterTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passregisterTb.ForeColor = System.Drawing.Color.White;
            this.passregisterTb.Location = new System.Drawing.Point(4, 160);
            this.passregisterTb.Multiline = true;
            this.passregisterTb.Name = "passregisterTb";
            this.passregisterTb.Size = new System.Drawing.Size(291, 38);
            this.passregisterTb.TabIndex = 2;
            this.passregisterTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passregisterTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passregisterTb_KeyDown);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(40)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(463, 8);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(61, 33);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "Back";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(17)))));
            this.guna2Panel1.Controls.Add(this.loginPnl);
            this.guna2Panel1.Controls.Add(this.registerPnl);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(889, 393);
            this.guna2Panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(893, 397);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPnl.ResumeLayout(false);
            this.loginPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockiconPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humaniconPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.registerPnl.ResumeLayout(false);
            this.registerPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2Panel loginPnl;
        private Guna.UI2.WinForms.Guna2Button registerBtn;
        private Guna.UI2.WinForms.Guna2Panel registerPnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passregisterTb;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.TextBox userregisterTb;
        private Guna.UI2.WinForms.Guna2TextBox usernameTb;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox passTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button registrationBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.CheckBox rememberChkb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MA;
        private System.Windows.Forms.Label forgotLbl;
        private FontAwesome.Sharp.IconPictureBox lockiconPb;
        private FontAwesome.Sharp.IconPictureBox humaniconPb;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

