namespace AIUB_LOST_AND_FOUND
{
    partial class MatchConfirmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchConfirmForm));
            this.pnlSelectedReport = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblUniqueMark = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirmMatch = new System.Windows.Forms.Button();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.pnlSelectedReport.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelectedReport
            // 
            this.pnlSelectedReport.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlSelectedReport.Controls.Add(this.lblLocation);
            this.pnlSelectedReport.Controls.Add(this.lblUniqueMark);
            this.pnlSelectedReport.Controls.Add(this.lblColor);
            this.pnlSelectedReport.Controls.Add(this.lblCategory);
            this.pnlSelectedReport.Controls.Add(this.lblItemName);
            this.pnlSelectedReport.Controls.Add(this.lblType);
            this.pnlSelectedReport.Controls.Add(this.lblTitle);
            this.pnlSelectedReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectedReport.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectedReport.Name = "pnlSelectedReport";
            this.pnlSelectedReport.Size = new System.Drawing.Size(984, 142);
            this.pnlSelectedReport.TabIndex = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(723, 27);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(61, 16);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location:";
            // 
            // lblUniqueMark
            // 
            this.lblUniqueMark.AutoSize = true;
            this.lblUniqueMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniqueMark.Location = new System.Drawing.Point(723, 77);
            this.lblUniqueMark.Name = "lblUniqueMark";
            this.lblUniqueMark.Size = new System.Drawing.Size(86, 16);
            this.lblUniqueMark.TabIndex = 6;
            this.lblUniqueMark.Text = "Unique Mark:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(459, 89);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(42, 16);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(230, 89);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 16);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(230, 37);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(35, 16);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "Item:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(459, 37);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(42, 16);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Selected Report";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlActions.Controls.Add(this.btnBack);
            this.pnlActions.Controls.Add(this.btnConfirmMatch);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 461);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(984, 100);
            this.pnlActions.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(349, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<<Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirmMatch
            // 
            this.btnConfirmMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmMatch.Location = new System.Drawing.Point(521, 28);
            this.btnConfirmMatch.Name = "btnConfirmMatch";
            this.btnConfirmMatch.Size = new System.Drawing.Size(135, 32);
            this.btnConfirmMatch.TabIndex = 0;
            this.btnConfirmMatch.Text = "Confirm Match";
            this.btnConfirmMatch.UseVisualStyleBackColor = true;
            this.btnConfirmMatch.Click += new System.EventHandler(this.btnConfirmMatch_Click);
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AllowUserToResizeRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatches.Location = new System.Drawing.Point(0, 142);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(984, 319);
            this.dgvMatches.TabIndex = 3;
            this.dgvMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatches_CellClick);
            this.dgvMatches.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMatches_DataBindingComplete);
            // 
            // MatchConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlSelectedReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatchConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match Confirmation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatchConfirmForm_FormClosing);
            this.Load += new System.EventHandler(this.MatchConfirmForm_Load);
            this.pnlSelectedReport.ResumeLayout(false);
            this.pnlSelectedReport.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSelectedReport;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblUniqueMark;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirmMatch;
        private System.Windows.Forms.DataGridView dgvMatches;
    }
}