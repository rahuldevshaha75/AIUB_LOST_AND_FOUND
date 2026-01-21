namespace AIUB_LOST_AND_FOUND
{
    partial class ManageUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersForm));
            this.pnlManageUserOperation = new System.Windows.Forms.Panel();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnManageUserBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblManageUserTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlUserManageContectBody = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlmUserMangeContentHeader = new System.Windows.Forms.Panel();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.lblSearchGender = new System.Windows.Forms.Label();
            this.lblUserManageContentHeaderTitle = new System.Windows.Forms.Label();
            this.lblSearchRole = new System.Windows.Forms.Label();
            this.lblSearchEmail = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.cmbSearchGender = new System.Windows.Forms.ComboBox();
            this.cmbSearchRole = new System.Windows.Forms.ComboBox();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.pnlManageUserAside = new System.Windows.Forms.Panel();
            this.btnCancelUserForm = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAddUserTitle = new System.Windows.Forms.Label();
            this.pnlManageUserOperation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlUserManageContectBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlmUserMangeContentHeader.SuspendLayout();
            this.pnlManageUserAside.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManageUserOperation
            // 
            this.pnlManageUserOperation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlManageUserOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManageUserOperation.Controls.Add(this.btnRemoveUser);
            this.pnlManageUserOperation.Controls.Add(this.btnEditUser);
            this.pnlManageUserOperation.Controls.Add(this.btnAddNewUser);
            this.pnlManageUserOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlManageUserOperation.Location = new System.Drawing.Point(0, 459);
            this.pnlManageUserOperation.Name = "pnlManageUserOperation";
            this.pnlManageUserOperation.Size = new System.Drawing.Size(1223, 81);
            this.pnlManageUserOperation.TabIndex = 1;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.Location = new System.Drawing.Point(772, 22);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(145, 40);
            this.btnRemoveUser.TabIndex = 2;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.Location = new System.Drawing.Point(589, 23);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(144, 39);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Location = new System.Drawing.Point(400, 22);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(152, 40);
            this.btnAddNewUser.TabIndex = 0;
            this.btnAddNewUser.Text = "Add User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnManageUserBack
            // 
            this.btnManageUserBack.Location = new System.Drawing.Point(24, 25);
            this.btnManageUserBack.Name = "btnManageUserBack";
            this.btnManageUserBack.Size = new System.Drawing.Size(133, 29);
            this.btnManageUserBack.TabIndex = 2;
            this.btnManageUserBack.Text = "Back To Dashboard";
            this.btnManageUserBack.UseVisualStyleBackColor = true;
            this.btnManageUserBack.Click += new System.EventHandler(this.btnManageUserBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblManageUserTitle);
            this.panel1.Controls.Add(this.btnManageUserBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 78);
            this.panel1.TabIndex = 3;
            // 
            // lblManageUserTitle
            // 
            this.lblManageUserTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManageUserTitle.AutoSize = true;
            this.lblManageUserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUserTitle.Location = new System.Drawing.Point(466, 22);
            this.lblManageUserTitle.Name = "lblManageUserTitle";
            this.lblManageUserTitle.Size = new System.Drawing.Size(227, 25);
            this.lblManageUserTitle.TabIndex = 3;
            this.lblManageUserTitle.Text = "USER MANAGEMENT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnlManageUserAside);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 381);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.pnlUserManageContectBody);
            this.panel3.Controls.Add(this.pnlmUserMangeContentHeader);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(249, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 381);
            this.panel3.TabIndex = 2;
            // 
            // pnlUserManageContectBody
            // 
            this.pnlUserManageContectBody.BackColor = System.Drawing.Color.MistyRose;
            this.pnlUserManageContectBody.Controls.Add(this.dgvUsers);
            this.pnlUserManageContectBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserManageContectBody.Location = new System.Drawing.Point(0, 67);
            this.pnlUserManageContectBody.Name = "pnlUserManageContectBody";
            this.pnlUserManageContectBody.Size = new System.Drawing.Size(974, 314);
            this.pnlUserManageContectBody.TabIndex = 2;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(974, 314);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            this.dgvUsers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUsers_DataBindingComplete);
            // 
            // pnlmUserMangeContentHeader
            // 
            this.pnlmUserMangeContentHeader.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlmUserMangeContentHeader.Controls.Add(this.btnClearFilters);
            this.pnlmUserMangeContentHeader.Controls.Add(this.lblSearchGender);
            this.pnlmUserMangeContentHeader.Controls.Add(this.lblUserManageContentHeaderTitle);
            this.pnlmUserMangeContentHeader.Controls.Add(this.lblSearchRole);
            this.pnlmUserMangeContentHeader.Controls.Add(this.lblSearchEmail);
            this.pnlmUserMangeContentHeader.Controls.Add(this.lblSearchName);
            this.pnlmUserMangeContentHeader.Controls.Add(this.cmbSearchGender);
            this.pnlmUserMangeContentHeader.Controls.Add(this.cmbSearchRole);
            this.pnlmUserMangeContentHeader.Controls.Add(this.txtSearchEmail);
            this.pnlmUserMangeContentHeader.Controls.Add(this.txtSearchName);
            this.pnlmUserMangeContentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmUserMangeContentHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlmUserMangeContentHeader.Name = "pnlmUserMangeContentHeader";
            this.pnlmUserMangeContentHeader.Size = new System.Drawing.Size(974, 67);
            this.pnlmUserMangeContentHeader.TabIndex = 1;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.Color.Salmon;
            this.btnClearFilters.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.Location = new System.Drawing.Point(845, 19);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(98, 35);
            this.btnClearFilters.TabIndex = 10;
            this.btnClearFilters.Text = "Clear Filter";
            this.btnClearFilters.UseVisualStyleBackColor = false;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // lblSearchGender
            // 
            this.lblSearchGender.AutoSize = true;
            this.lblSearchGender.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchGender.Location = new System.Drawing.Point(684, 11);
            this.lblSearchGender.Name = "lblSearchGender";
            this.lblSearchGender.Size = new System.Drawing.Size(100, 16);
            this.lblSearchGender.TabIndex = 9;
            this.lblSearchGender.Text = "Select Gender";
            // 
            // lblUserManageContentHeaderTitle
            // 
            this.lblUserManageContentHeaderTitle.AutoSize = true;
            this.lblUserManageContentHeaderTitle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserManageContentHeaderTitle.Location = new System.Drawing.Point(20, 27);
            this.lblUserManageContentHeaderTitle.Name = "lblUserManageContentHeaderTitle";
            this.lblUserManageContentHeaderTitle.Size = new System.Drawing.Size(90, 18);
            this.lblUserManageContentHeaderTitle.TabIndex = 2;
            this.lblUserManageContentHeaderTitle.Text = "Search By:";
            // 
            // lblSearchRole
            // 
            this.lblSearchRole.AutoSize = true;
            this.lblSearchRole.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchRole.Location = new System.Drawing.Point(540, 13);
            this.lblSearchRole.Name = "lblSearchRole";
            this.lblSearchRole.Size = new System.Drawing.Size(81, 16);
            this.lblSearchRole.TabIndex = 8;
            this.lblSearchRole.Text = "Select Role";
            // 
            // lblSearchEmail
            // 
            this.lblSearchEmail.AutoSize = true;
            this.lblSearchEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmail.Location = new System.Drawing.Point(376, 11);
            this.lblSearchEmail.Name = "lblSearchEmail";
            this.lblSearchEmail.Size = new System.Drawing.Size(40, 16);
            this.lblSearchEmail.TabIndex = 7;
            this.lblSearchEmail.Text = "Email";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(189, 13);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(43, 16);
            this.lblSearchName.TabIndex = 6;
            this.lblSearchName.Text = "Name";
            // 
            // cmbSearchGender
            // 
            this.cmbSearchGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchGender.FormattingEnabled = true;
            this.cmbSearchGender.Location = new System.Drawing.Point(687, 29);
            this.cmbSearchGender.Name = "cmbSearchGender";
            this.cmbSearchGender.Size = new System.Drawing.Size(111, 21);
            this.cmbSearchGender.TabIndex = 5;
            this.cmbSearchGender.SelectedIndexChanged += new System.EventHandler(this.cmbSearchGender_SelectedIndexChanged);
            // 
            // cmbSearchRole
            // 
            this.cmbSearchRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchRole.FormattingEnabled = true;
            this.cmbSearchRole.Location = new System.Drawing.Point(524, 30);
            this.cmbSearchRole.Name = "cmbSearchRole";
            this.cmbSearchRole.Size = new System.Drawing.Size(125, 21);
            this.cmbSearchRole.TabIndex = 4;
            this.cmbSearchRole.SelectedIndexChanged += new System.EventHandler(this.cmbSearchRole_SelectedIndexChanged);
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Location = new System.Drawing.Point(329, 30);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(156, 20);
            this.txtSearchEmail.TabIndex = 1;
            this.txtSearchEmail.TextChanged += new System.EventHandler(this.txtSearchEmail_TextChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(138, 30);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(155, 20);
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // pnlManageUserAside
            // 
            this.pnlManageUserAside.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlManageUserAside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManageUserAside.Controls.Add(this.btnCancelUserForm);
            this.pnlManageUserAside.Controls.Add(this.cmbGender);
            this.pnlManageUserAside.Controls.Add(this.cmbRole);
            this.pnlManageUserAside.Controls.Add(this.txtPassword);
            this.pnlManageUserAside.Controls.Add(this.txtPhone);
            this.pnlManageUserAside.Controls.Add(this.txtEmail);
            this.pnlManageUserAside.Controls.Add(this.txtFullName);
            this.pnlManageUserAside.Controls.Add(this.btnSaveUser);
            this.pnlManageUserAside.Controls.Add(this.lblPassword);
            this.pnlManageUserAside.Controls.Add(this.lblGender);
            this.pnlManageUserAside.Controls.Add(this.lblEmail);
            this.pnlManageUserAside.Controls.Add(this.lblRole);
            this.pnlManageUserAside.Controls.Add(this.lblPhone);
            this.pnlManageUserAside.Controls.Add(this.lblFullName);
            this.pnlManageUserAside.Controls.Add(this.lblAddUserTitle);
            this.pnlManageUserAside.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlManageUserAside.Location = new System.Drawing.Point(0, 0);
            this.pnlManageUserAside.Name = "pnlManageUserAside";
            this.pnlManageUserAside.Size = new System.Drawing.Size(249, 381);
            this.pnlManageUserAside.TabIndex = 1;
            // 
            // btnCancelUserForm
            // 
            this.btnCancelUserForm.Location = new System.Drawing.Point(47, 308);
            this.btnCancelUserForm.Name = "btnCancelUserForm";
            this.btnCancelUserForm.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUserForm.TabIndex = 12;
            this.btnCancelUserForm.Text = "Cancel";
            this.btnCancelUserForm.UseVisualStyleBackColor = true;
            this.btnCancelUserForm.Click += new System.EventHandler(this.btnCancelUserForm_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(91, 255);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(137, 21);
            this.cmbGender.TabIndex = 11;
            // 
            // cmbRole
            // 
            this.cmbRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmbRole.Location = new System.Drawing.Point(91, 217);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(137, 21);
            this.cmbRole.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(91, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(137, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(91, 131);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(137, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(137, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(91, 63);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(137, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(139, 308);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUser.TabIndex = 1;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(21, 175);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 15);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(21, 256);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(51, 15);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(21, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(21, 217);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(36, 15);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Role:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(21, 132);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 15);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(21, 63);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(64, 15);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "FullName:";
            this.lblFullName.Click += new System.EventHandler(this.txtFullName_Click);
            // 
            // lblAddUserTitle
            // 
            this.lblAddUserTitle.AutoSize = true;
            this.lblAddUserTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUserTitle.Location = new System.Drawing.Point(47, 18);
            this.lblAddUserTitle.Name = "lblAddUserTitle";
            this.lblAddUserTitle.Size = new System.Drawing.Size(129, 16);
            this.lblAddUserTitle.TabIndex = 0;
            this.lblAddUserTitle.Text = "Adding New User";
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlManageUserOperation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageUsersForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            this.pnlManageUserOperation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlUserManageContectBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlmUserMangeContentHeader.ResumeLayout(false);
            this.pnlmUserMangeContentHeader.PerformLayout();
            this.pnlManageUserAside.ResumeLayout(false);
            this.pnlManageUserAside.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManageUserOperation;
        private System.Windows.Forms.Button btnManageUserBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManageUserTitle;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlManageUserAside;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAddUserTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnCancelUserForm;
        private System.Windows.Forms.Panel pnlmUserMangeContentHeader;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.ComboBox cmbSearchGender;
        private System.Windows.Forms.ComboBox cmbSearchRole;
        private System.Windows.Forms.Label lblUserManageContentHeaderTitle;
        private System.Windows.Forms.Panel pnlUserManageContectBody;
        private System.Windows.Forms.Label lblSearchGender;
        private System.Windows.Forms.Label lblSearchRole;
        private System.Windows.Forms.Label lblSearchEmail;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Button btnClearFilters;
    }
}