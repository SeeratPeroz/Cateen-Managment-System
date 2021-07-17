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
    public partial class frmOnStockProducts : Form
    {
        SqlDataAdapter AD;
        String searchStock = "";
        DataTable excelData;
        public frmOnStockProducts()
        {
            InitializeComponent();
            AD = new SqlDataAdapter();
            DBContext.createConnection(Program.userName, Program.userPass);
        }

        private void frmOnStockProducts_Load(object sender, EventArgs e)
        {
            showOnStockProducts();
        }

        // Show On Stck Products
        void showOnStockProducts()
        {
            try
            {
                AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[vw_OnStock]", DBContext.con);
                DataSet dt = new DataSet();
                AD.Fill(dt);
                excelData = new DataTable();
                AD.Fill(excelData);
                dgv_OnStock.DataSource = dt.Tables[0];
            }catch(Exception ex)
            {
                MessageBox.Show("Error to show on stock products: "+ex.Message);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Stock_Print stP = new Stock_Print();
            stP.Show();
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSearchBy.Text == "Category Name")
            {
                searchStock = "Category";
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.Text == "Category Name")
            {
                SearchStock(searchStock);
            }
            else
            {
                SearchStock(cmbSearchBy.Text);
            }

        }

        void SearchStock(String Search)
        {
            try
            {
                String QYR = "";
                if(Search == "")
                {
                    showOnStockProducts();
                }
                else
                {
                    QYR = "SELECT *  FROM [Canteen_Database].[dbo].[vw_OnStock] WHERE [" + Search + "] = '" + txtSearch.Text+"'";
                    //MessageBox.Show(QYR);

                    AD.SelectCommand = new SqlCommand(QYR, DBContext.con);
                    DataTable dt = new DataTable();
                    AD.Fill(dt);
                    excelData = new DataTable();

                    AD.Fill(excelData);
                    dgv_OnStock.DataSource = dt;
                }

            }catch(Exception ed)
            {
                MessageBox.Show("Error while searching product: "+ ed.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            showOnStockProducts();
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            export_excel();
        }
        // Function to export data.
        void export_excel()
        {
            try
            {
                using(SaveFileDialog sf = new SaveFileDialog() { Filter = "Excel workboox|*.xlsx"})
                {
                    if(sf.ShowDialog() == DialogResult.OK)
                    {
                        using(XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(excelData, "On Stock");
                            workbook.SaveAs(sf.FileName);
                        }
                        MessageBox.Show("Successfully exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error while exporting data: " + ex.Message, "Inof");
            }
        }
    }
}
