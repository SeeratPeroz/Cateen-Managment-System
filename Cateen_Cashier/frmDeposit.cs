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

    public partial class frmDeposit : Form
    {
        String name, IDD, Balance,Card;

        int toggle = 0;
        SqlDataAdapter AD;
        String custPKID;
        String custName;
        String custBalance;
        String custID;
        bool checkBalance = false;
        bool userFound = false;
        // UniPrice variable for update operation
        long updatePrice;
        // Updating deposited money 
        String Balance_ID;
        String oldAmount;
        // Update Customer Record variable to store customer pK
        long custCart_pnlCustomer = 0;

        // PRODUCT PANEL UPDATE RECORD ID and also use to store Category ID in Category Panel
        String strPrdID_ProductPanel;
        String strCatID_ProductPanel;

        // FORM MOVEMENT
        private bool dragging;
        private Point startPoint;
        private int clickMOVE = 1;


        // Data Entry base on Validation, Declaring Validation Veriables
        bool isCategory_Panel_Valid = false;
        bool isProduct_Panel_Valid = false;
        // Cart Panel
        bool isCardValid_ID_pnlCart = false;
        bool isCardValid_Quantity_pnlCart = false;
        bool isSearchByName_pnlCart = false;
        // Customer Panel
        bool isCustomerValid_pnlCustomer = false;
        // Deposit Panel
        bool isdopisteAmount_validate_pnlDeposit;
        public frmDeposit(String Card, String name, String Balance,String IDD)
        {
            InitializeComponent();
            DBContext.createConnection(Program.userName, Program.userPass);
            AD = new SqlDataAdapter();
            this.Card = Card;
            this.name = name;
            this.Balance = Balance;
            this.IDD = IDD;
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            lblCustID.Text = IDD;
            lblCustName.Text = name;
            lblCustBalance.Text = Balance;
            pnlUpdate_Child_pnlDeposit.Visible = false;
            lblCustCard.Text = Card;
            get_user_image();

        }


        // get imgage()
        void get_user_image()
        {
            try
            {
                // Searching Customer Image
                AD.SelectCommand = new SqlCommand("SELECT [custImage] FROM [Canteen_Database].[dbo].[Customers] WHERE [custCard] ='" + lblCustCard.Text+"'", DBContext.con);
                DataTable dt = new DataTable();
                AD.Fill(dt);
                String imgDGV = dt.Rows[0][0].ToString();
                pic_User.Image = new Bitmap(@"" + imgDGV);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Deposit Image: " + ex.Message);
            }
        }

        // Add to balance button.
        private void btn_Add2Balance_Click(object sender, EventArgs e)
        {
            if (txtDepositAmount1.Texts == "")
            {
                MessageBox.Show("Please enter a value in text box.");
                txtDepositAmount1.Focus();
              
            }
            else
            {
                if (isdopisteAmount_validate_pnlDeposit)
                {
                    // Depositing amount to customer balance.
                    depositeMoney(Card, txtDepositAmount1.Texts);
                    
                }
                else
                {
                    MessageBox.Show("Please fill the text boxes with numbers");
                    txtDepositAmount1.Focus();
                    
                }

            }
        }

        // Depositing Money function
        private void depositeMoney(String id, String amount)
        {
            try
            {
                String Date = DateTime.Now.ToString("yyyy-MM-dd");
                String Query = "INSERT INTO [Canteen_Database].[dbo].[customer_Balance] ([custCard] ,[depositeDate] ,[depositAmount]) VALUES ('" + id + "'," + Date + "," + amount + ")";
                AD.InsertCommand = new SqlCommand(Query, DBContext.con);
                DBContext.openConnection();
                AD.InsertCommand.ExecuteNonQuery();
                MessageBox.Show(amount + " is deposited to " + id + " account.");
                DBContext.closeConnection();

                // Call function to show balance of customer.
                showCustomerBalancebyCard(lblCustCard.Text);
                txtDepositAmount1.Texts = "";



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //==================================================================================

        // Validating Deposite Moeny Text box --> Deposit Panel
        private void txtDepositAmount_TextChanged(object sender, EventArgs e)
        {
            isdopisteAmount_validate_pnlDeposit = Validation.validatePrice(txtDepositAmount1.Texts);
            if (isdopisteAmount_validate_pnlDeposit)
            {
                pic_depositeAmount_pnlDeposit.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_depositeAmount_pnlDeposit.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }


        // Toggle Button to show customer deposit list
        private void btn_Transaction_pnlDeposit_Click(object sender, EventArgs e)
        {
            if (pnlUpdate_Child_pnlDeposit.Visible)
            {
                pnlUpdate_Child_pnlDeposit.Visible = false;
                txtPriceUpdate.Texts = "";
                showDeposit_list(lblCustCard.Text);
                btn_Add2Balance1.Visible = true;
                txtDepositAmount1.Visible = true;
                pnl_label.Visible = true;
                pnl_pic.Visible = true;
            }
            else
            {
                showDeposit_list(lblCustCard.Text);
                pnlUpdate_Child_pnlDeposit.Visible = true;
                btn_Add2Balance1.Visible = false;
                txtDepositAmount1.Visible = false;
                pnl_label.Visible = false;
                pnl_pic.Visible = false;

            }
        }


        // Show Deposit list 
        void showDeposit_list(String search)
        {
            try
            {
                String QYR = "SELECT TOP 3 [BID] as Balance_ID,depositeDate as Deposited_Date,depositAmount as Amount FROM [Canteen_Database].[dbo].[customer_Balance] WHERE [custCard] = '" + search + "' order by BID desc";
                AD.SelectCommand = new SqlCommand(QYR, DBContext.con);
                DataSet dpDS = new DataSet();
                AD.Fill(dpDS);
                dgvCustomerDeposit_List_pnlDeposit.DataSource = dpDS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deposit Panel: " + ex.Message);
            }
        }


        // Update Deposit list 
        void updateDeposite_list(String search, String amount)
        {
            try
            {
                String QR = "UPDATE [Canteen_Database].[dbo].[customer_Balance] SET [depositAmount] = " + amount + " WHERE [BID] = " + search;
                AD.UpdateCommand = new SqlCommand(QR, DBContext.con);
                DBContext.openConnection();
                AD.UpdateCommand.ExecuteNonQuery();
                DBContext.closeConnection();

                // Save transaction of employee
                String Date = DateTime.Now.ToString("yyyy-MM-dd");
                String Q = "INSERT INTO [Canteen_Database].[dbo].[update_Tranasaction] ([trans_date] ,[BID] ,[transed_amount_old],[transed_amount_new] ,[trans_state]) VALUES ('" + Date.ToString() + "'," + search + "," + oldAmount + "," + amount + ",'Update_" + lblCustCard.Text + "')";
                AD.InsertCommand = new SqlCommand(Q, DBContext.con);
                DBContext.openConnection();
                AD.InsertCommand.ExecuteNonQuery();
                DBContext.closeConnection();

                showDeposit_list(Card);
                MessageBox.Show("Updated successfully");
                Balance_ID = "";
                txtPriceUpdate.Texts = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while update deposite: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Add_MouseEnter(object sender, EventArgs e)
        {
            btn_Add2Balance1.ForeColor = Color.Black;
        }

        private void Add_MouseLeave(object sender, EventArgs e)
        {
            btn_Add2Balance1.ForeColor = Color.DeepSkyBlue;
        }

       








        // Depiste Panel deposit list Gride View.
        private void dgvCustomerDeposit_List_pnlDeposit_Click(object sender, EventArgs e)
        {
            Balance_ID = dgvCustomerDeposit_List_pnlDeposit.CurrentRow.Cells[0].FormattedValue.ToString();
            txtPriceUpdate.Texts = dgvCustomerDeposit_List_pnlDeposit.CurrentRow.Cells[2].FormattedValue.ToString();
            oldAmount = dgvCustomerDeposit_List_pnlDeposit.CurrentRow.Cells[2].FormattedValue.ToString();
        }

        // Button to update deposit list
        private void btn_Update_DpMoeney_pnlDeposit_Click_1(object sender, EventArgs e)
        {
            if (Validation.validatePrice(txtPriceUpdate.Texts))
            {
                updateDeposite_list(Balance_ID, txtPriceUpdate.Texts);
                showCustomerBalancebyCard(Card);
            }
            else
            {
                MessageBox.Show("Please enter price for product");
                txtPriceUpdate.Focus();
                txtPriceUpdate.Select();
            }

        }


        // Customer Balance to Display in DEPOSIT Panel
        public void showCustomerBalancebyCard(String id)
        {
            try
            {
                String QER = "SELECT * FROM [Canteen_Database].[dbo].[vw_CustomerBalance] WHERE [CustomerCard] = '" + id + "' OR [custID] = '" + id+"'";
                DataTable ds = new DataTable();
                AD.SelectCommand = new SqlCommand(QER, DBContext.con);

                AD.Fill(ds);

                lblCustID.Text = ds.Rows[0][3].ToString(); ;
                lblCustName.Text = ds.Rows[0][1].ToString();
                lblCustBalance.Text = ds.Rows[0][2].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Balance by ID: " + ex.Message);
            }
        }

    }
}
