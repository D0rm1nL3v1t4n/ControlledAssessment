namespace VisualCSharp
{
    partial class testForm2
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
            this.EventEnableForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventEnableForm1
            // 
            this.EventEnableForm1.Location = new System.Drawing.Point(82, 70);
            this.EventEnableForm1.Name = "EventEnableForm1";
            this.EventEnableForm1.Size = new System.Drawing.Size(118, 104);
            this.EventEnableForm1.TabIndex = 0;
            this.EventEnableForm1.Text = "Toggle Enable/Unenable form 1";
            this.EventEnableForm1.UseVisualStyleBackColor = true;
            this.EventEnableForm1.Click += new System.EventHandler(this.EventEnableForm1_Click);
            // 
            // testForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.EventEnableForm1);
            this.Name = "testForm2";
            this.Text = "testForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EventEnableForm1;
    }
}