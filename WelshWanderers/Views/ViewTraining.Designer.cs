namespace WelshWanderers
{
    partial class ViewTrainings
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
            this.InputDate = new System.Windows.Forms.DateTimePicker();
            this.InputTimeM = new System.Windows.Forms.TextBox();
            this.InputTimeH = new System.Windows.Forms.TextBox();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.InputTeam = new System.Windows.Forms.ComboBox();
            this.InputDuration = new System.Windows.Forms.TextBox();
            this.LabelTeam = new System.Windows.Forms.Label();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.LabelChangesMade = new System.Windows.Forms.Label();
            this.EventSave = new System.Windows.Forms.Button();
            this.NavBack = new System.Windows.Forms.Button();
            this.EventEdit = new System.Windows.Forms.Button();
            this.EventCancelEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(91, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(176, 33);
            this.LabelHeader.TabIndex = 8;
            this.LabelHeader.Text = "View Training";
            // 
            // InputDate
            // 
            this.InputDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDate.Location = new System.Drawing.Point(152, 183);
            this.InputDate.Name = "InputDate";
            this.InputDate.Size = new System.Drawing.Size(161, 27);
            this.InputDate.TabIndex = 64;
            this.InputDate.Value = new System.DateTime(2018, 11, 4, 0, 0, 0, 0);
            this.InputDate.ValueChanged += new System.EventHandler(this.InputDate_ValueChanged);
            // 
            // InputTimeM
            // 
            this.InputTimeM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeM.Location = new System.Drawing.Point(217, 117);
            this.InputTimeM.Name = "InputTimeM";
            this.InputTimeM.Size = new System.Drawing.Size(59, 27);
            this.InputTimeM.TabIndex = 63;
            this.InputTimeM.TextChanged += new System.EventHandler(this.InputTimeM_TextChanged);
            // 
            // InputTimeH
            // 
            this.InputTimeH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeH.Location = new System.Drawing.Point(152, 117);
            this.InputTimeH.Name = "InputTimeH";
            this.InputTimeH.Size = new System.Drawing.Size(59, 27);
            this.InputTimeH.TabIndex = 62;
            this.InputTimeH.TextChanged += new System.EventHandler(this.InputTimeH_TextChanged);
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.Location = new System.Drawing.Point(101, 120);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(45, 19);
            this.LabelTime.TabIndex = 61;
            this.LabelTime.Text = "Time";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(106, 189);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(41, 19);
            this.LabelDate.TabIndex = 60;
            this.LabelDate.Text = "Date";
            // 
            // InputTeam
            // 
            this.InputTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTeam.FormattingEnabled = true;
            this.InputTeam.Items.AddRange(new object[] {
            "Junior",
            "Men",
            "Women"});
            this.InputTeam.Location = new System.Drawing.Point(153, 84);
            this.InputTeam.Name = "InputTeam";
            this.InputTeam.Size = new System.Drawing.Size(161, 27);
            this.InputTeam.TabIndex = 65;
            this.InputTeam.SelectedIndexChanged += new System.EventHandler(this.InputTeam_SelectedIndexChanged);
            // 
            // InputDuration
            // 
            this.InputDuration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDuration.Location = new System.Drawing.Point(152, 150);
            this.InputDuration.Name = "InputDuration";
            this.InputDuration.Size = new System.Drawing.Size(124, 27);
            this.InputDuration.TabIndex = 66;
            this.InputDuration.TextChanged += new System.EventHandler(this.InputDuration_TextChanged);
            // 
            // LabelTeam
            // 
            this.LabelTeam.AutoSize = true;
            this.LabelTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTeam.Location = new System.Drawing.Point(98, 87);
            this.LabelTeam.Name = "LabelTeam";
            this.LabelTeam.Size = new System.Drawing.Size(49, 19);
            this.LabelTeam.TabIndex = 67;
            this.LabelTeam.Text = "Team";
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDuration.Location = new System.Drawing.Point(33, 153);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(114, 19);
            this.LabelDuration.TabIndex = 68;
            this.LabelDuration.Text = "Duration (min)";
            // 
            // LabelChangesMade
            // 
            this.LabelChangesMade.AutoSize = true;
            this.LabelChangesMade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChangesMade.Location = new System.Drawing.Point(223, 267);
            this.LabelChangesMade.Name = "LabelChangesMade";
            this.LabelChangesMade.Size = new System.Drawing.Size(91, 19);
            this.LabelChangesMade.TabIndex = 71;
            this.LabelChangesMade.Text = "No changes";
            // 
            // EventSave
            // 
            this.EventSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventSave.Location = new System.Drawing.Point(229, 216);
            this.EventSave.Name = "EventSave";
            this.EventSave.Size = new System.Drawing.Size(89, 48);
            this.EventSave.TabIndex = 70;
            this.EventSave.Text = "Save";
            this.EventSave.UseVisualStyleBackColor = true;
            this.EventSave.Click += new System.EventHandler(this.EventSave_Click);
            // 
            // NavBack
            // 
            this.NavBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBack.Location = new System.Drawing.Point(39, 216);
            this.NavBack.Name = "NavBack";
            this.NavBack.Size = new System.Drawing.Size(89, 48);
            this.NavBack.TabIndex = 69;
            this.NavBack.Text = "Back";
            this.NavBack.UseVisualStyleBackColor = true;
            this.NavBack.Click += new System.EventHandler(this.NavBack_Click);
            // 
            // EventEdit
            // 
            this.EventEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventEdit.Location = new System.Drawing.Point(229, 216);
            this.EventEdit.Name = "EventEdit";
            this.EventEdit.Size = new System.Drawing.Size(89, 48);
            this.EventEdit.TabIndex = 72;
            this.EventEdit.Text = "Edit";
            this.EventEdit.UseVisualStyleBackColor = true;
            this.EventEdit.Click += new System.EventHandler(this.EventEdit_Click);
            // 
            // EventCancelEdit
            // 
            this.EventCancelEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventCancelEdit.Location = new System.Drawing.Point(134, 216);
            this.EventCancelEdit.Name = "EventCancelEdit";
            this.EventCancelEdit.Size = new System.Drawing.Size(89, 48);
            this.EventCancelEdit.TabIndex = 73;
            this.EventCancelEdit.Text = "Cancel Edit";
            this.EventCancelEdit.UseVisualStyleBackColor = true;
            this.EventCancelEdit.Click += new System.EventHandler(this.EventCancelEdit_Click);
            // 
            // ViewTrainings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 306);
            this.Controls.Add(this.EventCancelEdit);
            this.Controls.Add(this.EventEdit);
            this.Controls.Add(this.LabelChangesMade);
            this.Controls.Add(this.EventSave);
            this.Controls.Add(this.NavBack);
            this.Controls.Add(this.LabelDuration);
            this.Controls.Add(this.LabelTeam);
            this.Controls.Add(this.InputDuration);
            this.Controls.Add(this.InputTeam);
            this.Controls.Add(this.InputDate);
            this.Controls.Add(this.InputTimeM);
            this.Controls.Add(this.InputTimeH);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelHeader);
            this.Name = "ViewTrainings";
            this.Text = "EditTraining";
            this.Load += new System.EventHandler(this.EditTraining_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DateTimePicker InputDate;
        private System.Windows.Forms.TextBox InputTimeM;
        private System.Windows.Forms.TextBox InputTimeH;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.ComboBox InputTeam;
        private System.Windows.Forms.TextBox InputDuration;
        private System.Windows.Forms.Label LabelTeam;
        private System.Windows.Forms.Label LabelDuration;
        private System.Windows.Forms.Label LabelChangesMade;
        private System.Windows.Forms.Button EventSave;
        private System.Windows.Forms.Button NavBack;
        private System.Windows.Forms.Button EventEdit;
        private System.Windows.Forms.Button EventCancelEdit;
    }
}