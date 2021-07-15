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
namespace Cateen_Cashier
{
    public partial class frmDashboard : Form
    {
        SqlDataAdapter AD;
        public frmDashboard()
        {
            InitializeComponent();
            AD = new SqlDataAdapter();
            DBContext.createConnection(Program.userName, Program.userPass);

        }



        private void frmDashboard_Load(object sender, EventArgs e)
        {

            show_Statictics();
        }

        // SHow statistics
        void show_Statictics()
        {
            try
            {
                AD.SelectCommand = new SqlCommand("SELECT COUNT(custID) FROM [Canteen_Database].[dbo].[Customers]", DBContext.con);
                DataTable dtCustomer = new DataTable();
                AD.Fill(dtCustomer);
                lblCustomerCount.Text = dtCustomer.Rows[0][0].ToString();

                AD.SelectCommand = new SqlCommand("SELECT *FROM [Canteen_Database].[dbo].[vw_Daily_Sales]", DBContext.con);
                DataTable dtEarnings = new DataTable();
                AD.Fill(dtEarnings);
                lblEarnings.Text = dtEarnings.Rows[0][0].ToString();

                //

                AD.SelectCommand = new SqlCommand("SELECT COUNT([prdID]) FROM [Canteen_Database].[dbo].[Products]", DBContext.con);
                DataTable dtProducts = new DataTable();
                AD.Fill(dtProducts);
                lblProduct_on_stk.Text = dtProducts.Rows[0][0].ToString();


                // SELECT TOP 10 [prdName] ,[Expr1] FROM [Canteen_Database].[dbo].[vw_Top_10_Products]
                AD.SelectCommand = new SqlCommand("SELECT TOP 5 * FROM [Canteen_Database].[dbo].[vw_Top_10_Products] order by [Total Sold] desc", DBContext.con);
                DataTable dt_Top_Products = new DataTable();
                AD.Fill(dt_Top_Products);
                dv.DataSource = dt_Top_Products;


                for (int s = 0; s < dv.RowCount - 1; s++)
                {
                    //MessageBox.Show(dt_Top_Products.Rows[0][1].ToString());

                    chart_top_product.Series["Products"].Points.Add(Convert.ToInt32(dt_Top_Products.Rows[s][1].ToString()));
                    chart_top_product.Series["Products"].Points[s].AxisLabel = dt_Top_Products.Rows[s][0].ToString();
                    chart_top_product.Series["Products"].Points[s].LegendText = dt_Top_Products.Rows[s][0].ToString();
                    chart_top_product.Series["Products"].Points[s].Label = dt_Top_Products.Rows[s][1].ToString();
                    //chart_top_product.Series["Apple"].Points.AddXY(200, Convert.ToInt32(dt_Top_Products.Rows[s][1].ToString()));
                }
                chart_top_product.Series["Products"].Points[0].Color = Color.Orchid;
                chart_top_product.Series["Products"].Points[1].Color = Color.Green;
                chart_top_product.Series["Products"].Points[2].Color = Color.Black;
                chart_top_product.Series["Products"].Points[3].Color = Color.Yellow;
                chart_top_product.Series["Products"].Points[4].Color = Color.Orange;



                AD.SelectCommand = new SqlCommand("SELECT sum([amount]) FROM [Canteen_Database].[dbo].[Invoice_Details]", DBContext.con);
                DataTable dt_Top_Products1 = new DataTable();
                AD.Fill(dt_Top_Products1);

                sales_Purchase_chart.Series["Series4"].Points.AddXY("Income", dt_Top_Products1.Rows[0][0]);
                sales_Purchase_chart.Series["Series4"].Points[0].Label = dt_Top_Products1.Rows[0][0].ToString() + " Afs";
                sales_Purchase_chart.Series["Series4"].Points[0].LegendText = "Income";

                AD.SelectCommand = new SqlCommand("SELECT sum([amount]) FROM [Canteen_Database].[dbo].[Purchase_Details]", DBContext.con);
                DataTable dt_Top_Products2 = new DataTable();
                AD.Fill(dt_Top_Products2);

                sales_Purchase_chart.Series["Series4"].Points.AddXY("Expence", dt_Top_Products2.Rows[0][0]);
                sales_Purchase_chart.Series["Series4"].Points[1].Label = dt_Top_Products2.Rows[0][0].ToString() + " Afs";
                sales_Purchase_chart.Series["Series4"].Points[1].LegendText = "Expence";

            }
            catch(Exception ex)
            {
                MessageBox.Show("Statics: " + ex.Message);
            }
        }

        
    }
}
