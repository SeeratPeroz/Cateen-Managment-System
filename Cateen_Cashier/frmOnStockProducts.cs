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
            showOnStockProducts(null);

            AD.SelectCommand = new SqlCommand("SELECT COUNT([Product ID])  FROM [Canteen_Database].[dbo].[vw_OnStock]", DBContext.con);
            DataTable dt = new DataTable();
            AD.Fill(dt);
            lbl_totalProducts.Text = dt.Rows[0][0].ToString();
        }

        // Show On Stck Products
        void showOnStockProducts(String search)
        {
            try
            {
                if(search == null)
                {
                    AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[vw_OnStock]", DBContext.con);
                }
                else
                {
                    AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[vw_OnStock] WHERE [Product ID] LIKE '%"+search+ "%' OR [Name] LIKE '%" + search + "%' OR [Quantity] LIKE '%" + search + "%' OR [Category] LIKE '%" + search + "%'", DBContext.con);

                }
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

    

   

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            showOnStockProducts(null);
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

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (Validation.validateSeach(txtSearch.Texts))
            {
                if (txtSearch.Texts == "")
                {
                    showOnStockProducts(null);
                    toggle_OutOFstock.Checked = false;
                }
                else
                {
                    showOnStockProducts(txtSearch.Texts);
                }
            }
            else
            {
                MessageBox.Show("Symbols are not allowed");
            }
            
        }

        private void toggle_OutOFstock_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_OutOFstock.Checked)
            {
                AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[vw_OnStock] WHERE [Quantity] < = 2", DBContext.con);
                DataSet dt = new DataSet();
                AD.Fill(dt);
                excelData = new DataTable();
                AD.Fill(excelData);
                dgv_OnStock.DataSource = dt.Tables[0];
            }
            else
            {
                showOnStockProducts(null);
            }
        }
    }
}
