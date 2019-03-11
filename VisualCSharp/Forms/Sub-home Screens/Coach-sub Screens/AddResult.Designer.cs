namespace VisualCSharp.Forms.Sub_home_Screens.Coach_sub_Screens
{
    partial class AddResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddResultForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblAddResult = new System.Windows.Forms.Label();
            this.grpbxOpponentStats = new System.Windows.Forms.GroupBox();
            this.txtOpponentMajors = new System.Windows.Forms.TextBox();
            this.LblOpponentMajors = new System.Windows.Forms.Label();
            this.LblOpponentGoals = new System.Windows.Forms.Label();
            this.txtOpponentGoals = new System.Windows.Forms.TextBox();
            this.TableAddResult = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlayed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMajors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOther = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbxOpponentStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableAddResult)).BeginInit();
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
            // LblAddResult
            // 
            this.LblAddResult.AutoSize = true;
            this.LblAddResult.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddResult.Location = new System.Drawing.Point(152, 183);
            this.LblAddResult.Name = "LblAddResult";
            this.LblAddResult.Size = new System.Drawing.Size(181, 42);
            this.LblAddResult.TabIndex = 11;
            this.LblAddResult.Text = "Add Result";
            // 
            // grpbxOpponentStats
            // 
            this.grpbxOpponentStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpbxOpponentStats.Controls.Add(this.txtOpponentMajors);
            this.grpbxOpponentStats.Controls.Add(this.LblOpponentMajors);
            this.grpbxOpponentStats.Controls.Add(this.LblOpponentGoals);
            this.grpbxOpponentStats.Controls.Add(this.txtOpponentGoals);
            this.grpbxOpponentStats.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxOpponentStats.Location = new System.Drawing.Point(131, 502);
            this.grpbxOpponentStats.Name = "grpbxOpponentStats";
            this.grpbxOpponentStats.Size = new System.Drawing.Size(228, 71);
            this.grpbxOpponentStats.TabIndex = 22;
            this.grpbxOpponentStats.TabStop = false;
            // 
            // txtOpponentMajors
            // 
            this.txtOpponentMajors.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpponentMajors.Location = new System.Drawing.Point(170, 37);
            this.txtOpponentMajors.MaxLength = 10;
            this.txtOpponentMajors.Name = "txtOpponentMajors";
            this.txtOpponentMajors.Size = new System.Drawing.Size(46, 25);
            this.txtOpponentMajors.TabIndex = 19;
            // 
            // LblOpponentMajors
            // 
            this.LblOpponentMajors.AutoSize = true;
            this.LblOpponentMajors.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOpponentMajors.Location = new System.Drawing.Point(111, 37);
            this.LblOpponentMajors.Name = "LblOpponentMajors";
            this.LblOpponentMajors.Size = new System.Drawing.Size(53, 19);
            this.LblOpponentMajors.TabIndex = 18;
            this.LblOpponentMajors.Text = "Majors";
            // 
            // LblOpponentGoals
            // 
            this.LblOpponentGoals.AutoSize = true;
            this.LblOpponentGoals.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOpponentGoals.Location = new System.Drawing.Point(9, 38);
            this.LblOpponentGoals.Name = "LblOpponentGoals";
            this.LblOpponentGoals.Size = new System.Drawing.Size(44, 19);
            this.LblOpponentGoals.TabIndex = 16;
            this.LblOpponentGoals.Text = "Goals";
            // 
            // txtOpponentGoals
            // 
            this.txtOpponentGoals.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpponentGoals.Location = new System.Drawing.Point(59, 37);
            this.txtOpponentGoals.MaxLength = 10;
            this.txtOpponentGoals.Name = "txtOpponentGoals";
            this.txtOpponentGoals.Size = new System.Drawing.Size(46, 25);
            this.txtOpponentGoals.TabIndex = 15;
            // 
            // TableAddResult
            // 
            this.TableAddResult.AllowUserToAddRows = false;
            this.TableAddResult.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableAddResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableAddResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableAddResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColPlayerName,
            this.ColPlayed,
            this.ColGoals,
            this.ColMajors,
            this.ColOther});
            this.TableAddResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.TableAddResult.Location = new System.Drawing.Point(12, 245);
            this.TableAddResult.Name = "TableAddResult";
            this.TableAddResult.RowHeadersVisible = false;
            this.TableAddResult.RowHeadersWidth = 10;
            this.TableAddResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TableAddResult.ShowCellToolTips = false;
            this.TableAddResult.Size = new System.Drawing.Size(460, 251);
            this.TableAddResult.TabIndex = 23;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 33;
            // 
            // ColPlayerName
            // 
            this.ColPlayerName.HeaderText = "Player";
            this.ColPlayerName.Name = "ColPlayerName";
            this.ColPlayerName.ReadOnly = true;
            this.ColPlayerName.Width = 120;
            // 
            // ColPlayed
            // 
            this.ColPlayed.HeaderText = "Played?";
            this.ColPlayed.Name = "ColPlayed";
            this.ColPlayed.Width = 65;
            // 
            // ColGoals
            // 
            this.ColGoals.HeaderText = "Goals";
            this.ColGoals.Name = "ColGoals";
            this.ColGoals.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColGoals.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColGoals.Width = 55;
            // 
            // ColMajors
            // 
            this.ColMajors.HeaderText = "Major Fouls";
            this.ColMajors.Name = "ColMajors";
            this.ColMajors.Width = 94;
            // 
            // ColOther
            // 
            this.ColOther.HeaderText = "Other";
            this.ColOther.Items.AddRange(new object[] {
            "None",
            "Brutality",
            "Wrapped",
            "Yellow Card",
            "Red Card"});
            this.ColOther.Name = "ColOther";
            this.ColOther.Width = 90;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(12, 532);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(113, 42);
            this.BtnBack.TabIndex = 24;
            this.BtnBack.Text = "Cancel";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(365, 532);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(107, 42);
            this.BtnSave.TabIndex = 25;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // AddResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 587);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TableAddResult);
            this.Controls.Add(this.grpbxOpponentStats);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblAddResult);
            this.Name = "AddResultForm";
            this.Text = "Add Result";
            this.Load += new System.EventHandler(this.AddResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbxOpponentStats.ResumeLayout(false);
            this.grpbxOpponentStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableAddResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblAddResult;
        private System.Windows.Forms.GroupBox grpbxOpponentStats;
        private System.Windows.Forms.TextBox txtOpponentGoals;
        private System.Windows.Forms.Label LblOpponentGoals;
        private System.Windows.Forms.Label LblOpponentMajors;
        private System.Windows.Forms.DataGridView TableAddResult;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox txtOpponentMajors;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlayerName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMajors;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColOther;
        private System.Windows.Forms.Button BtnSave;
    }
}