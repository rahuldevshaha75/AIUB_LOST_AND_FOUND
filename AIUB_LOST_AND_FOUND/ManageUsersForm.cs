using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AIUB_LOST_AND_FOUND
{
    public partial class ManageUsersForm : Form
    {

        
        private AdminDashboard adminPageRef;
        private int loggedInUserId;
        private int selectedUserId = -1;
        private bool idBacked = false;

        private DBConnect db;




        
        public ManageUsersForm(AdminDashboard adminPageRef, int loggedInUserId)
        {
            InitializeComponent();
            this.adminPageRef = adminPageRef;
            this.loggedInUserId = loggedInUserId;
            db = new DBConnect();
        }



        //Fetching Users Method
        private void LoadUsers()
        {
            try
            {
               
                string query = @"
                SELECT 
                u.UserID AS 'User ID',
                u.FullName AS 'Full Name',
                u.Email AS 'Email',
                u.Phone AS Phone,
                u.Role AS Role,
                u.Gender AS Gender,
                ISNULL(a.FullName, 'System') AS 'Added By'
                FROM Users u
                LEFT JOIN Users a ON u.AddedBy = a.UserID;";

                DataTable dt = db.ExecuteQueryTable(query);
                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        //Clear Form Fields Method
        private void ClearFields() {
            this.txtFullName.Text = "";
            this.txtEmail.Text = "";
            this.txtPhone.Text = "";
            this.cmbRole.SelectedIndex = -1;
            this.cmbGender.SelectedIndex = -1;
        }






        // User Filter Method
        private void ApplyUserFilters()
        {
            try
            {
                string name = txtSearchName.Text.Trim();
                string email = txtSearchEmail.Text.Trim();
                string role = cmbSearchRole.Text;
                string gender = cmbSearchGender.Text;

                string query = @"SELECT 
                u.UserID AS 'User ID',
                u.FullName,
                u.Email,
                u.Phone,
                u.Role,
                u.Gender,
                ISNULL(a.FullName, 'System') AS 'Added By'
            FROM Users u
            LEFT JOIN Users a ON u.AddedBy = a.UserID
            WHERE 1=1";


                if (name != "")
                    query += $" AND u.FullName LIKE '%{name}%'";

                
                if (email != "")
                    query += $" AND u.Email LIKE '%{email}%'";

                
                if (role != "" && role != "Select")
                    query += $" AND u.Role = '{role}'";

                
                if (gender != "" && gender != "Select")
                    query += $" AND u.Gender = '{gender}'";

                
                DataTable dt = db.ExecuteQueryTable(query);
                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter error: " + ex.Message);
            }
        }







        //Form Load Event
        private void ManageUsersForm_Load(object sender, EventArgs e)
        {

        
            
            this.cmbSearchRole.Items.Clear();
            this.cmbSearchGender.Items.Clear();


         
            this.cmbSearchRole.Items.Add("Select");
            this.cmbSearchRole.Items.Add("Admin");
            this.cmbSearchRole.Items.Add("Staff");

            this.cmbSearchGender.Items.Add("Select");
            this.cmbSearchGender.Items.Add("Male");
            this.cmbSearchGender.Items.Add("Female");

           
            this.cmbSearchRole.SelectedIndex = 0;
            this.cmbSearchGender.SelectedIndex = 0;

            
            this.pnlManageUserAside.Visible = false;

            
            this.LoadUsers();

        }







        //Back Button Click
        private void btnManageUserBack_Click(object sender, EventArgs e)
        {
            this.idBacked= true;
            this.adminPageRef.Show();
            this.Close();
        }




        //Form Closing
        private void ManageUsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (idBacked == false)
                Application.Exit();

        }




        //Add New User Pnael Show Button Click
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            this.selectedUserId = -1;
            this.ClearFields();
            this.txtPassword.Text= "";
            this.cmbRole.SelectedIndex = 0;
            this.cmbGender.SelectedIndex = 0;
            this.pnlManageUserAside.Visible = true;
        }





        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFullName_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        //Save User Button Click
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string fullName = this.txtFullName.Text.Trim();
            string email = this.txtEmail.Text.Trim();
            string phone = this.txtPhone.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            string role = this.cmbRole.Text;
            string gender = this.cmbGender.Text;

            if (fullName == "" || email == "" || phone == "" || role == "" || gender == "")
            {
                MessageBox.Show("Please fill Up All Info!");
                return;
            }

            // Email validation
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please Enter valid Email!");
                return;
            }


            // Phone number validation (digits only, 7–15 length)
                if (!Regex.IsMatch(phone, @"^01[3-9]\d{8}$"))
            {
                MessageBox.Show("Please Enter Valid Phone Number!");
                return;
            }




            try
            {
                 
                string query = "";

                if (selectedUserId == -1)
                {

                    if (string.IsNullOrWhiteSpace(password))
                    {
                        MessageBox.Show("Please Enter Password for New User.");
                        return;
                    }

                    if (password.Length < 6)
                    {
                        MessageBox.Show("Password Must be 6 Characters Long.");
                        return;
                    }
                    

                    query = $@"INSERT INTO Users (FullName, Email, Phone, Password, Role, Gender, AddedBy)
                            VALUES ('{fullName}', '{email}', '{phone}', '{password}', '{role}', '{gender}', {loggedInUserId})";

                }else{
                    if (password == "")
                    {
                        query = $@"UPDATE Users
                    SET 
                        FullName = '{fullName}',
                        Email = '{email}',
                        Phone = '{phone}',
                        Role = '{role}',
                        Gender = '{gender}'
                    WHERE UserID = {selectedUserId}";
                    }
                    else
                    {

                        if (password.Length < 6)
                        {
                            MessageBox.Show("Password Must be 6 Characters Long.");
                            return;
                        }

                        query = $@" UPDATE Users
                    SET 
                        FullName = '{fullName}',
                        Email = '{email}',
                        Phone = '{phone}',
                        Password = '{password}',
                        Role = '{role}',
                        Gender = '{gender}'
                    WHERE UserID = {selectedUserId}";
                    }
                }

                int result = db.ExecuteDMLQuery(query);

                if (result > 0)
                {
                    MessageBox.Show(selectedUserId == -1 ? "User added successfully!" : "User updated successfully!");

                    this.ClearFields();
                    this.LoadUsers();
                    this.pnlManageUserAside.Visible = false;

                    this.selectedUserId = -1;
                    this.btnSaveUser.Text = "Add User";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }






        //Cancel Button Click
        private void btnCancelUserForm_Click(object sender, EventArgs e)
        {
            this.pnlManageUserAside.Visible = false;
            this.ClearFields();
        }




        //DataGridView Cell Click
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt32(row.Cells["User ID"].Value);
            }
        }




        //Edit User Button Click
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please Select a User First.");
                return;
            }

            try
            {
                string query = $"SELECT * FROM Users WHERE UserID = {selectedUserId}";
                DataTable dt = db.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    DataRow row = dt.Rows[0];

                    this.txtFullName.Text = row["FullName"].ToString();
                    this.txtEmail.Text = row["Email"].ToString();
                    this.txtPhone.Text = row["Phone"].ToString();
                    this.cmbRole.Text = row["Role"].ToString();
                    this.cmbGender.Text = row["Gender"].ToString();

                    this.txtPassword.Text = ""; 

                    this.pnlManageUserAside.Visible = true;
                    this.btnSaveUser.Text = "Update User";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        //Remove User Button Click
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            //  Preventing self-Remove
            if (selectedUserId == loggedInUserId)
            {
                MessageBox.Show("You Cannot Delete your Own Account While logged in.", "Action Denied");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Are you Sure you Want to Delete this User?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                try
                {
                    string query = $"DELETE FROM Users WHERE UserID = {selectedUserId}";
                    int result = db.ExecuteDMLQuery(query);

                    if (result > 0)
                    {
                        MessageBox.Show("User Removed Successfully!");

                        selectedUserId = -1;
                        LoadUsers();
                        ClearFields();
                        pnlManageUserAside.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }







        //Search/Filter Events
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            ApplyUserFilters();

        }

        private void txtSearchEmail_TextChanged(object sender, EventArgs e)
        {
            ApplyUserFilters();

        }

        private void cmbSearchRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyUserFilters();

        }

        private void cmbSearchGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyUserFilters();

        }





        //Clear Filters Button Click
        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtSearchName.Text = "";
            txtSearchEmail.Text = "";
            cmbSearchRole.SelectedIndex = 0;   
            cmbSearchGender.SelectedIndex = 0; 

            LoadUsers();
        }


        private void dgvUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUsers.ClearSelection();

        }




    }
}
