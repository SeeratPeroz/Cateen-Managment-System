using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cateen_Cashier
{
    public partial class frmCustomer : Form
    {
        String Image_Path2;


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
        public frmCustomer()
        {
            InitializeComponent();
            DBContext.createConnection(Program.userName, Program.userPass);
            AD = new SqlDataAdapter();
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            // Set default image for customer
            pic_user_pnlCustomerAcc.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\avatart.png");


            // Call function to show all Customers in Customer Panel Grid View
            showAllCustomers();
            clearTextBoxes();
            txtCustomerPanelSearch.Clear();
            showCust_Type();
        }

        // Show cutomer types
        void showCust_Type()
        {
            try
            {
                DataSet dws = new DataSet();
                AD.SelectCommand = new SqlCommand("SELECT * FROM [Canteen_Database].[dbo].[Customer_Type]", DBContext.con);
                AD.Fill(dws);
                cmb_Cust_TYpe.DataSource = dws.Tables[0];
                cmb_Cust_TYpe.DisplayMember = "cust_Type";
                cmb_Cust_TYpe.ValueMember = "cust_Type_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // ---------------------------------------------------------------------------------------
 
 

        //--------------------------- Validation -----------------------------------------------

        // Validating Customer Card NO -> Custmer Panel
        private void txtCustCard_TextChanged(object sender, EventArgs e)
        {
            isCustomerValid_pnlCustomer = Validation.validateCustCard(txtCustCard.Text);
            if (isCustomerValid_pnlCustomer)
            {
                //pic_customerCardValidate_pnlCustomer.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                //pic_customerCardValidate_pnlCustomer.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }
        // Validating Customer ID  -> Custmer Panel
        private void txtCustID_TextChanged(object sender, EventArgs e)
        {
            isCustomerValid_pnlCustomer = Validation.validateCustID(txtCustID.Text);
            if (isCustomerValid_pnlCustomer)
            {
                pic_customerIDValidate_pnlCustomer.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_customerIDValidate_pnlCustomer.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }
        // Validating Customer Name  -> Custmer Panel
        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
            isCustomerValid_pnlCustomer = Validation.validateCustName(txtCustName.Text);
            if (isCustomerValid_pnlCustomer)
            {
                pic_customerNameValidate_pnlCustomer.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_customerNameValidate_pnlCustomer.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }
        // Validating Customer Email  -> Custmer Panel
        private void txtCustEmail_TextChanged(object sender, EventArgs e)
        {
            isCustomerValid_pnlCustomer = Validation.validateCustEmail(txtCustEmail.Text);
            if (isCustomerValid_pnlCustomer)
            {
                pic_customerEmailValidate_pnlCustomer.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_customerEmailValidate_pnlCustomer.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }
        // Validating Customer Phone  -> Custmer Panel
        private void txtCustPhone_TextChanged(object sender, EventArgs e)
        {
            isCustomerValid_pnlCustomer = Validation.validateCustPhone(txtCustPhone.Text);
            if (isCustomerValid_pnlCustomer)
            {
                pic_customerPhoneValidate_pnlCustomer.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_customerPhoneValidate_pnlCustomer.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }

// ------------------------------------------------------

        // Customer IMAGE
        private void btnSave_Pic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpg; *.png; *.jpeg; *.gif;)|*.gif; *.jpg; *.png; *.jpeg;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtImage_Path.Text = open.FileName;
                    pic_user_pnlCustomerAcc.Image = new Bitmap(open.FileName);
                }
                File.Copy(txtImage_Path.Text, Path.Combine(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\Images\", Path.GetFileName(txtImage_Path.Text)), true);
                Image_Path2 = @"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\Images\" + Path.GetFileName(txtImage_Path.Text);
                txtImage_Path.Text = Image_Path2;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while importing image: " + ex.Message);
            }
            
        }

        /*
        ---------------------------------------
                    CUSTOMER PANEL
        ---------------------------------------
        */
        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {

        }





        private void btnShow_Click(object sender, EventArgs e)
        {
            showAllCustomers();
            showCust_Type();
        }

        private void showAllCustomers()
        {
            try
            {
                DataSet dws = new DataSet();
                AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[vw_Customer_Display]", DBContext.con);
                AD.Fill(dws);
                dgvCustomer.DataSource = dws.Tables[0];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Button to insert customer details in Database ---> CUSTOMER_ACCOUNT PANEL
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isCustomerValid_pnlCustomer)
            {
                try
                {
                    AD.InsertCommand = new SqlCommand("INSERT INTO [Canteen_Database].[dbo].[Customers] VALUES ('" + txtCustCard.Text + "','" + txtCustName.Text + "','" + txtCustEmail.Text + "','" + txtCustPhone.Text + "','" + txtCustID.Text + "', '" + Image_Path2 + "','"+cmb_Cust_TYpe.SelectedValue+"')", DBContext.con);
                    DBContext.openConnection();
                    AD.InsertCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                    MessageBox.Show("Customer added successfully.");

                    //// ADD creating account to deposit money.
                    //String Date = DateTime.Now.ToString("yyyy-MM-dd");
                    //String Query = "INSERT INTO [Canteen_Database].[dbo].[customer_Balance] ([custCard] ,[depositeDate] ,[depositAmount]) VALUES ('" + txtCustCard.Text + "'," + Date + ",0)";
                    //AD.InsertCommand = new SqlCommand(Query, DBContext.con);
                    //DBContext.openConnection();
                    //AD.InsertCommand.ExecuteNonQuery();
                    //DBContext.closeConnection();
                    showAllCustomers();
                    clearTextBoxes();
                    pic_user_pnlCustomerAcc.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\avatart.png");
                    txtImage_Path.Clear();

                    showAllCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter correct value");
            }
        }


        // Deleting customer  from customer Panel
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure to delete selected customer?.", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AD.DeleteCommand = new SqlCommand("DELETE FROM [Canteen_Database].[dbo].[Customers] WHERE custCard = '" + txtCustCard.Text + "'", DBContext.con);
                    DBContext.openConnection();
                    AD.DeleteCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                    showAllCustomers();
                    pic_user_pnlCustomerAcc.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\avatart.png");
                    clearTextBoxes();
                    MessageBox.Show("Customer Deleted");
                }
                else
                {
                    clearTextBoxes();
                    MessageBox.Show("Operating Canceled");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        // Clearing all text boxes in Customer Panel.
        private void clearTextBoxes()
        {
            txtCustCard.Text = "";
            txtCustEmail.Clear();
            txtCustID.Clear();
            txtCustName.Clear();
            txtCustPhone.Clear();
        }


        // On Grid View Click  ----> CUSTOMER PANEL
        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                txtCustCard.Text = dgvCustomer.CurrentRow.Cells[0].FormattedValue.ToString();
                txtCustName.Text = dgvCustomer.CurrentRow.Cells[1].FormattedValue.ToString();
                txtCustEmail.Text = dgvCustomer.CurrentRow.Cells[2].FormattedValue.ToString();
                txtCustPhone.Text = dgvCustomer.CurrentRow.Cells[3].FormattedValue.ToString();
                txtCustID.Text = dgvCustomer.CurrentRow.Cells[4].FormattedValue.ToString();
                cmb_Cust_TYpe.Text = dgvCustomer.CurrentRow.Cells[5].FormattedValue.ToString();

                custCart_pnlCustomer = Convert.ToInt64(dgvCustomer.CurrentRow.Cells[0].FormattedValue.ToString());

                // Searching Customer Image
                AD.SelectCommand = new SqlCommand("SELECT [custImage] FROM [Canteen_Database].[dbo].[Customers] WHERE [custCard] =" + txtCustCard.Text, DBContext.con);
                DataTable dt = new DataTable();
                AD.Fill(dt);
                String imgDGV = dt.Rows[0][0].ToString();
                txtImage_Path.Text = imgDGV;
                pic_user_pnlCustomerAcc.Image = new Bitmap(@"" + imgDGV);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pic_user_pnlCustomerAcc.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\avatart.png");
                txtImage_Path.Text = @"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\avatart.png";
            }

        }


        // Updating Customer ----> CUSTOMER PANEL
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isCustomerValid_pnlCustomer)
            {
                try
                {
                    AD.UpdateCommand = new SqlCommand("UPDATE [Canteen_Database].[dbo].[Customers] SET [custID] = '" + txtCustID.Text + "',[custCard] = '" + txtCustCard.Text + "',[custName] = '" + txtCustName.Text + "',[custEmail] = '" + txtCustEmail.Text + "',[custPhone] = '" + txtCustPhone.Text + "',[custImage] = '" + Image_Path2 + "',[cust_Type_Id] ="+cmb_Cust_TYpe.SelectedValue+" WHERE custCard = " + custCart_pnlCustomer, DBContext.con);
                    DBContext.openConnection();
                    AD.UpdateCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                    showAllCustomers();
                    clearTextBoxes();
                    pic_user_pnlCustomerAcc.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\avatart.png");
                    txtImage_Path.Clear();
                    MessageBox.Show("Changes Saved");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    clearTextBoxes();

                }
            }
            else
            {
                MessageBox.Show("Please enter correct value");
            }
        }


        // Searching Customer
        private void txtCustomerPanelSearch_TextChanged(object sender, EventArgs e)
        {
            if (Validation.validateSeach(txtCustomerPanelSearch.Text))
            {
                try
                {
                    DataSet dws = new DataSet();
                    AD.SelectCommand = new SqlCommand("SELECT *  FROM [Canteen_Database].[dbo].[vw_Customer_Display] WHERE [Reg #] like '%" + txtCustomerPanelSearch.Text + "%' or [Card #] like '%" + txtCustomerPanelSearch.Text + "%' or [Type] like '%"+ txtCustomerPanelSearch.Text+ "%' or [Name] like '%" + txtCustomerPanelSearch.Text + "%' or [Email] like '%" + txtCustomerPanelSearch.Text + "%' or [Phone] like '%" + txtCustomerPanelSearch.Text + "%'", DBContext.con);
                    AD.Fill(dws);
                    dgvCustomer.DataSource = dws.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                txtCustomerPanelSearch.Focus();
                txtCustomerPanelSearch.SelectAll();
                MessageBox.Show("Symbols are not allowed.");
            }
        }

        

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
                    custPKID = DS.Rows[0][0].ToString();
                    custID = DS.Rows[0][4].ToString();
                    custName = DS.Rows[0][1].ToString();
                    custBalance = DS.Rows[0][2].ToString();
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
                MessageBox.Show("Error: " + ex.Message);
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
                    custPKID = DS.Rows[0][0].ToString();
                    custID = DS.Rows[0][4].ToString();
                    custName = DS.Rows[0][1].ToString();
                    custBalance = DS.Rows[0][2].ToString();
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

        private void btn_Clear_pnlCustomer_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            showAllCustomers();
            showCust_Type();

        }

        private void btn_Add_Supplier_Click(object sender, EventArgs e)
        {
            frmCustomerType custType= new frmCustomerType();
            custType.ShowDialog();
        }
    }
}
