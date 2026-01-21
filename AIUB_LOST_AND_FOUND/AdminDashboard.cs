using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIUB_LOST_AND_FOUND
{
    public partial class AdminDashboard : Form
    {

        private  int loggedInUserId;
        private bool isLoggingOut = false;
        private LoginForm loginFormRef;
        private DBConnect db;


        // Constructor
        public AdminDashboard(LoginForm loginForm, int userId)
        {
            InitializeComponent();
            this.loggedInUserId = userId;
            this.loginFormRef = loginForm;
            db = new DBConnect();
        }



        // Load Confirmed Matches Method
        private void LoadConfirmedMatches()
        {
            try
            {
                
                string query = @"
            SELECT  

            l.ReporterName AS 'Lost Reporter Name',
            l.ReporterPhone AS 'Lost Reporter Phone',
            f.ReporterName AS 'Found Reporter Name',
            f.ReporterPhone AS 'Found Reporter Phone',
            l.ItemName AS 'Lost Item',
            l.UniqueMark AS 'Unique Mark',
            mh.MatchScore AS 'Match Score',
            mh.MatchDate AS 'Match Date',
            u.FullName AS 'Confirmed By'
            FROM MatchHistories mh
            JOIN Reports l ON mh.LostReportID = l.ReportID
            JOIN Reports f ON mh.FoundReportID = f.ReportID
            JOIN Users u ON mh.ConfirmedBy = u.UserID
            ORDER BY mh.MatchDate DESC;";


             dgvMatchedItems.DataSource = db.ExecuteQueryTable(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading matched items: " + ex.Message);
            }
        }





        // Search Match History Method
        private void SearchMatchHistory()
        {
            try
            {
                string phone = this.txtSearchLostPhone.Text.Trim();

                //DBConnect db = new DBConnect();

                string query = @"
        SELECT 
            mh.MatchID,
            l.ReporterName AS LostReporter,
            l.ReporterPhone,
            l.ItemName AS LostItem,
            f.ItemName AS FoundItem,
            mh.MatchScore,
            mh.MatchDate,
            u.FullName AS ConfirmedBy
        FROM MatchHistories mh
        JOIN Reports l ON mh.LostReportID = l.ReportID
        JOIN Reports f ON mh.FoundReportID = f.ReportID
        JOIN Users u ON mh.ConfirmedBy = u.UserID
        WHERE 1=1";

                if (phone != "")
                    query += $" AND l.ReporterPhone LIKE '%{phone}%'";

                dgvMatchedItems.DataSource = db.ExecuteQueryTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }





        // Form Load 
        private void AdminDashboard_Load(object sender, EventArgs e){
            LoadConfirmedMatches();
        }




        // Form Close
        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLoggingOut)
            {
                Application.Exit();
            }
        }





        // Logout Button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.isLoggingOut = true;
            this.loginFormRef.Show(); 
            this.Close();
        }







        //Unused Methods
        private void btnManageUser_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {

        }

        private void btnEditReport_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteReport_Click(object sender, EventArgs e)
        {

        }

        private void btnPossibleMatch_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateReport_Click_1(object sender, EventArgs e)
        {
          
        }







        // Manage Reports Button
        private void btnReportManagement_Click(object sender, EventArgs e)
        {
            ManageReportsForm mReport = new ManageReportsForm(this, loggedInUserId);
            mReport.Show();
            this.Hide();
        }




        // Manage Users Button
        private void btnUserManage_Click(object sender, EventArgs e)
        {
            ManageUsersForm mUser = new ManageUsersForm(this, loggedInUserId);
            mUser.Show();
            this.Hide();
        }




        //Clear Gridview Selection
        private void dgvMatchedItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvMatchedItems.ClearSelection();

        }




        private void lblFilterTitle_Click(object sender, EventArgs e)
        {

        }




        private void txtSearchLostPhone_TextChanged(object sender, EventArgs e)
        {
            this.SearchMatchHistory();
        }




    }
}
