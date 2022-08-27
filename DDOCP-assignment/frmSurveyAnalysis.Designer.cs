
namespace DDOCP_assignment
{
    partial class frmSurveyAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSurveyAnalysis));
            this.lblSurveyList = new System.Windows.Forms.Label();
            this.comboBoxListOfSurvey = new System.Windows.Forms.ComboBox();
            this.lblYes = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblNoAnswer = new System.Windows.Forms.Label();
            this.lblYesAnswer = new System.Windows.Forms.Label();
            this.lblYesNoQuestion = new System.Windows.Forms.Label();
            this.lblRaitingQuestion = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblDropDownQuestion = new System.Windows.Forms.Label();
            this.dgDropDownOptionResult = new System.Windows.Forms.DataGridView();
            this.optionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAverageHeader = new System.Windows.Forms.Label();
            this.grpBoxYesNoQuestionType = new System.Windows.Forms.GroupBox();
            this.btnNextYesNoResult = new System.Windows.Forms.Button();
            this.grpBoxRatingQuestionType = new System.Windows.Forms.GroupBox();
            this.btnNextRatingNextResult = new System.Windows.Forms.Button();
            this.grpBoxDropDownQuestionType = new System.Windows.Forms.GroupBox();
            this.btnNextDropDownResult = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAnalyseSurvey = new System.Windows.Forms.Label();
            this.lblNumberOfUser = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDropDownOptionResult)).BeginInit();
            this.grpBoxYesNoQuestionType.SuspendLayout();
            this.grpBoxRatingQuestionType.SuspendLayout();
            this.grpBoxDropDownQuestionType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSurveyList
            // 
            this.lblSurveyList.AutoSize = true;
            this.lblSurveyList.Font = new System.Drawing.Font("Bahnschrift", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblSurveyList.Location = new System.Drawing.Point(615, 23);
            this.lblSurveyList.Name = "lblSurveyList";
            this.lblSurveyList.Size = new System.Drawing.Size(123, 22);
            this.lblSurveyList.TabIndex = 36;
            this.lblSurveyList.Text = "List of Survey";
            // 
            // comboBoxListOfSurvey
            // 
            this.comboBoxListOfSurvey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxListOfSurvey.FormattingEnabled = true;
            this.comboBoxListOfSurvey.Location = new System.Drawing.Point(764, 24);
            this.comboBoxListOfSurvey.Name = "comboBoxListOfSurvey";
            this.comboBoxListOfSurvey.Size = new System.Drawing.Size(215, 21);
            this.comboBoxListOfSurvey.TabIndex = 35;
            this.comboBoxListOfSurvey.SelectedIndexChanged += new System.EventHandler(this.comboBoxListOfSurvey_SelectedIndexChanged);
            // 
            // lblYes
            // 
            this.lblYes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYes.AutoSize = true;
            this.lblYes.Font = new System.Drawing.Font("Bahnschrift", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYes.Location = new System.Drawing.Point(806, 48);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(37, 22);
            this.lblYes.TabIndex = 38;
            this.lblYes.Text = "Yes";
            // 
            // lblNo
            // 
            this.lblNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Bahnschrift", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNo.Location = new System.Drawing.Point(869, 48);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(33, 22);
            this.lblNo.TabIndex = 39;
            this.lblNo.Text = "No";
            // 
            // lblNoAnswer
            // 
            this.lblNoAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoAnswer.AutoSize = true;
            this.lblNoAnswer.Font = new System.Drawing.Font("Bahnschrift", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblNoAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNoAnswer.Location = new System.Drawing.Point(872, 91);
            this.lblNoAnswer.Name = "lblNoAnswer";
            this.lblNoAnswer.Size = new System.Drawing.Size(30, 22);
            this.lblNoAnswer.TabIndex = 40;
            this.lblNoAnswer.Text = "    ";
            // 
            // lblYesAnswer
            // 
            this.lblYesAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYesAnswer.AutoSize = true;
            this.lblYesAnswer.Font = new System.Drawing.Font("Bahnschrift", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblYesAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYesAnswer.Location = new System.Drawing.Point(813, 91);
            this.lblYesAnswer.Name = "lblYesAnswer";
            this.lblYesAnswer.Size = new System.Drawing.Size(30, 22);
            this.lblYesAnswer.TabIndex = 41;
            this.lblYesAnswer.Text = "    ";
            // 
            // lblYesNoQuestion
            // 
            this.lblYesNoQuestion.AutoSize = true;
            this.lblYesNoQuestion.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblYesNoQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYesNoQuestion.Location = new System.Drawing.Point(23, 37);
            this.lblYesNoQuestion.Name = "lblYesNoQuestion";
            this.lblYesNoQuestion.Size = new System.Drawing.Size(101, 16);
            this.lblYesNoQuestion.TabIndex = 42;
            this.lblYesNoQuestion.Text = "Yes No Question";
            // 
            // lblRaitingQuestion
            // 
            this.lblRaitingQuestion.AutoSize = true;
            this.lblRaitingQuestion.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblRaitingQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRaitingQuestion.Location = new System.Drawing.Point(28, 44);
            this.lblRaitingQuestion.Name = "lblRaitingQuestion";
            this.lblRaitingQuestion.Size = new System.Drawing.Size(98, 16);
            this.lblRaitingQuestion.TabIndex = 44;
            this.lblRaitingQuestion.Text = "Rating Question";
            // 
            // lblAverage
            // 
            this.lblAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Bahnschrift", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblAverage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAverage.Location = new System.Drawing.Point(835, 107);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(45, 22);
            this.lblAverage.TabIndex = 45;
            this.lblAverage.Text = "       ";
            // 
            // lblDropDownQuestion
            // 
            this.lblDropDownQuestion.AutoSize = true;
            this.lblDropDownQuestion.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblDropDownQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDropDownQuestion.Location = new System.Drawing.Point(28, 43);
            this.lblDropDownQuestion.Name = "lblDropDownQuestion";
            this.lblDropDownQuestion.Size = new System.Drawing.Size(122, 16);
            this.lblDropDownQuestion.TabIndex = 46;
            this.lblDropDownQuestion.Text = "Dropdown Question";
            // 
            // dgDropDownOptionResult
            // 
            this.dgDropDownOptionResult.AllowUserToAddRows = false;
            this.dgDropDownOptionResult.AllowUserToDeleteRows = false;
            this.dgDropDownOptionResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDropDownOptionResult.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgDropDownOptionResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDropDownOptionResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.optionText,
            this.optionResult});
            this.dgDropDownOptionResult.Location = new System.Drawing.Point(697, 10);
            this.dgDropDownOptionResult.Name = "dgDropDownOptionResult";
            this.dgDropDownOptionResult.ReadOnly = true;
            this.dgDropDownOptionResult.Size = new System.Drawing.Size(268, 152);
            this.dgDropDownOptionResult.TabIndex = 51;
            // 
            // optionText
            // 
            this.optionText.HeaderText = "Drop Down Option";
            this.optionText.Name = "optionText";
            this.optionText.ReadOnly = true;
            this.optionText.Width = 120;
            // 
            // optionResult
            // 
            this.optionResult.HeaderText = "Result";
            this.optionResult.Name = "optionResult";
            this.optionResult.ReadOnly = true;
            // 
            // lblAverageHeader
            // 
            this.lblAverageHeader.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblAverageHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAverageHeader.AutoSize = true;
            this.lblAverageHeader.Font = new System.Drawing.Font("Bahnschrift", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblAverageHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAverageHeader.Location = new System.Drawing.Point(781, 64);
            this.lblAverageHeader.Name = "lblAverageHeader";
            this.lblAverageHeader.Size = new System.Drawing.Size(158, 22);
            this.lblAverageHeader.TabIndex = 54;
            this.lblAverageHeader.Text = "Average of Rating";
            // 
            // grpBoxYesNoQuestionType
            // 
            this.grpBoxYesNoQuestionType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxYesNoQuestionType.BackColor = System.Drawing.Color.CadetBlue;
            this.grpBoxYesNoQuestionType.Controls.Add(this.lblYesNoQuestion);
            this.grpBoxYesNoQuestionType.Controls.Add(this.lblNo);
            this.grpBoxYesNoQuestionType.Controls.Add(this.lblYes);
            this.grpBoxYesNoQuestionType.Controls.Add(this.btnNextYesNoResult);
            this.grpBoxYesNoQuestionType.Controls.Add(this.lblNoAnswer);
            this.grpBoxYesNoQuestionType.Controls.Add(this.lblYesAnswer);
            this.grpBoxYesNoQuestionType.Location = new System.Drawing.Point(24, 121);
            this.grpBoxYesNoQuestionType.Name = "grpBoxYesNoQuestionType";
            this.grpBoxYesNoQuestionType.Size = new System.Drawing.Size(960, 129);
            this.grpBoxYesNoQuestionType.TabIndex = 55;
            this.grpBoxYesNoQuestionType.TabStop = false;
            this.grpBoxYesNoQuestionType.Text = "Yes/No Question Type";
            // 
            // btnNextYesNoResult
            // 
            this.btnNextYesNoResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextYesNoResult.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNextYesNoResult.FlatAppearance.BorderSize = 0;
            this.btnNextYesNoResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextYesNoResult.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.btnNextYesNoResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextYesNoResult.Location = new System.Drawing.Point(26, 91);
            this.btnNextYesNoResult.Name = "btnNextYesNoResult";
            this.btnNextYesNoResult.Size = new System.Drawing.Size(102, 32);
            this.btnNextYesNoResult.TabIndex = 48;
            this.btnNextYesNoResult.Text = "Next";
            this.btnNextYesNoResult.UseVisualStyleBackColor = false;
            this.btnNextYesNoResult.Click += new System.EventHandler(this.btnNextYesNoResult_Click);
            // 
            // grpBoxRatingQuestionType
            // 
            this.grpBoxRatingQuestionType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxRatingQuestionType.BackColor = System.Drawing.Color.CadetBlue;
            this.grpBoxRatingQuestionType.Controls.Add(this.btnNextRatingNextResult);
            this.grpBoxRatingQuestionType.Controls.Add(this.lblRaitingQuestion);
            this.grpBoxRatingQuestionType.Controls.Add(this.lblAverage);
            this.grpBoxRatingQuestionType.Controls.Add(this.lblAverageHeader);
            this.grpBoxRatingQuestionType.Location = new System.Drawing.Point(19, 293);
            this.grpBoxRatingQuestionType.Name = "grpBoxRatingQuestionType";
            this.grpBoxRatingQuestionType.Size = new System.Drawing.Size(965, 163);
            this.grpBoxRatingQuestionType.TabIndex = 56;
            this.grpBoxRatingQuestionType.TabStop = false;
            this.grpBoxRatingQuestionType.Text = "Rating Question Type";
            // 
            // btnNextRatingNextResult
            // 
            this.btnNextRatingNextResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextRatingNextResult.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNextRatingNextResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextRatingNextResult.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRatingNextResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextRatingNextResult.Location = new System.Drawing.Point(31, 125);
            this.btnNextRatingNextResult.Name = "btnNextRatingNextResult";
            this.btnNextRatingNextResult.Size = new System.Drawing.Size(102, 32);
            this.btnNextRatingNextResult.TabIndex = 55;
            this.btnNextRatingNextResult.Text = "Next";
            this.btnNextRatingNextResult.UseVisualStyleBackColor = false;
            this.btnNextRatingNextResult.Click += new System.EventHandler(this.btnNextRatingNextResult_Click);
            // 
            // grpBoxDropDownQuestionType
            // 
            this.grpBoxDropDownQuestionType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxDropDownQuestionType.BackColor = System.Drawing.Color.CadetBlue;
            this.grpBoxDropDownQuestionType.Controls.Add(this.btnNextDropDownResult);
            this.grpBoxDropDownQuestionType.Controls.Add(this.lblDropDownQuestion);
            this.grpBoxDropDownQuestionType.Controls.Add(this.dgDropDownOptionResult);
            this.grpBoxDropDownQuestionType.Location = new System.Drawing.Point(19, 497);
            this.grpBoxDropDownQuestionType.Name = "grpBoxDropDownQuestionType";
            this.grpBoxDropDownQuestionType.Size = new System.Drawing.Size(965, 162);
            this.grpBoxDropDownQuestionType.TabIndex = 57;
            this.grpBoxDropDownQuestionType.TabStop = false;
            this.grpBoxDropDownQuestionType.Text = "Dropdown Question Type";
            // 
            // btnNextDropDownResult
            // 
            this.btnNextDropDownResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextDropDownResult.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNextDropDownResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextDropDownResult.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDropDownResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextDropDownResult.Location = new System.Drawing.Point(31, 124);
            this.btnNextDropDownResult.Name = "btnNextDropDownResult";
            this.btnNextDropDownResult.Size = new System.Drawing.Size(102, 32);
            this.btnNextDropDownResult.TabIndex = 56;
            this.btnNextDropDownResult.Text = "Next";
            this.btnNextDropDownResult.UseVisualStyleBackColor = false;
            this.btnNextDropDownResult.Click += new System.EventHandler(this.btnNextDropDownResult_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1016, 10);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // lblAnalyseSurvey
            // 
            this.lblAnalyseSurvey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnalyseSurvey.AutoSize = true;
            this.lblAnalyseSurvey.Font = new System.Drawing.Font("Bahnschrift", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblAnalyseSurvey.Location = new System.Drawing.Point(20, 24);
            this.lblAnalyseSurvey.Name = "lblAnalyseSurvey";
            this.lblAnalyseSurvey.Size = new System.Drawing.Size(202, 22);
            this.lblAnalyseSurvey.TabIndex = 59;
            this.lblAnalyseSurvey.Text = " Analyse survey results";
            // 
            // lblNumberOfUser
            // 
            this.lblNumberOfUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfUser.AutoSize = true;
            this.lblNumberOfUser.Font = new System.Drawing.Font("Bahnschrift", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfUser.Location = new System.Drawing.Point(648, 84);
            this.lblNumberOfUser.Name = "lblNumberOfUser";
            this.lblNumberOfUser.Size = new System.Drawing.Size(45, 22);
            this.lblNumberOfUser.TabIndex = 60;
            this.lblNumberOfUser.Text = "       ";
            // 
            // lblUsers
            // 
            this.lblUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Bahnschrift", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblUsers.Location = new System.Drawing.Point(452, 84);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(190, 22);
            this.lblUsers.TabIndex = 61;
            this.lblUsers.Text = "Number of Customers";
            // 
            // frmSurveyAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 687);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblNumberOfUser);
            this.Controls.Add(this.lblAnalyseSurvey);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.grpBoxDropDownQuestionType);
            this.Controls.Add(this.grpBoxRatingQuestionType);
            this.Controls.Add(this.grpBoxYesNoQuestionType);
            this.Controls.Add(this.lblSurveyList);
            this.Controls.Add(this.comboBoxListOfSurvey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1030, 726);
            this.MinimumSize = new System.Drawing.Size(1030, 726);
            this.Name = "frmSurveyAnalysis";
            this.Text = "SurveyAnalysis";
            this.Load += new System.EventHandler(this.frmSurveyAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDropDownOptionResult)).EndInit();
            this.grpBoxYesNoQuestionType.ResumeLayout(false);
            this.grpBoxYesNoQuestionType.PerformLayout();
            this.grpBoxRatingQuestionType.ResumeLayout(false);
            this.grpBoxRatingQuestionType.PerformLayout();
            this.grpBoxDropDownQuestionType.ResumeLayout(false);
            this.grpBoxDropDownQuestionType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSurveyList;
        private System.Windows.Forms.ComboBox comboBoxListOfSurvey;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblNoAnswer;
        private System.Windows.Forms.Label lblYesAnswer;
        private System.Windows.Forms.Label lblYesNoQuestion;
        private System.Windows.Forms.Label lblRaitingQuestion;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblDropDownQuestion;
        private System.Windows.Forms.DataGridView dgDropDownOptionResult;
        private System.Windows.Forms.Label lblAverageHeader;
        private System.Windows.Forms.GroupBox grpBoxYesNoQuestionType;
        private System.Windows.Forms.GroupBox grpBoxRatingQuestionType;
        private System.Windows.Forms.Button btnNextRatingNextResult;
        private System.Windows.Forms.Button btnNextYesNoResult;
        private System.Windows.Forms.GroupBox grpBoxDropDownQuestionType;
        private System.Windows.Forms.Button btnNextDropDownResult;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAnalyseSurvey;
        private System.Windows.Forms.Label lblNumberOfUser;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionResult;
    }
}