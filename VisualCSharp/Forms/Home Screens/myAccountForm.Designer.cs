namespace VisualCSharp.Forms.Home_Screens
{
    partial class myAccountDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myAccountDetails));
            this.BtnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMyAccountDetails = new System.Windows.Forms.Label();
            this.grpbxPersonalDetails = new System.Windows.Forms.GroupBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblTelephoneNo = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtTelephoneNo = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.BtnSaveAccountDetails = new System.Windows.Forms.Button();
            this.LblChangesMade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbxPersonalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(39, 511);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(113, 34);
            this.BtnBack.TabIndex = 17;
            this.BtnBack.Text = "Cancel";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblMyAccountDetails
            // 
            this.lblMyAccountDetails.AutoSize = true;
            this.lblMyAccountDetails.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyAccountDetails.Location = new System.Drawing.Point(143, 183);
            this.lblMyAccountDetails.Name = "lblMyAccountDetails";
            this.lblMyAccountDetails.Size = new System.Drawing.Size(198, 42);
            this.lblMyAccountDetails.TabIndex = 18;
            this.lblMyAccountDetails.Text = "My Account";
            // 
            // grpbxPersonalDetails
            // 
            this.grpbxPersonalDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpbxPersonalDetails.Controls.Add(this.txtPostcode);
            this.grpbxPersonalDetails.Controls.Add(this.lblPostcode);
            this.grpbxPersonalDetails.Controls.Add(this.lblTelephoneNo);
            this.grpbxPersonalDetails.Controls.Add(this.lblEmailAddress);
            this.grpbxPersonalDetails.Controls.Add(this.dateOfBirth);
            this.grpbxPersonalDetails.Controls.Add(this.txtTelephoneNo);
            this.grpbxPersonalDetails.Controls.Add(this.lblDateOfBirth);
            this.grpbxPersonalDetails.Controls.Add(this.lblLastName);
            this.grpbxPersonalDetails.Controls.Add(this.txtEmailAddress);
            this.grpbxPersonalDetails.Controls.Add(this.cmbTitle);
            this.grpbxPersonalDetails.Controls.Add(this.lblFirstName);
            this.grpbxPersonalDetails.Controls.Add(this.lblTitle);
            this.grpbxPersonalDetails.Controls.Add(this.txtFirstName);
            this.grpbxPersonalDetails.Controls.Add(this.txtLastName);
            this.grpbxPersonalDetails.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPersonalDetails.Location = new System.Drawing.Point(39, 252);
            this.grpbxPersonalDetails.Name = "grpbxPersonalDetails";
            this.grpbxPersonalDetails.Size = new System.Drawing.Size(407, 253);
            this.grpbxPersonalDetails.TabIndex = 20;
            this.grpbxPersonalDetails.TabStop = false;

            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(186, 214);
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
            this.lblPostcode.Location = new System.Drawing.Point(32, 217);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(66, 19);
            this.lblPostcode.TabIndex = 14;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblTelephoneNo
            // 
            this.lblTelephoneNo.AutoSize = true;
            this.lblTelephoneNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephoneNo.Location = new System.Drawing.Point(32, 185);
            this.lblTelephoneNo.Name = "lblTelephoneNo";
            this.lblTelephoneNo.Size = new System.Drawing.Size(125, 19);
            this.lblTelephoneNo.TabIndex = 13;
            this.lblTelephoneNo.Text = "Telephone Number";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(32, 153);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(96, 19);
            this.lblEmailAddress.TabIndex = 12;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.Location = new System.Drawing.Point(186, 118);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(183, 25);
            this.dateOfBirth.TabIndex = 10;
            this.dateOfBirth.ValueChanged += new System.EventHandler(this.dateOfBirth_ValueChanged);
            // 
            // txtTelephoneNo
            // 
            this.txtTelephoneNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephoneNo.Location = new System.Drawing.Point(186, 182);
            this.txtTelephoneNo.MaxLength = 14;
            this.txtTelephoneNo.Name = "txtTelephoneNo";
            this.txtTelephoneNo.Size = new System.Drawing.Size(183, 25);
            this.txtTelephoneNo.TabIndex = 11;
            this.txtTelephoneNo.TextChanged += new System.EventHandler(this.txtTelephoneNo_TextChanged);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(32, 121);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(87, 19);
            this.lblDateOfBirth.TabIndex = 9;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(32, 89);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 19);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(186, 150);
            this.txtEmailAddress.MaxLength = 40;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(183, 25);
            this.txtEmailAddress.TabIndex = 10;
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.txtEmailAddress_TextChanged);
            // 
            // cmbTitle
            // 
            this.cmbTitle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Items.AddRange(new object[] {
            "Master",
            "Mr",
            "Miss",
            "Mrs",
            "Ms",
            "Other"});
            this.cmbTitle.Location = new System.Drawing.Point(186, 21);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(82, 25);
            this.cmbTitle.TabIndex = 7;
            this.cmbTitle.SelectedIndexChanged += new System.EventHandler(this.cmbTitle_SelectedIndexChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(32, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 19);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(32, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(34, 19);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(186, 54);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(183, 25);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(186, 86);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(183, 25);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // BtnSaveAccountDetails
            // 
            this.BtnSaveAccountDetails.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveAccountDetails.Location = new System.Drawing.Point(333, 511);
            this.BtnSaveAccountDetails.Name = "BtnSaveAccountDetails";
            this.BtnSaveAccountDetails.Size = new System.Drawing.Size(113, 34);
            this.BtnSaveAccountDetails.TabIndex = 21;
            this.BtnSaveAccountDetails.Text = "Save";
            this.BtnSaveAccountDetails.UseVisualStyleBackColor = true;
            this.BtnSaveAccountDetails.Click += new System.EventHandler(this.BtnSaveAccountDetails_Click);
            // 
            // LblChangesMade
            // 
            this.LblChangesMade.AutoSize = true;
            this.LblChangesMade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangesMade.Location = new System.Drawing.Point(329, 548);
            this.LblChangesMade.Name = "LblChangesMade";
            this.LblChangesMade.Size = new System.Drawing.Size(88, 19);
            this.LblChangesMade.TabIndex = 16;
            this.LblChangesMade.Text = "No Changes";
            // 
            // myAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(484, 586);
            this.Controls.Add(this.LblChangesMade);
            this.Controls.Add(this.BtnSaveAccountDetails);
            this.Controls.Add(this.grpbxPersonalDetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMyAccountDetails);
            this.Controls.Add(this.BtnBack);
            this.Name = "myAccountDetails";
            this.Text = "My Account";
            this.Load += new System.EventHandler(this.myAccountDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbxPersonalDetails.ResumeLayout(false);
            this.grpbxPersonalDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMyAccountDetails;
        private System.Windows.Forms.GroupBox grpbxPersonalDetails;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblTelephoneNo;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.TextBox txtTelephoneNo;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button BtnSaveAccountDetails;
        private System.Windows.Forms.Label LblChangesMade;
    }
}