namespace WelshWanderers
{
    partial class ResetPassword
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
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.EventEnter = new System.Windows.Forms.Button();
            this.LabelMsgUsername = new System.Windows.Forms.Label();
            this.LabelMsgEmail = new System.Windows.Forms.Label();
            this.LabelUserEmail = new System.Windows.Forms.Label();
            this.LabelMsgCode = new System.Windows.Forms.Label();
            this.InputCode = new System.Windows.Forms.TextBox();
            this.InputNewPassword = new System.Windows.Forms.TextBox();
            this.LabelNewPassword = new System.Windows.Forms.Label();
            this.LableConfirmNewPassword = new System.Windows.Forms.Label();
            this.InputConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.NavBack = new System.Windows.Forms.Button();
            this.EventNavChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputUsername
            // 
            this.InputUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.Location = new System.Drawing.Point(93, 69);
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(186, 27);
            this.InputUsername.TabIndex = 0;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(92, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(202, 33);
            this.LabelHeader.TabIndex = 13;
            this.LabelHeader.Text = "Reset Password";
            // 
            // EventEnter
            // 
            this.EventEnter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventEnter.Location = new System.Drawing.Point(285, 69);
            this.EventEnter.Name = "EventEnter";
            this.EventEnter.Size = new System.Drawing.Size(89, 27);
            this.EventEnter.TabIndex = 1;
            this.EventEnter.Text = "Search";
            this.EventEnter.UseVisualStyleBackColor = true;
            this.EventEnter.Click += new System.EventHandler(this.EventEnter_Click);
            // 
            // LabelMsgUsername
            // 
            this.LabelMsgUsername.AutoSize = true;
            this.LabelMsgUsername.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMsgUsername.Location = new System.Drawing.Point(12, 73);
            this.LabelMsgUsername.Name = "LabelMsgUsername";
            this.LabelMsgUsername.Size = new System.Drawing.Size(75, 18);
            this.LabelMsgUsername.TabIndex = 12;
            this.LabelMsgUsername.Text = "Username";
            // 
            // LabelMsgEmail
            // 
            this.LabelMsgEmail.AutoSize = true;
            this.LabelMsgEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMsgEmail.Location = new System.Drawing.Point(12, 111);
            this.LabelMsgEmail.Name = "LabelMsgEmail";
            this.LabelMsgEmail.Size = new System.Drawing.Size(350, 36);
            this.LabelMsgEmail.TabIndex = 11;
            this.LabelMsgEmail.Text = "The following email address will be sent an email with\r\nan 8 digit code to reset " +
    "your password:";
            // 
            // LabelUserEmail
            // 
            this.LabelUserEmail.AutoSize = true;
            this.LabelUserEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserEmail.Location = new System.Drawing.Point(12, 158);
            this.LabelUserEmail.Name = "LabelUserEmail";
            this.LabelUserEmail.Size = new System.Drawing.Size(0, 18);
            this.LabelUserEmail.TabIndex = 10;
            // 
            // LabelMsgCode
            // 
            this.LabelMsgCode.AutoSize = true;
            this.LabelMsgCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMsgCode.Location = new System.Drawing.Point(12, 192);
            this.LabelMsgCode.Name = "LabelMsgCode";
            this.LabelMsgCode.Size = new System.Drawing.Size(87, 18);
            this.LabelMsgCode.TabIndex = 9;
            this.LabelMsgCode.Text = "8 digit code:";
            // 
            // InputCode
            // 
            this.InputCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCode.Location = new System.Drawing.Point(143, 188);
            this.InputCode.Name = "InputCode";
            this.InputCode.Size = new System.Drawing.Size(135, 27);
            this.InputCode.TabIndex = 2;
            // 
            // InputNewPassword
            // 
            this.InputNewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNewPassword.Location = new System.Drawing.Point(143, 221);
            this.InputNewPassword.Name = "InputNewPassword";
            this.InputNewPassword.PasswordChar = '*';
            this.InputNewPassword.Size = new System.Drawing.Size(231, 27);
            this.InputNewPassword.TabIndex = 3;
            // 
            // LabelNewPassword
            // 
            this.LabelNewPassword.AutoSize = true;
            this.LabelNewPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNewPassword.Location = new System.Drawing.Point(12, 225);
            this.LabelNewPassword.Name = "LabelNewPassword";
            this.LabelNewPassword.Size = new System.Drawing.Size(102, 18);
            this.LabelNewPassword.TabIndex = 8;
            this.LabelNewPassword.Text = "New Password";
            // 
            // LableConfirmNewPassword
            // 
            this.LableConfirmNewPassword.AutoSize = true;
            this.LableConfirmNewPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableConfirmNewPassword.Location = new System.Drawing.Point(12, 258);
            this.LableConfirmNewPassword.Name = "LableConfirmNewPassword";
            this.LableConfirmNewPassword.Size = new System.Drawing.Size(124, 18);
            this.LableConfirmNewPassword.TabIndex = 7;
            this.LableConfirmNewPassword.Text = "Confirm Password";
            // 
            // InputConfirmNewPassword
            // 
            this.InputConfirmNewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputConfirmNewPassword.Location = new System.Drawing.Point(143, 254);
            this.InputConfirmNewPassword.Name = "InputConfirmNewPassword";
            this.InputConfirmNewPassword.PasswordChar = '*';
            this.InputConfirmNewPassword.Size = new System.Drawing.Size(231, 27);
            this.InputConfirmNewPassword.TabIndex = 4;
            // 
            // NavBack
            // 
            this.NavBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBack.Location = new System.Drawing.Point(12, 12);
            this.NavBack.Name = "NavBack";
            this.NavBack.Size = new System.Drawing.Size(64, 30);
            this.NavBack.TabIndex = 6;
            this.NavBack.Text = "Back";
            this.NavBack.UseVisualStyleBackColor = true;
            this.NavBack.Click += new System.EventHandler(this.NavBack_Click);
            // 
            // EventNavChangePassword
            // 
            this.EventNavChangePassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavChangePassword.Location = new System.Drawing.Point(15, 287);
            this.EventNavChangePassword.Name = "EventNavChangePassword";
            this.EventNavChangePassword.Size = new System.Drawing.Size(359, 30);
            this.EventNavChangePassword.TabIndex = 5;
            this.EventNavChangePassword.Text = "Change Password";
            this.EventNavChangePassword.UseVisualStyleBackColor = true;
            this.EventNavChangePassword.Click += new System.EventHandler(this.EventNavChangePassword_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 330);
            this.Controls.Add(this.NavBack);
            this.Controls.Add(this.InputConfirmNewPassword);
            this.Controls.Add(this.LableConfirmNewPassword);
            this.Controls.Add(this.LabelNewPassword);
            this.Controls.Add(this.InputNewPassword);
            this.Controls.Add(this.InputCode);
            this.Controls.Add(this.LabelMsgCode);
            this.Controls.Add(this.LabelUserEmail);
            this.Controls.Add(this.LabelMsgEmail);
            this.Controls.Add(this.LabelMsgUsername);
            this.Controls.Add(this.EventEnter);
            this.Controls.Add(this.EventNavChangePassword);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.InputUsername);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button EventEnter;
        private System.Windows.Forms.Label LabelMsgUsername;
        private System.Windows.Forms.Label LabelMsgEmail;
        private System.Windows.Forms.Label LabelUserEmail;
        private System.Windows.Forms.Label LabelMsgCode;
        private System.Windows.Forms.TextBox InputCode;
        private System.Windows.Forms.TextBox InputNewPassword;
        private System.Windows.Forms.Label LabelNewPassword;
        private System.Windows.Forms.Label LableConfirmNewPassword;
        private System.Windows.Forms.TextBox InputConfirmNewPassword;
        private System.Windows.Forms.Button NavBack;
        private System.Windows.Forms.Button EventNavChangePassword;
    }
}