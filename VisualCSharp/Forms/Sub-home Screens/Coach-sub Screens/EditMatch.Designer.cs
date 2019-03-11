namespace VisualCSharp.Forms.Sub_home_Screens.Coach_sub_Screens
{
    partial class EditMatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMatchForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEditMatch = new System.Windows.Forms.Label();
            this.grpbxEditMatch = new System.Windows.Forms.GroupBox();
            this.cmbTeamType = new System.Windows.Forms.ComboBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblAddressLine = new System.Windows.Forms.Label();
            this.matchDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.lblTeamType = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.cmbMatchType = new System.Windows.Forms.ComboBox();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.lblMatchType = new System.Windows.Forms.Label();
            this.txtOpponent = new System.Windows.Forms.TextBox();
            this.BtnSaveMatch = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblChangesMade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbxEditMatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblEditMatch
            // 
            this.lblEditMatch.AutoSize = true;
            this.lblEditMatch.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMatch.Location = new System.Drawing.Point(152, 183);
            this.lblEditMatch.Name = "lblEditMatch";
            this.lblEditMatch.Size = new System.Drawing.Size(181, 42);
            this.lblEditMatch.TabIndex = 9;
            this.lblEditMatch.Text = "Edit Match";
            // 
            // grpbxEditMatch
            // 
            this.grpbxEditMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpbxEditMatch.Controls.Add(this.cmbTeamType);
            this.grpbxEditMatch.Controls.Add(this.txtPostcode);
            this.grpbxEditMatch.Controls.Add(this.lblPostcode);
            this.grpbxEditMatch.Controls.Add(this.lblAddressLine);
            this.grpbxEditMatch.Controls.Add(this.matchDateAndTime);
            this.grpbxEditMatch.Controls.Add(this.txtAddressLine2);
            this.grpbxEditMatch.Controls.Add(this.lblDateAndTime);
            this.grpbxEditMatch.Controls.Add(this.lblTeamType);
            this.grpbxEditMatch.Controls.Add(this.txtAddressLine1);
            this.grpbxEditMatch.Controls.Add(this.cmbMatchType);
            this.grpbxEditMatch.Controls.Add(this.lblOpponent);
            this.grpbxEditMatch.Controls.Add(this.lblMatchType);
            this.grpbxEditMatch.Controls.Add(this.txtOpponent);
            this.grpbxEditMatch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxEditMatch.Location = new System.Drawing.Point(39, 240);
            this.grpbxEditMatch.Name = "grpbxEditMatch";
            this.grpbxEditMatch.Size = new System.Drawing.Size(407, 253);
            this.grpbxEditMatch.TabIndex = 21;
            this.grpbxEditMatch.TabStop = false;
            // 
            // cmbTeamType
            // 
            this.cmbTeamType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeamType.FormattingEnabled = true;
            this.cmbTeamType.Items.AddRange(new object[] {
            "Juniors",
            "Mens",
            "Womens"});
            this.cmbTeamType.Location = new System.Drawing.Point(186, 84);
            this.cmbTeamType.Name = "cmbTeamType";
            this.cmbTeamType.Size = new System.Drawing.Size(129, 25);
            this.cmbTeamType.TabIndex = 16;
            this.cmbTeamType.SelectedIndexChanged += new System.EventHandler(this.cmbTeamType_SelectedIndexChanged);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(186, 212);
            this.txtPostcode.MaxLength = 10;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(183, 25);
            this.txtPostcode.TabIndex = 15;
            this.txtPostcode.TextChanged += new System.EventHandler(this.txtPostcode_TextChanged);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(32, 215);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(66, 19);
            this.lblPostcode.TabIndex = 14;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblAddressLine
            // 
            this.lblAddressLine.AutoSize = true;
            this.lblAddressLine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine.Location = new System.Drawing.Point(32, 151);
            this.lblAddressLine.Name = "lblAddressLine";
            this.lblAddressLine.Size = new System.Drawing.Size(60, 19);
            this.lblAddressLine.TabIndex = 12;
            this.lblAddressLine.Text = "Address";
            // 
            // matchDateAndTime
            // 
            this.matchDateAndTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchDateAndTime.Location = new System.Drawing.Point(186, 116);
            this.matchDateAndTime.Name = "matchDateAndTime";
            this.matchDateAndTime.Size = new System.Drawing.Size(183, 25);
            this.matchDateAndTime.TabIndex = 10;
            this.matchDateAndTime.ValueChanged += new System.EventHandler(this.matchDateAndTime_ValueChanged);
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressLine2.Location = new System.Drawing.Point(186, 180);
            this.txtAddressLine2.MaxLength = 14;
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(183, 25);
            this.txtAddressLine2.TabIndex = 11;
            this.txtAddressLine2.TextChanged += new System.EventHandler(this.txtAddressLine2_TextChanged);
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.Location = new System.Drawing.Point(32, 119);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(97, 19);
            this.lblDateAndTime.TabIndex = 9;
            this.lblDateAndTime.Text = "Date and Time";
            // 
            // lblTeamType
            // 
            this.lblTeamType.AutoSize = true;
            this.lblTeamType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamType.Location = new System.Drawing.Point(32, 87);
            this.lblTeamType.Name = "lblTeamType";
            this.lblTeamType.Size = new System.Drawing.Size(76, 19);
            this.lblTeamType.TabIndex = 8;
            this.lblTeamType.Text = "Team Type";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressLine1.Location = new System.Drawing.Point(186, 148);
            this.txtAddressLine1.MaxLength = 40;
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(183, 25);
            this.txtAddressLine1.TabIndex = 10;
            this.txtAddressLine1.TextChanged += new System.EventHandler(this.txtAddressLine1_TextChanged);
            // 
            // cmbMatchType
            // 
            this.cmbMatchType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMatchType.FormattingEnabled = true;
            this.cmbMatchType.Items.AddRange(new object[] {
            "Friendly",
            "League",
            "Tournament",
            "Training",
            "Other"});
            this.cmbMatchType.Location = new System.Drawing.Point(186, 19);
            this.cmbMatchType.Name = "cmbMatchType";
            this.cmbMatchType.Size = new System.Drawing.Size(129, 25);
            this.cmbMatchType.TabIndex = 7;
            this.cmbMatchType.SelectedIndexChanged += new System.EventHandler(this.cmbMatchType_SelectedIndexChanged);
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponent.Location = new System.Drawing.Point(32, 55);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(70, 19);
            this.lblOpponent.TabIndex = 6;
            this.lblOpponent.Text = "Opponent";
            // 
            // lblMatchType
            // 
            this.lblMatchType.AutoSize = true;
            this.lblMatchType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchType.Location = new System.Drawing.Point(32, 23);
            this.lblMatchType.Name = "lblMatchType";
            this.lblMatchType.Size = new System.Drawing.Size(82, 19);
            this.lblMatchType.TabIndex = 5;
            this.lblMatchType.Text = "Match Type";
            // 
            // txtOpponent
            // 
            this.txtOpponent.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpponent.Location = new System.Drawing.Point(186, 52);
            this.txtOpponent.MaxLength = 20;
            this.txtOpponent.Name = "txtOpponent";
            this.txtOpponent.Size = new System.Drawing.Size(183, 25);
            this.txtOpponent.TabIndex = 2;
            this.txtOpponent.TextChanged += new System.EventHandler(this.txtOpponent_TextChanged);
            // 
            // BtnSaveMatch
            // 
            this.BtnSaveMatch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveMatch.Location = new System.Drawing.Point(333, 499);
            this.BtnSaveMatch.Name = "BtnSaveMatch";
            this.BtnSaveMatch.Size = new System.Drawing.Size(113, 34);
            this.BtnSaveMatch.TabIndex = 22;
            this.BtnSaveMatch.Text = "Save";
            this.BtnSaveMatch.UseVisualStyleBackColor = true;
            this.BtnSaveMatch.Click += new System.EventHandler(this.BtnSaveMatch_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(39, 499);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(113, 34);
            this.BtnBack.TabIndex = 23;
            this.BtnBack.Text = "Cancel";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblChangesMade
            // 
            this.LblChangesMade.AutoSize = true;
            this.LblChangesMade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangesMade.Location = new System.Drawing.Point(329, 536);
            this.LblChangesMade.Name = "LblChangesMade";
            this.LblChangesMade.Size = new System.Drawing.Size(88, 19);
            this.LblChangesMade.TabIndex = 24;
            this.LblChangesMade.Text = "No Changes";
            // 
            // EditMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 568);
            this.Controls.Add(this.LblChangesMade);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSaveMatch);
            this.Controls.Add(this.grpbxEditMatch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEditMatch);
            this.Name = "EditMatchForm";
            this.Text = "Edit Match";
            this.Load += new System.EventHandler(this.EditMatchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbxEditMatch.ResumeLayout(false);
            this.grpbxEditMatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEditMatch;
        private System.Windows.Forms.GroupBox grpbxEditMatch;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblAddressLine;
        private System.Windows.Forms.DateTimePicker matchDateAndTime;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Label lblTeamType;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.ComboBox cmbMatchType;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.Label lblMatchType;
        private System.Windows.Forms.TextBox txtOpponent;
        private System.Windows.Forms.ComboBox cmbTeamType;
        private System.Windows.Forms.Button BtnSaveMatch;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblChangesMade;
    }
}