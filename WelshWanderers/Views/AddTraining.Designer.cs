namespace WelshWanderers
{
    partial class AddTraining
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
            this.InputTeam = new System.Windows.Forms.ComboBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.InputDate = new System.Windows.Forms.DateTimePicker();
            this.EventNavSave = new System.Windows.Forms.Button();
            this.NavCancel = new System.Windows.Forms.Button();
            this.InputDuration = new System.Windows.Forms.TextBox();
            this.InputTimeM = new System.Windows.Forms.TextBox();
            this.InputTimeH = new System.Windows.Forms.TextBox();
            this.LabelTeam = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.EventPreviewEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputTeam
            // 
            this.InputTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTeam.FormattingEnabled = true;
            this.InputTeam.Items.AddRange(new object[] {
            "Junior",
            "Men",
            "Women"});
            this.InputTeam.Location = new System.Drawing.Point(132, 69);
            this.InputTeam.Name = "InputTeam";
            this.InputTeam.Size = new System.Drawing.Size(165, 27);
            this.InputTeam.TabIndex = 0;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(71, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(166, 33);
            this.LabelHeader.TabIndex = 12;
            this.LabelHeader.Text = "Add Training";
            // 
            // InputDate
            // 
            this.InputDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDate.Location = new System.Drawing.Point(132, 166);
            this.InputDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.InputDate.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.InputDate.Name = "InputDate";
            this.InputDate.Size = new System.Drawing.Size(165, 27);
            this.InputDate.TabIndex = 3;
            this.InputDate.Value = new System.DateTime(2019, 2, 22, 0, 0, 0, 0);
            // 
            // EventNavSave
            // 
            this.EventNavSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavSave.Location = new System.Drawing.Point(244, 12);
            this.EventNavSave.Name = "EventNavSave";
            this.EventNavSave.Size = new System.Drawing.Size(53, 30);
            this.EventNavSave.TabIndex = 6;
            this.EventNavSave.Text = "Save";
            this.EventNavSave.UseVisualStyleBackColor = true;
            this.EventNavSave.Click += new System.EventHandler(this.EventNavSave_Click);
            // 
            // NavCancel
            // 
            this.NavCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavCancel.Location = new System.Drawing.Point(12, 12);
            this.NavCancel.Name = "NavCancel";
            this.NavCancel.Size = new System.Drawing.Size(53, 30);
            this.NavCancel.TabIndex = 7;
            this.NavCancel.Text = "Back";
            this.NavCancel.UseVisualStyleBackColor = true;
            this.NavCancel.Click += new System.EventHandler(this.NavCancel_Click);
            // 
            // InputDuration
            // 
            this.InputDuration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDuration.Location = new System.Drawing.Point(132, 135);
            this.InputDuration.Name = "InputDuration";
            this.InputDuration.Size = new System.Drawing.Size(165, 27);
            this.InputDuration.TabIndex = 3;
            // 
            // InputTimeM
            // 
            this.InputTimeM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeM.Location = new System.Drawing.Point(218, 102);
            this.InputTimeM.Name = "InputTimeM";
            this.InputTimeM.Size = new System.Drawing.Size(79, 27);
            this.InputTimeM.TabIndex = 2;
            // 
            // InputTimeH
            // 
            this.InputTimeH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeH.Location = new System.Drawing.Point(132, 102);
            this.InputTimeH.Name = "InputTimeH";
            this.InputTimeH.Size = new System.Drawing.Size(79, 27);
            this.InputTimeH.TabIndex = 1;
            // 
            // LabelTeam
            // 
            this.LabelTeam.AutoSize = true;
            this.LabelTeam.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTeam.Location = new System.Drawing.Point(12, 73);
            this.LabelTeam.Name = "LabelTeam";
            this.LabelTeam.Size = new System.Drawing.Size(47, 18);
            this.LabelTeam.TabIndex = 11;
            this.LabelTeam.Text = "Team";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(12, 173);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(39, 18);
            this.LabelDate.TabIndex = 10;
            this.LabelDate.Text = "Date";
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDuration.Location = new System.Drawing.Point(12, 139);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(102, 18);
            this.LabelDuration.TabIndex = 9;
            this.LabelDuration.Text = "Duration (min)";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.Location = new System.Drawing.Point(12, 106);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(41, 18);
            this.LabelTime.TabIndex = 8;
            this.LabelTime.Text = "Time";
            // 
            // EventPreviewEmail
            // 
            this.EventPreviewEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventPreviewEmail.Location = new System.Drawing.Point(183, 199);
            this.EventPreviewEmail.Name = "EventPreviewEmail";
            this.EventPreviewEmail.Size = new System.Drawing.Size(114, 30);
            this.EventPreviewEmail.TabIndex = 5;
            this.EventPreviewEmail.Text = "Preview Email";
            this.EventPreviewEmail.UseVisualStyleBackColor = true;
            this.EventPreviewEmail.Click += new System.EventHandler(this.InputPreviewEmail_Click);
            // 
            // AddTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 235);
            this.Controls.Add(this.EventPreviewEmail);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelDuration);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelTeam);
            this.Controls.Add(this.InputTimeH);
            this.Controls.Add(this.InputTimeM);
            this.Controls.Add(this.InputDuration);
            this.Controls.Add(this.NavCancel);
            this.Controls.Add(this.EventNavSave);
            this.Controls.Add(this.InputDate);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.InputTeam);
            this.Name = "AddTraining";
            this.Text = "AddTraining";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InputTeam;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DateTimePicker InputDate;
        private System.Windows.Forms.Button EventNavSave;
        private System.Windows.Forms.Button NavCancel;
        private System.Windows.Forms.TextBox InputDuration;
        private System.Windows.Forms.TextBox InputTimeM;
        private System.Windows.Forms.TextBox InputTimeH;
        private System.Windows.Forms.Label LabelTeam;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelDuration;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Button EventPreviewEmail;
    }
}