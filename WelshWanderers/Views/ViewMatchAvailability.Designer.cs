namespace WelshWanderers.Views
{
    partial class ViewMatchAvailability
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
            this.LabelHeader = new System.Windows.Forms.Label();
            this.TableMatchAvailability = new System.Windows.Forms.DataGridView();
            this.NavBack = new System.Windows.Forms.Button();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColResponded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColAvailability = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableMatchAvailability)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(95, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(282, 33);
            this.LabelHeader.TabIndex = 8;
            this.LabelHeader.Text = "View Match Availability";
            // 
            // TableMatchAvailability
            // 
            this.TableMatchAvailability.AllowUserToAddRows = false;
            this.TableMatchAvailability.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableMatchAvailability.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableMatchAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMatchAvailability.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColFirstName,
            this.ColLastName,
            this.ColResponded,
            this.ColAvailability});
            this.TableMatchAvailability.Location = new System.Drawing.Point(34, 83);
            this.TableMatchAvailability.MultiSelect = false;
            this.TableMatchAvailability.Name = "TableMatchAvailability";
            this.TableMatchAvailability.ReadOnly = true;
            this.TableMatchAvailability.RowHeadersVisible = false;
            this.TableMatchAvailability.RowHeadersWidth = 10;
            this.TableMatchAvailability.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableMatchAvailability.ShowCellToolTips = false;
            this.TableMatchAvailability.Size = new System.Drawing.Size(404, 248);
            this.TableMatchAvailability.TabIndex = 18;
            // 
            // NavBack
            // 
            this.NavBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBack.Location = new System.Drawing.Point(34, 337);
            this.NavBack.Name = "NavBack";
            this.NavBack.Size = new System.Drawing.Size(89, 48);
            this.NavBack.TabIndex = 32;
            this.NavBack.Text = "Back";
            this.NavBack.UseVisualStyleBackColor = true;
            this.NavBack.Click += new System.EventHandler(this.NavBack_Click);
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColID.Visible = false;
            this.ColID.Width = 35;
            // 
            // ColFirstName
            // 
            this.ColFirstName.HeaderText = "First Name";
            this.ColFirstName.Name = "ColFirstName";
            this.ColFirstName.ReadOnly = true;
            // 
            // ColLastName
            // 
            this.ColLastName.HeaderText = "Last Name";
            this.ColLastName.Name = "ColLastName";
            this.ColLastName.ReadOnly = true;
            // 
            // ColResponded
            // 
            this.ColResponded.HeaderText = "Responded?";
            this.ColResponded.Name = "ColResponded";
            this.ColResponded.ReadOnly = true;
            // 
            // ColAvailability
            // 
            this.ColAvailability.HeaderText = "Available";
            this.ColAvailability.Name = "ColAvailability";
            this.ColAvailability.ReadOnly = true;
            this.ColAvailability.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ViewMatchAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 410);
            this.Controls.Add(this.NavBack);
            this.Controls.Add(this.TableMatchAvailability);
            this.Controls.Add(this.LabelHeader);
            this.Name = "ViewMatchAvailability";
            this.Text = "ViewMatchAvailability";
            this.Load += new System.EventHandler(this.ViewMatchAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableMatchAvailability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView TableMatchAvailability;
        private System.Windows.Forms.Button NavBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColResponded;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColAvailability;
    }
}