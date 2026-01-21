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
    public partial class AddEditReportForm : Form
    {
        private string operationType; 
        private int selectedReportId = -1;
        private int filledByUserId;
        private DBConnect db;



        //Constructor
        public AddEditReportForm(string Type, int filledByUserId, int selectedReportId)
        {
            InitializeComponent();
            this.operationType = Type;
            this.selectedReportId = selectedReportId;
            this.filledByUserId = filledByUserId;
            db = new DBConnect();
        }






        //Load Report For Edit Method
        private void LoadReportForEdit()
        {
            try
            {
                
                string query = $"SELECT * FROM Reports WHERE ReportID = {selectedReportId}";
                DataTable dt = db.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    DataRow r = dt.Rows[0];

                    this.cmbReportType.Text = r["ReportType"].ToString();
                    this.txtReporterName.Text = r["ReporterName"].ToString();
                    this.txtReporterStudentID.Text = r["ReporterStudentID"].ToString();
                    this.txtReporterPhone.Text = r["ReporterPhone"].ToString();

                    this.txtItemName.Text = r["ItemName"].ToString();
                    this.cmbItemCategory.Text = r["ItemCategory"].ToString();
                    this.txtBrand.Text = r["Brand"].ToString();
                    this.txtColor.Text = r["Color"].ToString();
                    this.txtUniqueMark.Text = r["UniqueMark"].ToString();
                    this.txtDescription.Text = r["Description"].ToString();
                    this.txtLocation.Text = r["Location"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }







        //Form Load Event
        private void AddEditReportForm_Load(object sender, EventArgs e)
        {
            if (operationType == "Edit")
            {
                this.LoadReportForEdit();
                btnSaveReport.Text = "Update Report";
            }
            else
            {
                this.btnSaveReport.Text = "Save Report";
            }


        }






        //Form Close
        private void AddEditReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!isNavigatingBack)
            //{
            //    //Application.Exit();
            //}

        }






        //Back Button
        private void btnReportFillFormBack_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }






        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }






        //Save Button 
        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            string reportType = this.cmbReportType.Text;
            string reporterName = this.txtReporterName.Text.Trim();
            string reporterStudentID = this.txtReporterStudentID.Text.Trim();
            string reporterPhone = this.txtReporterPhone.Text.Trim();

            string itemName = this.txtItemName.Text.Trim();
            string itemCategory = this.cmbItemCategory.Text;

            string brand = this.txtBrand.Text.Trim();
            string color = this.txtColor.Text.Trim();
            string uniqueMark = this.txtUniqueMark.Text.Trim();
            string description = this.txtDescription.Text.Trim();
            string location = this.txtLocation.Text.Trim();

            // Basic Validation
            if (reportType == "" || reporterName == "" || reporterStudentID == "" || reporterPhone == "" ||
                itemName == "" || itemCategory == "" || location == "")
            {
                MessageBox.Show("Please fill Up Properly!");
                return;
            }

            // Phone number validation: digits only, length between 7 - 15
            if (!System.Text.RegularExpressions.Regex.IsMatch(reporterPhone, @"^\+?\d{7,15}$"))
            {
                MessageBox.Show("Please Enter Valid Phone Number!.");
                return;
            }



            try
            {
                string query = "";

                // ADD MODE
                if (operationType == "Add")
                {
                    query = $@"
            INSERT INTO Reports
            (ReportType, ReporterName, ReporterStudentID, ReporterPhone,
             ItemName, ItemCategory, Brand, Color, UniqueMark,
             Description, Location, Status, AddedBy)
            VALUES
            ('{reportType}', '{reporterName}', '{reporterStudentID}', '{reporterPhone}',
             '{itemName}', '{itemCategory}', '{brand}', '{color}', '{uniqueMark}',
             '{description}', '{location}', 'Pending', {filledByUserId})";
                }
                // EDIT MODE
                else if (operationType == "Edit")
                {
                    query = $@"
            UPDATE Reports SET
                ReportType = '{reportType}',
                ReporterName = '{reporterName}',
                ReporterStudentID = '{reporterStudentID}',
                ReporterPhone = '{reporterPhone}',
                ItemName = '{itemName}',
                ItemCategory = '{itemCategory}',
                Brand = '{brand}',
                Color = '{color}',
                UniqueMark = '{uniqueMark}',
                Description = '{description}',
                Location = '{location}'
            WHERE ReportID = {selectedReportId}";
                }

                int result = db.ExecuteDMLQuery(query);

                if (result > 0)
                {
                    if (operationType == "Add")
                        MessageBox.Show("Report Created successfully!");
                    else
                        MessageBox.Show("Report Updated successfully!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save error: " + ex.Message);
            }
        }







        //Clear Button 
        private void btnClearReportForm_Click(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = -1;

            txtReporterName.Clear();
            txtReporterStudentID.Clear();
            txtReporterPhone.Clear();

            txtItemName.Clear();
            cmbItemCategory.SelectedIndex = -1;

            txtBrand.Clear();
            txtColor.Clear();
            txtUniqueMark.Clear();
            txtDescription.Clear();
            txtLocation.Clear();
        }









    }
}
