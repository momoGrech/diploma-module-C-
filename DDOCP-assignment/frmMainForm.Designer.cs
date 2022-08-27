
namespace DDOCP_assignment
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.lblMainUserName = new System.Windows.Forms.Label();
            this.lblMainPassword = new System.Windows.Forms.Label();
            this.txtMainUsernameInput = new System.Windows.Forms.TextBox();
            this.txtMainPwdInput = new System.Windows.Forms.TextBox();
            this.btnMainClear = new System.Windows.Forms.Button();
            this.btnMainLogin = new System.Windows.Forms.Button();
            this.btnShowHidePwd = new System.Windows.Forms.Button();
            this.btnMainSignup = new System.Windows.Forms.Button();
            this.lblAccountLocked = new System.Windows.Forms.Button();
            this.timerLockAccount = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainUserName
            // 
            this.lblMainUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMainUserName.AutoSize = true;
            this.lblMainUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblMainUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMainUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMainUserName.Location = new System.Drawing.Point(29, 302);
            this.lblMainUserName.Name = "lblMainUserName";
            this.lblMainUserName.Size = new System.Drawing.Size(81, 18);
            this.lblMainUserName.TabIndex = 1;
            this.lblMainUserName.Text = "username";
            // 
            // lblMainPassword
            // 
            this.lblMainPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMainPassword.AutoSize = true;
            this.lblMainPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblMainPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMainPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMainPassword.Location = new System.Drawing.Point(29, 350);
            this.lblMainPassword.Name = "lblMainPassword";
            this.lblMainPassword.Size = new System.Drawing.Size(77, 18);
            this.lblMainPassword.TabIndex = 3;
            this.lblMainPassword.Text = "password";
            // 
            // txtMainUsernameInput
            // 
            this.txtMainUsernameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMainUsernameInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtMainUsernameInput.Location = new System.Drawing.Point(118, 303);
            this.txtMainUsernameInput.Multiline = true;
            this.txtMainUsernameInput.Name = "txtMainUsernameInput";
            this.txtMainUsernameInput.Size = new System.Drawing.Size(243, 22);
            this.txtMainUsernameInput.TabIndex = 1;
            // 
            // txtMainPwdInput
            // 
            this.txtMainPwdInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMainPwdInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtMainPwdInput.Location = new System.Drawing.Point(118, 348);
            this.txtMainPwdInput.Multiline = true;
            this.txtMainPwdInput.Name = "txtMainPwdInput";
            this.txtMainPwdInput.PasswordChar = '*';
            this.txtMainPwdInput.Size = new System.Drawing.Size(243, 22);
            this.txtMainPwdInput.TabIndex = 2;
            // 
            // btnMainClear
            // 
            this.btnMainClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMainClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMainClear.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnMainClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainClear.Font = new System.Drawing.Font("Gilroy Light", 11.75F);
            this.btnMainClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMainClear.Location = new System.Drawing.Point(261, 396);
            this.btnMainClear.Name = "btnMainClear";
            this.btnMainClear.Size = new System.Drawing.Size(100, 41);
            this.btnMainClear.TabIndex = 4;
            this.btnMainClear.Text = "Clear";
            this.btnMainClear.UseVisualStyleBackColor = false;
            this.btnMainClear.Click += new System.EventHandler(this.btnMainClear_Click);
            // 
            // btnMainLogin
            // 
            this.btnMainLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMainLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMainLogin.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnMainLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainLogin.Font = new System.Drawing.Font("Gilroy Light", 11.75F);
            this.btnMainLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMainLogin.Location = new System.Drawing.Point(118, 396);
            this.btnMainLogin.Name = "btnMainLogin";
            this.btnMainLogin.Size = new System.Drawing.Size(100, 41);
            this.btnMainLogin.TabIndex = 3;
            this.btnMainLogin.Text = "Login";
            this.btnMainLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMainLogin.UseVisualStyleBackColor = false;
            this.btnMainLogin.Click += new System.EventHandler(this.btnMainLogin_Click);
            // 
            // btnShowHidePwd
            // 
            this.btnShowHidePwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowHidePwd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowHidePwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowHidePwd.BackgroundImage")));
            this.btnShowHidePwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowHidePwd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowHidePwd.FlatAppearance.BorderSize = 0;
            this.btnShowHidePwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShowHidePwd.Location = new System.Drawing.Point(386, 346);
            this.btnShowHidePwd.Name = "btnShowHidePwd";
            this.btnShowHidePwd.Size = new System.Drawing.Size(25, 24);
            this.btnShowHidePwd.TabIndex = 6;
            this.btnShowHidePwd.UseMnemonic = false;
            this.btnShowHidePwd.UseVisualStyleBackColor = false;
            this.btnShowHidePwd.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnMainSignup
            // 
            this.btnMainSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMainSignup.BackColor = System.Drawing.Color.Transparent;
            this.btnMainSignup.FlatAppearance.BorderSize = 0;
            this.btnMainSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMainSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMainSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnMainSignup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMainSignup.Location = new System.Drawing.Point(198, 454);
            this.btnMainSignup.Name = "btnMainSignup";
            this.btnMainSignup.Size = new System.Drawing.Size(78, 33);
            this.btnMainSignup.TabIndex = 5;
            this.btnMainSignup.Text = "Sign up";
            this.btnMainSignup.UseVisualStyleBackColor = false;
            this.btnMainSignup.Click += new System.EventHandler(this.btnMainSignup_Click);
            this.btnMainSignup.MouseEnter += new System.EventHandler(this.btnMainSignup_MouseEnter);
            this.btnMainSignup.MouseLeave += new System.EventHandler(this.btnMainSignup_MouseLeave);
            // 
            // lblAccountLocked
            // 
            this.lblAccountLocked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountLocked.BackColor = System.Drawing.Color.Maroon;
            this.lblAccountLocked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lblAccountLocked.FlatAppearance.BorderSize = 0;
            this.lblAccountLocked.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lblAccountLocked.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lblAccountLocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAccountLocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountLocked.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAccountLocked.Location = new System.Drawing.Point(0, 201);
            this.lblAccountLocked.Name = "lblAccountLocked";
            this.lblAccountLocked.Size = new System.Drawing.Size(486, 59);
            this.lblAccountLocked.TabIndex = 7;
            this.lblAccountLocked.Text = "Account blocked for 10 seconds! Please try later.";
            this.lblAccountLocked.UseVisualStyleBackColor = false;
            this.lblAccountLocked.Visible = false;
            this.lblAccountLocked.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAccountLocked_MouseMove);
            // 
            // timerLockAccount
            // 
            this.timerLockAccount.Interval = 2500;
            this.timerLockAccount.Tick += new System.EventHandler(this.timerLockAccount_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(194, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // txtAdmin
            // 
            this.txtAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdmin.BackColor = System.Drawing.Color.CadetBlue;
            this.txtAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdmin.Font = new System.Drawing.Font("Gilroy ExtraBold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtAdmin.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAdmin.Location = new System.Drawing.Point(158, 22);
            this.txtAdmin.Multiline = true;
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(170, 25);
            this.txtAdmin.TabIndex = 28;
            this.txtAdmin.Text = "Survey Application";
            this.txtAdmin.TextChanged += new System.EventHandler(this.txtAdmin_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 71);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 531);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblAccountLocked);
            this.Controls.Add(this.btnMainSignup);
            this.Controls.Add(this.btnMainLogin);
            this.Controls.Add(this.btnMainClear);
            this.Controls.Add(this.btnShowHidePwd);
            this.Controls.Add(this.txtMainPwdInput);
            this.Controls.Add(this.txtMainUsernameInput);
            this.Controls.Add(this.lblMainPassword);
            this.Controls.Add(this.lblMainUserName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 570);
            this.MinimumSize = new System.Drawing.Size(500, 570);
            this.Name = "frmMainForm";
            this.Text = "Survey App";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMainUserName;
        private System.Windows.Forms.Label lblMainPassword;
        private System.Windows.Forms.TextBox txtMainUsernameInput;
        private System.Windows.Forms.TextBox txtMainPwdInput;
        private System.Windows.Forms.Button btnMainClear;
        private System.Windows.Forms.Button btnMainLogin;
        private System.Windows.Forms.Button btnShowHidePwd;
        private System.Windows.Forms.Button btnMainSignup;
        private System.Windows.Forms.Button lblAccountLocked;
        private System.Windows.Forms.Timer timerLockAccount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProviderUsername;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
    }
}