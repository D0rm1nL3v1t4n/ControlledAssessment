namespace WelshWanderers
{
    partial class SignIn
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
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.NavResetPassword = new System.Windows.Forms.Button();
            this.EventNavSignIn = new System.Windows.Forms.Button();
            this.NavRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(12, 62);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(75, 18);
            this.LabelUsername.TabIndex = 5;
            this.LabelUsername.Text = "Username";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(12, 94);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(69, 18);
            this.LabelPassword.TabIndex = 6;
            this.LabelPassword.Text = "Password";
            // 
            // InputUsername
            // 
            this.InputUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.Location = new System.Drawing.Point(93, 58);
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(187, 27);
            this.InputUsername.TabIndex = 0;
            // 
            // InputPassword
            // 
            this.InputPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPassword.Location = new System.Drawing.Point(93, 90);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '*';
            this.InputPassword.Size = new System.Drawing.Size(187, 27);
            this.InputPassword.TabIndex = 1;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(97, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(99, 33);
            this.LabelHeader.TabIndex = 7;
            this.LabelHeader.Text = "Sign In";
            // 
            // EventNavSignIn
            // 
            this.EventNavSignIn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavSignIn.Location = new System.Drawing.Point(16, 123);
            this.EventNavSignIn.Name = "EventNavSignIn";
            this.EventNavSignIn.Size = new System.Drawing.Size(264, 29);
            this.EventNavSignIn.TabIndex = 2;
            this.EventNavSignIn.Text = "Sign In";
            this.EventNavSignIn.UseVisualStyleBackColor = true;
            this.EventNavSignIn.Click += new System.EventHandler(this.EventNavSignIn_Click);
            // 
            // NavResetPassword
            // 
            this.NavResetPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavResetPassword.Location = new System.Drawing.Point(16, 158);
            this.NavResetPassword.Name = "NavResetPassword";
            this.NavResetPassword.Size = new System.Drawing.Size(127, 30);
            this.NavResetPassword.TabIndex = 3;
            this.NavResetPassword.Text = "Reset Password";
            this.NavResetPassword.UseVisualStyleBackColor = true;
            this.NavResetPassword.Click += new System.EventHandler(this.NavResetPassword_Click);
            // 
            // NavRegister
            // 
            this.NavRegister.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavRegister.Location = new System.Drawing.Point(149, 158);
            this.NavRegister.Name = "NavRegister";
            this.NavRegister.Size = new System.Drawing.Size(131, 30);
            this.NavRegister.TabIndex = 4;
            this.NavRegister.Text = "Register";
            this.NavRegister.UseVisualStyleBackColor = true;
            this.NavRegister.Click += new System.EventHandler(this.NavRegister_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 200);
            this.Controls.Add(this.EventNavSignIn);
            this.Controls.Add(this.NavRegister);
            this.Controls.Add(this.NavResetPassword);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputUsername);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button NavResetPassword;
        private System.Windows.Forms.Button EventNavSignIn;
        private System.Windows.Forms.Button NavRegister;
    }
}

