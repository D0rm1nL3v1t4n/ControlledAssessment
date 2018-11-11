namespace WelshWanderers
{
    partial class ViewTraining
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableViewTrainings = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrainingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStartTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFinishTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.NavHome = new System.Windows.Forms.Button();
            this.NavEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableViewTrainings)).BeginInit();
            this.SuspendLayout();
            // 
            // TableViewTrainings
            // 
            this.TableViewTrainings.AllowUserToAddRows = false;
            this.TableViewTrainings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TableViewTrainings.Location = new System.Drawing.Point(28, 78);
            this.TableViewTrainings.Name = "TableViewTrainings";
            this.TableViewTrainings.ReadOnly = true;
            this.TableViewTrainings.RowHeadersVisible = false;
            this.TableViewTrainings.RowHeadersWidth = 10;
            this.TableViewTrainings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableViewTrainings.ShowCellToolTips = false;
            this.TableViewTrainings.Size = new System.Drawing.Size(428, 313);
            this.TableViewTrainings.TabIndex = 16;
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
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(148, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(188, 33);
            this.LabelHeader.TabIndex = 17;
            this.LabelHeader.Text = "View Trainings";
            // 
            // NavHome
            // 
            this.NavHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHome.Location = new System.Drawing.Point(28, 397);
            this.NavHome.Name = "NavHome";
            this.NavHome.Size = new System.Drawing.Size(89, 48);
            this.NavHome.TabIndex = 30;
            this.NavHome.Text = "Home";
            this.NavHome.UseVisualStyleBackColor = true;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // NavEdit
            // 
            this.NavEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavEdit.Location = new System.Drawing.Point(367, 397);
            this.NavEdit.Name = "NavEdit";
            this.NavEdit.Size = new System.Drawing.Size(89, 48);
            this.NavEdit.TabIndex = 31;
            this.NavEdit.Text = "Edit";
            this.NavEdit.UseVisualStyleBackColor = true;
            this.NavEdit.Click += new System.EventHandler(this.NavEdit_Click);
            // 
            // ViewTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 465);
            this.Controls.Add(this.NavEdit);
            this.Controls.Add(this.NavHome);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.TableViewTrainings);
            this.Name = "ViewTraining";
            this.Text = "ViewTraining";
            ((System.ComponentModel.ISupportInitialize)(this.TableViewTrainings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableViewTrainings;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrainingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStartTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFinishTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button NavHome;
        private System.Windows.Forms.Button NavEdit;
    }
}