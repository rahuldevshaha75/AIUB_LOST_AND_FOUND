using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIUB_LOST_AND_FOUND
{
    public partial class ManageReportsForm : Form
    {

        private AdminDashboard adminDashPageRef;
        private StaffDashboard stuffDashBoadRef;
        private bool isNavigatingBack = false;
        private int selectedReportId = -1;
        private int filledByUserId;
        DBConnect db;

       

        //Constructor
        public ManageReportsForm(AdminDashboard adminDashPageRef, int filledByUser)
        {
            InitializeComponent();
            this.adminDashPageRef = adminDashPageRef;
            this.filledByUserId = filledByUser;
        }


        //Constructor
        public ManageReportsForm(StaffDashboard staffDashPageRef, int filledByUser)
        {
            InitializeComponent();
            this.stuffDashBoadRef = staffDashPageRef;
            this.filledByUserId = filledByUser;
           
        }



        //Load Report Method
        internal void LoadReports()
        {
            try
            {
                
                string query = @"
            SELECT 
                r.ReportID AS 'Report ID',
                r.ReportType,
                r.ItemName,
                r.ItemCategory,
                r.Brand,
                r.Color,
                r.UniqueMark,
                r.Location,
                r.ReportDate,
                r.Status,

                r.ReporterName,
                r.ReporterStudentID,
                r.ReporterPhone,

                u.FullName AS AddedBy
            FROM Reports r, Users u
            WHERE r.AddedBy = u.UserID
            ORDER BY r.ReportDate DESC";

                dgvReports.DataSource = db.ExecuteQueryTable(query);

                dgvReports.ReadOnly = true;
                dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvReports.MultiSelect = false;
                dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }



        //Search Reports Method
        private void SearchReports()
        {
            try
            {
                string name = txtSearchName.Text.Trim();
                string sid = txtSearchStudentId.Text.Trim();
                string phone = txtSearchPhone.Text.Trim();
                string status = cmbReportStatus.Text;

                string query = @"
        SELECT 
            r.ReportID AS 'Report ID',
            r.ReportType AS 'Report Type',
            r.ItemName AS 'Item Name',
            r.ItemCategory AS Category,
            r.Brand AS Brand,
            r.Color AS Color,
            r.UniqueMark AS 'Unique Mark',
            r.Location AS Location,
            r.ReportDate AS 'Report Date',
            r.Status AS Staus,
            r.ReporterName AS 'Reporter Name',
            r.ReporterStudentID AS 'Reporter ID',
            r.ReporterPhone AS Phone,
            u.FullName AS AddedBy
        FROM Reports r, Users u
        WHERE r.AddedBy = u.UserID
        ";

                if (!string.IsNullOrEmpty(name))
                    query += $" AND r.ReporterName LIKE '%{name}%'";

                if (!string.IsNullOrEmpty(sid))
                    query += $" AND r.ReporterStudentID LIKE '%{sid}%'";

                if (!string.IsNullOrEmpty(phone))
                    query += $" AND r.ReporterPhone LIKE '%{phone}%'";

                if (!string.IsNullOrEmpty(status) && status != "All")
                    query += $" AND r.Status = '{status}'";

                query += " ORDER BY r.ReportDate DESC";




                dgvReports.DataSource = db.ExecuteQueryTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }






        //Form Load
        private void ManageReportsForm_Load(object sender, EventArgs e)
        {
            db = new DBConnect();


         
            cmbReportStatus.Items.Clear();
            
            cmbReportStatus.Items.Add("Pending");
            cmbReportStatus.Items.Add("Matched");

            
            if (cmbReportStatus.Items.Count > 0)
            {
                cmbReportStatus.SelectedIndex = 0;
            }

            this.SearchReports();
           
        }




        private void panel1_Paint(object sender, PaintEventArgs e){

        }




        //Form Close
        private void ManageReportsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isNavigatingBack)
            {
                Application.Exit();
            }
         }



        //Id Selecting from DataGridView
        private void dgvReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedReportId = Convert.ToInt32(dgvReports.Rows[e.RowIndex].Cells["Report ID"].Value);
            }
        }









        //Back Button Click 
        private void btnReportManageBack_Click(object sender, EventArgs e)
        {
            isNavigatingBack = true;

            if (adminDashPageRef == null)
            {
                this.stuffDashBoadRef.Show();
            }
            else
            {
                this.adminDashPageRef.Show();
            }


            this.Close();
        }



        //Add Report Button 
        private void btnAddReport_Click(object sender, EventArgs e)
        {
            AddEditReportForm f = new AddEditReportForm("Add", filledByUserId, selectedReportId);

            DialogResult result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.LoadReports();  
                this.Show(); 
            }

        }




        //Edit Report Button 
        private void btnEditReport_Click(object sender, EventArgs e)
        {
            if (selectedReportId == -1)
            {
                MessageBox.Show("Please Select a Report to Edit.");
                return;
            }

            AddEditReportForm f = new AddEditReportForm( "Edit", filledByUserId, selectedReportId);
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.LoadReports();
            }

        }




        //Delete Button 
        private void btnDeleteReport_Click(object sender, EventArgs e)
        {
            if (selectedReportId == -1)
            {
                MessageBox.Show("Please Select a Report To Delete.");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this Report?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    
                    string query = $"DELETE FROM Reports WHERE ReportID = {selectedReportId}";
                    db.ExecuteDMLQuery(query);

                    MessageBox.Show("Report Deleted successfully!");
                    selectedReportId = -1;
                    LoadReports();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message);
                }
            }
        }




        //Possible Match Button 
        private void btnPossibleMatch_Click(object sender, EventArgs e)
        {
            if (selectedReportId == -1)
            {
                MessageBox.Show("Please Select  Report that You Want to Check!!!");
                return;
            }

            MatchConfirmForm mConfirm = new MatchConfirmForm(this, filledByUserId, selectedReportId );
            mConfirm.Show();
            this.Hide();
        }






        private void button1_Click(object sender, EventArgs e){  }



        //Auto Search 
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

            this.SearchReports();

        }

        private void txtSearchStudentId_TextChanged(object sender, EventArgs e)
        {
            this.SearchReports();
        }

        private void txtSearchPhone_TextChanged(object sender, EventArgs e)
        {
               this.SearchReports();
        }


        private void cmbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }






        //Clear Search Button
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            txtSearchStudentId.Clear();
            txtSearchPhone.Clear();

            cmbReportStatus.SelectedIndex = -1;

            this.LoadReports();
        }





        //Clear Selection in Gridview
        private void dgvReports_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvReports.ClearSelection();

        }

        private void cmbReportStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SearchReports();
        }

        private void lblStsatus_Click(object sender, EventArgs e)
        {

        }

        private void lblReportManageHeaderTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
