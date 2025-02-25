namespace Coursework.Forms
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            lblLogin = new Label();
            pbLogo = new PictureBox();
            tbUsername = new TextBox();
            rpnlUsername = new UserControls.RoundedPanel();
            tbPassword = new TextBox();
            rpnlPassword = new UserControls.RoundedPanel();
            linkToRegister = new LinkLabel();
            pnlLogin = new Panel();
            cbShowPassword = new CheckBox();
            btnLogin = new Button();
            lblPasswordIncorrect = new Label();
            pbClassImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            rpnlUsername.SuspendLayout();
            rpnlPassword.SuspendLayout();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClassImage).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 35F);
            lblLogin.ForeColor = Color.FromArgb(246, 231, 222);
            lblLogin.Location = new Point(3, 306);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(175, 62);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOG IN";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.tfLogo;
            pbLogo.Location = new Point(15, 28);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(563, 126);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI", 30F);
            tbUsername.Location = new Point(3, 13);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(557, 54);
            tbUsername.TabIndex = 0;
            // 
            // rpnlUsername
            // 
            rpnlUsername.BorderColour = Color.Transparent;
            rpnlUsername.BorderSize = 0;
            rpnlUsername.Controls.Add(tbUsername);
            rpnlUsername.Location = new Point(12, 371);
            rpnlUsername.Name = "rpnlUsername";
            rpnlUsername.PanelColour = Color.White;
            rpnlUsername.Radius = 30;
            rpnlUsername.Size = new Size(563, 68);
            rpnlUsername.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlUsername.TabIndex = 2;
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
            // rpnlPassword
            // 
            rpnlPassword.BorderColour = Color.Transparent;
            rpnlPassword.BorderSize = 0;
            rpnlPassword.Controls.Add(tbPassword);
            rpnlPassword.Location = new Point(12, 481);
            rpnlPassword.Name = "rpnlPassword";
            rpnlPassword.PanelColour = Color.White;
            rpnlPassword.Radius = 30;
            rpnlPassword.Size = new Size(563, 68);
            rpnlPassword.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlPassword.TabIndex = 3;
            // 
            // linkToRegister
            // 
            linkToRegister.ActiveLinkColor = Color.DarkRed;
            linkToRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkToRegister.AutoSize = true;
            linkToRegister.BackColor = Color.Transparent;
            linkToRegister.Font = new Font("Segoe UI", 20F);
            linkToRegister.LinkColor = Color.FromArgb(189, 59, 59);
            linkToRegister.Location = new Point(1496, 874);
            linkToRegister.Name = "linkToRegister";
            linkToRegister.Size = new Size(112, 37);
            linkToRegister.TabIndex = 5;
            linkToRegister.TabStop = true;
            linkToRegister.Text = "Register";
            linkToRegister.VisitedLinkColor = Color.IndianRed;
            linkToRegister.LinkClicked += linkToRegister_LinkClicked;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(54, 49, 46);
            pnlLogin.Controls.Add(cbShowPassword);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lblPasswordIncorrect);
            pnlLogin.Controls.Add(rpnlPassword);
            pnlLogin.Controls.Add(rpnlUsername);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Controls.Add(pbLogo);
            pnlLogin.Dock = DockStyle.Left;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(592, 920);
            pnlLogin.TabIndex = 4;
            // 
            // cbShowPassword
            // 
            cbShowPassword.Anchor = AnchorStyles.None;
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Segoe UI", 30F);
            cbShowPassword.ForeColor = Color.FromArgb(246, 231, 222);
            cbShowPassword.Location = new Point(15, 653);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(314, 58);
            cbShowPassword.TabIndex = 9;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogin.BackColor = Color.FromArgb(189, 59, 59);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 52F);
            btnLogin.ForeColor = Color.FromArgb(246, 231, 222);
            btnLogin.Location = new Point(12, 790);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(563, 118);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPasswordIncorrect
            // 
            lblPasswordIncorrect.AutoSize = true;
            lblPasswordIncorrect.Font = new Font("Segoe UI", 20F);
            lblPasswordIncorrect.ForeColor = Color.FromArgb(189, 59, 59);
            lblPasswordIncorrect.Location = new Point(12, 552);
            lblPasswordIncorrect.Name = "lblPasswordIncorrect";
            lblPasswordIncorrect.Size = new Size(269, 37);
            lblPasswordIncorrect.TabIndex = 7;
            lblPasswordIncorrect.Text = "Password is incorrect.";
            lblPasswordIncorrect.Visible = false;
            // 
            // pbClassImage
            // 
            pbClassImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbClassImage.BackColor = Color.Transparent;
            pbClassImage.Location = new Point(598, 0);
            pbClassImage.Name = "pbClassImage";
            pbClassImage.Size = new Size(1022, 920);
            pbClassImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbClassImage.TabIndex = 6;
            pbClassImage.TabStop = false;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cwBgWide;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1620, 920);
            Controls.Add(linkToRegister);
            Controls.Add(pnlLogin);
            Controls.Add(pbClassImage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginScreen";
            Text = "LoginScreen";
            WindowState = FormWindowState.Maximized;
            Activated += LoginScreen_Activated;
            Load += LoginScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            rpnlUsername.ResumeLayout(false);
            rpnlUsername.PerformLayout();
            rpnlPassword.ResumeLayout(false);
            rpnlPassword.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClassImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private PictureBox pbLogo;
        private TextBox tbUsername;
        private UserControls.RoundedPanel rpnlUsername;
        private TextBox tbPassword;
        private UserControls.RoundedPanel rpnlPassword;
        private LinkLabel linkToRegister;
        private Panel pnlLogin;
        private Label lblPasswordIncorrect;
        private Button btnLogin;
        private CheckBox cbShowPassword;
        private PictureBox pbClassImage;
    }
}