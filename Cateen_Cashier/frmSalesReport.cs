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
    public partial class frmSalesReport : Form
    {
        SqlDataAdapter AD;
        String searchStock = "";
        DataTable excelData;
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
        void showOnStockProducts()
        {
            try
            {
                AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[vw_SalesReport]", DBContext.con);
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

        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            showOnStockProducts();
        }

       
    }
}
