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
            this.InputBody.Location = new System.Drawing.Point(74, 106);
            this.InputBody.Multiline = true;
            this.InputBody.Name = "InputBody";
            this.InputBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputBody.Size = new System.Drawing.Size(475, 348);
            this.InputBody.TabIndex = 1;
            // 
            // InputSubject
            // 
            this.InputSubject.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSubject.Location = new System.Drawing.Point(74, 77);
            this.InputSubject.Name = "InputSubject";
            this.InputSubject.Size = new System.Drawing.Size(475, 23);
            this.InputSubject.TabIndex = 0;
            // 
            // LabelBody
            // 
            this.LabelBody.AutoSize = true;
            this.LabelBody.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBody.Location = new System.Drawing.Point(27, 106);
            this.LabelBody.Name = "LabelBody";
            this.LabelBody.Size = new System.Drawing.Size(41, 18);
            this.LabelBody.TabIndex = 4;
            this.LabelBody.Text = "Body";
            // 
            // LabelSubject
            // 
            this.LabelSubject.AutoSize = true;
            this.LabelSubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubject.Location = new System.Drawing.Point(12, 77);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Size = new System.Drawing.Size(56, 18);
            this.LabelSubject.TabIndex = 5;
            this.LabelSubject.Text = "Subject";
            // 
            // InputTo
            // 
            this.InputTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTo.Location = new System.Drawing.Point(74, 15);
            this.InputTo.Multiline = true;
            this.InputTo.Name = "InputTo";
            this.InputTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputTo.Size = new System.Drawing.Size(475, 56);
            this.InputTo.TabIndex = 3;
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTo.Location = new System.Drawing.Point(42, 15);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(26, 18);
            this.LabelTo.TabIndex = 47;
            this.LabelTo.Text = "To";
            // 
            // EventSendEmail
            // 
            this.EventSendEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventSendEmail.Location = new System.Drawing.Point(447, 460);
            this.EventSendEmail.Name = "EventSendEmail";
            this.EventSendEmail.Size = new System.Drawing.Size(102, 30);
            this.EventSendEmail.TabIndex = 2;
            this.EventSendEmail.Text = "Send Email";
            this.EventSendEmail.UseVisualStyleBackColor = true;
            this.EventSendEmail.Click += new System.EventHandler(this.EventSendEmail_Click);
            // 
            // PreviewEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 500);
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