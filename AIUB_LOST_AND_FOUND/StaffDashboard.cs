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
    public partial class StaffDashboard : Form
    {


        private LoginForm loginFormRef;
        private bool isLoggingOut = false;
        private int loggedInUserId;
        private DBConnect db;


        //Constructor
        public StaffDashboard(LoginForm loginForm, int userId)
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

                dgvStaffMatchView.DataSource = db.ExecuteQueryTable(query);

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
                string phone = this.txtStaffFilter.Text.Trim();

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

                dgvStaffMatchView.DataSource = db.ExecuteQueryTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }






        // Form Load
        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            this.LoadConfirmedMatches();
        }




        // Form Close
        private void StaffDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLoggingOut)
            {
                Application.Exit();
            }
        }




        // Logout Button
        private void btnLogoutStaff_Click(object sender, EventArgs e)
        {
            this.isLoggingOut = true;
            this.loginFormRef.Show();
            this.Close();

        }




        // Report Management Button
        private void btnReportManage_Click(object sender, EventArgs e)
        {
            ManageReportsForm f = new ManageReportsForm(this, loggedInUserId);
            f.Show();
            this.Hide();

        }




        //Clear DataGridView Selection
        private void dgvStaffMatchView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvStaffMatchView.ClearSelection();
        }

        private void txtStaffFilter_TextChanged(object sender, EventArgs e)
        {
            this.SearchMatchHistory();
        }




    }
}
