namespace AIUB_LOST_AND_FOUND
{
    partial class StaffDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            this.pnlStuffHeader = new System.Windows.Forms.Panel();
            this.lblAdminDashTitle = new System.Windows.Forms.Label();
            this.btnLogoutStaff = new System.Windows.Forms.Button();
            this.pnlStaffOperations = new System.Windows.Forms.Panel();
            this.btnReportManage = new System.Windows.Forms.Button();
            this.lblDashBoardContenttitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStaffMatchView = new System.Windows.Forms.DataGridView();
            this.lblStaffFilter = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtStaffFilter = new System.Windows.Forms.TextBox();
            this.pnlStuffHeader.SuspendLayout();
            this.pnlStaffOperations.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMatchView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStuffHeader
            // 
            this.pnlStuffHeader.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlStuffHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStuffHeader.Controls.Add(this.lblAdminDashTitle);
            this.pnlStuffHeader.Controls.Add(this.btnLogoutStaff);
            this.pnlStuffHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStuffHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlStuffHeader.Name = "pnlStuffHeader";
            this.pnlStuffHeader.Size = new System.Drawing.Size(1247, 100);
            this.pnlStuffHeader.TabIndex = 0;
            // 
            // lblAdminDashTitle
            // 
            this.lblAdminDashTitle.AutoSize = true;
            this.lblAdminDashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDashTitle.Location = new System.Drawing.Point(431, 41);
            this.lblAdminDashTitle.Name = "lblAdminDashTitle";
            this.lblAdminDashTitle.Size = new System.Drawing.Size(417, 25);
            this.lblAdminDashTitle.TabIndex = 4;
            this.lblAdminDashTitle.Text = "WELCOME TO EMPLOYEE DASHBOARD";
            // 
            // btnLogoutStaff
            // 
            this.btnLogoutStaff.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutStaff.Location = new System.Drawing.Point(58, 33);
            this.btnLogoutStaff.Name = "btnLogoutStaff";
            this.btnLogoutStaff.Size = new System.Drawing.Size(100, 33);
            this.btnLogoutStaff.TabIndex = 3;
            this.btnLogoutStaff.Text = "Logout";
            this.btnLogoutStaff.UseVisualStyleBackColor = true;
            this.btnLogoutStaff.Click += new System.EventHandler(this.btnLogoutStaff_Click);
            // 
            // pnlStaffOperations
            // 
            this.pnlStaffOperations.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlStaffOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStaffOperations.Controls.Add(this.btnReportManage);
            this.pnlStaffOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStaffOperations.Location = new System.Drawing.Point(0, 429);
            this.pnlStaffOperations.Name = "pnlStaffOperations";
            this.pnlStaffOperations.Size = new System.Drawing.Size(1247, 100);
            this.pnlStaffOperations.TabIndex = 1;
            // 
            // btnReportManage
            // 
            this.btnReportManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportManage.Location = new System.Drawing.Point(522, 30);
            this.btnReportManage.Name = "btnReportManage";
            this.btnReportManage.Size = new System.Drawing.Size(227, 42);
            this.btnReportManage.TabIndex = 0;
            this.btnReportManage.Text = "Report Management";
            this.btnReportManage.UseVisualStyleBackColor = true;
            this.btnReportManage.Click += new System.EventHandler(this.btnReportManage_Click);
            // 
            // lblDashBoardContenttitle
            // 
            this.lblDashBoardContenttitle.AutoSize = true;
            this.lblDashBoardContenttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBoardContenttitle.Location = new System.Drawing.Point(544, 3);
            this.lblDashBoardContenttitle.Name = "lblDashBoardContenttitle";
            this.lblDashBoardContenttitle.Size = new System.Drawing.Size(168, 25);
            this.lblDashBoardContenttitle.TabIndex = 2;
            this.lblDashBoardContenttitle.Text = "Matched History";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStaffFilter);
            this.panel1.Controls.Add(this.lblStaffFilter);
            this.panel1.Controls.Add(this.lblDashBoardContenttitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 38);
            this.panel1.TabIndex = 3;
            // 
            // dgvStaffMatchView
            // 
            this.dgvStaffMatchView.AllowUserToAddRows = false;
            this.dgvStaffMatchView.AllowUserToDeleteRows = false;
            this.dgvStaffMatchView.AllowUserToResizeRows = false;
            this.dgvStaffMatchView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffMatchView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffMatchView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaffMatchView.Location = new System.Drawing.Point(0, 138);
            this.dgvStaffMatchView.Name = "dgvStaffMatchView";
            this.dgvStaffMatchView.RowHeadersVisible = false;
            this.dgvStaffMatchView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffMatchView.Size = new System.Drawing.Size(1247, 291);
            this.dgvStaffMatchView.TabIndex = 4;
            this.dgvStaffMatchView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStaffMatchView_DataBindingComplete);
            // 
            // lblStaffFilter
            // 
            this.lblStaffFilter.AutoSize = true;
            this.lblStaffFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffFilter.Location = new System.Drawing.Point(770, 10);
            this.lblStaffFilter.Name = "lblStaffFilter";
            this.lblStaffFilter.Size = new System.Drawing.Size(204, 16);
            this.lblStaffFilter.TabIndex = 5;
            this.lblStaffFilter.Text = "Search By Lost Reporter Number\r\n";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtStaffFilter
            // 
            this.txtStaffFilter.Location = new System.Drawing.Point(980, 9);
            this.txtStaffFilter.Name = "txtStaffFilter";
            this.txtStaffFilter.Size = new System.Drawing.Size(151, 20);
            this.txtStaffFilter.TabIndex = 6;
            this.txtStaffFilter.TextChanged += new System.EventHandler(this.txtStaffFilter_TextChanged);
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 529);
            this.Controls.Add(this.dgvStaffMatchView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlStaffOperations);
            this.Controls.Add(this.pnlStuffHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffDashboard_FormClosing);
            this.Load += new System.EventHandler(this.StaffDashboard_Load);
            this.pnlStuffHeader.ResumeLayout(false);
            this.pnlStuffHeader.PerformLayout();
            this.pnlStaffOperations.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMatchView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStuffHeader;
        private System.Windows.Forms.Panel pnlStaffOperations;
        private System.Windows.Forms.Label lblAdminDashTitle;
        private System.Windows.Forms.Button btnLogoutStaff;
        private System.Windows.Forms.Button btnReportManage;
        private System.Windows.Forms.Label lblDashBoardContenttitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStaffMatchView;
        private System.Windows.Forms.TextBox txtStaffFilter;
        private System.Windows.Forms.Label lblStaffFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}