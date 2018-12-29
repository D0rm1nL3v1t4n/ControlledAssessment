namespace WelshWanderers
{
    partial class RegisterRequest
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
            this.LabelHeader = new System.Windows.Forms.Label();
            this.InputTitle = new System.Windows.Forms.ComboBox();
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.EventNavRegisterRequest = new System.Windows.Forms.Button();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelTelephoneNumber = new System.Windows.Forms.Label();
            this.LabelEmailAddress = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelDateOfBirth = new System.Windows.Forms.Label();
            this.LabelPostcode = new System.Windows.Forms.Label();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.InputEmailAddress = new System.Windows.Forms.TextBox();
            this.InputTelephoneNumber = new System.Windows.Forms.TextBox();
            this.InputPostcode = new System.Windows.Forms.TextBox();
            this.InputDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.InputConfirmPassword = new System.Windows.Forms.TextBox();
            this.LabelConfirmPassword = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.NavCancel = new System.Windows.Forms.Button();
            this.EventShowHelp = new System.Windows.Forms.Button();
            this.LabelTeam = new System.Windows.Forms.Label();
            this.InputTeam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(216, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(261, 33);
            this.LabelHeader.TabIndex = 5;
            this.LabelHeader.Text = "Registration Request";
            // 
            // InputTitle
            // 
            this.InputTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTitle.FormattingEnabled = true;
            this.InputTitle.Items.AddRange(new object[] {
            "Mr",
            "Ms",
            "Miss",
            "Mrs"});
            this.InputTitle.Location = new System.Drawing.Point(152, 79);
            this.InputTitle.Name = "InputTitle";
            this.InputTitle.Size = new System.Drawing.Size(161, 27);
            this.InputTitle.TabIndex = 6;
            // 
            // InputFirstName
            // 
            this.InputFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFirstName.Location = new System.Drawing.Point(152, 112);
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(161, 27);
            this.InputFirstName.TabIndex = 7;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(106, 85);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(40, 19);
            this.LabelTitle.TabIndex = 8;
            this.LabelTitle.Text = "Title";
            // 
            // EventNavRegisterRequest
            // 
            this.EventNavRegisterRequest.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavRegisterRequest.Location = new System.Drawing.Point(531, 351);
            this.EventNavRegisterRequest.Name = "EventNavRegisterRequest";
            this.EventNavRegisterRequest.Size = new System.Drawing.Size(106, 48);
            this.EventNavRegisterRequest.TabIndex = 9;
            this.EventNavRegisterRequest.Text = "Request Registration";
            this.EventNavRegisterRequest.UseVisualStyleBackColor = true;
            this.EventNavRegisterRequest.Click += new System.EventHandler(this.EventNavRegisterRequest_Click);
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.Location = new System.Drawing.Point(61, 115);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(85, 19);
            this.LabelFirstName.TabIndex = 10;
            this.LabelFirstName.Text = "First Name";
            // 
            // LabelTelephoneNumber
            // 
            this.LabelTelephoneNumber.AutoSize = true;
            this.LabelTelephoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTelephoneNumber.Location = new System.Drawing.Point(325, 148);
            this.LabelTelephoneNumber.Name = "LabelTelephoneNumber";
            this.LabelTelephoneNumber.Size = new System.Drawing.Size(145, 19);
            this.LabelTelephoneNumber.TabIndex = 11;
            this.LabelTelephoneNumber.Text = "Telephone Number";
            // 
            // LabelEmailAddress
            // 
            this.LabelEmailAddress.AutoSize = true;
            this.LabelEmailAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmailAddress.Location = new System.Drawing.Point(360, 115);
            this.LabelEmailAddress.Name = "LabelEmailAddress";
            this.LabelEmailAddress.Size = new System.Drawing.Size(110, 19);
            this.LabelEmailAddress.TabIndex = 12;
            this.LabelEmailAddress.Text = "Email Address";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastName.Location = new System.Drawing.Point(63, 149);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(83, 19);
            this.LabelLastName.TabIndex = 13;
            this.LabelLastName.Text = "Last Name";
            // 
            // LabelDateOfBirth
            // 
            this.LabelDateOfBirth.AutoSize = true;
            this.LabelDateOfBirth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDateOfBirth.Location = new System.Drawing.Point(48, 185);
            this.LabelDateOfBirth.Name = "LabelDateOfBirth";
            this.LabelDateOfBirth.Size = new System.Drawing.Size(98, 19);
            this.LabelDateOfBirth.TabIndex = 14;
            this.LabelDateOfBirth.Text = "Date of Birth";
            // 
            // LabelPostcode
            // 
            this.LabelPostcode.AutoSize = true;
            this.LabelPostcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPostcode.Location = new System.Drawing.Point(398, 180);
            this.LabelPostcode.Name = "LabelPostcode";
            this.LabelPostcode.Size = new System.Drawing.Size(72, 19);
            this.LabelPostcode.TabIndex = 15;
            this.LabelPostcode.Text = "Postcode";
            // 
            // InputLastName
            // 
            this.InputLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLastName.Location = new System.Drawing.Point(152, 146);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(161, 27);
            this.InputLastName.TabIndex = 16;
            // 
            // InputEmailAddress
            // 
            this.InputEmailAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEmailAddress.Location = new System.Drawing.Point(476, 112);
            this.InputEmailAddress.Name = "InputEmailAddress";
            this.InputEmailAddress.Size = new System.Drawing.Size(161, 27);
            this.InputEmailAddress.TabIndex = 17;
            // 
            // InputTelephoneNumber
            // 
            this.InputTelephoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTelephoneNumber.Location = new System.Drawing.Point(476, 145);
            this.InputTelephoneNumber.Name = "InputTelephoneNumber";
            this.InputTelephoneNumber.Size = new System.Drawing.Size(161, 27);
            this.InputTelephoneNumber.TabIndex = 18;
            // 
            // InputPostcode
            // 
            this.InputPostcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPostcode.Location = new System.Drawing.Point(476, 177);
            this.InputPostcode.Name = "InputPostcode";
            this.InputPostcode.Size = new System.Drawing.Size(161, 27);
            this.InputPostcode.TabIndex = 19;
            // 
            // InputDateOfBirth
            // 
            this.InputDateOfBirth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDateOfBirth.Location = new System.Drawing.Point(152, 179);
            this.InputDateOfBirth.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.InputDateOfBirth.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.InputDateOfBirth.Name = "InputDateOfBirth";
            this.InputDateOfBirth.Size = new System.Drawing.Size(161, 27);
            this.InputDateOfBirth.TabIndex = 20;
            this.InputDateOfBirth.Value = new System.DateTime(2018, 10, 26, 0, 0, 0, 0);
            // 
            // InputPassword
            // 
            this.InputPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPassword.Location = new System.Drawing.Point(472, 260);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(161, 27);
            this.InputPassword.TabIndex = 21;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(390, 263);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(76, 19);
            this.LabelPassword.TabIndex = 22;
            this.LabelPassword.Text = "Password";
            // 
            // InputUsername
            // 
            this.InputUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.Location = new System.Drawing.Point(152, 293);
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(161, 27);
            this.InputUsername.TabIndex = 23;
            // 
            // InputConfirmPassword
            // 
            this.InputConfirmPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputConfirmPassword.Location = new System.Drawing.Point(472, 293);
            this.InputConfirmPassword.Name = "InputConfirmPassword";
            this.InputConfirmPassword.Size = new System.Drawing.Size(161, 27);
            this.InputConfirmPassword.TabIndex = 24;
            // 
            // LabelConfirmPassword
            // 
            this.LabelConfirmPassword.AutoSize = true;
            this.LabelConfirmPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConfirmPassword.Location = new System.Drawing.Point(328, 296);
            this.LabelConfirmPassword.Name = "LabelConfirmPassword";
            this.LabelConfirmPassword.Size = new System.Drawing.Size(138, 19);
            this.LabelConfirmPassword.TabIndex = 25;
            this.LabelConfirmPassword.Text = "Confirm Password";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(66, 296);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(80, 19);
            this.LabelUsername.TabIndex = 26;
            this.LabelUsername.Text = "Username";
            // 
            // NavCancel
            // 
            this.NavCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavCancel.Location = new System.Drawing.Point(52, 351);
            this.NavCancel.Name = "NavCancel";
            this.NavCancel.Size = new System.Drawing.Size(89, 48);
            this.NavCancel.TabIndex = 27;
            this.NavCancel.Text = "Cancel";
            this.NavCancel.UseVisualStyleBackColor = true;
            this.NavCancel.Click += new System.EventHandler(this.NavCancel_Click);
            // 
            // EventShowHelp
            // 
            this.EventShowHelp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventShowHelp.Location = new System.Drawing.Point(484, 351);
            this.EventShowHelp.Name = "EventShowHelp";
            this.EventShowHelp.Size = new System.Drawing.Size(41, 48);
            this.EventShowHelp.TabIndex = 28;
            this.EventShowHelp.Text = "?";
            this.EventShowHelp.UseVisualStyleBackColor = true;
            this.EventShowHelp.Click += new System.EventHandler(this.EventShowHelp_Click);
            // 
            // LabelTeam
            // 
            this.LabelTeam.AutoSize = true;
            this.LabelTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTeam.Location = new System.Drawing.Point(97, 263);
            this.LabelTeam.Name = "LabelTeam";
            this.LabelTeam.Size = new System.Drawing.Size(49, 19);
            this.LabelTeam.TabIndex = 30;
            this.LabelTeam.Text = "Team";
            // 
            // InputTeam
            // 
            this.InputTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTeam.FormattingEnabled = true;
            this.InputTeam.Items.AddRange(new object[] {
            "Junior",
            "Men",
            "Women"});
            this.InputTeam.Location = new System.Drawing.Point(152, 260);
            this.InputTeam.Name = "InputTeam";
            this.InputTeam.Size = new System.Drawing.Size(161, 27);
            this.InputTeam.TabIndex = 29;
            // 
            // RegisterRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.LabelTeam);
            this.Controls.Add(this.InputTeam);
            this.Controls.Add(this.EventShowHelp);
            this.Controls.Add(this.NavCancel);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelConfirmPassword);
            this.Controls.Add(this.InputConfirmPassword);
            this.Controls.Add(this.InputUsername);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputDateOfBirth);
            this.Controls.Add(this.InputPostcode);
            this.Controls.Add(this.InputTelephoneNumber);
            this.Controls.Add(this.InputEmailAddress);
            this.Controls.Add(this.InputLastName);
            this.Controls.Add(this.LabelPostcode);
            this.Controls.Add(this.LabelDateOfBirth);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelEmailAddress);
            this.Controls.Add(this.LabelTelephoneNumber);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.EventNavRegisterRequest);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.InputFirstName);
            this.Controls.Add(this.InputTitle);
            this.Controls.Add(this.LabelHeader);
            this.Name = "RegisterRequest";
            this.Text = "RegisterRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.ComboBox InputTitle;
        private System.Windows.Forms.TextBox InputFirstName;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button EventNavRegisterRequest;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelTelephoneNumber;
        private System.Windows.Forms.Label LabelEmailAddress;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelDateOfBirth;
        private System.Windows.Forms.Label LabelPostcode;
        private System.Windows.Forms.TextBox InputLastName;
        private System.Windows.Forms.TextBox InputEmailAddress;
        private System.Windows.Forms.TextBox InputTelephoneNumber;
        private System.Windows.Forms.TextBox InputPostcode;
        private System.Windows.Forms.DateTimePicker InputDateOfBirth;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.TextBox InputConfirmPassword;
        private System.Windows.Forms.Label LabelConfirmPassword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Button NavCancel;
        private System.Windows.Forms.Button EventShowHelp;
        private System.Windows.Forms.Label LabelTeam;
        private System.Windows.Forms.ComboBox InputTeam;
    }
}