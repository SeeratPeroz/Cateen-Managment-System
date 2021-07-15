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
    public partial class frmPurchase : Form
    {
        // Purchase Variables
        String name, ID;

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
        public frmPurchase()
        {
            InitializeComponent();
            DBContext.createConnection(Program.userName, Program.userPass);
            AD = new SqlDataAdapter();
        }


        private void frmPurchase_Load(object sender, EventArgs e)
        {
            totalAmount();
            pnlCart.Visible = true;
            cmbPrdID.Visible = false;
            chkPrdSearch.Checked = false;
            totalAmount();
            // Purchase Codding
            show_Suppliers();
            // Calling function to Display Cart item
            showCartG();

        }

        // Display Supplier List
        public void show_Suppliers()
        {
            DataTable dt = new DataTable();
            AD.SelectCommand = new SqlCommand("SELECT * from [Canteen_Database].dbo.Supplier", DBContext.con);
            AD.Fill(dt);

            cmb_Supplier.DataSource = dt;
            cmb_Supplier.DisplayMember = "sup_Name";
            cmb_Supplier.ValueMember = "sup_ID";
            // cmb_Supplier.Text = cmbPrdID.SelectedValue.ToString();
        }

        /* 
        ----------------------------------------------------------
                   THE CART PANEL SETTING START FROM HERE 
        ----------------------------------------------------------
        */

        // Panel Cart Add Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            insert_Products_to_cart();
            
        }

        // Function to insert data in database.
        void insert_Products_to_cart()
        {
            try
            {
                DataTable ds = new DataTable();
                AD.SelectCommand = new SqlCommand("SELECT * from Products where prdID = " + txtPrdID.Text, DBContext.con);
                AD.Fill(ds);
                dgvProduct.DataSource = ds;

                if (dgvProduct.RowCount.ToString() != "0")
                {
                    long price = Convert.ToInt32(txtPrdRate.Text);
                    AD.InsertCommand = new SqlCommand("INSERT INTO [Canteen_Database].[dbo].[tbl_Temp_Purch]([prdID] ,[purch_Rate] ,[prdQty] ,[amount]) VALUES (" + txtPrdID.Text + "," + price + "," + txtPrdQuantity.Text + ",'" + price * Convert.ToInt64(txtPrdQuantity.Text) + "')", DBContext.con);
                    DBContext.openConnection();
                    AD.InsertCommand.ExecuteNonQuery();
                    DBContext.closeConnection();

                    clearAdd();
                    showCartG();
                    txtPrdID.Focus();

                    chkPrdSearch.Checked = false;
                    updatePNL_Cart_While_CHECK_Changed();
                }
                else
                {
                    MessageBox.Show("Product Not Found");
                    showCartG();
                }
                totalAmount();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                totalAmount();

            }
        }

        // Functino to calculate total amount of Products.  PANEL CART
        private void totalAmount()
        {
            try
            {
                DataSet ds = new DataSet();
                AD.SelectCommand = new SqlCommand("SELECT sum([amount]) FROM [Canteen_Database].[dbo].[tbl_Temp_Purch]", DBContext.con);
                AD.Fill(ds);
                dgvProduct.DataSource = ds.Tables[0];
                lblTotal_Cart.Text = dgvProduct.Rows[0].Cells[0].Value.ToString();
                showCartG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }


        // Function to display cart item in Gride View -->  PANEL CART
        private void showCartG()
        {
            DataSet dws = new DataSet();
            AD.SelectCommand = new SqlCommand("SELECT * FROM [Canteen_Database].[dbo].[vw_Cart_Purchase]", DBContext.con);
            AD.Fill(dws);
            dgvProduct.DataSource = dws.Tables[0];
        }

        // Function to clear ProductID and Quantity Text boxes. -->  PANEL CART
        private void clearAdd()
        {
            txtPrdID.Text = "";
            txtPrdQuantity.Text = "";
            txtPrdRate.Clear();
            showCartG();
            show_Suppliers();
        }



        // Delete all records from cart  -->  PANEL CART
        private void clearCart()
        {
            AD.DeleteCommand = new SqlCommand("DELETE  FROM [Canteen_Database].[dbo].[tbl_Temp_Purch]", DBContext.con);
            DBContext.openConnection();
            AD.DeleteCommand.ExecuteNonQuery();

            DBContext.closeConnection();
            showCartG();
            chkPrdSearch.Checked = false;
            updatePNL_Cart_While_CHECK_Changed();
        }





        // Update Cart Data -->  PANEL CART
        private void btnUpdateCart_Click(object sender, EventArgs e)
        {
            update_Purchase_cart();
        }
        // Function to update Purchase Cart 
        void update_Purchase_cart()
        {


            try
            {

                String delQuery = "DELETE FROM [Canteen_Database].[dbo].[tbl_Temp_Purch] WHERE prdID =" + ID;
                long totalPriceUpdated = Convert.ToInt64(txtPrdQuantity.Text) * Convert.ToUInt32(txtPrdRate.Text);

                AD.DeleteCommand = new SqlCommand(delQuery, DBContext.con);
                DBContext.openConnection();
                AD.DeleteCommand.ExecuteNonQuery();
                DBContext.closeConnection();

                AD.InsertCommand = new SqlCommand("INSERT INTO [Canteen_Database].[dbo].[tbl_Temp_Purch]([prdID] ,[purch_Rate] ,[prdQty] ,[amount]) VALUES (" + txtPrdID.Text + "," + txtPrdRate.Text + "," + txtPrdQuantity.Text + "," + totalPriceUpdated + ")", DBContext.con);
                DBContext.openConnection();
                AD.InsertCommand.ExecuteNonQuery();
                DBContext.closeConnection();

                // Call function to display cart items.
                showCartG();
                chkPrdSearch.Checked = false;
                updatePNL_Cart_While_CHECK_Changed();

                // Call function to calculate total amount of Products.  PANEL CART
                totalAmount();
                // Clearing all text boxes in CART PANEL
                clearAdd();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                showCartG();
                totalAmount();
            }
        }



        // Button to call clear cart functino-->  PANEL CART
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            clearCart();
        }



        //  TO Delete Item from cart. -->  PANEL CART

        private void btnDelete_ClickCart(object sender, EventArgs e)
        {
            if (isCardValid_ID_pnlCart)
            {
                try
                {
                    AD.DeleteCommand = new SqlCommand("DELETE  FROM [Canteen_Database].[dbo].[tblTemp] WHERE prdID = " + txtPrdID.Text, DBContext.con);
                    DBContext.openConnection();
                    AD.DeleteCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                    clearAdd();
                    showCartG();
                    totalAmount();
                    chkPrdSearch.Checked = false;
                    updatePNL_Cart_While_CHECK_Changed();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    showCartG();
                    totalAmount();
                }
            }
        }

        // while updating the checkbox to search product wil change to uncheck so we need to update panel
        void updatePNL_Cart_While_CHECK_Changed()
        {
            if (chkPrdSearch.Checked)
            {
                cmbPrdID.Visible = true;
                lblPrd.Text = "Product Name";
                txtPrdID.Visible = false;
                pic_prdIDValidate_pnlProduct.Visible = false;
                isSearchByName_pnlCart = true;

                DataTable dt = new DataTable();
                AD.SelectCommand = new SqlCommand("SELECT * from Products", DBContext.con);
                AD.Fill(dt);

                cmbPrdID.DataSource = dt;
                cmbPrdID.DisplayMember = "prdName";
                cmbPrdID.ValueMember = "prdID";
                txtPrdID.Text = cmbPrdID.SelectedValue.ToString();


            }
            else
            {
                isSearchByName_pnlCart = false;
                cmbPrdID.Visible = false;
                txtPrdID.Visible = true;
                pic_prdIDValidate_pnlProduct.Visible = true;

                lblPrd.Text = "Product ID";
            }
        }

        // Assign the ID of product when product is selected on combo -->  PANEL CART
        private void cmbPrdID_SelectedValueChanged_1(object sender, EventArgs e)
        {
            txtPrdID.Text = cmbPrdID.SelectedValue.ToString();
        }



        // Change search product by CHECK BOX -->  PANEL CART
        private void chkPrdSearch_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkPrdSearch.Checked)
            {
                isSearchByName_pnlCart = true;
                cmbPrdID.Visible = true;
                lblPrd.Text = "Product Name";
                txtPrdID.Visible = false;
                pic_prdIDValidate_pnlProduct.Visible = false;

                DataTable dt = new DataTable();
                AD.SelectCommand = new SqlCommand("SELECT * from Products", DBContext.con);
                AD.Fill(dt);

                cmbPrdID.DataSource = dt;
                cmbPrdID.DisplayMember = "prdName";
                cmbPrdID.ValueMember = "prdID";
                txtPrdID.Text = cmbPrdID.SelectedValue.ToString();


            }
            else
            {
                isSearchByName_pnlCart = false;
                cmbPrdID.Visible = false;
                txtPrdID.Visible = true;
                pic_prdIDValidate_pnlProduct.Visible = true;

                lblPrd.Text = "Product ID";
            }
        }


        // Get data from gride view (CART) and store it in string array in order to save it in purchase_details table.
        private String[] getTableData()
        {
            showCartG();
            String[] records = new String[dgvProduct.ColumnCount];
            for (int s = 0; s < dgvProduct.RowCount; s++)
            {
                for (int x = 0; x < dgvProduct.ColumnCount; x++)
                {
                    if (x == 1)
                    {
                        continue;
                    }
                    records[x] = dgvProduct.Rows[s].Cells[x].Value.ToString();
                    //MessageBox.Show(records[x]);
                }
            }
            return records;
        }

        // Submit button to insert data in database. ---> PANEL CART
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            insert_purchasedProduct();
        }

        // Function to insert Products in purchase_details table and create invoice for it.
        void insert_purchasedProduct()
        {

            try
            {

                // Getting Data in 2002-12-02 format
                String Date = DateTime.Now.ToString("yyyy-MM-dd");

                // Calling function to Display Cart item
                showCartG();

                // INSERT INTO [Canteen_Database].[dbo].[Purchase_Invoice] ([Purch_Date] ,[sup_ID]) VALUES ('2001-04-14',1)
                String QQ = "INSERT INTO [Canteen_Database].[dbo].[Purchase_Invoice] ([Purch_Date] ,[sup_ID]) VALUES ('" + Date.ToString() + "'," + cmb_Supplier.SelectedValue + ")";
                AD.InsertCommand = new SqlCommand(QQ, DBContext.con);
                DBContext.openConnection();
                AD.InsertCommand.ExecuteNonQuery();
                DBContext.closeConnection();

                AD.SelectCommand = new SqlCommand("SELECT TOP 1 * FROM [Canteen_Database].[dbo].[Purchase_Invoice] ORDER BY [PurchNO] DESC", DBContext.con);
                DataSet dss = new DataSet();
                AD.Fill(dss);
                dgvProduct.DataSource = dss.Tables[0];
                String purchID = dgvProduct.Rows[0].Cells[0].Value.ToString();
                //MessageBox.Show(purchID);
                String[] records = getTableData();

                showCartG();
                for (int s = 0; s < dgvProduct.RowCount; s++)
                {
                    for (int x = 0; x < dgvProduct.ColumnCount; x++)
                    {
                        if (x == 1)
                        {
                            continue;
                        }
                        records[x] = dgvProduct.Rows[s].Cells[x].Value.ToString();
                        //MessageBox.Show(records[x]);
                    }

                    // INSERT INTO [Canteen_Database].[dbo].[Purchase_Details] ([PurchNO] ,[prdID],[prdQty] ,[purch_Rate] ,[amount]) VALUES (1,1,2,2,4)
                    String QE = "INSERT INTO [Canteen_Database].[dbo].[Purchase_Details] ([PurchNO] ,[prdID],[prdQty] ,[purch_Rate] ,[amount]) VALUES (" + purchID + "," + records[0] + "," + records[3] + "," + records[2] + "," + records[4] + ")";
                    //MessageBox.Show(QE);
                    AD.InsertCommand = new SqlCommand(QE, DBContext.con);
                    DBContext.openConnection();
                    AD.InsertCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                }

                MessageBox.Show("Product Purchased.");
                clearCart();
                totalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                showCartG();
            }
        }

        // Validate Product ID -> Product Panel
        private void txtPrdID_TextChanged(object sender, EventArgs e)
        {
            isCardValid_ID_pnlCart = Validation.validateID(txtPrdID.Text);
            if (isCardValid_ID_pnlCart)
            {
                pic_prdIDValidate_pnlProduct.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_prdIDValidate_pnlProduct.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }

        private void txtPrdRate_TextChanged(object sender, EventArgs e)
        {
            isCardValid_ID_pnlCart = Validation.validateID(txtPrdRate.Text);
            if (isCardValid_ID_pnlCart)
            {
                pic_prdRate_validation.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_prdRate_validation.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }

        // Validate Product Quantity -> Cart Panel
        private void txtPrdQuantity_TextChanged(object sender, EventArgs e)
        {
            isCardValid_Quantity_pnlCart = Validation.validateQuantity(txtPrdQuantity.Text);
            if (isCardValid_Quantity_pnlCart)
            {
                pic_prdNameValidate_pnlProduct.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_prdNameValidate_pnlProduct.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }


        // when user click on a partical cell it will add id and quantity in textboxes. -->  PANEL CART
        private void dgvProduct_Click_1(object sender, EventArgs e)
        {
            try
            {

                txtPrdID.Text = dgvProduct.CurrentRow.Cells[0].FormattedValue.ToString();
                txtPrdQuantity.Text = dgvProduct.CurrentRow.Cells[3].FormattedValue.ToString();
                txtPrdRate.Text = dgvProduct.CurrentRow.Cells[2].FormattedValue.ToString();
                name = dgvProduct.CurrentRow.Cells[1].FormattedValue.ToString();
                ID = dgvProduct.CurrentRow.Cells[0].FormattedValue.ToString();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void btnDeleteCart_Click(object sender, EventArgs e)
        {
            delete_Products();
        }

        // Delete Product from Cart Purchase
        void delete_Products()
        {
            try
            {
                String delQuery = "DELETE FROM [Canteen_Database].[dbo].[tbl_Temp_Purch] WHERE prdID =" + txtPrdID.Text;
                AD.DeleteCommand = new SqlCommand(delQuery, DBContext.con);
                DBContext.openConnection();
                AD.DeleteCommand.ExecuteNonQuery();
                DBContext.closeConnection();
                MessageBox.Show("Product deleted successfully");
                showCartG();
                clearAdd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at Cart Purchase: " + ex.Message);
            }
        }

        private void btn_Add_Supplier_Click(object sender, EventArgs e)
        {
            frmSupplier sup = new frmSupplier();
            sup.ShowDialog();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            clearAdd();
        }


    }
}

