namespace WelshWanderers.Views
{
    partial class PreviewEmail
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
            this.InputBody = new System.Windows.Forms.TextBox();
            this.InputSubject = new System.Windows.Forms.TextBox();
            this.LabelBody = new System.Windows.Forms.Label();
            this.LabelSubject = new System.Windows.Forms.Label();
            this.InputTo = new System.Windows.Forms.TextBox();
            this.LabelTo = new System.Windows.Forms.Label();
            this.EventSendEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBody
            // 
            this.InputBody.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBody.Location = new System.Drawing.Point(80, 105);
            this.InputBody.Multiline = true;
            this.InputBody.Name = "InputBody";
            this.InputBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputBody.Size = new System.Drawing.Size(475, 348);
            this.InputBody.TabIndex = 39;
            // 
            // InputSubject
            // 
            this.InputSubject.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSubject.Location = new System.Drawing.Point(80, 76);
            this.InputSubject.Name = "InputSubject";
            this.InputSubject.Size = new System.Drawing.Size(475, 23);
            this.InputSubject.TabIndex = 43;
            // 
            // LabelBody
            // 
            this.LabelBody.AutoSize = true;
            this.LabelBody.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBody.Location = new System.Drawing.Point(30, 105);
            this.LabelBody.Name = "LabelBody";
            this.LabelBody.Size = new System.Drawing.Size(44, 19);
            this.LabelBody.TabIndex = 44;
            this.LabelBody.Text = "Body";
            // 
            // LabelSubject
            // 
            this.LabelSubject.AutoSize = true;
            this.LabelSubject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubject.Location = new System.Drawing.Point(13, 76);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Size = new System.Drawing.Size(61, 19);
            this.LabelSubject.TabIndex = 45;
            this.LabelSubject.Text = "Subject";
            // 
            // InputTo
            // 
            this.InputTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTo.Location = new System.Drawing.Point(80, 15);
            this.InputTo.Multiline = true;
            this.InputTo.Name = "InputTo";
            this.InputTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputTo.Size = new System.Drawing.Size(475, 56);
            this.InputTo.TabIndex = 46;
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTo.Location = new System.Drawing.Point(46, 15);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(28, 19);
            this.LabelTo.TabIndex = 47;
            this.LabelTo.Text = "To";
            // 
            // EventSendEmail
            // 
            this.EventSendEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventSendEmail.Location = new System.Drawing.Point(466, 459);
            this.EventSendEmail.Name = "EventSendEmail";
            this.EventSendEmail.Size = new System.Drawing.Size(89, 48);
            this.EventSendEmail.TabIndex = 49;
            this.EventSendEmail.Text = "Send Email";
            this.EventSendEmail.UseVisualStyleBackColor = true;
            this.EventSendEmail.Click += new System.EventHandler(this.EventSendEmail_Click);
            // 
            // PreviewEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 524);
            this.Controls.Add(this.EventSendEmail);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.InputTo);
            this.Controls.Add(this.LabelSubject);
            this.Controls.Add(this.LabelBody);
            this.Controls.Add(this.InputSubject);
            this.Controls.Add(this.InputBody);
            this.Name = "PreviewEmail";
            this.Text = "PreviewEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBody;
        private System.Windows.Forms.TextBox InputSubject;
        private System.Windows.Forms.Label LabelBody;
        private System.Windows.Forms.Label LabelSubject;
        private System.Windows.Forms.TextBox InputTo;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.Button EventSendEmail;
    }
}