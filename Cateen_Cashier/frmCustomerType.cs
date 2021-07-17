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
    public partial class frmCustomerType : Form
    {
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

        String TYPE_id;
        public frmCustomerType()
        {
            InitializeComponent();

            DBContext.createConnection(Program.userName, Program.userPass);
            AD = new SqlDataAdapter();
            showAllCustomers();
        }


        //--------------------------- Validation -----------------------------------------------



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



        /*
        ---------------------------------------
                    Customer Type PANEL
        ---------------------------------------
        */

        private void showAllCustomers()
        {
            try
            {
                DataSet dws = new DataSet();
                AD.SelectCommand = new SqlCommand("SELECT[cust_Type_Id] as ID,[cust_Type] as 'Customer Typer' FROM[Canteen_Database].[dbo].[Customer_Type]", DBContext.con);
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
                    AD.InsertCommand = new SqlCommand("INSERT INTO [Canteen_Database].[dbo].[Customer_Type] VALUES ('" + txtCustName.Text + "')", DBContext.con);
                    DBContext.openConnection();
                    AD.InsertCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                    MessageBox.Show("Type added successfully.");


                    showAllCustomers();
                    clearTextBoxes();
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
                var result = MessageBox.Show("Are you sure to delete selected Supplier?.", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AD.DeleteCommand = new SqlCommand("DELETE FROM [Canteen_Database].[dbo].[Customer_Type] WHERE [cust_Type_Id] = '" + TYPE_id + "'", DBContext.con);
                    DBContext.openConnection();
                    AD.DeleteCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                    showAllCustomers();
                    clearTextBoxes();
                    MessageBox.Show("Type Deleted");
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
            txtCustName.Clear();
            TYPE_id = "";
        }


        // On Grid View Click  ----> CUSTOMER PANEL
        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                TYPE_id = dgvCustomer.CurrentRow.Cells[0].FormattedValue.ToString();
                txtCustName.Text = dgvCustomer.CurrentRow.Cells[1].FormattedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        // Updating Customer ----> CUSTOMER PANEL
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isCustomerValid_pnlCustomer)
            {
                try
                {
                    AD.UpdateCommand = new SqlCommand("UPDATE [Canteen_Database].[dbo].[Customer_Type] SET [cust_Type] = '"+txtCustName.Text+"' WHERE [cust_Type_Id] = "+ TYPE_id, DBContext.con);
                    DBContext.openConnection();
                    AD.UpdateCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                    showAllCustomers();
                    clearTextBoxes();
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

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txtCustName.Text = "";
        }
    }
}