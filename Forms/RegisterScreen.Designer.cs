namespace Coursework
{
    partial class RegisterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScreen));
            lblSelectClass = new Label();
            pbScoutEmblem = new PictureBox();
            pbSoldierEmblem = new PictureBox();
            pbPyroEmblem = new PictureBox();
            pbDemoEmblem = new PictureBox();
            pbHWGEmblem = new PictureBox();
            pbEngineerEmblem = new PictureBox();
            pbMedicEmblem = new PictureBox();
            pbSniperEmblem = new PictureBox();
            pbSpyEmblem = new PictureBox();
            pnlRegister = new Panel();
            lblPleaseSelectClass = new Label();
            cbShowPassword = new CheckBox();
            lblPleaseEnter = new Label();
            lblPassMatch = new Label();
            lblAccExists = new Label();
            pbLogo = new PictureBox();
            btnRegister = new Button();
            rpnlReenter = new UserControls.RoundedPanel();
            tbReenter = new TextBox();
            rpnlPassword = new UserControls.RoundedPanel();
            tbPassword = new TextBox();
            rpnlUsername = new UserControls.RoundedPanel();
            tbUsername = new TextBox();
            lblRegister = new Label();
            linkToLogin = new LinkLabel();
            pbClassSelected = new PictureBox();
            pnlClasses = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbScoutEmblem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSoldierEmblem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPyroEmblem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDemoEmblem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHWGEmblem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEngineerEmblem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMedicEmblem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSniperEmblem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSpyEmblem).BeginInit();
            pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            rpnlReenter.SuspendLayout();
            rpnlPassword.SuspendLayout();
            rpnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClassSelected).BeginInit();
            pnlClasses.SuspendLayout();
            SuspendLayout();
            // 
            // lblSelectClass
            // 
            lblSelectClass.AutoSize = true;
            lblSelectClass.Font = new Font("Microsoft Sans Serif", 36F);
            lblSelectClass.ForeColor = Color.FromArgb(246, 231, 222);
            lblSelectClass.Location = new Point(24, 0);
            lblSelectClass.Name = "lblSelectClass";
            lblSelectClass.Padding = new Padding(10, 60, 0, 0);
            lblSelectClass.Size = new Size(544, 115);
            lblSelectClass.TabIndex = 0;
            lblSelectClass.Text = "SELECT YOUR CLASS";
            // 
            // pbScoutEmblem
            // 
            pbScoutEmblem.Image = Properties.Resources.scoutEmblem;
            pbScoutEmblem.Location = new Point(651, 20);
            pbScoutEmblem.Margin = new Padding(80, 20, 0, 3);
            pbScoutEmblem.MaximumSize = new Size(115, 115);
            pbScoutEmblem.MinimumSize = new Size(20, 20);
            pbScoutEmblem.Name = "pbScoutEmblem";
            pbScoutEmblem.Padding = new Padding(10, 0, 0, 0);
            pbScoutEmblem.Size = new Size(115, 115);
            pbScoutEmblem.SizeMode = PictureBoxSizeMode.Zoom;
            pbScoutEmblem.TabIndex = 1;
            pbScoutEmblem.TabStop = false;
            pbScoutEmblem.Tag = "1";
            pbScoutEmblem.Click += classSelect_Click;
            pbScoutEmblem.MouseEnter += classSelect_MouseEnter;
            // 
            // pbSoldierEmblem
            // 
            pbSoldierEmblem.Image = Properties.Resources.soldierEmblem;
            pbSoldierEmblem.Location = new Point(786, 20);
            pbSoldierEmblem.Margin = new Padding(20, 20, 0, 3);
            pbSoldierEmblem.MaximumSize = new Size(115, 115);
            pbSoldierEmblem.MinimumSize = new Size(20, 20);
            pbSoldierEmblem.Name = "pbSoldierEmblem";
            pbSoldierEmblem.Size = new Size(115, 115);
            pbSoldierEmblem.SizeMode = PictureBoxSizeMode.Zoom;
            pbSoldierEmblem.TabIndex = 2;
            pbSoldierEmblem.TabStop = false;
            pbSoldierEmblem.Tag = "2";
            pbSoldierEmblem.Click += classSelect_Click;
            pbSoldierEmblem.MouseEnter += classSelect_MouseEnter;
            // 
            // pbPyroEmblem
            // 
            pbPyroEmblem.Image = Properties.Resources.pyroEmblem;
            pbPyroEmblem.Location = new Point(921, 20);
            pbPyroEmblem.Margin = new Padding(20, 20, 0, 3);
            pbPyroEmblem.MaximumSize = new Size(115, 115);
            pbPyroEmblem.MinimumSize = new Size(20, 20);
            pbPyroEmblem.Name = "pbPyroEmblem";
            pbPyroEmblem.Size = new Size(115, 115);
            pbPyroEmblem.SizeMode = PictureBoxSizeMode.Zoom;
            pbPyroEmblem.TabIndex = 3;
            pbPyroEmblem.TabStop = false;
            pbPyroEmblem.Tag = "3";
            pbPyroEmblem.Click += classSelect_Click;
            pbPyroEmblem.MouseEnter += classSelect_MouseEnter;
            // 
            // pbDemoEmblem
            // 
            pbDemoEmblem.Image = Properties.Resources.demoEmblem;
            pbDemoEmblem.Location = new Point(1056, 20);
            pbDemoEmblem.Margin = new Padding(20, 20, 0, 3);
            pbDemoEmblem.MaximumSize = new Size(115, 115);
            pbDemoEmblem.MinimumSize = new Size(20, 20);
            pbDemoEmblem.Name = "pbDemoEmblem";
            pbDemoEmblem.Size = new Size(115, 115);
            pbDemoEmblem.SizeMode = PictureBoxSizeMode.Zoom;
            pbDemoEmblem.TabIndex = 4;
            pbDemoEmblem.TabStop = false;
            pbDemoEmblem.Tag = "4";
            pbDemoEmblem.Click += classSelect_Click;
            pbDemoEmblem.MouseEnter += classSelect_MouseEnter;
            // 
            // pbHWGEmblem
            // 
            pbHWGEmblem.Image = Properties.Resources.hwgEmblem;
            pbHWGEmblem.Location = new Point(1191, 20);
            pbHWGEmblem.Margin = new Padding(20, 20, 0, 3);
            pbHWGEmblem.MaximumSize = new Size(115, 115);
            pbHWGEmblem.MinimumSize = new Size(20, 20);
            pbHWGEmblem.Name = "pbHWGEmblem";
            pbHWGEmblem.Size = new Size(115, 115);
            pbHWGEmblem.SizeMode = PictureBoxSizeMode.Zoom;
            pbHWGEmblem.TabIndex = 5;
            pbHWGEmblem.TabStop = false;
            pbHWGEmblem.Tag = "5";
            pbHWGEmblem.Click += classSelect_Click;
            pbHWGEmblem.MouseEnter += classSelect_MouseEnter;
            // 
            // pbEngineerEmblem
            // 
            pbEngineerEmblem.Image = Properties.Resources.engineerEmblem;
            pbEngineerEmblem.Location = new Point(1326, 20);
            pbEngineerEmblem.Margin = new Padding(20, 20, 0, 3);
            pbEngineerEmblem.MaximumSize = new Size(115, 115);
            pbEngineerEmblem.MinimumSize = new Size(20, 20);
            pbEngineerEmblem.Name = "pbEngineerEmblem";
            pbEngineerEmblem.Size = new Size(115, 115);
            pbEngineerEmblem.SizeMode = PictureBoxSizeMode.Zoom;
            pbEngineerEmblem.TabIndex = 6;
            pbEngineerEmblem.TabStop = false;
            pbEngineerEmblem.Tag = "6";
            pbEngineerEmblem.Click += classSelect_Click;
            pbEngineerEmblem.MouseEnter += classSelect_MouseEnter;
            // 
            // pbMedicEmblem
            // 
            pbMedicEmblem.Image = Properties.Resources.medicEmblem;
            pbMedicEmblem.Location = new Point(1461, 20);
            pbMedicEmblem.Margin = new Padding(20, 20, 0, 3);
            pbMedicEmblem.MaximumSize = new Size(115, 115);
            pbMedicEmblem.MinimumSize = new Size(20, 20);
            pbMedicEmblem.Name = "pbMedicEmblem";
            pbMedicEmblem.Size = new Size(115, 115);
            pbMedicEmblem.SizeMode = PictureBoxSizeMode.Zoom;
            pbMedicEmblem.TabIndex = 7;
            pbMedicEmblem.TabStop = false;
            pbMedicEmblem.Tag = "7";
            pbMedicEmblem.Click += classSelect_Click;
            pbMedicEmblem.MouseEnter += classSelect_MouseEnter;
            // 
            // pbSniperEmblem
            // 
            pbSniperEmblem.Image = Properties.Resources.sniperEmblem;
            pbSniperEmblem.Location = new Point(1596, 20);
            pbSniperEmblem.Margin = new Padding(20, 20, 0, 3);
            pbSniperEmblem.MaximumSize = new Size(115, 115);
            pbSniperEmblem.MinimumSize = new Size(20, 20);
            pbSniperEmblem.Name = "pbSniperEmblem";
            pbSniperEmblem.Size = new Size(115, 115);
            pbSniperEmblem.SizeMode = PictureBoxSizeMode.Zoom;
            pbSniperEmblem.TabIndex = 8;
            pbSniperEmblem.TabStop = false;
            pbSniperEmblem.Tag = "8";
            pbSniperEmblem.Click += classSelect_Click;
            pbSniperEmblem.MouseEnter += classSelect_MouseEnter;
            // 
            // pbSpyEmblem
            // 
            pbSpyEmblem.Image = Properties.Resources.spyEmblem;
            pbSpyEmblem.Location = new Point(1731, 20);
            pbSpyEmblem.Margin = new Padding(20, 20, 0, 3);
            pbSpyEmblem.MaximumSize = new Size(115, 115);
            pbSpyEmblem.MinimumSize = new Size(20, 20);
            pbSpyEmblem.Name = "pbSpyEmblem";
            pbSpyEmblem.Size = new Size(115, 115);
            pbSpyEmblem.SizeMode = PictureBoxSizeMode.Zoom;
            pbSpyEmblem.TabIndex = 9;
            pbSpyEmblem.TabStop = false;
            pbSpyEmblem.Tag = "9";
            pbSpyEmblem.Click += classSelect_Click;
            pbSpyEmblem.MouseEnter += classSelect_MouseEnter;
            // 
            // pnlRegister
            // 
            pnlRegister.BackColor = Color.FromArgb(54, 49, 45);
            pnlRegister.Controls.Add(lblPleaseSelectClass);
            pnlRegister.Controls.Add(cbShowPassword);
            pnlRegister.Controls.Add(lblPleaseEnter);
            pnlRegister.Controls.Add(lblPassMatch);
            pnlRegister.Controls.Add(lblAccExists);
            pnlRegister.Controls.Add(pbLogo);
            pnlRegister.Controls.Add(btnRegister);
            pnlRegister.Controls.Add(rpnlReenter);
            pnlRegister.Controls.Add(rpnlPassword);
            pnlRegister.Controls.Add(rpnlUsername);
            pnlRegister.Controls.Add(lblRegister);
            pnlRegister.Dock = DockStyle.Left;
            pnlRegister.Location = new Point(0, 156);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(592, 744);
            pnlRegister.TabIndex = 2;
            // 
            // lblPleaseSelectClass
            // 
            lblPleaseSelectClass.Anchor = AnchorStyles.Left;
            lblPleaseSelectClass.AutoSize = true;
            lblPleaseSelectClass.Font = new Font("Segoe UI", 20F);
            lblPleaseSelectClass.ForeColor = Color.FromArgb(189, 59, 59);
            lblPleaseSelectClass.Location = new Point(12, 507);
            lblPleaseSelectClass.Name = "lblPleaseSelectClass";
            lblPleaseSelectClass.Size = new Size(335, 37);
            lblPleaseSelectClass.TabIndex = 10;
            lblPleaseSelectClass.Text = "Please select a class above.";
            lblPleaseSelectClass.Visible = false;
            // 
            // cbShowPassword
            // 
            cbShowPassword.Anchor = AnchorStyles.None;
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Segoe UI", 30F);
            cbShowPassword.ForeColor = Color.FromArgb(246, 231, 222);
            cbShowPassword.Location = new Point(12, 537);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(314, 58);
            cbShowPassword.TabIndex = 6;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // lblPleaseEnter
            // 
            lblPleaseEnter.Anchor = AnchorStyles.Left;
            lblPleaseEnter.AutoSize = true;
            lblPleaseEnter.Font = new Font("Segoe UI", 20F);
            lblPleaseEnter.ForeColor = Color.FromArgb(189, 59, 59);
            lblPleaseEnter.Location = new Point(12, 506);
            lblPleaseEnter.Name = "lblPleaseEnter";
            lblPleaseEnter.Size = new Size(481, 37);
            lblPleaseEnter.TabIndex = 9;
            lblPleaseEnter.Text = "Please enter a username and password.";
            lblPleaseEnter.Visible = false;
            // 
            // lblPassMatch
            // 
            lblPassMatch.Anchor = AnchorStyles.Left;
            lblPassMatch.AutoSize = true;
            lblPassMatch.Font = new Font("Segoe UI", 20F);
            lblPassMatch.ForeColor = Color.FromArgb(189, 59, 59);
            lblPassMatch.Location = new Point(15, 507);
            lblPassMatch.Name = "lblPassMatch";
            lblPassMatch.Size = new Size(457, 37);
            lblPassMatch.TabIndex = 8;
            lblPassMatch.Text = "Please ensure both passwords match.\r\n";
            lblPassMatch.Visible = false;
            // 
            // lblAccExists
            // 
            lblAccExists.Anchor = AnchorStyles.Left;
            lblAccExists.AutoSize = true;
            lblAccExists.Font = new Font("Segoe UI", 20F);
            lblAccExists.ForeColor = Color.FromArgb(189, 59, 59);
            lblAccExists.Location = new Point(12, 284);
            lblAccExists.Name = "lblAccExists";
            lblAccExists.Size = new Size(284, 37);
            lblAccExists.TabIndex = 7;
            lblAccExists.Text = "Account already exists.";
            lblAccExists.Visible = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.tfLogo;
            pbLogo.Location = new Point(15, 21);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(563, 126);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRegister.BackColor = Color.FromArgb(189, 59, 59);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 52F);
            btnRegister.ForeColor = Color.FromArgb(246, 231, 222);
            btnRegister.Location = new Point(15, 610);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(563, 118);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // rpnlReenter
            // 
            rpnlReenter.Anchor = AnchorStyles.Left;
            rpnlReenter.BorderColour = Color.Transparent;
            rpnlReenter.BorderSize = 0;
            rpnlReenter.Controls.Add(tbReenter);
            rpnlReenter.Location = new Point(12, 436);
            rpnlReenter.Name = "rpnlReenter";
            rpnlReenter.PanelColour = Color.White;
            rpnlReenter.Radius = 30;
            rpnlReenter.Size = new Size(563, 68);
            rpnlReenter.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlReenter.TabIndex = 4;
            // 
            // tbReenter
            // 
            tbReenter.BorderStyle = BorderStyle.None;
            tbReenter.Font = new Font("Segoe UI", 30F);
            tbReenter.Location = new Point(3, 13);
            tbReenter.Name = "tbReenter";
            tbReenter.PlaceholderText = "Re-enter Password";
            tbReenter.Size = new Size(557, 54);
            tbReenter.TabIndex = 1;
            tbReenter.UseSystemPasswordChar = true;
            // 
            // rpnlPassword
            // 
            rpnlPassword.Anchor = AnchorStyles.Left;
            rpnlPassword.BorderColour = Color.Transparent;
            rpnlPassword.BorderSize = 0;
            rpnlPassword.Controls.Add(tbPassword);
            rpnlPassword.Location = new Point(12, 326);
            rpnlPassword.Name = "rpnlPassword";
            rpnlPassword.PanelColour = Color.White;
            rpnlPassword.Radius = 30;
            rpnlPassword.Size = new Size(563, 68);
            rpnlPassword.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlPassword.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 30F);
            tbPassword.Location = new Point(3, 13);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(557, 54);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // rpnlUsername
            // 
            rpnlUsername.Anchor = AnchorStyles.Left;
            rpnlUsername.BorderColour = Color.Transparent;
            rpnlUsername.BorderSize = 0;
            rpnlUsername.Controls.Add(tbUsername);
            rpnlUsername.Location = new Point(12, 216);
            rpnlUsername.Name = "rpnlUsername";
            rpnlUsername.PanelColour = Color.White;
            rpnlUsername.Radius = 30;
            rpnlUsername.Size = new Size(563, 68);
            rpnlUsername.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlUsername.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI", 30F);
            tbUsername.Location = new Point(3, 11);
            tbUsername.MaxLength = 20;
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(557, 54);
            tbUsername.TabIndex = 0;
            // 
            // lblRegister
            // 
            lblRegister.Anchor = AnchorStyles.Left;
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 35F);
            lblRegister.ForeColor = Color.FromArgb(246, 231, 222);
            lblRegister.Location = new Point(0, 151);
            lblRegister.Margin = new Padding(0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(226, 62);
            lblRegister.TabIndex = 1;
            lblRegister.Text = "REGISTER";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkToLogin
            // 
            linkToLogin.ActiveLinkColor = Color.DarkRed;
            linkToLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkToLogin.AutoSize = true;
            linkToLogin.BackColor = Color.Transparent;
            linkToLogin.Font = new Font("Segoe UI", 20F);
            linkToLogin.LinkColor = Color.FromArgb(189, 59, 59);
            linkToLogin.Location = new Point(1497, 854);
            linkToLogin.Name = "linkToLogin";
            linkToLogin.Size = new Size(91, 37);
            linkToLogin.TabIndex = 3;
            linkToLogin.TabStop = true;
            linkToLogin.Text = "Log In";
            linkToLogin.VisitedLinkColor = Color.IndianRed;
            linkToLogin.LinkClicked += linkToLogin_LinkClicked;
            // 
            // pbClassSelected
            // 
            pbClassSelected.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbClassSelected.BackColor = Color.Transparent;
            pbClassSelected.Location = new Point(598, 156);
            pbClassSelected.Name = "pbClassSelected";
            pbClassSelected.Size = new Size(1002, 744);
            pbClassSelected.SizeMode = PictureBoxSizeMode.Zoom;
            pbClassSelected.TabIndex = 4;
            pbClassSelected.TabStop = false;
            // 
            // pnlClasses
            // 
            pnlClasses.AutoScroll = true;
            pnlClasses.BackColor = Color.FromArgb(41, 39, 39);
            pnlClasses.Controls.Add(lblSelectClass);
            pnlClasses.Controls.Add(pbScoutEmblem);
            pnlClasses.Controls.Add(pbSoldierEmblem);
            pnlClasses.Controls.Add(pbPyroEmblem);
            pnlClasses.Controls.Add(pbDemoEmblem);
            pnlClasses.Controls.Add(pbHWGEmblem);
            pnlClasses.Controls.Add(pbEngineerEmblem);
            pnlClasses.Controls.Add(pbMedicEmblem);
            pnlClasses.Controls.Add(pbSniperEmblem);
            pnlClasses.Controls.Add(pbSpyEmblem);
            pnlClasses.Dock = DockStyle.Top;
            pnlClasses.Location = new Point(0, 0);
            pnlClasses.Name = "pnlClasses";
            pnlClasses.Size = new Size(1600, 156);
            pnlClasses.TabIndex = 5;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cwBgWide;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 900);
            Controls.Add(linkToLogin);
            Controls.Add(pbClassSelected);
            Controls.Add(pnlRegister);
            Controls.Add(pnlClasses);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterScreen";
            Text = "Registration";
            WindowState = FormWindowState.Maximized;
            Load += RegisterScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pbScoutEmblem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSoldierEmblem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPyroEmblem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDemoEmblem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHWGEmblem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEngineerEmblem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMedicEmblem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSniperEmblem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSpyEmblem).EndInit();
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            rpnlReenter.ResumeLayout(false);
            rpnlReenter.PerformLayout();
            rpnlPassword.ResumeLayout(false);
            rpnlPassword.PerformLayout();
            rpnlUsername.ResumeLayout(false);
            rpnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClassSelected).EndInit();
            pnlClasses.ResumeLayout(false);
            pnlClasses.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSelectClass;
        private Panel pnlRegister;
        private PictureBox pbLogo;
        private Label lblRegister;
        private UserControls.RoundedPanel rpnlReenter;
        private UserControls.RoundedPanel rpnlPassword;
        private UserControls.RoundedPanel rpnlUsername;
        private Button btnRegister;
        private TextBox tbReenter;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private CheckBox cbShowPassword;
        private Label lblAccExists;
        private Label lblPassMatch;
        private Label lblPleaseEnter;
        private LinkLabel linkToLogin;
        private PictureBox pbScoutEmblem;
        private PictureBox pbSoldierEmblem;
        private PictureBox pbPyroEmblem;
        private PictureBox pbDemoEmblem;
        private PictureBox pbHWGEmblem;
        private PictureBox pbEngineerEmblem;
        private PictureBox pbMedicEmblem;
        private PictureBox pbSniperEmblem;
        private PictureBox pbSpyEmblem;
        private PictureBox pbClassSelected;
        private Panel pnlClasses;
        private Label lblPleaseSelectClass;
    }
}