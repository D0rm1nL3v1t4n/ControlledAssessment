namespace WelshWanderers.Views
{
    partial class EditLeague
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
            this.EventNavSave = new System.Windows.Forms.Button();
            this.NavCancel = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelTeam = new System.Windows.Forms.Label();
            this.InputTeam = new System.Windows.Forms.ComboBox();
            this.InputName = new System.Windows.Forms.TextBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventNavSave
            // 
            this.EventNavSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavSave.Location = new System.Drawing.Point(166, 152);
            this.EventNavSave.Name = "EventNavSave";
            this.EventNavSave.Size = new System.Drawing.Size(89, 48);
            this.EventNavSave.TabIndex = 45;
            this.EventNavSave.Text = "Save";
            this.EventNavSave.UseVisualStyleBackColor = true;
            // 
            // NavCancel
            // 
            this.NavCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavCancel.Location = new System.Drawing.Point(33, 152);
            this.NavCancel.Name = "NavCancel";
            this.NavCancel.Size = new System.Drawing.Size(89, 48);
            this.NavCancel.TabIndex = 44;
            this.NavCancel.Text = "Cancel";
            this.NavCancel.UseVisualStyleBackColor = true;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(29, 77);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(50, 19);
            this.LabelName.TabIndex = 43;
            this.LabelName.Text = "Name";
            // 
            // LabelTeam
            // 
            this.LabelTeam.AutoSize = true;
            this.LabelTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTeam.Location = new System.Drawing.Point(30, 110);
            this.LabelTeam.Name = "LabelTeam";
            this.LabelTeam.Size = new System.Drawing.Size(49, 19);
            this.LabelTeam.TabIndex = 42;
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
            this.InputTeam.Location = new System.Drawing.Point(85, 107);
            this.InputTeam.Name = "InputTeam";
            this.InputTeam.Size = new System.Drawing.Size(170, 27);
            this.InputTeam.TabIndex = 41;
            // 
            // InputName
            // 
            this.InputName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputName.Location = new System.Drawing.Point(85, 74);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(170, 27);
            this.InputName.TabIndex = 40;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(66, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(153, 33);
            this.LabelHeader.TabIndex = 39;
            this.LabelHeader.Text = "Edit League";
            // 
            // EditLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.EventNavSave);
            this.Controls.Add(this.NavCancel);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelTeam);
            this.Controls.Add(this.InputTeam);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.LabelHeader);
            this.Name = "EditLeague";
            this.Text = "EditLeague";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EventNavSave;
        private System.Windows.Forms.Button NavCancel;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelTeam;
        private System.Windows.Forms.ComboBox InputTeam;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Label LabelHeader;
    }
}