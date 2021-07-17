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
    public partial class frmProduct : Form
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
        public frmProduct()
        {
            InitializeComponent();
            DBContext.createConnection(Program.userName, Program.userPass);
            AD = new SqlDataAdapter();
            
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            pnlProduct.Parent = this;
            showAllProducts(null);
            showAllCategories(null);
        }
        // ----------------------------------------------------------------------------------------------



        // UKNOW YET
        //private String[] getTableData()
        //{
        //    showCartG();
        //    String[] records = new String[dgvProduct.ColumnCount];
        //    for (int s = 0; s < dgvProduct.RowCount; s++)
        //    {
        //        for (int x = 0; x < dgvProduct.ColumnCount; x++)
        //        {
        //            records[x] = dgvProduct.Rows[s].Cells[x].Value.ToString();
        //        }
        //    }
        //    return records;
        //}



        /* 
       ----------------------------------------------------------
                  THE Product PANEL SETTING START FROM HERE 
       ----------------------------------------------------------
       */

        // Button Product in Side Panel
        
            
            // Function to show all category  --> PRODUCT PANEL
        void showAllCategories(string search)
        {
            try
            {
                if (search == null)
                {
                    String QUERY = "SELECT  ([catID]) as 'Category ID' ,([catName]) as 'Category Name' FROM [Canteen_Database].[dbo].[Categories]";
                    AD.SelectCommand = new SqlCommand(QUERY, DBContext.con);
                    DataTable dt = new DataTable();
                    AD.Fill(dt);
                    // Setting data for  Combo Box in Product Panel
                    cmbPrdCategory_ProductPanel.DataSource = dt;
                    cmbPrdCategory_ProductPanel.DisplayMember = "Category Name";
                    cmbPrdCategory_ProductPanel.ValueMember = "Category ID";
                }
                else
                {
                    String QUERY = "SELECT  ([catID]) as 'Category ID' ,([catName]) as 'Category Name' FROM [Canteen_Database].[dbo].[Categories] where [catID] LIKE '%" + search + "%' OR [catName] LIKE '%" + search + "%'";
                    AD.SelectCommand = new SqlCommand(QUERY, DBContext.con);
                    DataTable dt = new DataTable();
                    AD.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Function to show all Products  --> PRODUCT PANEL
        void showAllProducts(String search)
        {
            try
            {
                if (search == null)
                {
                    String QUERY = "SELECT * FROM [Canteen_Database].[dbo].[vw_Product]";
                    AD.SelectCommand = new SqlCommand(QUERY, DBContext.con);
                }
                else
                {
                    String QUERY = "SELECT *  FROM [Canteen_Database].[dbo].[vw_Product] WHERE [Product ID] like '%" + search + "%' or [Product Name] like '" + search + "%%' or [Unit Price] like '%" + search + "%' or [Category Name] like '%" + search + "%' ";
                    AD.SelectCommand = new SqlCommand(QUERY, DBContext.con);
                }
                DataSet prdDs = new DataSet();
                AD.Fill(prdDs);

                // Add the Products in Gride Veiw in PRODUCT PANEL
                dgvProduct_ProductPanel.DataSource = prdDs.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_ProductPanel_Click(object sender, EventArgs e)
        {
            if (isProduct_Panel_Valid)
            {
                insertProduct_to_Database();
            }
        }

        // Clearing text boxes in PRODUCT PANEL.
        void clearPanelPRODUCT_Textboxes()
        {
            txtPrdID_ProductPanel.Clear();
            txtPrdName_ProductPanel.Clear();
            txtPrdPrice_ProductPanel.Clear();
            txtPrdSearch_ProductPanel.Clear();
            showAllCategories(null);
        }

        // Inserting Products to Database ---> PRODUCT PANEL
        void insertProduct_to_Database()
        {
            try
            {
                String QUR = "INSERT INTO [Canteen_Database].[dbo].[Products] values(" + txtPrdID_ProductPanel.Text + ",'" + txtPrdName_ProductPanel.Text + "'," + txtPrdPrice_ProductPanel.Text + "," + cmbPrdCategory_ProductPanel.SelectedValue + ")";
                AD.InsertCommand = new SqlCommand(QUR, DBContext.con);
                DBContext.openConnection();
                AD.InsertCommand.ExecuteNonQuery();
                DBContext.closeConnection();

                // Calling Function to show Products 
                showAllProducts(null);

                // Calling Functino to clear text boxes.
                clearPanelPRODUCT_Textboxes();

                MessageBox.Show("Product NO: " + txtPrdSearch_ProductPanel.Text + " has inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Operation Failed");
            }
        }

        // Searching Products in PRODUCT PANEL 
        private void txtPrdSearch_ProductPanel_TextChanged(object sender, EventArgs e)
        {
            if (Validation.validateSeach(txtPrdSearch_ProductPanel.Text))
            {
                showAllProducts(txtPrdSearch_ProductPanel.Text);
            }
            else
            {
                MessageBox.Show("Symbols are not allowed.");
                txtPrdSearch_ProductPanel.SelectAll();
                txtPrdSearch_ProductPanel.Focus();
            }
        }


        // Update Button. ---> PRODUCT PANEL
        private void btnUpdate_ProductPanel_Click(object sender, EventArgs e)
        {
            // Calling Update Function
            if (isProduct_Panel_Valid)
            {
                updateProduct_on_Database(strPrdID_ProductPanel);
            }
            else
            {
                MessageBox.Show("Please fill the form correctly");
            }
        }


        // Function to Update Products ---> PRODUCT PANEL
        void updateProduct_on_Database(String search)
        {
            try
            {
                var result = MessageBox.Show("Are you sure to update selected product?.", "Info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    String QUR = "UPDATE [Canteen_Database].[dbo].[Products] SET [prdID] = " + txtPrdID_ProductPanel.Text + " ,[prdName] = '" + txtPrdName_ProductPanel.Text + "' ,[prdUnitPrice] = '" + txtPrdPrice_ProductPanel.Text + "' ,[catID] = '" + cmbPrdCategory_ProductPanel.SelectedValue + "' WHERE [prdID] = " + search;
                    AD.UpdateCommand = new SqlCommand(QUR, DBContext.con);
                    DBContext.openConnection();
                    AD.UpdateCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                    // Text Boxes ---> PRODUCT PANEL
                    clearPanelPRODUCT_Textboxes();
                    // SHOW PRODUCTS
                    showAllProducts(null);

                }
                else
                {
                    MessageBox.Show("Operating Canceled");
                    // SHOW PRODUCTS
                    showAllProducts(null);

                }
            }
            catch (Exception ex)
            {
                // SHOW PRODUCTS
                showAllProducts(null);
                MessageBox.Show(ex.Message);
            }
        }


        private void btnDelete_ProductPanel_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure to delete selected product?.", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AD.DeleteCommand = new SqlCommand("DELETE FROM [Canteen_Database].[dbo].[Products] WHERE prdID = " + txtPrdID_ProductPanel.Text, DBContext.con);
                    DBContext.openConnection();
                    AD.DeleteCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                    showAllProducts(null);
                    clearPanelPRODUCT_Textboxes();
                    MessageBox.Show("Product Deleted");
                }
                else
                {
                    MessageBox.Show("Operating Canceled");
                    // SHOW PRODUCTS
                    showAllProducts(null);
                    clearPanelPRODUCT_Textboxes();

                }


            }
            catch (Exception ex)
            {
                showAllProducts(null);
                MessageBox.Show(ex.Message);
            }
        }


        // GridView Click EVENT on PRODUCT PANEL.
        private void dgvProduct_ProductPanel_Click(object sender, EventArgs e)
        {
            try
            {
                // Assigning Product ID to Golobal veriable
                strPrdID_ProductPanel = dgvProduct_ProductPanel.CurrentRow.Cells[0].FormattedValue.ToString();
                // Text boxes on PRODUCT PANEL.
                txtPrdID_ProductPanel.Text = dgvProduct_ProductPanel.CurrentRow.Cells[0].FormattedValue.ToString();
                txtPrdName_ProductPanel.Text = dgvProduct_ProductPanel.CurrentRow.Cells[1].FormattedValue.ToString();
                txtPrdPrice_ProductPanel.Text = dgvProduct_ProductPanel.CurrentRow.Cells[2].FormattedValue.ToString();

                String temp = dgvProduct_ProductPanel.CurrentRow.Cells[3].FormattedValue.ToString();
                String QUERY = "SELECT  ([catID]) as 'Category ID' ,([catName]) as 'Category Name' FROM [Canteen_Database].[dbo].[Categories] where [catName] = '" + temp + "'";
                AD.SelectCommand = new SqlCommand(QUERY, DBContext.con);
                DataTable catDT = new DataTable();
                AD.Fill(catDT);
                strCatID_ProductPanel = "";
                strCatID_ProductPanel = catDT.Rows[0][0].ToString();
                cmbPrdCategory_ProductPanel.Text = catDT.Rows[0][1].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Show all products in PRODUCT Panel
        private void btnShow_ProductPanel_Click(object sender, EventArgs e)
        {
            showAllProducts(null);
            txtPrdSearch_ProductPanel.Clear();
        }

        private void btnClearPnlProucts_Click(object sender, EventArgs e)
        {
            txtPrdName_ProductPanel.Clear();
            txtPrdID_ProductPanel.Clear();
            txtPrdPrice_ProductPanel.Clear();
            showAllCategories(null);
        }


        /*----------------------------------------------------------
                 Validation Codding 

         ---------------------------------------------------------*/

        // Product Panel Validation --> Product ID
        private void txtPrdID_ProductPanel_TextChanged(object sender, EventArgs e)
        {
            isProduct_Panel_Valid = Validation.validateID(txtPrdID_ProductPanel.Text);
            if (isProduct_Panel_Valid)
            {
                pic_pnlProduct_prdID_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\Yes.ico");
            }
            else
            {
                pic_pnlProduct_prdID_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\No.ico");
            }
        }

        // Product Panel Validation --> Product Name
        private void txtPrdName_ProductPanel_TextChanged(object sender, EventArgs e)
        {
            isProduct_Panel_Valid = Validation.validateCategoryName(txtPrdName_ProductPanel.Text);
            if (isProduct_Panel_Valid)
            {
                pic_pnlProduct_prdName_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\Yes.ico");
            }
            else
            {
                pic_pnlProduct_prdName_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\No.ico");
            }
        }
        // Product Panel Validation --> Prodcut Price
        private void txtPrdPrice_ProductPanel_TextChanged(object sender, EventArgs e)
        {
            isProduct_Panel_Valid = Validation.validatePrice(txtPrdPrice_ProductPanel.Text);
            if (isProduct_Panel_Valid)
            {
                pic_pnlProduct_prdPrice_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\Yes.ico");
            }
            else
            {
                pic_pnlProduct_prdPrice_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\No.ico");
            }
        }

       



    }

}
