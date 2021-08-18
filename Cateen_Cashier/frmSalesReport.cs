using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cateen_Cashier
{
    public partial class frmSalesReport : Form
    {
        SqlDataAdapter AD;
        String searchStock = "";
        DataTable excelData;
        String From, To, Search_data;
        String path;

        public frmSalesReport()
        {
            InitializeComponent();
            AD = new SqlDataAdapter();
            DBContext.createConnection(Program.userName, Program.userPass);
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

        }

         // Show On Sales
        void showOnStockProducts(string Search,string fromDate, string toDate)
        {
            try
            {
                if (Search == null & fromDate ==null & toDate==null)
                {
                    AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[vw_SalesReport]", DBContext.con);

                }
                else if(Search != null & fromDate == null & toDate == null)
                {
                    AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[vw_SalesReport] WHERE [Invoice #] LIKE '%"+Search+"%' OR [Customer] LIKE '%"+Search+"%'", DBContext.con);

                }
                else if (Search != null & fromDate != null & toDate != null)
                {
                    AD.SelectCommand = new SqlCommand("SELECT * FROM[Canteen_Database].[dbo].[vw_SalesReport] where([Sale Date] < '"+ toDate+ "' and[Sale Date] >= '"+ fromDate + "') and([Invoice #] LIKE '%"+Search+ "%' OR [Customer] LIKE '%" + Search + "%')  ", DBContext.con);

                }
                else
                {
                    AD.SelectCommand = new SqlCommand("SELECT * FROM[Canteen_Database].[dbo].[vw_SalesReport] where([Sale Date] < '" + toDate + "' and[Sale Date] >= '" + fromDate + "') ", DBContext.con);
                }
                DataSet dt = new DataSet();
                AD.Fill(dt);
                excelData = new DataTable();
                AD.Fill(excelData);
                dgv_Sales.DataSource = dt.Tables[0];
            }catch(Exception ex)
            {
                MessageBox.Show("Error to show on stock products: "+ex.Message);
            }
        }
        // Load event of form  to show all report and make veriables empty.
        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            showOnStockProducts(null,null,null);
            From = To = Search_data=null;
        }
        // Load event of form  to show all report and make veriables empty.
        private void dtpk_To_ValueChanged(object sender, EventArgs e)
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

        private void dgv_Sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
                            workbook.Worksheets.Add(excelData, "Sales Report");
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

        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You should save the report first.", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                export_excel();
                frmEmail fr = new frmEmail(path);
                fr.Show();
            }
        }

         // Function to display Specific Invoice Details
        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please wait to load invoice.");


            frm_InvDetails_Report frm = new frm_InvDetails_Report(txtInvoiceSearch.Texts);
                    frm.Show();
        }




        // From date picker click event
        private void dtpk_From_ValueChanged(object sender, EventArgs e)
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
                txtInvoiceSearch.Focus();
                
            }

        }

       
    }
}

