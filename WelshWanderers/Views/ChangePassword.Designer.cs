namespace WelshWanderers.Views
{
    partial class ChangePassword
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
            this.InputCurrentPassword = new System.Windows.Forms.TextBox();
            this.InputNewPassword = new System.Windows.Forms.TextBox();
            this.InputConfirmPassword = new System.Windows.Forms.TextBox();
            this.LabelCurrentPassword = new System.Windows.Forms.Label();
            this.LabelNewPassword = new System.Windows.Forms.Label();
            this.LabelConfirmPassword = new System.Windows.Forms.Label();
            this.EventNavChange = new System.Windows.Forms.Button();
            this.EventNavCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(86, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(151, 33);
            this.LabelHeader.TabIndex = 6;
            this.LabelHeader.Text = "My Account";
            // 
            // InputCurrentPassword
            // 
            this.InputCurrentPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCurrentPassword.Location = new System.Drawing.Point(152, 54);
            this.InputCurrentPassword.Name = "InputCurrentPassword";
            this.InputCurrentPassword.PasswordChar = '*';
            this.InputCurrentPassword.Size = new System.Drawing.Size(161, 27);
            this.InputCurrentPassword.TabIndex = 0;
            // 
            // InputNewPassword
            // 
            this.InputNewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNewPassword.Location = new System.Drawing.Point(152, 87);
            this.InputNewPassword.Name = "InputNewPassword";
            this.InputNewPassword.PasswordChar = '*';
            this.InputNewPassword.Size = new System.Drawing.Size(161, 27);
            this.InputNewPassword.TabIndex = 1;
            // 
            // InputConfirmPassword
            // 
            this.InputConfirmPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputConfirmPassword.Location = new System.Drawing.Point(152, 120);
            this.InputConfirmPassword.Name = "InputConfirmPassword";
            this.InputConfirmPassword.PasswordChar = '*';
            this.InputConfirmPassword.Size = new System.Drawing.Size(161, 27);
            this.InputConfirmPassword.TabIndex = 2;
            // 
            // LabelCurrentPassword
            // 
            this.LabelCurrentPassword.AutoSize = true;
            this.LabelCurrentPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentPassword.Location = new System.Drawing.Point(9, 58);
            this.LabelCurrentPassword.Name = "LabelCurrentPassword";
            this.LabelCurrentPassword.Size = new System.Drawing.Size(122, 18);
            this.LabelCurrentPassword.TabIndex = 7;
            this.LabelCurrentPassword.Text = "Current Password";
            // 
            // LabelNewPassword
            // 
            this.LabelNewPassword.AutoSize = true;
            this.LabelNewPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNewPassword.Location = new System.Drawing.Point(9, 91);
            this.LabelNewPassword.Name = "LabelNewPassword";
            this.LabelNewPassword.Size = new System.Drawing.Size(102, 18);
            this.LabelNewPassword.TabIndex = 8;
            this.LabelNewPassword.Text = "New Password";
            // 
            // LabelConfirmPassword
            // 
            this.LabelConfirmPassword.AutoSize = true;
            this.LabelConfirmPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConfirmPassword.Location = new System.Drawing.Point(9, 124);
            this.LabelConfirmPassword.Name = "LabelConfirmPassword";
            this.LabelConfirmPassword.Size = new System.Drawing.Size(124, 18);
            this.LabelConfirmPassword.TabIndex = 9;
            this.LabelConfirmPassword.Text = "Confirm Password";
            // 
            // EventNavChange
            // 
            this.EventNavChange.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavChange.Location = new System.Drawing.Point(152, 153);
            this.EventNavChange.Name = "EventNavChange";
            this.EventNavChange.Size = new System.Drawing.Size(159, 30);
            this.EventNavChange.TabIndex = 3;
            this.EventNavChange.Text = "Change";
            this.EventNavChange.UseVisualStyleBackColor = true;
            this.EventNavChange.Click += new System.EventHandler(this.EventNavChange_Click);
            // 
            // EventNavCancel
            // 
            this.EventNavCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavCancel.Location = new System.Drawing.Point(12, 12);
            this.EventNavCancel.Name = "EventNavCancel";
            this.EventNavCancel.Size = new System.Drawing.Size(58, 30);
            this.EventNavCancel.TabIndex = 5;
            this.EventNavCancel.Text = "Back";
            this.EventNavCancel.UseVisualStyleBackColor = true;
            this.EventNavCancel.Click += new System.EventHandler(this.EventNavCancel_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 193);
            this.Controls.Add(this.EventNavCancel);
            this.Controls.Add(this.EventNavChange);
            this.Controls.Add(this.LabelConfirmPassword);
            this.Controls.Add(this.LabelNewPassword);
            this.Controls.Add(this.LabelCurrentPassword);
            this.Controls.Add(this.InputConfirmPassword);
            this.Controls.Add(this.InputNewPassword);
            this.Controls.Add(this.InputCurrentPassword);
            this.Controls.Add(this.LabelHeader);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.TextBox InputCurrentPassword;
        private System.Windows.Forms.TextBox InputNewPassword;
        private System.Windows.Forms.TextBox InputConfirmPassword;
        private System.Windows.Forms.Label LabelCurrentPassword;
        private System.Windows.Forms.Label LabelNewPassword;
        private System.Windows.Forms.Label LabelConfirmPassword;
        private System.Windows.Forms.Button EventNavChange;
        private System.Windows.Forms.Button EventNavCancel;
    }
}