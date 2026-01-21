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
    public partial class MatchConfirmForm : Form
    {



        private int selectedReportId;
        private int loggedInUserId;
        private DBConnect db;
        private DataSet ds;

        private int selectedMatchedReportId = -1;
        private int selectedMatchScore = 0;

        private ManageReportsForm manageReportsFormRef;





        //Constructor
        public MatchConfirmForm(ManageReportsForm rageRef, int ConfirmedByUser, int selectedReportId)
        {
            InitializeComponent();
           
            this.loggedInUserId = ConfirmedByUser;
            this.selectedReportId = selectedReportId;
            this.manageReportsFormRef = rageRef;

        }






        // Load Selected Report Info Method
        private void LoadSelectedReportInfo()
        {
            try
            {
                string query = $"SELECT * FROM Reports WHERE ReportID = {selectedReportId}";
                ds = db.ExecuteQuery(query);
                DataRow r = ds.Tables[0].Rows[0];

                lblType.Text = "Type: " + r["ReportType"].ToString();
                lblItemName.Text = "Item: " + r["ItemName"].ToString();
                lblCategory.Text = "Category: " + r["ItemCategory"].ToString();
                lblColor.Text = "Color: " + r["Color"].ToString();
                lblUniqueMark.Text = "Unique Mark: " + r["UniqueMark"].ToString();
                lblLocation.Text = "Location: " + r["Location"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected report: " + ex.Message);
            }
        }





        // Load Possible Matches Method
        private void LoadPossibleMatches()
        {
            try
            {
                //Get Selected Report
                string selectedQuery = $"SELECT * FROM Reports WHERE ReportID = {selectedReportId}";
                ds = db.ExecuteQuery(selectedQuery);
                DataRow selectedRow = ds.Tables[0].Rows[0];

                string selectedType = selectedRow["ReportType"].ToString();
                string oppositeType = selectedType == "Lost" ? "Found" : "Lost";

                //Get Opposite Type Reports
                string query = $"SELECT * FROM Reports WHERE ReportType = '{oppositeType}' AND Status = 'Pending'";
                DataSet possibleDs = db.ExecuteQuery(query);
                DataTable dt = possibleDs.Tables[0];

                // Add Score column
                dt.Columns.Add("MatchScore", typeof(int));
                dt.Columns["MatchScore"].SetOrdinal(2);

                // Calculate score
                foreach (DataRow row in dt.Rows)
                {
                    int score = CalculateScore(selectedRow, row);
                    row["MatchScore"] = score;
                }

                this.dgvMatches.DataSource = dt;

                //this.dgvMatches.ReadOnly = true;
                //this.dgvMatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //this.dgvMatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //this.dgvMatches.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading matches: " + ex.Message);
            }
        }




        // Calculate Score Method
        private int CalculateScore(DataRow r1, DataRow r2)
        {
            int score = 0;

            if (r1["ItemCategory"].ToString() == r2["ItemCategory"].ToString())
                score += 20;

            if (r1["Brand"].ToString() == r2["Brand"].ToString())
                score += 15;

            if (r1["Color"].ToString() == r2["Color"].ToString())
                score += 15;

            if (r1["UniqueMark"].ToString() != "" &&
                r1["UniqueMark"].ToString() == r2["UniqueMark"].ToString())
                score += 30;

            if (r1["ItemName"].ToString().ToLower().Contains(r2["ItemName"].ToString().ToLower()) ||
                r2["ItemName"].ToString().ToLower().Contains(r1["ItemName"].ToString().ToLower()))
                score += 10;

            return score;
        }




        // Back Button Click 
        private void btnBack_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.manageReportsFormRef.Show();
            this.Close();
        }



        //Form load
        private void MatchConfirmForm_Load(object sender, EventArgs e)
        {
            this.db = new DBConnect();
            this.LoadSelectedReportInfo();
            this.LoadPossibleMatches();
        }




        // Form Close
        private void MatchConfirmForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        // Data Collect from DataGridView
        private void dgvMatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.selectedMatchedReportId = Convert.ToInt32(dgvMatches.Rows[e.RowIndex].Cells["ReportID"].Value);
                this.selectedMatchScore = Convert.ToInt32(dgvMatches.Rows[e.RowIndex].Cells["MatchScore"].Value);
            }
        }




        // Confirm Match Button Click Event
        private void btnConfirmMatch_Click(object sender, EventArgs e)
        {
            if (this.selectedMatchedReportId == -1)
            {
                MessageBox.Show("Please Select a Match to Confirm!.");
                return;
            }

            try
            {
                // Get Selected Report Type
                string q1 = $"SELECT ReportType FROM Reports WHERE ReportID = {selectedReportId}";
                DataSet d1 = db.ExecuteQuery(q1);
                string selectedType = d1.Tables[0].Rows[0]["ReportType"].ToString();

                int lostId, foundId;

                if (selectedType == "Lost")
                {
                    lostId = selectedReportId;
                    foundId = selectedMatchedReportId;
                }
                else
                {
                    lostId = selectedMatchedReportId;
                    foundId = selectedReportId;
                }

              
                string insertQuery = $@"
                         INSERT INTO MatchHistories
                          (LostReportID, FoundReportID, MatchScore, MatchDate, ConfirmedBy)
                        VALUES
                        ({lostId}, {foundId}, {selectedMatchScore}, GETDATE(), {loggedInUserId})";

                        db.ExecuteDMLQuery(insertQuery);


                string updateQuery1 = $"UPDATE Reports SET Status = 'Matched' WHERE ReportID = {lostId}";
                string updateQuery2 = $"UPDATE Reports SET Status = 'Matched' WHERE ReportID = {foundId}";

                db.ExecuteDMLQuery(updateQuery1);
                db.ExecuteDMLQuery(updateQuery2);

                MessageBox.Show("Match Confirmed!");

                this.manageReportsFormRef.LoadReports();
                this.manageReportsFormRef.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Confirm Error: " + ex.Message);
            }
        }



        //Clear Selection in Grid view
        private void dgvMatches_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvMatches.ClearSelection();

        }




    }
}
