namespace VisualCSharp
{
    partial class testForm1
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
            this.EventOpenForm2 = new System.Windows.Forms.Button();
            this.EventCloseForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventOpenForm2
            // 
            this.EventOpenForm2.Location = new System.Drawing.Point(78, 32);
            this.EventOpenForm2.Name = "EventOpenForm2";
            this.EventOpenForm2.Size = new System.Drawing.Size(117, 75);
            this.EventOpenForm2.TabIndex = 0;
            this.EventOpenForm2.Text = "Open form 2";
            this.EventOpenForm2.UseVisualStyleBackColor = true;
            this.EventOpenForm2.Click += new System.EventHandler(this.EventOpenForm2_Click);
            // 
            // EventCloseForm2
            // 
            this.EventCloseForm2.Location = new System.Drawing.Point(78, 133);
            this.EventCloseForm2.Name = "EventCloseForm2";
            this.EventCloseForm2.Size = new System.Drawing.Size(117, 69);
            this.EventCloseForm2.TabIndex = 1;
            this.EventCloseForm2.Text = "Close form 2";
            this.EventCloseForm2.UseVisualStyleBackColor = true;
            this.EventCloseForm2.Click += new System.EventHandler(this.EventCloseForm2_Click);
            // 
            // testForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.EventCloseForm2);
            this.Controls.Add(this.EventOpenForm2);
            this.Name = "testForm2";
            this.Text = "testForm2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EventOpenForm2;
        private System.Windows.Forms.Button EventCloseForm2;
    }
}