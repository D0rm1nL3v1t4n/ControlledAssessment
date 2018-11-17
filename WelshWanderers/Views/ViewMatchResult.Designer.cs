namespace WelshWanderers
{
    partial class ViewMatchResult
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
            this.TableMatchResult = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlayed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMajors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOther = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NavBack = new System.Windows.Forms.Button();
            this.LabelOpponentGoals = new System.Windows.Forms.Label();
            this.LabelOpponentMajorFouls = new System.Windows.Forms.Label();
            this.InputOpponentGoals = new System.Windows.Forms.TextBox();
            this.InputOpponentMajorFouls = new System.Windows.Forms.TextBox();
            this.LabelOpponent = new System.Windows.Forms.Label();
            this.InputOpponent = new System.Windows.Forms.TextBox();
            this.LabelWanderersGoals = new System.Windows.Forms.Label();
            this.LabelWanderersMajors = new System.Windows.Forms.Label();
            this.InputWanderersGoals = new System.Windows.Forms.TextBox();
            this.InputWanderersMajors = new System.Windows.Forms.TextBox();
            this.EventEditMatchResult = new System.Windows.Forms.Button();
            this.EventSave = new System.Windows.Forms.Button();
            this.EventCancelEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableMatchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(233, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(167, 33);
            this.LabelHeader.TabIndex = 7;
            this.LabelHeader.Text = "Match Result";
            // 
            // TableMatchResult
            // 
            this.TableMatchResult.AllowUserToAddRows = false;
            this.TableMatchResult.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableMatchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableMatchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMatchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColPlayerName,
            this.ColPlayed,
            this.ColGoals,
            this.ColMajors,
            this.ColOther});
            this.TableMatchResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.TableMatchResult.Enabled = false;
            this.TableMatchResult.Location = new System.Drawing.Point(50, 195);
            this.TableMatchResult.Name = "TableMatchResult";
            this.TableMatchResult.RowHeadersVisible = false;
            this.TableMatchResult.RowHeadersWidth = 10;
            this.TableMatchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TableMatchResult.ShowCellToolTips = false;
            this.TableMatchResult.Size = new System.Drawing.Size(533, 251);
            this.TableMatchResult.TabIndex = 25;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 40;
            // 
            // ColPlayerName
            // 
            this.ColPlayerName.HeaderText = "Player";
            this.ColPlayerName.Name = "ColPlayerName";
            this.ColPlayerName.ReadOnly = true;
            this.ColPlayerName.Width = 130;
            // 
            // ColPlayed
            // 
            this.ColPlayed.HeaderText = "Played?";
            this.ColPlayed.Name = "ColPlayed";
            this.ColPlayed.Width = 80;
            // 
            // ColGoals
            // 
            this.ColGoals.HeaderText = "Goals";
            this.ColGoals.Name = "ColGoals";
            this.ColGoals.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColGoals.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColGoals.Width = 80;
            // 
            // ColMajors
            // 
            this.ColMajors.HeaderText = "Major Fouls";
            this.ColMajors.Name = "ColMajors";
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
            // 
            // NavBack
            // 
            this.NavBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBack.Location = new System.Drawing.Point(49, 452);
            this.NavBack.Name = "NavBack";
            this.NavBack.Size = new System.Drawing.Size(89, 48);
            this.NavBack.TabIndex = 30;
            this.NavBack.Text = "Back";
            this.NavBack.UseVisualStyleBackColor = true;
            // 
            // LabelOpponentGoals
            // 
            this.LabelOpponentGoals.AutoSize = true;
            this.LabelOpponentGoals.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpponentGoals.Location = new System.Drawing.Point(373, 126);
            this.LabelOpponentGoals.Name = "LabelOpponentGoals";
            this.LabelOpponentGoals.Size = new System.Drawing.Size(123, 19);
            this.LabelOpponentGoals.TabIndex = 34;
            this.LabelOpponentGoals.Text = "Opponent Goals";
            // 
            // LabelOpponentMajorFouls
            // 
            this.LabelOpponentMajorFouls.AutoSize = true;
            this.LabelOpponentMajorFouls.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpponentMajorFouls.Location = new System.Drawing.Point(330, 159);
            this.LabelOpponentMajorFouls.Name = "LabelOpponentMajorFouls";
            this.LabelOpponentMajorFouls.Size = new System.Drawing.Size(166, 19);
            this.LabelOpponentMajorFouls.TabIndex = 33;
            this.LabelOpponentMajorFouls.Text = "Opponent Major Fouls";
            // 
            // InputOpponentGoals
            // 
            this.InputOpponentGoals.Enabled = false;
            this.InputOpponentGoals.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOpponentGoals.Location = new System.Drawing.Point(502, 123);
            this.InputOpponentGoals.Name = "InputOpponentGoals";
            this.InputOpponentGoals.Size = new System.Drawing.Size(81, 27);
            this.InputOpponentGoals.TabIndex = 32;
            // 
            // InputOpponentMajorFouls
            // 
            this.InputOpponentMajorFouls.Enabled = false;
            this.InputOpponentMajorFouls.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOpponentMajorFouls.Location = new System.Drawing.Point(502, 156);
            this.InputOpponentMajorFouls.Name = "InputOpponentMajorFouls";
            this.InputOpponentMajorFouls.Size = new System.Drawing.Size(81, 27);
            this.InputOpponentMajorFouls.TabIndex = 31;
            // 
            // LabelOpponent
            // 
            this.LabelOpponent.AutoSize = true;
            this.LabelOpponent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpponent.Location = new System.Drawing.Point(372, 93);
            this.LabelOpponent.Name = "LabelOpponent";
            this.LabelOpponent.Size = new System.Drawing.Size(79, 19);
            this.LabelOpponent.TabIndex = 35;
            this.LabelOpponent.Text = "Opponent";
            // 
            // InputOpponent
            // 
            this.InputOpponent.Enabled = false;
            this.InputOpponent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOpponent.Location = new System.Drawing.Point(457, 90);
            this.InputOpponent.Name = "InputOpponent";
            this.InputOpponent.Size = new System.Drawing.Size(126, 27);
            this.InputOpponent.TabIndex = 36;
            // 
            // LabelWanderersGoals
            // 
            this.LabelWanderersGoals.AutoSize = true;
            this.LabelWanderersGoals.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWanderersGoals.Location = new System.Drawing.Point(89, 126);
            this.LabelWanderersGoals.Name = "LabelWanderersGoals";
            this.LabelWanderersGoals.Size = new System.Drawing.Size(128, 19);
            this.LabelWanderersGoals.TabIndex = 42;
            this.LabelWanderersGoals.Text = "Wanderers Goals";
            // 
            // LabelWanderersMajors
            // 
            this.LabelWanderersMajors.AutoSize = true;
            this.LabelWanderersMajors.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWanderersMajors.Location = new System.Drawing.Point(46, 159);
            this.LabelWanderersMajors.Name = "LabelWanderersMajors";
            this.LabelWanderersMajors.Size = new System.Drawing.Size(171, 19);
            this.LabelWanderersMajors.TabIndex = 41;
            this.LabelWanderersMajors.Text = "Wanderers Major Fouls";
            // 
            // InputWanderersGoals
            // 
            this.InputWanderersGoals.Enabled = false;
            this.InputWanderersGoals.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputWanderersGoals.Location = new System.Drawing.Point(223, 123);
            this.InputWanderersGoals.Name = "InputWanderersGoals";
            this.InputWanderersGoals.Size = new System.Drawing.Size(81, 27);
            this.InputWanderersGoals.TabIndex = 40;
            // 
            // InputWanderersMajors
            // 
            this.InputWanderersMajors.Enabled = false;
            this.InputWanderersMajors.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputWanderersMajors.Location = new System.Drawing.Point(223, 156);
            this.InputWanderersMajors.Name = "InputWanderersMajors";
            this.InputWanderersMajors.Size = new System.Drawing.Size(81, 27);
            this.InputWanderersMajors.TabIndex = 39;
            // 
            // EventEditMatchResult
            // 
            this.EventEditMatchResult.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventEditMatchResult.Location = new System.Drawing.Point(494, 452);
            this.EventEditMatchResult.Name = "EventEditMatchResult";
            this.EventEditMatchResult.Size = new System.Drawing.Size(89, 48);
            this.EventEditMatchResult.TabIndex = 43;
            this.EventEditMatchResult.Text = "Edit";
            this.EventEditMatchResult.UseVisualStyleBackColor = true;
            this.EventEditMatchResult.Click += new System.EventHandler(this.EventEditMatchResult_Click);
            // 
            // EventSave
            // 
            this.EventSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventSave.Location = new System.Drawing.Point(494, 452);
            this.EventSave.Name = "EventSave";
            this.EventSave.Size = new System.Drawing.Size(89, 48);
            this.EventSave.TabIndex = 44;
            this.EventSave.Text = "Save";
            this.EventSave.UseVisualStyleBackColor = true;
            // 
            // EventCancelEdit
            // 
            this.EventCancelEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventCancelEdit.Location = new System.Drawing.Point(399, 452);
            this.EventCancelEdit.Name = "EventCancelEdit";
            this.EventCancelEdit.Size = new System.Drawing.Size(89, 48);
            this.EventCancelEdit.TabIndex = 45;
            this.EventCancelEdit.Text = "Cancel Edit";
            this.EventCancelEdit.UseVisualStyleBackColor = true;
            // 
            // ViewMatchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 516);
            this.Controls.Add(this.EventCancelEdit);
            this.Controls.Add(this.EventSave);
            this.Controls.Add(this.EventEditMatchResult);
            this.Controls.Add(this.LabelWanderersGoals);
            this.Controls.Add(this.LabelWanderersMajors);
            this.Controls.Add(this.InputWanderersGoals);
            this.Controls.Add(this.InputWanderersMajors);
            this.Controls.Add(this.InputOpponent);
            this.Controls.Add(this.LabelOpponent);
            this.Controls.Add(this.LabelOpponentGoals);
            this.Controls.Add(this.LabelOpponentMajorFouls);
            this.Controls.Add(this.InputOpponentGoals);
            this.Controls.Add(this.InputOpponentMajorFouls);
            this.Controls.Add(this.NavBack);
            this.Controls.Add(this.TableMatchResult);
            this.Controls.Add(this.LabelHeader);
            this.Name = "ViewMatchResult";
            this.Text = "ViewMatchResult";
            this.Load += new System.EventHandler(this.ViewMatchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableMatchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView TableMatchResult;
        private System.Windows.Forms.Button NavBack;
        private System.Windows.Forms.Label LabelOpponentGoals;
        private System.Windows.Forms.Label LabelOpponentMajorFouls;
        private System.Windows.Forms.TextBox InputOpponentGoals;
        private System.Windows.Forms.TextBox InputOpponentMajorFouls;
        private System.Windows.Forms.Label LabelOpponent;
        private System.Windows.Forms.TextBox InputOpponent;
        private System.Windows.Forms.Label LabelWanderersGoals;
        private System.Windows.Forms.Label LabelWanderersMajors;
        private System.Windows.Forms.TextBox InputWanderersGoals;
        private System.Windows.Forms.TextBox InputWanderersMajors;
        private System.Windows.Forms.Button EventEditMatchResult;
        private System.Windows.Forms.Button EventSave;
        private System.Windows.Forms.Button EventCancelEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlayerName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMajors;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColOther;
    }
}