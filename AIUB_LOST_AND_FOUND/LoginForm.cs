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
    public partial class LoginForm : Form
    {

        
        private DBConnect db;



        //Constructor
        public LoginForm()
        {
            InitializeComponent();
            this.db = new DBConnect();
        }







        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }








        //Login In User
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text.Trim();
            string password = this.txtPassword.Text.Trim();


            //AdminDashboard ad = new AdminDashboard(this, 1);
            //ad.Show();
            //this.Hide();


            

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please Enter Email and Password.");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please Enter valid Email!");
                return;
            }



            try
            {
            
                string query = "SELECT * FROM Users WHERE Email = '" + email + "' AND Password = '" + password + "'";
                DataTable dt = db.ExecuteQueryTable(query);



                if (dt.Rows.Count == 1)
                {
                    string role = dt.Rows[0]["Role"].ToString();
                    int userId = Convert.ToInt32(dt.Rows[0]["UserID"]);

                    MessageBox.Show("Login Successful!");

                    if (role == "Admin")
                    {
                        AdminDashboard ad = new AdminDashboard(this, userId);
                        ad.Show();
                        this.Hide();
                    }
                    else if (role == "Staff")
                    {
                        StaffDashboard sd = new StaffDashboard(this, userId);
                        sd.Show();
                        this.Hide();
                    }

                    this.txtEmail.Text = "";
                    this.txtPassword.Text = "";

                }
                else
                {
                    MessageBox.Show("Wrong Email or Password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }






        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtEmail.Text = "";
            this.txtPassword.Text = "";
        }






        private void LoginForm_Load(object sender, EventArgs e)
        {
         
        }



    }
}
