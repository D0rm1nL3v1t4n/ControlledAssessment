namespace WelshWanderers.Views
{
    partial class Testing
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
            this.EventTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventTest
            // 
            this.EventTest.Location = new System.Drawing.Point(66, 63);
            this.EventTest.Name = "EventTest";
            this.EventTest.Size = new System.Drawing.Size(75, 23);
            this.EventTest.TabIndex = 0;
            this.EventTest.Text = "Test";
            this.EventTest.UseVisualStyleBackColor = true;
            this.EventTest.Click += new System.EventHandler(this.EventTest_Click);
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 142);
            this.Controls.Add(this.EventTest);
            this.Name = "Testing";
            this.Text = "Testing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EventTest;
    }
}