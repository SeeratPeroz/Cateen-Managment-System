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
    public partial class frmCustomerSearch : Form
    {
        String NAME, BALANCE, CARD,IDD;
        String Check_Balance_pnl = null;

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
        public frmCustomerSearch(String st)
        {
            InitializeComponent();
            DBContext.createConnection(Program.userName, Program.userPass);
            AD = new SqlDataAdapter();
            Check_Balance_pnl = st;
        }

        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        //----------------------

        // Search by Card
        public void showCustomerbyCard(TextBox id)
        {
            try
            {
                DataTable DS = new DataTable();
                AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[Customers] WHERE custCard = " + id.Text, DBContext.con);
                AD.Fill(DS);
                try
                {
                    CARD = DS.Rows[0][0].ToString();
                    IDD = DS.Rows[0][4].ToString();
                    NAME = DS.Rows[0][1].ToString();

                    BALANCE = "N/A";
                    //pic_User.Image = new Bitmap(@"" + DS.Rows[0][5]);
                    //  MessageBox.Show(custPKID);
                    userFound = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("User not found.");
                    userFound = false;
                    custPKID = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Customer By Card: " + ex.Message);
            }
        }






        // Search by ID Function ---> DEPOSIT PANEL
        public void showCustomerbyID(TextBox id)
        {
            try
            {
                DataTable DS = new DataTable();
                AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[Customers] WHERE custID = " + id.Text, DBContext.con);
                AD.Fill(DS);
                try
                {
                    CARD = DS.Rows[0][0].ToString();
                    IDD = DS.Rows[0][4].ToString();
                    NAME = DS.Rows[0][1].ToString();
                    BALANCE = DS.Rows[0][2].ToString();
                //    pic_User.Image = new Bitmap(@"" + DS.Rows[0][5].ToString());
                    //MessageBox.Show(custPKID);
                    userFound = true;

                }
                catch (Exception)
                {
                    MessageBox.Show("User not found.");
                    userFound = false;
                    custPKID = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Enter key to Search Customer in Search Panel (pnlCustomerSearch)
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (Validation.validateCustCard(txtSearch.Text))
                {
                    Console.Beep(1000, 800);
                    picSearchButton();
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID or Card#");
                }
            }
        }
        // Button to search user.
        private void picSearch_Click(object sender, EventArgs e)
        {
            if (Validation.validateCustCard(txtSearch.Text))
            {
                picSearchButton();
            }
            else
            {
                MessageBox.Show("Please enter a valid ID or Card#");
                txtSearch.Focus();
                txtSearch.SelectAll();
            }
        }


        // Function for PicSearch Button
        void picSearchButton()
        {
            if (toggle == 0 && txtSearch.Text != "")
            {
                showCustomerbyID(txtSearch);

            }
            else if (toggle == 1 && txtSearch.Text != "")
            {

                showCustomerbyCard(txtSearch);
            }



            // Condition to check wheather user found or not
            if (userFound && txtSearch.Text != "")
            {
                showCustomerBalancebyCard(txtSearch.Text);
                //frmMain.openChildForm(new frmDeposit(ID,NAME,BALANCE));
              // MessageBox.Show("User Found: "+userFound.ToString());
                // Opening Deposit Form

                if(Check_Balance_pnl == "DP")
                {
                    openDepositForm();
                }
                else if(Check_Balance_pnl == null)
                {
                    open_CheckBalance_Form();
                }

            }
            else
            {
                MessageBox.Show("Please enter you ID or scan user Card.");
            }
        }

        // Function open Check_Balance Form
        // Function to openDeposit form
        void open_CheckBalance_Form()
        {
            frmMain.activeForm = null;
            Form childForm = new frmCheckBalance(CARD, NAME, BALANCE, IDD);

            if (frmMain.activeForm != null)
            {
                frmMain.activeForm.Close();
            }
            frmMain.activeForm = childForm;
            childForm.TopLevel = false;
            childForm.BringToFront();
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            frmMain.pnl_Child_Form.Controls.Add(childForm);
            frmMain.pnl_Child_Form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        // Function to openDeposit form
        void openDepositForm()
        {
            frmMain.activeForm = null;
            Form childForm = new frmDeposit(CARD, NAME, BALANCE,IDD);

            if (frmMain.activeForm != null)
            {
                frmMain.activeForm.Close();
            }
            frmMain.activeForm = childForm;
            childForm.TopLevel = false;
            childForm.BringToFront();
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            frmMain.pnl_Child_Form.Controls.Add(childForm);
            frmMain.pnl_Child_Form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        // Customer Balance to Display in DEPOSIT Panel
        public void showCustomerBalancebyCard(String id)
        {
            try
            {
                String QER = "SELECT * FROM [Canteen_Database].[dbo].[vw_CustomerBalance] WHERE [CustomerCard] = " + id + " OR [custID] = " + id;
                DataTable ds = new DataTable();
                AD.SelectCommand = new SqlCommand(QER, DBContext.con);

                AD.Fill(ds);

                //CARD = CARD;
                NAME = ds.Rows[0][1].ToString();
                BALANCE = ds.Rows[0][2].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Balance by ID: " + ex.Message);
            }
        }

 


        // User can search by.
        private void picSearchBy_Click(object sender, EventArgs e)
        {
            if (toggle == 1)
            {
                lblSearchBY.Text = "Customer ID";
                toggle = 0;
                txtSearch.Text = "";
            }
            else
            {
                lblSearchBY.Text = "Customer Card";
                toggle = 1;
                txtSearch.Text = "";

            }

            // txtSearch.Text = toggle.ToString();
        }

        // Search By Hover
        private void picSearchBy_MouseHover(object sender, EventArgs e)
        {
            picSearchBy.BackColor = Color.Silver;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCustomerSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSearchBY_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        // Search By Hover 1
        private void picSearchBy_MouseLeave(object sender, EventArgs e)
        {
            picSearchBy.BackColor = Color.Transparent;

        }
        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            picSearch.BackColor = Color.Silver;
        }

        private void picSearch_MouseLeave(object sender, EventArgs e)
        {
            picSearch.BackColor = Color.Transparent;

        }
        
    }
}
