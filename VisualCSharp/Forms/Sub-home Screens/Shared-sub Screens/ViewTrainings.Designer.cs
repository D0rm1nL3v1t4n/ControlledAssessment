namespace VisualCSharp.Forms.Sub_home_Screens.Shared_sub_Screens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTrainings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblViewTrainings = new System.Windows.Forms.Label();
            this.TableViewTrainings = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrainingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStartTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFinishTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditTraining = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableViewTrainings)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblViewTrainings
            // 
            this.lblViewTrainings.AutoSize = true;
            this.lblViewTrainings.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewTrainings.Location = new System.Drawing.Point(122, 183);
            this.lblViewTrainings.Name = "lblViewTrainings";
            this.lblViewTrainings.Size = new System.Drawing.Size(241, 42);
            this.lblViewTrainings.TabIndex = 9;
            this.lblViewTrainings.Text = "View Trainings";
            // 
            // TableViewTrainings
            // 
            this.TableViewTrainings.AllowUserToAddRows = false;
            this.TableViewTrainings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableViewTrainings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableViewTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableViewTrainings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColTrainingType,
            this.ColStartTime1,
            this.ColFinishTime1,
            this.ColDate});
            this.TableViewTrainings.Location = new System.Drawing.Point(28, 228);
            this.TableViewTrainings.Name = "TableViewTrainings";
            this.TableViewTrainings.ReadOnly = true;
            this.TableViewTrainings.RowHeadersVisible = false;
            this.TableViewTrainings.RowHeadersWidth = 10;
            this.TableViewTrainings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableViewTrainings.ShowCellToolTips = false;
            this.TableViewTrainings.Size = new System.Drawing.Size(428, 251);
            this.TableViewTrainings.TabIndex = 15;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 35;
            // 
            // ColTrainingType
            // 
            this.ColTrainingType.HeaderText = "Training Type";
            this.ColTrainingType.Name = "ColTrainingType";
            this.ColTrainingType.ReadOnly = true;
            this.ColTrainingType.Width = 90;
            // 
            // ColStartTime1
            // 
            this.ColStartTime1.HeaderText = "Start Time";
            this.ColStartTime1.Name = "ColStartTime1";
            this.ColStartTime1.ReadOnly = true;
            // 
            // ColFinishTime1
            // 
            this.ColFinishTime1.HeaderText = "Finish Time";
            this.ColFinishTime1.Name = "ColFinishTime1";
            this.ColFinishTime1.ReadOnly = true;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // BtnEditTraining
            // 
            this.BtnEditTraining.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditTraining.Location = new System.Drawing.Point(375, 485);
            this.BtnEditTraining.Name = "BtnEditTraining";
            this.BtnEditTraining.Size = new System.Drawing.Size(81, 36);
            this.BtnEditTraining.TabIndex = 16;
            this.BtnEditTraining.Text = "Edit";
            this.BtnEditTraining.UseVisualStyleBackColor = true;
            this.BtnEditTraining.Click += new System.EventHandler(this.BtnEditTraining_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(28, 485);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(81, 36);
            this.BtnBack.TabIndex = 18;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ViewTrainings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 576);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnEditTraining);
            this.Controls.Add(this.TableViewTrainings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblViewTrainings);
            this.Name = "ViewTrainings";
            this.Text = "ViewTrainings";
            this.Load += new System.EventHandler(this.ViewTrainings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableViewTrainings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblViewTrainings;
        private System.Windows.Forms.DataGridView TableViewTrainings;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrainingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStartTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFinishTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.Button BtnEditTraining;
        private System.Windows.Forms.Button BtnBack;
    }
}