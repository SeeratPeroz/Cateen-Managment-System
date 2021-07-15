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
    public partial class frmCart : Form
    {
        SqlDataAdapter AD;
       
        // UniPrice variable for update operation
        long updatePrice;
        // Cart Panel
        bool isCardValid_ID_pnlCart = false;
        bool isCardValid_Quantity_pnlCart = false;
        bool isSearchByName_pnlCart = false;

        public frmCart()
        {
            InitializeComponent();
            DBContext.createConnection(Program.userName,Program.userPass);
            AD = new SqlDataAdapter();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            // Calling function to Display Cart item
            showCartG();
            totalAmount();
            pnlCart.Visible = true;
            txtStdID.Text = "";
            lblCustBalanceCart.Text = "";
            cmbPrdID.Visible = false;
            chkPrdSearch.Checked = false;
            totalAmount();
            chk_Manual.Checked = false;
            txtUnitPrice.Enabled= false;
        }

   

        //--------------------------------------------------------------------------------------


        /* 
        ----------------------------------------------------------
                   THE CART PANEL SETTING START FROM HERE 
        ----------------------------------------------------------
        */

        // Panel Cart Add Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((isSearchByName_pnlCart & isCardValid_Quantity_pnlCart) | (!isSearchByName_pnlCart & isCardValid_Quantity_pnlCart & isCardValid_ID_pnlCart))
            {
                try
                {
                    DataSet ds = new DataSet();
                    AD.SelectCommand = new SqlCommand("SELECT * from Products where prdID = " + txtPrdID.Text, DBContext.con);
                    AD.Fill(ds);
                    dgvProduct.DataSource = ds.Tables[0];

                    if (dgvProduct.RowCount.ToString() != "0")
                    {

                        long price = Convert.ToInt32(txtUnitPrice.Text);
                        AD.InsertCommand = new SqlCommand("INSERT INTO [Canteen_Database].[dbo].[tblTemp] ([prdID] ,[prdQty],[uniPrice] ,[amount]) VALUES ('" + txtPrdID.Text + "','" + txtPrdQuantity.Text + "',"+ price +",'" + price * Convert.ToInt64(txtPrdQuantity.Text) + "')", DBContext.con);
                        DBContext.openConnection();
                        AD.InsertCommand.ExecuteNonQuery();
                        DBContext.closeConnection();

                        clearAdd();
                        showCartG();
                        txtPrdID.Focus();

                        chkPrdSearch.Checked = false;
                        updatePNL_Cart_While_CHECK_Changed();
                        txtUnitPrice.Clear();
                        txtUnitPrice.Enabled = false;
                        chk_Manual.Checked = false;



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
            else
            {
                MessageBox.Show("Please fill the form correctly");
            }
        }


        // Functino to calculate total amount of Products.  PANEL CART
        private void totalAmount()
        {
            try
            {
                DataSet ds = new DataSet();
                AD.SelectCommand = new SqlCommand("SELECT SUM(amount) FROM [Canteen_Database].[dbo].[tblTemp] WHERE [emp_Name] = '"+Program.userName+"'", DBContext.con);
                AD.Fill(ds);
                dgvProduct.DataSource = ds.Tables[0];
                lblTotal.Text = dgvProduct.Rows[0].Cells[0].Value.ToString();
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
            try
            {

                DataSet dws = new DataSet();
                AD.SelectCommand = new SqlCommand("SELECT [Product ID],[Product Name],[Unit Price],[Quantity],[Total] FROM cartView WHERE [emp_Name] ='" + Program.userName.ToLower()+"'", DBContext.con);
                AD.Fill(dws);
                dgvProduct.DataSource = dws.Tables[0];
            }
            catch(Exception ex){
                MessageBox.Show("Error Cart: " + ex.Message);
            }
        }

        // Function to clear ProductID and Quantity Text boxes. -->  PANEL CART
        private void clearAdd()
        {
            txtPrdID.Text = "";
            txtPrdQuantity.Text = "";
        }



        // Delete all records from cart  -->  PANEL CART
        private void clearCart()
        {
            txtStdID.Text = "";
            lblTotal.Text = "";
            lblCustBalanceCart.Text = "";
            AD.DeleteCommand = new SqlCommand("DELETE  FROM [Canteen_Database].[dbo].[tblTemp] WHERE [emp_Name] = '"+Program.userName+"'", DBContext.con);
            DBContext.openConnection();
            AD.DeleteCommand.ExecuteNonQuery();
            DBContext.closeConnection();
            showCartG();
            chkPrdSearch.Checked = false;
            updatePNL_Cart_While_CHECK_Changed();
        }



        // when user click on a partical cell it will add id and quantity in textboxes. -->  PANEL CART
        private void dgvProduct_Click(object sender, EventArgs e)
        {
            try
            {

                txtPrdID.Text = dgvProduct.CurrentRow.Cells[0].FormattedValue.ToString();
                txtPrdQuantity.Text = dgvProduct.CurrentRow.Cells[3].FormattedValue.ToString();
                txtUnitPrice.Text = dgvProduct.CurrentRow.Cells[2].FormattedValue.ToString();
                updatePrice = Convert.ToInt64(dgvProduct.CurrentRow.Cells[2].FormattedValue.ToString());
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }


        // Update Cart Data -->  PANEL CART
        private void btnUpdateCart_Click(object sender, EventArgs e)
        {
            if ((isSearchByName_pnlCart & isCardValid_Quantity_pnlCart) | (!isSearchByName_pnlCart & isCardValid_Quantity_pnlCart & isCardValid_ID_pnlCart))
            {
                try
                {
                    long totalPriceUpdated = Convert.ToInt64(txtPrdQuantity.Text) * Convert.ToInt32(txtUnitPrice.Text);

                    AD.DeleteCommand = new SqlCommand("DELETE  FROM [Canteen_Database].[dbo].[tblTemp] WHERE prdID = " + txtPrdID.Text+ " AND [emp_Name] = '"+Program.userName+"'", DBContext.con);
                    DBContext.openConnection();
                    AD.DeleteCommand.ExecuteNonQuery();
                    DBContext.closeConnection();

                    AD.InsertCommand = new SqlCommand("INSERT INTO [Canteen_Database].[dbo].[tblTemp] ([prdID] ,[prdQty],[uniPrice] ,[amount]) VALUES ('" + txtPrdID.Text + "','" + txtPrdQuantity.Text + "'," + txtUnitPrice.Text + ",'" + totalPriceUpdated+ "')", DBContext.con);
                    DBContext.openConnection();
                    AD.InsertCommand.ExecuteNonQuery();
                    DBContext.closeConnection();

                    // Call function to display cart items.
                    DBContext.closeConnection();
                    showCartG();
                    chkPrdSearch.Checked = false;
                    chk_Manual.Checked = false;
                    txtUnitPrice.Enabled = false;

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
            else
            {
                MessageBox.Show("Please fill the form correctly.");
            }
        }


        // Button to call clear cart functino-->  PANEL CART
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            clearCart();
            chk_Manual.Checked = false;
            txtUnitPrice.Enabled = false;
        }



        //  TO Delete Item from cart. -->  PANEL CART

        private void btnDelete_ClickCart(object sender, EventArgs e)
        {
            if (isCardValid_ID_pnlCart)
            {
                try
                {
                    AD.DeleteCommand = new SqlCommand("DELETE  FROM [Canteen_Database].[dbo].[tblTemp] WHERE prdID = " + txtPrdID.Text + "AND [emp_Name] = '"+Program.userName+"'", DBContext.con);
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
        private void cmbPrdID_SelectedValueChanged(object sender, EventArgs e)
        {
            txtPrdID.Text = cmbPrdID.SelectedValue.ToString();
        }



        // Change search product by CHECK BOX -->  PANEL CART
        private void chkPrdSearch_CheckedChanged(object sender, EventArgs e)
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



        // When user press enter in customer id textbox. --> CART PANEL
        private void txtStdID_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (Validation.validateCustCard(txtStdID.Text))
                {
                    Console.Beep(1000, 800);
                    btnSubmit.PerformClick();
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID");
                    txtStdID.Focus();
                    txtStdID.SelectAll();
                }
            }



        }



        // Submit button to insert data in database. ---> PANEL CART
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validation.validateCustCard(txtStdID.Text))
            {
                try
                {
                    // checking whether we have something in cart or not
                    AD.SelectCommand = new SqlCommand("SELECT COUNT([Product ID]) FROM [Canteen_Database].[dbo].[cartView]", DBContext.con);
                    DataTable dtCardSee = new DataTable();
                    AD.Fill(dtCardSee);
                    int prdCount = Convert.ToInt16(dtCardSee.Rows[0][0].ToString());
                    if (prdCount < 1)
                    {
                        throw new Exception("Cart is empty");
                    }


                    // Getting Data in 2002-12-02 format
                    String Date = DateTime.Now.ToString("yyyy-MM-dd");

                    // Calling Balance Function to check balance if enough then return true.
                    bool Balance = checkBalance1();

                    // Calling function to Display Cart item
                    showCartG();
                    if (txtStdID.Text != "" && Balance.Equals(true))
                    {
                        String QQ = "INSERT INTO [Canteen_Database].[dbo].[Invoices] ([InvDate] ,[custCard]) VALUES('" + Date + "','" + txtStdID.Text + "')";
                        AD.InsertCommand = new SqlCommand(QQ, DBContext.con);
                        DBContext.openConnection();
                        AD.InsertCommand.ExecuteNonQuery();
                        DBContext.closeConnection();

                        AD.SelectCommand = new SqlCommand("SELECT TOP 1 * FROM [Canteen_Database].[dbo].[Invoices] ORDER BY InvNO DESC", DBContext.con);
                        DataSet dss = new DataSet();
                        AD.Fill(dss);
                        dgvProduct.DataSource = dss.Tables[0];
                        String orderID = dgvProduct.Rows[0].Cells[0].Value.ToString();
                        //MessageBox.Show(orderID);
                        String[] records = getTableData();

                        showCartG();
                        for (int s = 0; s < dgvProduct.RowCount; s++)
                        {
                            for (int x = 0; x < dgvProduct.ColumnCount; x++)
                            {
                                records[x] = dgvProduct.Rows[s].Cells[x].Value.ToString();
                            }


                            AD.SelectCommand = new SqlCommand("SELECT [prdUnitPrice] FROM [Canteen_Database].[dbo].[Products] WHERE prdID = " + records[0], DBContext.con);
                            DataTable unitPriceTable = new DataTable();
                            AD. Fill(unitPriceTable);
                            String unitPrice = unitPriceTable.Rows[0][0].ToString();
                            


                            AD.InsertCommand = new SqlCommand("INSERT INTO [Canteen_Database].[dbo].[Invoice_Details] ([InvNO] ,[prdID] ,[prdQty],[sale_Rate] ,[amount]) VALUES ('" + orderID + "'," + records[0] + "," + records[3] + ","+ unitPrice + "," + records[4] + ")", DBContext.con);
                            DBContext.openConnection();
                            AD.InsertCommand.ExecuteNonQuery();
                            DBContext.closeConnection();
                        }

                        MessageBox.Show("Product sold.");
                        clearCart();


                    }
                    else
                    {
                        if (Balance)
                        {
                            txtStdID.Focus();
                            showCartG();
                            throw new Exception("Please enter student ID");
                        }

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    showCartG();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID");
                txtStdID.Focus();
                txtStdID.SelectAll();
            }
        }



        // UKNOW YET
        private String[] getTableData()
        {
            showCartG();
            String[] records = new String[dgvProduct.ColumnCount];
            for (int s = 0; s < dgvProduct.RowCount; s++)
            {
                for (int x = 0; x < dgvProduct.ColumnCount; x++)
                {
                    records[x] = dgvProduct.Rows[s].Cells[x].Value.ToString();
                }
            }
            return records;
        }


        // Function to check Balance
        private bool checkBalance1()
        {
            try
            {
                String[] records = getTableData();

                long typeAmount = Convert.ToInt64(records[4]);

                DataSet DS = new DataSet();
                DS = showCustomerBalancebyCard1(txtStdID.Text);
                dgvProduct.DataSource = DS.Tables[0];
                long Balance = Convert.ToInt64(dgvProduct.Rows[0].Cells[2].Value.ToString());
                lblCustBalanceCart.Text = Balance.ToString();
                if (Balance > typeAmount)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Customer balance low!!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer not Found!!");
                lblCustBalanceCart.Text = "";
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        // Customer Balance
        public DataSet showCustomerBalancebyCard1(String id)
        {
            try
            {
                DataSet ds = new DataSet();
                AD.SelectCommand = new SqlCommand("SELECT * FROM [Canteen_Database].[dbo].[vw_CustomerBalance] WHERE [CustomerCard] = " + id, DBContext.con);
                AD.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }      


        // Validate Product ID -> Product Panel
        private void txtPrdID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AD.SelectCommand = new SqlCommand("SELECT [prdUnitPrice] FROM [Canteen_Database].[dbo].[Products] WHERE prdID = " + txtPrdID.Text, DBContext.con);
                DataTable unitPriceTable = new DataTable();
                AD.Fill(unitPriceTable);
                txtUnitPrice.Text = unitPriceTable.Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                txtUnitPrice.Clear();
            }


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

        private void chk_Manual_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Manual.Checked)
            {
                txtUnitPrice.Enabled = true;
            }
            else
            {
                txtUnitPrice.Enabled = false;
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            isCardValid_Quantity_pnlCart = Validation.validateQuantity(txtUnitPrice.Text);
            if (isCardValid_Quantity_pnlCart)
            {
                pic_UnitPrice_Valid.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_UnitPrice_Valid.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }
    }
}
