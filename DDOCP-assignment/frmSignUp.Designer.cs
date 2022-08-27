
namespace DDOCP_assignment
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.txtPasswordInput1 = new System.Windows.Forms.TextBox();
            this.txtPasswordInput2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowHidePwd1 = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsernameInput = new System.Windows.Forms.TextBox();
            this.txtAgeInput = new System.Windows.Forms.TextBox();
            this.txtFullNameInput = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnShowHidePwd2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblUserAge = new System.Windows.Forms.Label();
            this.numericAgeInput = new System.Windows.Forms.NumericUpDown();
            this.CheckBtnIsAdmin = new System.Windows.Forms.CheckBox();
            this.lblIsAdmin = new System.Windows.Forms.Label();
            this.errorFirstPwd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSecondPwd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFullName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSecondPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            resources.ApplyResources(this.btnSignUp, "btnSignUp");
            this.btnSignUp.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            this.btnSignUp.MouseEnter += new System.EventHandler(this.btnSignUp_MouseEnter);
            this.btnSignUp.MouseLeave += new System.EventHandler(this.btnSignUp_MouseLeave);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // lblPassword2
            // 
            resources.ApplyResources(this.lblPassword2, "lblPassword2");
            this.lblPassword2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword2.Name = "lblPassword2";
            // 
            // lblPassword1
            // 
            resources.ApplyResources(this.lblPassword1, "lblPassword1");
            this.lblPassword1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword1.Name = "lblPassword1";
            // 
            // txtPasswordInput1
            // 
            resources.ApplyResources(this.txtPasswordInput1, "txtPasswordInput1");
            this.txtPasswordInput1.BackColor = System.Drawing.Color.White;
            this.txtPasswordInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordInput1.Name = "txtPasswordInput1";
            // 
            // txtPasswordInput2
            // 
            resources.ApplyResources(this.txtPasswordInput2, "txtPasswordInput2");
            this.txtPasswordInput2.BackColor = System.Drawing.Color.White;
            this.txtPasswordInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordInput2.Name = "txtPasswordInput2";
            this.txtPasswordInput2.Tag = "";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackgroundImage = global::DDOCP_assignment.Properties.Resources.account;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // txtUser
            // 
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.BackColor = System.Drawing.Color.CadetBlue;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUser.Name = "txtUser";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnShowHidePwd1
            // 
            resources.ApplyResources(this.btnShowHidePwd1, "btnShowHidePwd1");
            this.btnShowHidePwd1.BackColor = System.Drawing.Color.White;
            this.btnShowHidePwd1.BackgroundImage = global::DDOCP_assignment.Properties.Resources.showPassword;
            this.btnShowHidePwd1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowHidePwd1.FlatAppearance.BorderSize = 0;
            this.btnShowHidePwd1.Name = "btnShowHidePwd1";
            this.btnShowHidePwd1.UseMnemonic = false;
            this.btnShowHidePwd1.UseVisualStyleBackColor = false;
            this.btnShowHidePwd1.Click += new System.EventHandler(this.btnShowHidePwd1_Click);
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsername.Name = "lblUsername";
            // 
            // txtUsernameInput
            // 
            resources.ApplyResources(this.txtUsernameInput, "txtUsernameInput");
            this.txtUsernameInput.BackColor = System.Drawing.Color.White;
            this.txtUsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameInput.Name = "txtUsernameInput";
            // 
            // txtAgeInput
            // 
            resources.ApplyResources(this.txtAgeInput, "txtAgeInput");
            this.txtAgeInput.BackColor = System.Drawing.Color.White;
            this.txtAgeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeInput.Name = "txtAgeInput";
            this.txtAgeInput.Tag = "";
            // 
            // txtFullNameInput
            // 
            resources.ApplyResources(this.txtFullNameInput, "txtFullNameInput");
            this.txtFullNameInput.BackColor = System.Drawing.Color.White;
            this.txtFullNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullNameInput.Name = "txtFullNameInput";
            this.txtFullNameInput.Tag = "";
            // 
            // lblFullName
            // 
            resources.ApplyResources(this.lblFullName, "lblFullName");
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFullName.Name = "lblFullName";
            // 
            // btnShowHidePwd2
            // 
            resources.ApplyResources(this.btnShowHidePwd2, "btnShowHidePwd2");
            this.btnShowHidePwd2.BackColor = System.Drawing.Color.White;
            this.btnShowHidePwd2.BackgroundImage = global::DDOCP_assignment.Properties.Resources.showPassword;
            this.btnShowHidePwd2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowHidePwd2.FlatAppearance.BorderSize = 0;
            this.btnShowHidePwd2.Name = "btnShowHidePwd2";
            this.btnShowHidePwd2.UseMnemonic = false;
            this.btnShowHidePwd2.UseVisualStyleBackColor = false;
            this.btnShowHidePwd2.Click += new System.EventHandler(this.btnShowHidePwd2_Click);
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.CadetBlue;
            this.textBox5.Name = "textBox5";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.CadetBlue;
            this.textBox6.Name = "textBox6";
            // 
            // lblAge
            // 
            resources.ApplyResources(this.lblAge, "lblAge");
            this.lblAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAge.Name = "lblAge";
            // 
            // lblUserAge
            // 
            resources.ApplyResources(this.lblUserAge, "lblUserAge");
            this.lblUserAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserAge.Name = "lblUserAge";
            // 
            // numericAgeInput
            // 
            resources.ApplyResources(this.numericAgeInput, "numericAgeInput");
            this.numericAgeInput.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericAgeInput.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericAgeInput.Name = "numericAgeInput";
            this.numericAgeInput.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // CheckBtnIsAdmin
            // 
            resources.ApplyResources(this.CheckBtnIsAdmin, "CheckBtnIsAdmin");
            this.CheckBtnIsAdmin.Name = "CheckBtnIsAdmin";
            this.CheckBtnIsAdmin.UseVisualStyleBackColor = true;
            // 
            // lblIsAdmin
            // 
            resources.ApplyResources(this.lblIsAdmin, "lblIsAdmin");
            this.lblIsAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIsAdmin.Name = "lblIsAdmin";
            // 
            // errorFirstPwd
            // 
            this.errorFirstPwd.ContainerControl = this;
            // 
            // errorSecondPwd
            // 
            this.errorSecondPwd.ContainerControl = this;
            // 
            // errorFullName
            // 
            this.errorFullName.ContainerControl = this;
            // 
            // errorUserName
            // 
            this.errorUserName.ContainerControl = this;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DDOCP_assignment.User);
            // 
            // frmSignUp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblIsAdmin);
            this.Controls.Add(this.CheckBtnIsAdmin);
            this.Controls.Add(this.numericAgeInput);
            this.Controls.Add(this.lblUserAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnShowHidePwd2);
            this.Controls.Add(this.txtFullNameInput);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtAgeInput);
            this.Controls.Add(this.txtUsernameInput);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnShowHidePwd1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPasswordInput2);
            this.Controls.Add(this.txtPasswordInput1);
            this.Controls.Add(this.lblPassword1);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSignUp);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "frmSignUp";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSecondPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblPassword1;
        internal System.Windows.Forms.TextBox txtPasswordInput1;
        internal System.Windows.Forms.TextBox txtPasswordInput2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowHidePwd1;
        private System.Windows.Forms.Label lblUsername;
        internal System.Windows.Forms.TextBox txtUsernameInput;
        internal System.Windows.Forms.TextBox txtAgeInput;
        internal System.Windows.Forms.TextBox txtFullNameInput;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnShowHidePwd2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblUserAge;
        private System.Windows.Forms.NumericUpDown numericAgeInput;
        private System.Windows.Forms.CheckBox CheckBtnIsAdmin;
        private System.Windows.Forms.Label lblIsAdmin;
        private System.Windows.Forms.ErrorProvider errorFirstPwd;
        private System.Windows.Forms.ErrorProvider errorSecondPwd;
        private System.Windows.Forms.ErrorProvider errorFullName;
        private System.Windows.Forms.ErrorProvider errorUserName;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}

