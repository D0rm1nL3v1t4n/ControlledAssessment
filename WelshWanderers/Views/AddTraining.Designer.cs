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
            this.InputType = new System.Windows.Forms.ComboBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.InputDate = new System.Windows.Forms.DateTimePicker();
            this.EventNavSave = new System.Windows.Forms.Button();
            this.NavCancel = new System.Windows.Forms.Button();
            this.InputDuration = new System.Windows.Forms.TextBox();
            this.InputTimeM = new System.Windows.Forms.TextBox();
            this.InputTimeH = new System.Windows.Forms.TextBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputType
            // 
            this.InputType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputType.FormattingEnabled = true;
            this.InputType.Items.AddRange(new object[] {
            "Clinic",
            "Junior",
            "Men",
            "Women"});
            this.InputType.Location = new System.Drawing.Point(154, 75);
            this.InputType.Name = "InputType";
            this.InputType.Size = new System.Drawing.Size(161, 27);
            this.InputType.TabIndex = 7;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(91, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(166, 33);
            this.LabelHeader.TabIndex = 8;
            this.LabelHeader.Text = "Add Training";
            // 
            // InputDate
            // 
            this.InputDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDate.Location = new System.Drawing.Point(154, 174);
            this.InputDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.InputDate.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.InputDate.Name = "InputDate";
            this.InputDate.Size = new System.Drawing.Size(161, 27);
            this.InputDate.TabIndex = 21;
            this.InputDate.Value = new System.DateTime(2018, 10, 26, 0, 0, 0, 0);
            // 
            // EventNavSave
            // 
            this.EventNavSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavSave.Location = new System.Drawing.Point(226, 207);
            this.EventNavSave.Name = "EventNavSave";
            this.EventNavSave.Size = new System.Drawing.Size(89, 48);
            this.EventNavSave.TabIndex = 28;
            this.EventNavSave.Text = "Save";
            this.EventNavSave.UseVisualStyleBackColor = true;
            this.EventNavSave.Click += new System.EventHandler(this.EventNavSave_Click);
            // 
            // NavCancel
            // 
            this.NavCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavCancel.Location = new System.Drawing.Point(38, 207);
            this.NavCancel.Name = "NavCancel";
            this.NavCancel.Size = new System.Drawing.Size(89, 48);
            this.NavCancel.TabIndex = 29;
            this.NavCancel.Text = "Cancel";
            this.NavCancel.UseVisualStyleBackColor = true;
            this.NavCancel.Click += new System.EventHandler(this.NavCancel_Click);
            // 
            // InputDuration
            // 
            this.InputDuration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDuration.Location = new System.Drawing.Point(154, 141);
            this.InputDuration.Name = "InputDuration";
            this.InputDuration.Size = new System.Drawing.Size(120, 27);
            this.InputDuration.TabIndex = 30;
            // 
            // InputTimeM
            // 
            this.InputTimeM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeM.Location = new System.Drawing.Point(217, 108);
            this.InputTimeM.Name = "InputTimeM";
            this.InputTimeM.Size = new System.Drawing.Size(57, 27);
            this.InputTimeM.TabIndex = 31;
            // 
            // InputTimeH
            // 
            this.InputTimeH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeH.Location = new System.Drawing.Point(154, 108);
            this.InputTimeH.Name = "InputTimeH";
            this.InputTimeH.Size = new System.Drawing.Size(57, 27);
            this.InputTimeH.TabIndex = 32;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelType.Location = new System.Drawing.Point(104, 78);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(44, 19);
            this.LabelType.TabIndex = 33;
            this.LabelType.Text = "Type";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(107, 180);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(41, 19);
            this.LabelDate.TabIndex = 34;
            this.LabelDate.Text = "Date";
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDuration.Location = new System.Drawing.Point(34, 144);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(114, 19);
            this.LabelDuration.TabIndex = 35;
            this.LabelDuration.Text = "Duration (min)";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.Location = new System.Drawing.Point(103, 111);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(45, 19);
            this.LabelTime.TabIndex = 36;
            this.LabelTime.Text = "Time";
            // 
            // AddTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 277);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelDuration);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.InputTimeH);
            this.Controls.Add(this.InputTimeM);
            this.Controls.Add(this.InputDuration);
            this.Controls.Add(this.NavCancel);
            this.Controls.Add(this.EventNavSave);
            this.Controls.Add(this.InputDate);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.InputType);
            this.Name = "AddTraining";
            this.Text = "AddTraining";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InputType;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DateTimePicker InputDate;
        private System.Windows.Forms.Button EventNavSave;
        private System.Windows.Forms.Button NavCancel;
        private System.Windows.Forms.TextBox InputDuration;
        private System.Windows.Forms.TextBox InputTimeM;
        private System.Windows.Forms.TextBox InputTimeH;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelDuration;
        private System.Windows.Forms.Label LabelTime;
    }
}