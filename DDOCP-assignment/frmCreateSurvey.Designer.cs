
namespace DDOCP_assignment
{
    partial class frmCreateSurvey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateSurvey));
            this.errorSurveyName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSurveyId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSurveyDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSurveyName = new System.Windows.Forms.Label();
            this.lblSurveyDescription = new System.Windows.Forms.Label();
            this.lblSurveyCreator = new System.Windows.Forms.Label();
            this.txtSurveyName = new System.Windows.Forms.TextBox();
            this.txtSurveyDescription = new System.Windows.Forms.TextBox();
            this.btnCreateSurvey = new System.Windows.Forms.Button();
            this.grpYesNo = new System.Windows.Forms.GroupBox();
            this.lblYesNoQuestion = new System.Windows.Forms.Label();
            this.btnAddYesNo = new System.Windows.Forms.Button();
            this.txtYesNoText = new System.Windows.Forms.TextBox();
            this.lblYesNoText = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpDropDown = new System.Windows.Forms.GroupBox();
            this.MultiOptionsList = new System.Windows.Forms.ListBox();
            this.btnAddOption = new System.Windows.Forms.Button();
            this.txtEnterOption = new System.Windows.Forms.TextBox();
            this.lblDropDownOptions = new System.Windows.Forms.Label();
            this.btnAddDropDown = new System.Windows.Forms.Button();
            this.txtDropDownText = new System.Windows.Forms.TextBox();
            this.lblDropDownQuestion = new System.Windows.Forms.Label();
            this.grpRaiting = new System.Windows.Forms.GroupBox();
            this.btnAddRaiting = new System.Windows.Forms.Button();
            this.txtRaitingText = new System.Windows.Forms.TextBox();
            this.lblRankingQuestion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveSurvey = new System.Windows.Forms.Button();
            this.lblAdminSurveyCreator = new System.Windows.Forms.Label();
            this.grpCreateSurvey = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSurveyAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorSurveyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurveyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurveyDescription)).BeginInit();
            this.grpYesNo.SuspendLayout();
            this.grpDropDown.SuspendLayout();
            this.grpRaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpCreateSurvey.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorSurveyName
            // 
            this.errorSurveyName.ContainerControl = this;
            // 
            // errorSurveyId
            // 
            this.errorSurveyId.ContainerControl = this;
            // 
            // errorSurveyDescription
            // 
            this.errorSurveyDescription.ContainerControl = this;
            // 
            // lblSurveyName
            // 
            this.lblSurveyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSurveyName.AutoSize = true;
            this.lblSurveyName.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurveyName.Location = new System.Drawing.Point(3, 161);
            this.lblSurveyName.Name = "lblSurveyName";
            this.lblSurveyName.Size = new System.Drawing.Size(97, 17);
            this.lblSurveyName.TabIndex = 0;
            this.lblSurveyName.Text = "Survey Name:";
            // 
            // lblSurveyDescription
            // 
            this.lblSurveyDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSurveyDescription.AutoSize = true;
            this.lblSurveyDescription.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurveyDescription.Location = new System.Drawing.Point(3, 242);
            this.lblSurveyDescription.Name = "lblSurveyDescription";
            this.lblSurveyDescription.Size = new System.Drawing.Size(134, 17);
            this.lblSurveyDescription.TabIndex = 2;
            this.lblSurveyDescription.Text = "Survey Description:";
            // 
            // lblSurveyCreator
            // 
            this.lblSurveyCreator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSurveyCreator.AutoSize = true;
            this.lblSurveyCreator.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurveyCreator.Location = new System.Drawing.Point(3, 99);
            this.lblSurveyCreator.Name = "lblSurveyCreator";
            this.lblSurveyCreator.Size = new System.Drawing.Size(108, 17);
            this.lblSurveyCreator.TabIndex = 4;
            this.lblSurveyCreator.Text = "Survey Creator:";
            // 
            // txtSurveyName
            // 
            this.txtSurveyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSurveyName.Location = new System.Drawing.Point(106, 161);
            this.txtSurveyName.MaxLength = 40;
            this.txtSurveyName.Name = "txtSurveyName";
            this.txtSurveyName.Size = new System.Drawing.Size(205, 20);
            this.txtSurveyName.TabIndex = 1;
            // 
            // txtSurveyDescription
            // 
            this.txtSurveyDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSurveyDescription.Location = new System.Drawing.Point(6, 276);
            this.txtSurveyDescription.MaxLength = 120;
            this.txtSurveyDescription.Name = "txtSurveyDescription";
            this.txtSurveyDescription.Size = new System.Drawing.Size(305, 20);
            this.txtSurveyDescription.TabIndex = 2;
            // 
            // btnCreateSurvey
            // 
            this.btnCreateSurvey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateSurvey.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCreateSurvey.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnCreateSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateSurvey.Font = new System.Drawing.Font("Gilroy Light", 9.749999F);
            this.btnCreateSurvey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateSurvey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreateSurvey.Location = new System.Drawing.Point(26, 489);
            this.btnCreateSurvey.Name = "btnCreateSurvey";
            this.btnCreateSurvey.Size = new System.Drawing.Size(100, 41);
            this.btnCreateSurvey.TabIndex = 3;
            this.btnCreateSurvey.Text = "Create";
            this.btnCreateSurvey.UseVisualStyleBackColor = false;
            this.btnCreateSurvey.Click += new System.EventHandler(this.btnCreateSurvey_Click);
            // 
            // grpYesNo
            // 
            this.grpYesNo.Controls.Add(this.lblYesNoQuestion);
            this.grpYesNo.Controls.Add(this.btnAddYesNo);
            this.grpYesNo.Controls.Add(this.txtYesNoText);
            this.grpYesNo.Controls.Add(this.lblYesNoText);
            this.grpYesNo.Enabled = false;
            this.grpYesNo.Location = new System.Drawing.Point(342, 31);
            this.grpYesNo.Name = "grpYesNo";
            this.grpYesNo.Size = new System.Drawing.Size(286, 187);
            this.grpYesNo.TabIndex = 21;
            this.grpYesNo.TabStop = false;
            this.grpYesNo.Text = "Add Yes/No Question";
            // 
            // lblYesNoQuestion
            // 
            this.lblYesNoQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYesNoQuestion.AutoSize = true;
            this.lblYesNoQuestion.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesNoQuestion.Location = new System.Drawing.Point(3, 37);
            this.lblYesNoQuestion.Name = "lblYesNoQuestion";
            this.lblYesNoQuestion.Size = new System.Drawing.Size(134, 17);
            this.lblYesNoQuestion.TabIndex = 26;
            this.lblYesNoQuestion.Text = "Enter Question Text";
            // 
            // btnAddYesNo
            // 
            this.btnAddYesNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddYesNo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddYesNo.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnAddYesNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddYesNo.Font = new System.Drawing.Font("Gilroy Light", 9.749999F);
            this.btnAddYesNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddYesNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddYesNo.Location = new System.Drawing.Point(57, 130);
            this.btnAddYesNo.Name = "btnAddYesNo";
            this.btnAddYesNo.Size = new System.Drawing.Size(169, 41);
            this.btnAddYesNo.TabIndex = 28;
            this.btnAddYesNo.Text = "Add Question to Survey";
            this.btnAddYesNo.UseVisualStyleBackColor = false;
            this.btnAddYesNo.Click += new System.EventHandler(this.btnAddYesNo_Click);
            // 
            // txtYesNoText
            // 
            this.txtYesNoText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYesNoText.Location = new System.Drawing.Point(6, 66);
            this.txtYesNoText.MaxLength = 100;
            this.txtYesNoText.Name = "txtYesNoText";
            this.txtYesNoText.Size = new System.Drawing.Size(274, 20);
            this.txtYesNoText.TabIndex = 26;
            // 
            // lblYesNoText
            // 
            this.lblYesNoText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYesNoText.AutoSize = true;
            this.lblYesNoText.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesNoText.Location = new System.Drawing.Point(6, -15);
            this.lblYesNoText.Name = "lblYesNoText";
            this.lblYesNoText.Size = new System.Drawing.Size(0, 17);
            this.lblYesNoText.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Gilroy Light", 9.749999F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClear.Location = new System.Drawing.Point(199, 489);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 41);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpDropDown
            // 
            this.grpDropDown.Controls.Add(this.MultiOptionsList);
            this.grpDropDown.Controls.Add(this.btnAddOption);
            this.grpDropDown.Controls.Add(this.txtEnterOption);
            this.grpDropDown.Controls.Add(this.lblDropDownOptions);
            this.grpDropDown.Controls.Add(this.btnAddDropDown);
            this.grpDropDown.Controls.Add(this.txtDropDownText);
            this.grpDropDown.Controls.Add(this.lblDropDownQuestion);
            this.grpDropDown.Enabled = false;
            this.grpDropDown.Location = new System.Drawing.Point(671, 31);
            this.grpDropDown.Name = "grpDropDown";
            this.grpDropDown.Size = new System.Drawing.Size(286, 439);
            this.grpDropDown.TabIndex = 22;
            this.grpDropDown.TabStop = false;
            this.grpDropDown.Text = "Add DropDown Question";
            // 
            // MultiOptionsList
            // 
            this.MultiOptionsList.FormattingEnabled = true;
            this.MultiOptionsList.Location = new System.Drawing.Point(9, 252);
            this.MultiOptionsList.Name = "MultiOptionsList";
            this.MultiOptionsList.Size = new System.Drawing.Size(268, 95);
            this.MultiOptionsList.TabIndex = 39;
            // 
            // btnAddOption
            // 
            this.btnAddOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddOption.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddOption.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnAddOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOption.Font = new System.Drawing.Font("Gilroy Light", 9.749999F);
            this.btnAddOption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddOption.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddOption.Location = new System.Drawing.Point(177, 131);
            this.btnAddOption.Name = "btnAddOption";
            this.btnAddOption.Size = new System.Drawing.Size(100, 41);
            this.btnAddOption.TabIndex = 38;
            this.btnAddOption.Text = "Add";
            this.btnAddOption.UseVisualStyleBackColor = false;
            this.btnAddOption.Click += new System.EventHandler(this.btnAddOption_Click);
            // 
            // txtEnterOption
            // 
            this.txtEnterOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnterOption.Location = new System.Drawing.Point(6, 215);
            this.txtEnterOption.MaxLength = 100;
            this.txtEnterOption.Name = "txtEnterOption";
            this.txtEnterOption.Size = new System.Drawing.Size(274, 20);
            this.txtEnterOption.TabIndex = 37;
            // 
            // lblDropDownOptions
            // 
            this.lblDropDownOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDropDownOptions.AutoSize = true;
            this.lblDropDownOptions.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropDownOptions.Location = new System.Drawing.Point(3, 142);
            this.lblDropDownOptions.Name = "lblDropDownOptions";
            this.lblDropDownOptions.Size = new System.Drawing.Size(171, 17);
            this.lblDropDownOptions.TabIndex = 35;
            this.lblDropDownOptions.Text = "Enter Drop Down Options";
            // 
            // btnAddDropDown
            // 
            this.btnAddDropDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddDropDown.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddDropDown.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnAddDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDropDown.Font = new System.Drawing.Font("Gilroy Light", 9.749999F);
            this.btnAddDropDown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddDropDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddDropDown.Location = new System.Drawing.Point(61, 368);
            this.btnAddDropDown.Name = "btnAddDropDown";
            this.btnAddDropDown.Size = new System.Drawing.Size(169, 41);
            this.btnAddDropDown.TabIndex = 34;
            this.btnAddDropDown.Text = "Add Question to Survey";
            this.btnAddDropDown.UseVisualStyleBackColor = false;
            this.btnAddDropDown.Click += new System.EventHandler(this.btnAddDropDown_Click);
            // 
            // txtDropDownText
            // 
            this.txtDropDownText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDropDownText.Location = new System.Drawing.Point(6, 66);
            this.txtDropDownText.MaxLength = 100;
            this.txtDropDownText.Name = "txtDropDownText";
            this.txtDropDownText.Size = new System.Drawing.Size(274, 20);
            this.txtDropDownText.TabIndex = 33;
            // 
            // lblDropDownQuestion
            // 
            this.lblDropDownQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDropDownQuestion.AutoSize = true;
            this.lblDropDownQuestion.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropDownQuestion.Location = new System.Drawing.Point(6, 37);
            this.lblDropDownQuestion.Name = "lblDropDownQuestion";
            this.lblDropDownQuestion.Size = new System.Drawing.Size(134, 17);
            this.lblDropDownQuestion.TabIndex = 32;
            this.lblDropDownQuestion.Text = "Enter Question Text";
            // 
            // grpRaiting
            // 
            this.grpRaiting.Controls.Add(this.btnAddRaiting);
            this.grpRaiting.Controls.Add(this.txtRaitingText);
            this.grpRaiting.Controls.Add(this.lblRankingQuestion);
            this.grpRaiting.Enabled = false;
            this.grpRaiting.Location = new System.Drawing.Point(342, 283);
            this.grpRaiting.Name = "grpRaiting";
            this.grpRaiting.Size = new System.Drawing.Size(286, 187);
            this.grpRaiting.TabIndex = 22;
            this.grpRaiting.TabStop = false;
            this.grpRaiting.Text = "Add Raiting Question";
            // 
            // btnAddRaiting
            // 
            this.btnAddRaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddRaiting.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddRaiting.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnAddRaiting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRaiting.Font = new System.Drawing.Font("Gilroy Light", 9.749999F);
            this.btnAddRaiting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddRaiting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddRaiting.Location = new System.Drawing.Point(57, 129);
            this.btnAddRaiting.Name = "btnAddRaiting";
            this.btnAddRaiting.Size = new System.Drawing.Size(169, 41);
            this.btnAddRaiting.TabIndex = 31;
            this.btnAddRaiting.Text = "Add Question to Survey";
            this.btnAddRaiting.UseVisualStyleBackColor = false;
            this.btnAddRaiting.Click += new System.EventHandler(this.btnAddRaiting_Click);
            // 
            // txtRaitingText
            // 
            this.txtRaitingText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRaitingText.Location = new System.Drawing.Point(6, 66);
            this.txtRaitingText.MaxLength = 100;
            this.txtRaitingText.Name = "txtRaitingText";
            this.txtRaitingText.Size = new System.Drawing.Size(274, 20);
            this.txtRaitingText.TabIndex = 30;
            // 
            // lblRankingQuestion
            // 
            this.lblRankingQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRankingQuestion.AutoSize = true;
            this.lblRankingQuestion.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRankingQuestion.Location = new System.Drawing.Point(3, 37);
            this.lblRankingQuestion.Name = "lblRankingQuestion";
            this.lblRankingQuestion.Size = new System.Drawing.Size(134, 17);
            this.lblRankingQuestion.TabIndex = 29;
            this.lblRankingQuestion.Text = "Enter Question Text";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.Location = new System.Drawing.Point(326, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 538);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveSurvey
            // 
            this.btnSaveSurvey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveSurvey.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSaveSurvey.Enabled = false;
            this.btnSaveSurvey.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnSaveSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSurvey.Font = new System.Drawing.Font("Gilroy Light", 9.749999F);
            this.btnSaveSurvey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveSurvey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveSurvey.Location = new System.Drawing.Point(857, 489);
            this.btnSaveSurvey.Name = "btnSaveSurvey";
            this.btnSaveSurvey.Size = new System.Drawing.Size(100, 41);
            this.btnSaveSurvey.TabIndex = 26;
            this.btnSaveSurvey.Text = "Save";
            this.btnSaveSurvey.UseVisualStyleBackColor = false;
            this.btnSaveSurvey.Click += new System.EventHandler(this.btnSaveSurvey_Click);
            // 
            // lblAdminSurveyCreator
            // 
            this.lblAdminSurveyCreator.AutoSize = true;
            this.lblAdminSurveyCreator.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdminSurveyCreator.Location = new System.Drawing.Point(121, 100);
            this.lblAdminSurveyCreator.Name = "lblAdminSurveyCreator";
            this.lblAdminSurveyCreator.Size = new System.Drawing.Size(13, 17);
            this.lblAdminSurveyCreator.TabIndex = 27;
            this.lblAdminSurveyCreator.Text = " ";
            // 
            // grpCreateSurvey
            // 
            this.grpCreateSurvey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpCreateSurvey.BackColor = System.Drawing.Color.Azure;
            this.grpCreateSurvey.CausesValidation = false;
            this.grpCreateSurvey.Controls.Add(this.lblAdminSurveyCreator);
            this.grpCreateSurvey.Controls.Add(this.btnSaveSurvey);
            this.grpCreateSurvey.Controls.Add(this.pictureBox1);
            this.grpCreateSurvey.Controls.Add(this.grpRaiting);
            this.grpCreateSurvey.Controls.Add(this.grpDropDown);
            this.grpCreateSurvey.Controls.Add(this.btnClear);
            this.grpCreateSurvey.Controls.Add(this.grpYesNo);
            this.grpCreateSurvey.Controls.Add(this.btnCreateSurvey);
            this.grpCreateSurvey.Controls.Add(this.txtSurveyDescription);
            this.grpCreateSurvey.Controls.Add(this.txtSurveyName);
            this.grpCreateSurvey.Controls.Add(this.lblSurveyCreator);
            this.grpCreateSurvey.Controls.Add(this.lblSurveyDescription);
            this.grpCreateSurvey.Controls.Add(this.lblSurveyName);
            this.grpCreateSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCreateSurvey.Location = new System.Drawing.Point(35, 82);
            this.grpCreateSurvey.Name = "grpCreateSurvey";
            this.grpCreateSurvey.Size = new System.Drawing.Size(990, 536);
            this.grpCreateSurvey.TabIndex = 0;
            this.grpCreateSurvey.TabStop = false;
            this.grpCreateSurvey.Text = "Create New Survey";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSurveyAnalysis,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ToolStripSurveyAnalysis
            // 
            this.ToolStripSurveyAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripSurveyAnalysis.ForeColor = System.Drawing.Color.Black;
            this.ToolStripSurveyAnalysis.Name = "ToolStripSurveyAnalysis";
            this.ToolStripSurveyAnalysis.Size = new System.Drawing.Size(199, 24);
            this.ToolStripSurveyAnalysis.Text = "Survey Anaysis";
            this.ToolStripSurveyAnalysis.Click += new System.EventHandler(this.ToolStripSurveyAnalysis_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DDOCP_assignment.User);
            // 
            // frmCreateSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1066, 698);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpCreateSurvey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1082, 737);
            this.MinimumSize = new System.Drawing.Size(1082, 726);
            this.Name = "frmCreateSurvey";
            this.Text = "Create Survey";
            this.Load += new System.EventHandler(this.frmSurvey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorSurveyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurveyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurveyDescription)).EndInit();
            this.grpYesNo.ResumeLayout(false);
            this.grpYesNo.PerformLayout();
            this.grpDropDown.ResumeLayout(false);
            this.grpDropDown.PerformLayout();
            this.grpRaiting.ResumeLayout(false);
            this.grpRaiting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpCreateSurvey.ResumeLayout(false);
            this.grpCreateSurvey.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorSurveyName;
        private System.Windows.Forms.ErrorProvider errorSurveyId;
        private System.Windows.Forms.ErrorProvider errorSurveyDescription;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.GroupBox grpCreateSurvey;
        private System.Windows.Forms.Label lblAdminSurveyCreator;
        private System.Windows.Forms.Button btnSaveSurvey;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpRaiting;
        private System.Windows.Forms.Button btnAddRaiting;
        private System.Windows.Forms.TextBox txtRaitingText;
        private System.Windows.Forms.Label lblRankingQuestion;
        private System.Windows.Forms.GroupBox grpDropDown;
        private System.Windows.Forms.Label lblDropDownOptions;
        private System.Windows.Forms.Button btnAddDropDown;
        private System.Windows.Forms.TextBox txtDropDownText;
        private System.Windows.Forms.Label lblDropDownQuestion;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpYesNo;
        private System.Windows.Forms.Label lblYesNoQuestion;
        private System.Windows.Forms.Button btnAddYesNo;
        private System.Windows.Forms.TextBox txtYesNoText;
        private System.Windows.Forms.Label lblYesNoText;
        private System.Windows.Forms.Button btnCreateSurvey;
        private System.Windows.Forms.TextBox txtSurveyDescription;
        private System.Windows.Forms.TextBox txtSurveyName;
        private System.Windows.Forms.Label lblSurveyCreator;
        private System.Windows.Forms.Label lblSurveyDescription;
        private System.Windows.Forms.Label lblSurveyName;
        private System.Windows.Forms.Button btnAddOption;
        private System.Windows.Forms.TextBox txtEnterOption;
        private System.Windows.Forms.ListBox MultiOptionsList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSurveyAnalysis;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}