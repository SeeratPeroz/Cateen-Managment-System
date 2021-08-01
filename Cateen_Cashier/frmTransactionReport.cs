using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cateen_Cashier
{
    public partial class frmTransactionReport : Form
    {
        SqlDataAdapter AD;
        String searchStock = "";
        DataTable excelData;
        String From, To, Search_data;
        String path;
        public frmTransactionReport()
        {
            InitializeComponent();
            AD = new SqlDataAdapter();
            DBContext.createConnection(Program.userName, Program.userPass);
        }



        // Show On Transactions
        void showOnStockProducts(string Search, string fromDate, string toDate)
        {
            try
            {
                if (Search == null & fromDate == null & toDate == null)
                {
                    AD.SelectCommand = new SqlCommand("SELECT * FROM [Canteen_Database].[dbo].[vw_TransactionReport]", DBContext.con);

                }
                else if (Search != null & fromDate == null & toDate == null)
                {
                    AD.SelectCommand = new SqlCommand("SELECT * FROM [Canteen_Database].[dbo].[vw_TransactionReport] WHERE [Employee] LIKE '%" + Search + "%' OR [Customer] LIKE '%" + Search + "%'", DBContext.con);

                }
                else if (Search != null & fromDate != null & toDate != null)
                {
                    AD.SelectCommand = new SqlCommand("SELECT * FROM [Canteen_Database].[dbo].[vw_TransactionReport] where([Deposit Date] < '" + toDate + "' and[Deposit Date] >= '" + fromDate + "') and([Employee] LIKE '%" + Search + "%' OR [Customer] LIKE '%" + Search + "%')  ", DBContext.con);

                }
                else
                {
                    AD.SelectCommand = new SqlCommand("SELECT * FROM [Canteen_Database].[dbo].[vw_TransactionReport] where([Deposit Date] < '" + toDate + "' and [Deposit Date] >= '" + fromDate + "') ", DBContext.con);
                }
                DataSet dt = new DataSet();
                AD.Fill(dt);
                excelData = new DataTable();
                AD.Fill(excelData);
                dgv_Sales.DataSource = dt.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to show on stock products: " + ex.Message);
            }
        }

        // Load event of form  to show all report and make veriables empty.
        private void dtpk_To_ValueChanged_1(object sender, EventArgs e)
        {

            DateTime dtp = dtpk_From.Value;
            From = dtp.Year + "-" + dtp.Month + "-" + dtp.Day;
            DateTime dtp1 = dtpk_To.Value;
            To = dtp1.Year + "-" + dtp1.Month + "-" + dtp1.Day;

            //MessageBox.Show("FROM: " + From + "     TO: " + To);

            if (Search_data == null)
            {
                showOnStockProducts(null, From, To);
            }
            else
            {
                showOnStockProducts(Search_data, From, To);
            }
        }


        // Button to reset girde view searched data
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            showOnStockProducts(null, null, null);
            From = To = Search_data = null;
        }

        private void btn_Export_to_exel_Click(object sender, EventArgs e)
        {
            export_excel();
        }


        // Function to export data.
        void export_excel()
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog() { Filter = "Excel workboox|*.xlsx" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(excelData, "Purchase Report");
                            workbook.SaveAs(sf.FileName);
                            path = sf.FileName;
                        }
                        MessageBox.Show("Successfully exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while exporting data: " + ex.Message, "Inof");
            }
        }

        // Load event of Panel

        private void frmTransactionReport_Load(object sender, EventArgs e)
        {
            showOnStockProducts(null, null, null);
            From = To = Search_data = null;
        }

        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You should first save the report .", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                export_excel();
                frmEmail fr = new frmEmail(path);
                fr.Show();
            }
        }











        // From date picker click event
        private void dtpk_From_ValueChanged_1(object sender, EventArgs e)
        {

            DateTime dtp = dtpk_From.Value;
            From = dtp.Year + "-" + dtp.Month + "-" + dtp.Day;
            DateTime dtp1 = dtpk_To.Value;
            To = dtp1.Year + "-" + dtp1.Month + "-" + dtp1.Day;

            //MessageBox.Show("FROM: " + From + "     TO: " + To);
            if (Search_data == null)
            {
                showOnStockProducts(null, From, To);
            }
            else
            {
                showOnStockProducts(Search_data, From, To);
            }
        }


        // Search in gride view
        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            if (Validation.validateSeach(txtSearch.Texts))
            {
                if (To == null || From == null)
                {
                    Search_data = txtSearch.Texts;
                    showOnStockProducts(Search_data, null, null);
                }
                else
                {
                    Search_data = txtSearch.Texts;
                    showOnStockProducts(Search_data, From, To);
                }

                if (txtSearch.Texts == "")
                {
                    Search_data = null;
                }
            }
            else
            {
                MessageBox.Show("Symbols are not allowed");
                txtSearch.Texts = "";
                dgv_Sales.Focus();
            }

        }


    }
}
