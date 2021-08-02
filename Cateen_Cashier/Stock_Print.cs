using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Cateen_Cashier
{
    public partial class Stock_Print : Form
    {
        DataTable dt;
        SqlDataAdapter AD;
        public Stock_Print()
        {
            InitializeComponent();
            AD = new SqlDataAdapter();
            DBContext.createConnection(Program.userName, Program.userPass);
            showOnStockProducts();
        }

        private void Stock_Print_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument crypt = new ReportDocument();
                CrystalReport1 cr = new CrystalReport1();
                string path = Application.StartupPath + "\\CrystalReport1.rpt";
                MessageBox.Show(path);
                crypt.Load(path);
                //crypt.SetDataSource(dt);


                //cr.Database.Tables["vw_OnStock"].SetDataSource(dt);
                //cr.SetDataSource(dt);
                crystal_Report.ReportSource = crypt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error on Stock Print: " + ex.Message);
            }
            

        }

        public void showOnStockProducts()
        {
            try
            {
                dt = new DataTable();
                DBContext.openConnection();
                AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[vw_OnStock] where [Product ID] = 1", DBContext.con);
                AD.Fill(dt);
                           }
            catch (Exception ex)
            {
                MessageBox.Show("Error to show on stock products: " + ex.Message);
            }
        }
    }
}
