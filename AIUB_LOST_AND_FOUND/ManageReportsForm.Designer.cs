namespace AIUB_LOST_AND_FOUND
{
    partial class ManageReportsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageReportsForm));
            this.pnlReportManagePage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbReportStatus = new System.Windows.Forms.ComboBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.txtSearchStudentId = new System.Windows.Forms.TextBox();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblStsatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReporterPhn = new System.Windows.Forms.Label();
            this.lblSchRptrName = new System.Windows.Forms.Label();
            this.lblReportSearch = new System.Windows.Forms.Label();
            this.pnlReportManageAsideRight = new System.Windows.Forms.Panel();
            this.pnlReportManageAsideLeft = new System.Windows.Forms.Panel();
            this.pnlReportManageOperation = new System.Windows.Forms.Panel();
            this.btnPossibleMatch = new System.Windows.Forms.Button();
            this.btnDeleteReport = new System.Windows.Forms.Button();
            this.btnEditReport = new System.Windows.Forms.Button();
            this.btnAddReport = new System.Windows.Forms.Button();
            this.pnlReportManageHeader = new System.Windows.Forms.Panel();
            this.lblReportManageHeaderTitle = new System.Windows.Forms.Label();
            this.btnReportManageBack = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlReportManagePage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlReportManageOperation.SuspendLayout();
            this.pnlReportManageHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReportManagePage
            // 
            this.pnlReportManagePage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlReportManagePage.Controls.Add(this.panel2);
            this.pnlReportManagePage.Controls.Add(this.panel1);
            this.pnlReportManagePage.Controls.Add(this.pnlReportManageAsideRight);
            this.pnlReportManagePage.Controls.Add(this.pnlReportManageAsideLeft);
            this.pnlReportManagePage.Controls.Add(this.pnlReportManageOperation);
            this.pnlReportManagePage.Controls.Add(this.pnlReportManageHeader);
            this.pnlReportManagePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReportManagePage.Location = new System.Drawing.Point(0, 0);
            this.pnlReportManagePage.Name = "pnlReportManagePage";
            this.pnlReportManagePage.Size = new System.Drawing.Size(1251, 492);
            this.pnlReportManagePage.TabIndex = 1;
            this.pnlReportManagePage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.dgvReports);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(28, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 321);
            this.panel2.TabIndex = 5;
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.Location = new System.Drawing.Point(0, 0);
            this.dgvReports.MultiSelect = false;
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReports.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(1197, 321);
            this.dgvReports.TabIndex = 0;
            this.dgvReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellClick);
            this.dgvReports.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvReports_DataBindingComplete);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(950, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.cmbReportStatus);
            this.panel1.Controls.Add(this.btnClearSearch);
            this.panel1.Controls.Add(this.txtSearchStudentId);
            this.panel1.Controls.Add(this.txtSearchPhone);
            this.panel1.Controls.Add(this.txtSearchName);
            this.panel1.Controls.Add(this.lblStsatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblReporterPhn);
            this.panel1.Controls.Add(this.lblSchRptrName);
            this.panel1.Controls.Add(this.lblReportSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(28, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 45);
            this.panel1.TabIndex = 4;
            // 
            // cmbReportStatus
            // 
            this.cmbReportStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportStatus.FormattingEnabled = true;
            this.cmbReportStatus.Location = new System.Drawing.Point(952, 11);
            this.cmbReportStatus.Name = "cmbReportStatus";
            this.cmbReportStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbReportStatus.TabIndex = 12;
            this.cmbReportStatus.SelectedIndexChanged += new System.EventHandler(this.cmbReportStatus_SelectedIndexChanged);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.Location = new System.Drawing.Point(1093, 8);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(75, 23);
            this.btnClearSearch.TabIndex = 11;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtSearchStudentId
            // 
            this.txtSearchStudentId.Location = new System.Drawing.Point(717, 12);
            this.txtSearchStudentId.Name = "txtSearchStudentId";
            this.txtSearchStudentId.Size = new System.Drawing.Size(149, 20);
            this.txtSearchStudentId.TabIndex = 8;
            this.txtSearchStudentId.TextChanged += new System.EventHandler(this.txtSearchStudentId_TextChanged);
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.Location = new System.Drawing.Point(492, 12);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(130, 20);
            this.txtSearchPhone.TabIndex = 7;
            this.txtSearchPhone.TextChanged += new System.EventHandler(this.txtSearchPhone_TextChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(222, 11);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(140, 20);
            this.txtSearchName.TabIndex = 6;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // lblStsatus
            // 
            this.lblStsatus.AutoSize = true;
            this.lblStsatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStsatus.Location = new System.Drawing.Point(905, 15);
            this.lblStsatus.Name = "lblStsatus";
            this.lblStsatus.Size = new System.Drawing.Size(41, 15);
            this.lblStsatus.TabIndex = 4;
            this.lblStsatus.Text = "Status";
            this.lblStsatus.Click += new System.EventHandler(this.lblStsatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(641, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reporter ID";
            // 
            // lblReporterPhn
            // 
            this.lblReporterPhn.AutoSize = true;
            this.lblReporterPhn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporterPhn.Location = new System.Drawing.Point(392, 13);
            this.lblReporterPhn.Name = "lblReporterPhn";
            this.lblReporterPhn.Size = new System.Drawing.Size(94, 15);
            this.lblReporterPhn.TabIndex = 2;
            this.lblReporterPhn.Text = "Reporter Phone";
            // 
            // lblSchRptrName
            // 
            this.lblSchRptrName.AutoSize = true;
            this.lblSchRptrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchRptrName.Location = new System.Drawing.Point(124, 14);
            this.lblSchRptrName.Name = "lblSchRptrName";
            this.lblSchRptrName.Size = new System.Drawing.Size(92, 15);
            this.lblSchRptrName.TabIndex = 1;
            this.lblSchRptrName.Text = "Reporter Name";
            // 
            // lblReportSearch
            // 
            this.lblReportSearch.AutoSize = true;
            this.lblReportSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSearch.Location = new System.Drawing.Point(21, 13);
            this.lblReportSearch.Name = "lblReportSearch";
            this.lblReportSearch.Size = new System.Drawing.Size(90, 18);
            this.lblReportSearch.TabIndex = 0;
            this.lblReportSearch.Text = "Search By:";
            // 
            // pnlReportManageAsideRight
            // 
            this.pnlReportManageAsideRight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlReportManageAsideRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlReportManageAsideRight.Location = new System.Drawing.Point(1225, 56);
            this.pnlReportManageAsideRight.Name = "pnlReportManageAsideRight";
            this.pnlReportManageAsideRight.Size = new System.Drawing.Size(26, 366);
            this.pnlReportManageAsideRight.TabIndex = 3;
            // 
            // pnlReportManageAsideLeft
            // 
            this.pnlReportManageAsideLeft.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlReportManageAsideLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlReportManageAsideLeft.Location = new System.Drawing.Point(0, 56);
            this.pnlReportManageAsideLeft.Name = "pnlReportManageAsideLeft";
            this.pnlReportManageAsideLeft.Size = new System.Drawing.Size(28, 366);
            this.pnlReportManageAsideLeft.TabIndex = 2;
            // 
            // pnlReportManageOperation
            // 
            this.pnlReportManageOperation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlReportManageOperation.Controls.Add(this.btnPossibleMatch);
            this.pnlReportManageOperation.Controls.Add(this.btnDeleteReport);
            this.pnlReportManageOperation.Controls.Add(this.btnEditReport);
            this.pnlReportManageOperation.Controls.Add(this.btnAddReport);
            this.pnlReportManageOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlReportManageOperation.Location = new System.Drawing.Point(0, 422);
            this.pnlReportManageOperation.Name = "pnlReportManageOperation";
            this.pnlReportManageOperation.Size = new System.Drawing.Size(1251, 70);
            this.pnlReportManageOperation.TabIndex = 1;
            // 
            // btnPossibleMatch
            // 
            this.btnPossibleMatch.Location = new System.Drawing.Point(919, 20);
            this.btnPossibleMatch.Name = "btnPossibleMatch";
            this.btnPossibleMatch.Size = new System.Drawing.Size(134, 29);
            this.btnPossibleMatch.TabIndex = 5;
            this.btnPossibleMatch.Text = "Possible Match";
            this.btnPossibleMatch.UseVisualStyleBackColor = true;
            this.btnPossibleMatch.Click += new System.EventHandler(this.btnPossibleMatch_Click);
            // 
            // btnDeleteReport
            // 
            this.btnDeleteReport.Location = new System.Drawing.Point(728, 20);
            this.btnDeleteReport.Name = "btnDeleteReport";
            this.btnDeleteReport.Size = new System.Drawing.Size(134, 29);
            this.btnDeleteReport.TabIndex = 4;
            this.btnDeleteReport.Text = "Delete Report";
            this.btnDeleteReport.UseVisualStyleBackColor = true;
            this.btnDeleteReport.Click += new System.EventHandler(this.btnDeleteReport_Click);
            // 
            // btnEditReport
            // 
            this.btnEditReport.Location = new System.Drawing.Point(534, 20);
            this.btnEditReport.Name = "btnEditReport";
            this.btnEditReport.Size = new System.Drawing.Size(134, 29);
            this.btnEditReport.TabIndex = 3;
            this.btnEditReport.Text = "Edit Report";
            this.btnEditReport.UseVisualStyleBackColor = true;
            this.btnEditReport.Click += new System.EventHandler(this.btnEditReport_Click);
            // 
            // btnAddReport
            // 
            this.btnAddReport.Location = new System.Drawing.Point(322, 20);
            this.btnAddReport.Name = "btnAddReport";
            this.btnAddReport.Size = new System.Drawing.Size(134, 29);
            this.btnAddReport.TabIndex = 2;
            this.btnAddReport.Text = "Create New Report";
            this.btnAddReport.UseVisualStyleBackColor = true;
            this.btnAddReport.Click += new System.EventHandler(this.btnAddReport_Click);
            // 
            // pnlReportManageHeader
            // 
            this.pnlReportManageHeader.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlReportManageHeader.Controls.Add(this.lblReportManageHeaderTitle);
            this.pnlReportManageHeader.Controls.Add(this.btnReportManageBack);
            this.pnlReportManageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportManageHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlReportManageHeader.Name = "pnlReportManageHeader";
            this.pnlReportManageHeader.Size = new System.Drawing.Size(1251, 56);
            this.pnlReportManageHeader.TabIndex = 0;
            // 
            // lblReportManageHeaderTitle
            // 
            this.lblReportManageHeaderTitle.AutoSize = true;
            this.lblReportManageHeaderTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportManageHeaderTitle.Location = new System.Drawing.Point(515, 19);
            this.lblReportManageHeaderTitle.Name = "lblReportManageHeaderTitle";
            this.lblReportManageHeaderTitle.Size = new System.Drawing.Size(251, 25);
            this.lblReportManageHeaderTitle.TabIndex = 1;
            this.lblReportManageHeaderTitle.Text = "Report Management";
            this.lblReportManageHeaderTitle.Click += new System.EventHandler(this.lblReportManageHeaderTitle_Click);
            // 
            // btnReportManageBack
            // 
            this.btnReportManageBack.Location = new System.Drawing.Point(28, 12);
            this.btnReportManageBack.Name = "btnReportManageBack";
            this.btnReportManageBack.Size = new System.Drawing.Size(134, 29);
            this.btnReportManageBack.TabIndex = 0;
            this.btnReportManageBack.Text = "Back to DashBoard";
            this.btnReportManageBack.UseVisualStyleBackColor = true;
            this.btnReportManageBack.Click += new System.EventHandler(this.btnReportManageBack_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ManageReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 492);
            this.Controls.Add(this.pnlReportManagePage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReportsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageReportsForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageReportsForm_Load);
            this.pnlReportManagePage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlReportManageOperation.ResumeLayout(false);
            this.pnlReportManageHeader.ResumeLayout(false);
            this.pnlReportManageHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReportManagePage;
        private System.Windows.Forms.Panel pnlReportManageHeader;
        private System.Windows.Forms.Panel pnlReportManageOperation;
        private System.Windows.Forms.Panel pnlReportManageAsideLeft;
        private System.Windows.Forms.Button btnDeleteReport;
        private System.Windows.Forms.Button btnEditReport;
        private System.Windows.Forms.Button btnAddReport;
        private System.Windows.Forms.Label lblReportManageHeaderTitle;
        private System.Windows.Forms.Button btnReportManageBack;
        private System.Windows.Forms.Panel pnlReportManageAsideRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnPossibleMatch;
        private System.Windows.Forms.Label lblReportSearch;
        private System.Windows.Forms.Label lblSchRptrName;
        private System.Windows.Forms.Label lblReporterPhn;
        private System.Windows.Forms.TextBox txtSearchStudentId;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblStsatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.ComboBox cmbReportStatus;
    }
}