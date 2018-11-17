namespace WelshWanderers.Views
{
    partial class CreateLeague
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
            this.InputName = new System.Windows.Forms.TextBox();
            this.InputTeam = new System.Windows.Forms.ComboBox();
            this.LabelTeam = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.NavCancel = new System.Windows.Forms.Button();
            this.EventNavCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(57, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(185, 33);
            this.LabelHeader.TabIndex = 9;
            this.LabelHeader.Text = "Create League";
            // 
            // InputName
            // 
            this.InputName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputName.Location = new System.Drawing.Point(92, 78);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(170, 27);
            this.InputName.TabIndex = 31;
            // 
            // InputTeam
            // 
            this.InputTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTeam.FormattingEnabled = true;
            this.InputTeam.Items.AddRange(new object[] {
            "Junior",
            "Men",
            "Women"});
            this.InputTeam.Location = new System.Drawing.Point(92, 111);
            this.InputTeam.Name = "InputTeam";
            this.InputTeam.Size = new System.Drawing.Size(170, 27);
            this.InputTeam.TabIndex = 32;
            // 
            // LabelTeam
            // 
            this.LabelTeam.AutoSize = true;
            this.LabelTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTeam.Location = new System.Drawing.Point(37, 114);
            this.LabelTeam.Name = "LabelTeam";
            this.LabelTeam.Size = new System.Drawing.Size(49, 19);
            this.LabelTeam.TabIndex = 34;
            this.LabelTeam.Text = "Team";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(36, 81);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(50, 19);
            this.LabelName.TabIndex = 36;
            this.LabelName.Text = "Name";
            // 
            // NavCancel
            // 
            this.NavCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavCancel.Location = new System.Drawing.Point(40, 156);
            this.NavCancel.Name = "NavCancel";
            this.NavCancel.Size = new System.Drawing.Size(89, 48);
            this.NavCancel.TabIndex = 37;
            this.NavCancel.Text = "Cancel";
            this.NavCancel.UseVisualStyleBackColor = true;
            this.NavCancel.Click += new System.EventHandler(this.NavCancel_Click);
            // 
            // EventNavCreate
            // 
            this.EventNavCreate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavCreate.Location = new System.Drawing.Point(173, 156);
            this.EventNavCreate.Name = "EventNavCreate";
            this.EventNavCreate.Size = new System.Drawing.Size(89, 48);
            this.EventNavCreate.TabIndex = 38;
            this.EventNavCreate.Text = "Create";
            this.EventNavCreate.UseVisualStyleBackColor = true;
            this.EventNavCreate.Click += new System.EventHandler(this.EventNavCreate_Click);
            // 
            // CreateLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 233);
            this.Controls.Add(this.EventNavCreate);
            this.Controls.Add(this.NavCancel);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelTeam);
            this.Controls.Add(this.InputTeam);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.LabelHeader);
            this.Name = "CreateLeague";
            this.Text = "CreateLeague";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.ComboBox InputTeam;
        private System.Windows.Forms.Label LabelTeam;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button NavCancel;
        private System.Windows.Forms.Button EventNavCreate;
    }
}