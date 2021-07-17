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

    public partial class frmCheckBalance : Form
    {
        String name, IDD, Balance, Card;
        SqlDataAdapter AD;

        public frmCheckBalance(String Card, String name, String Balance, String IDD)
        {
            InitializeComponent();
            DBContext.createConnection(Program.userName, Program.userPass);
            AD = new SqlDataAdapter();
            this.Card = Card;
            this.name = name;
            this.Balance = Balance;
            this.IDD = IDD;

            /// ------------------------------------
            lblCustID.Text = IDD;
            lblCustName.Text = name;
            //lblCustBalance.Text = Balance +" Afs";
            get_user_image();
            showCustomerBalance();
        }

        void get_user_image()
        {
            try
            {
                // Searching Customer Image
                AD.SelectCommand = new SqlCommand("SELECT [custImage] FROM [Canteen_Database].[dbo].[Customers] WHERE [custCard] =" + Card, DBContext.con);
                DataTable dt = new DataTable();
                AD.Fill(dt);
                String imgDGV = dt.Rows[0][0].ToString();
                pic_User1.Image = new Bitmap(@"" + imgDGV);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Deposit Image: " + ex.Message);
            }
        }

        // Customer Balance to Display in DEPOSIT Panel
        public void showCustomerBalance()
        {
            try
            {
                String QER = "SELECT * FROM [Canteen_Database].[dbo].[vw_CustomerBalance] WHERE [CustomerCard] = " + Card + " OR [custID] = " + lblCustID.Text;
                DataTable ds = new DataTable();
                AD.SelectCommand = new SqlCommand(QER, DBContext.con);

                AD.Fill(ds);
                lblCustBalance.Text = ds.Rows[0][2].ToString() + " Afs";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have not deposited yet! \n " + ex.Message);
            }
        }
    }
}
