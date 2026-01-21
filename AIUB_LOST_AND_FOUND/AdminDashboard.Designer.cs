namespace AIUB_LOST_AND_FOUND
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.pnlHeaderAdmin = new System.Windows.Forms.Panel();
            this.btnUserManage = new System.Windows.Forms.Button();
            this.lblStaffDashTitle = new System.Windows.Forms.Label();
            this.btnLogoutAdmin = new System.Windows.Forms.Button();
            this.pnlAdminDataBody = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatcHistoryTitle = new System.Windows.Forms.Label();
            this.pnlMatchContent = new System.Windows.Forms.Panel();
            this.dgvMatchedItems = new System.Windows.Forms.DataGridView();
            this.pnlAdminOperations = new System.Windows.Forms.Panel();
            this.btnReportManagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.txtSearchLostPhone = new System.Windows.Forms.TextBox();
            this.pnlHeaderAdmin.SuspendLayout();
            this.pnlAdminDataBody.SuspendLayout();
            this.pnlMatchContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchedItems)).BeginInit();
            this.pnlAdminOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderAdmin
            // 
            this.pnlHeaderAdmin.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlHeaderAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeaderAdmin.Controls.Add(this.btnUserManage);
            this.pnlHeaderAdmin.Controls.Add(this.lblStaffDashTitle);
            this.pnlHeaderAdmin.Controls.Add(this.btnLogoutAdmin);
            this.pnlHeaderAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderAdmin.Name = "pnlHeaderAdmin";
            this.pnlHeaderAdmin.Size = new System.Drawing.Size(1243, 102);
            this.pnlHeaderAdmin.TabIndex = 0;
            // 
            // btnUserManage
            // 
            this.btnUserManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManage.Location = new System.Drawing.Point(1028, 35);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(112, 38);
            this.btnUserManage.TabIndex = 2;
            this.btnUserManage.Text = "ManageUser";
            this.btnUserManage.UseVisualStyleBackColor = true;
            this.btnUserManage.Click += new System.EventHandler(this.btnUserManage_Click);
            // 
            // lblStaffDashTitle
            // 
            this.lblStaffDashTitle.AutoSize = true;
            this.lblStaffDashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffDashTitle.Location = new System.Drawing.Point(421, 39);
            this.lblStaffDashTitle.Name = "lblStaffDashTitle";
            this.lblStaffDashTitle.Size = new System.Drawing.Size(367, 25);
            this.lblStaffDashTitle.TabIndex = 1;
            this.lblStaffDashTitle.Text = "WELCOME TO ADMIN DASHBOARD";
            // 
            // btnLogoutAdmin
            // 
            this.btnLogoutAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutAdmin.Location = new System.Drawing.Point(42, 31);
            this.btnLogoutAdmin.Name = "btnLogoutAdmin";
            this.btnLogoutAdmin.Size = new System.Drawing.Size(86, 33);
            this.btnLogoutAdmin.TabIndex = 0;
            this.btnLogoutAdmin.Text = "Logout";
            this.btnLogoutAdmin.UseVisualStyleBackColor = true;
            this.btnLogoutAdmin.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlAdminDataBody
            // 
            this.pnlAdminDataBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAdminDataBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdminDataBody.Controls.Add(this.txtSearchLostPhone);
            this.pnlAdminDataBody.Controls.Add(this.lblFilterTitle);
            this.pnlAdminDataBody.Controls.Add(this.label1);
            this.pnlAdminDataBody.Controls.Add(this.lblMatcHistoryTitle);
            this.pnlAdminDataBody.Controls.Add(this.pnlMatchContent);
            this.pnlAdminDataBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminDataBody.Location = new System.Drawing.Point(0, 102);
            this.pnlAdminDataBody.Name = "pnlAdminDataBody";
            this.pnlAdminDataBody.Size = new System.Drawing.Size(1243, 431);
            this.pnlAdminDataBody.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(882, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // lblMatcHistoryTitle
            // 
            this.lblMatcHistoryTitle.AutoSize = true;
            this.lblMatcHistoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatcHistoryTitle.Location = new System.Drawing.Point(572, 15);
            this.lblMatcHistoryTitle.Name = "lblMatcHistoryTitle";
            this.lblMatcHistoryTitle.Size = new System.Drawing.Size(106, 20);
            this.lblMatcHistoryTitle.TabIndex = 1;
            this.lblMatcHistoryTitle.Text = "Match History";
            // 
            // pnlMatchContent
            // 
            this.pnlMatchContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMatchContent.Controls.Add(this.dgvMatchedItems);
            this.pnlMatchContent.Controls.Add(this.button1);
            this.pnlMatchContent.Location = new System.Drawing.Point(0, 48);
            this.pnlMatchContent.Name = "pnlMatchContent";
            this.pnlMatchContent.Size = new System.Drawing.Size(1243, 286);
            this.pnlMatchContent.TabIndex = 0;
            // 
            // dgvMatchedItems
            // 
            this.dgvMatchedItems.AllowUserToAddRows = false;
            this.dgvMatchedItems.AllowUserToDeleteRows = false;
            this.dgvMatchedItems.AllowUserToResizeRows = false;
            this.dgvMatchedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatchedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatchedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatchedItems.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMatchedItems.Location = new System.Drawing.Point(0, 0);
            this.dgvMatchedItems.MultiSelect = false;
            this.dgvMatchedItems.Name = "dgvMatchedItems";
            this.dgvMatchedItems.ReadOnly = true;
            this.dgvMatchedItems.RowHeadersVisible = false;
            this.dgvMatchedItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMatchedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatchedItems.Size = new System.Drawing.Size(1243, 286);
            this.dgvMatchedItems.TabIndex = 0;
            this.dgvMatchedItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMatchedItems_DataBindingComplete);
            // 
            // pnlAdminOperations
            // 
            this.pnlAdminOperations.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlAdminOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdminOperations.Controls.Add(this.btnReportManagement);
            this.pnlAdminOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdminOperations.Location = new System.Drawing.Point(0, 433);
            this.pnlAdminOperations.Name = "pnlAdminOperations";
            this.pnlAdminOperations.Size = new System.Drawing.Size(1243, 100);
            this.pnlAdminOperations.TabIndex = 2;
            // 
            // btnReportManagement
            // 
            this.btnReportManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportManagement.Location = new System.Drawing.Point(543, 21);
            this.btnReportManagement.Name = "btnReportManagement";
            this.btnReportManagement.Size = new System.Drawing.Size(163, 43);
            this.btnReportManagement.TabIndex = 1;
            this.btnReportManagement.Text = "Report Management";
            this.btnReportManagement.UseVisualStyleBackColor = true;
            this.btnReportManagement.Click += new System.EventHandler(this.btnReportManagement_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(902, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterTitle.Location = new System.Drawing.Point(770, 15);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(195, 16);
            this.lblFilterTitle.TabIndex = 4;
            this.lblFilterTitle.Text = "Search By Lost Reporter Phone";
            this.lblFilterTitle.Click += new System.EventHandler(this.lblFilterTitle_Click);
            // 
            // txtSearchLostPhone
            // 
            this.txtSearchLostPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLostPhone.Location = new System.Drawing.Point(983, 11);
            this.txtSearchLostPhone.Name = "txtSearchLostPhone";
            this.txtSearchLostPhone.Size = new System.Drawing.Size(177, 22);
            this.txtSearchLostPhone.TabIndex = 5;
            this.txtSearchLostPhone.TextChanged += new System.EventHandler(this.txtSearchLostPhone_TextChanged);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 533);
            this.Controls.Add(this.pnlAdminOperations);
            this.Controls.Add(this.pnlAdminDataBody);
            this.Controls.Add(this.pnlHeaderAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlHeaderAdmin.ResumeLayout(false);
            this.pnlHeaderAdmin.PerformLayout();
            this.pnlAdminDataBody.ResumeLayout(false);
            this.pnlAdminDataBody.PerformLayout();
            this.pnlMatchContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchedItems)).EndInit();
            this.pnlAdminOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderAdmin;
        private System.Windows.Forms.Panel pnlAdminDataBody;
        private System.Windows.Forms.Panel pnlAdminOperations;
        private System.Windows.Forms.Button btnLogoutAdmin;
        private System.Windows.Forms.Label lblStaffDashTitle;
        private System.Windows.Forms.Button btnReportManagement;
        private System.Windows.Forms.Button btnUserManage;
        private System.Windows.Forms.Label lblMatcHistoryTitle;
        private System.Windows.Forms.Panel pnlMatchContent;
        private System.Windows.Forms.DataGridView dgvMatchedItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchLostPhone;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Button button1;
    }
}