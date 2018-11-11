namespace VisualCSharp.Forms.Sub_home_Screens.Coach_sub_Screens
{
    partial class EditTrainingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTrainingForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEditTraining = new System.Windows.Forms.Label();
            this.grpbxAddMatch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColon1 = new System.Windows.Forms.Label();
            this.txtFinishMin = new System.Windows.Forms.TextBox();
            this.txtFinishHours = new System.Windows.Forms.TextBox();
            this.txtStartMin = new System.Windows.Forms.TextBox();
            this.txtStartHours = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.TrainingDate = new System.Windows.Forms.DateTimePicker();
            this.lblFinishTime = new System.Windows.Forms.Label();
            this.CmbTrainingType = new System.Windows.Forms.ComboBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblTrainingType = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSaveTraining = new System.Windows.Forms.Button();
            this.LblChangesMade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbxAddMatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblEditTraining
            // 
            this.lblEditTraining.AutoSize = true;
            this.lblEditTraining.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTraining.Location = new System.Drawing.Point(152, 183);
            this.lblEditTraining.Name = "lblEditTraining";
            this.lblEditTraining.Size = new System.Drawing.Size(181, 42);
            this.lblEditTraining.TabIndex = 11;
            this.lblEditTraining.Text = "Edit Match";
            // 
            // grpbxAddMatch
            // 
            this.grpbxAddMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpbxAddMatch.Controls.Add(this.label1);
            this.grpbxAddMatch.Controls.Add(this.lblColon1);
            this.grpbxAddMatch.Controls.Add(this.txtFinishMin);
            this.grpbxAddMatch.Controls.Add(this.txtFinishHours);
            this.grpbxAddMatch.Controls.Add(this.txtStartMin);
            this.grpbxAddMatch.Controls.Add(this.txtStartHours);
            this.grpbxAddMatch.Controls.Add(this.lblDate);
            this.grpbxAddMatch.Controls.Add(this.TrainingDate);
            this.grpbxAddMatch.Controls.Add(this.lblFinishTime);
            this.grpbxAddMatch.Controls.Add(this.CmbTrainingType);
            this.grpbxAddMatch.Controls.Add(this.lblStartTime);
            this.grpbxAddMatch.Controls.Add(this.lblTrainingType);
            this.grpbxAddMatch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAddMatch.Location = new System.Drawing.Point(37, 246);
            this.grpbxAddMatch.Name = "grpbxAddMatch";
            this.grpbxAddMatch.Size = new System.Drawing.Size(410, 156);
            this.grpbxAddMatch.TabIndex = 14;
            this.grpbxAddMatch.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = ":";
            // 
            // lblColon1
            // 
            this.lblColon1.AutoSize = true;
            this.lblColon1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColon1.Location = new System.Drawing.Point(232, 54);
            this.lblColon1.Name = "lblColon1";
            this.lblColon1.Size = new System.Drawing.Size(14, 19);
            this.lblColon1.TabIndex = 22;
            this.lblColon1.Text = ":";
            // 
            // txtFinishMin
            // 
            this.txtFinishMin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinishMin.Location = new System.Drawing.Point(246, 82);
            this.txtFinishMin.MaxLength = 2;
            this.txtFinishMin.Name = "txtFinishMin";
            this.txtFinishMin.Size = new System.Drawing.Size(46, 26);
            this.txtFinishMin.TabIndex = 21;
            this.txtFinishMin.TextChanged += new System.EventHandler(this.txtFinishMin_TextChanged);
            // 
            // txtFinishHours
            // 
            this.txtFinishHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinishHours.Location = new System.Drawing.Point(186, 82);
            this.txtFinishHours.MaxLength = 2;
            this.txtFinishHours.Name = "txtFinishHours";
            this.txtFinishHours.Size = new System.Drawing.Size(46, 26);
            this.txtFinishHours.TabIndex = 20;
            this.txtFinishHours.TextChanged += new System.EventHandler(this.txtFinishHours_TextChanged);
            // 
            // txtStartMin
            // 
            this.txtStartMin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartMin.Location = new System.Drawing.Point(246, 51);
            this.txtStartMin.MaxLength = 2;
            this.txtStartMin.Name = "txtStartMin";
            this.txtStartMin.Size = new System.Drawing.Size(46, 26);
            this.txtStartMin.TabIndex = 19;
            this.txtStartMin.TextChanged += new System.EventHandler(this.txtStartMin_TextChanged);
            // 
            // txtStartHours
            // 
            this.txtStartHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartHours.Location = new System.Drawing.Point(186, 51);
            this.txtStartHours.MaxLength = 2;
            this.txtStartHours.Name = "txtStartHours";
            this.txtStartHours.Size = new System.Drawing.Size(46, 26);
            this.txtStartHours.TabIndex = 18;
            this.txtStartHours.TextChanged += new System.EventHandler(this.txtStartHours_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(41, 121);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 19);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            // 
            // TrainingDate
            // 
            this.TrainingDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainingDate.Location = new System.Drawing.Point(186, 114);
            this.TrainingDate.Name = "TrainingDate";
            this.TrainingDate.Size = new System.Drawing.Size(183, 26);
            this.TrainingDate.TabIndex = 11;
            this.TrainingDate.Value = new System.DateTime(2018, 10, 19, 0, 0, 0, 0);
            this.TrainingDate.ValueChanged += new System.EventHandler(this.TrainingDate_ValueChanged);
            // 
            // lblFinishTime
            // 
            this.lblFinishTime.AutoSize = true;
            this.lblFinishTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishTime.Location = new System.Drawing.Point(41, 89);
            this.lblFinishTime.Name = "lblFinishTime";
            this.lblFinishTime.Size = new System.Drawing.Size(77, 19);
            this.lblFinishTime.TabIndex = 9;
            this.lblFinishTime.Text = "Finish Time";
            // 
            // CmbTrainingType
            // 
            this.CmbTrainingType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTrainingType.FormattingEnabled = true;
            this.CmbTrainingType.Items.AddRange(new object[] {
            "Juniors",
            "Mens",
            "Womens",
            "Clinic"});
            this.CmbTrainingType.Location = new System.Drawing.Point(186, 20);
            this.CmbTrainingType.Name = "CmbTrainingType";
            this.CmbTrainingType.Size = new System.Drawing.Size(106, 25);
            this.CmbTrainingType.TabIndex = 8;
            this.CmbTrainingType.SelectedIndexChanged += new System.EventHandler(this.CmbTrainingType_SelectedIndexChanged);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(41, 58);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(71, 19);
            this.lblStartTime.TabIndex = 6;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblTrainingType
            // 
            this.lblTrainingType.AutoSize = true;
            this.lblTrainingType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainingType.Location = new System.Drawing.Point(41, 26);
            this.lblTrainingType.Name = "lblTrainingType";
            this.lblTrainingType.Size = new System.Drawing.Size(90, 19);
            this.lblTrainingType.TabIndex = 5;
            this.lblTrainingType.Text = "Training Type";
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(36, 408);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(113, 34);
            this.BtnBack.TabIndex = 24;
            this.BtnBack.Text = "Cancel";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSaveTraining
            // 
            this.BtnSaveTraining.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveTraining.Location = new System.Drawing.Point(334, 408);
            this.BtnSaveTraining.Name = "BtnSaveTraining";
            this.BtnSaveTraining.Size = new System.Drawing.Size(113, 34);
            this.BtnSaveTraining.TabIndex = 25;
            this.BtnSaveTraining.Text = "Save";
            this.BtnSaveTraining.UseVisualStyleBackColor = true;
            this.BtnSaveTraining.Click += new System.EventHandler(this.BtnSaveTraining_Click);
            // 
            // LblChangesMade
            // 
            this.LblChangesMade.AutoSize = true;
            this.LblChangesMade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangesMade.Location = new System.Drawing.Point(330, 445);
            this.LblChangesMade.Name = "LblChangesMade";
            this.LblChangesMade.Size = new System.Drawing.Size(88, 19);
            this.LblChangesMade.TabIndex = 26;
            this.LblChangesMade.Text = "No Changes";
            // 
            // EditTrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(484, 481);
            this.Controls.Add(this.LblChangesMade);
            this.Controls.Add(this.BtnSaveTraining);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.grpbxAddMatch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEditTraining);
            this.Name = "EditTrainingForm";
            this.Text = "EditTraining";
            this.Load += new System.EventHandler(this.EditTrainingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbxAddMatch.ResumeLayout(false);
            this.grpbxAddMatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEditTraining;
        private System.Windows.Forms.GroupBox grpbxAddMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColon1;
        private System.Windows.Forms.TextBox txtFinishMin;
        private System.Windows.Forms.TextBox txtFinishHours;
        private System.Windows.Forms.TextBox txtStartMin;
        private System.Windows.Forms.TextBox txtStartHours;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker TrainingDate;
        private System.Windows.Forms.Label lblFinishTime;
        private System.Windows.Forms.ComboBox CmbTrainingType;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblTrainingType;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSaveTraining;
        private System.Windows.Forms.Label LblChangesMade;
    }
}