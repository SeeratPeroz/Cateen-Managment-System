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
    public partial class frmCategory : Form
    {
        SqlDataAdapter AD;
        // PRODUCT PANEL UPDATE RECORD ID and also use to store Category ID in Category Panel
        String strPrdID_ProductPanel;
        String strCatID_ProductPanel;

        // Data Entry base on Validation, Declaring Validation Veriables
        bool isCategory_Panel_Valid = false;
        bool isProduct_Panel_Valid = false;

        public frmCategory()
        {
            InitializeComponent();
            // Database 
            DBContext.createConnection(Program.userName, Program.userPass);
            AD = new SqlDataAdapter();
            pnlCateogry.Parent = this;

        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            showAllCategories(null);
        }



        // -----------------------------------------------------------------------------------------
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

                    dgvCategory_pnlCategory.DataSource = dt;
                }
                else
                {
                    String QUERY = "SELECT  ([catID]) as 'Category ID' ,([catName]) as 'Category Name' FROM [Canteen_Database].[dbo].[Categories] where [catID] LIKE '%" + search + "%' OR [catName] LIKE '%" + search + "%'";
                    AD.SelectCommand = new SqlCommand(QUERY, DBContext.con);
                    DataTable dt = new DataTable();
                    AD.Fill(dt);
                    dgvCategory_pnlCategory.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /* 
    ----------------------------------------------------------
               THE Category PANEL SETTING START FROM HERE 
    ----------------------------------------------------------
    */
        // Button to show all categories in CATEGORY PANEL
        private void btnShow_pnlCategory_Click(object sender, EventArgs e)
        {
            showAllCategories(null);
        }

        private void btnClear_pnlCategory_Click(object sender, EventArgs e)
        {
            txtCatName_pnlCategory.Clear();
            txtCatSearch_pnlCategory.Clear();
        }


        // Searching Catgory ---> CATEGORY PANEL
        private void txtCatSearch_pnlCategory_TextChanged(object sender, EventArgs e)
        {
            if (Validation.validateSeach(txtCatSearch_pnlCategory.Text))
            {
                showAllCategories(txtCatSearch_pnlCategory.Text);
            }
            else
            {
                MessageBox.Show("Symbols are not allowed.");
                txtCatSearch_pnlCategory.SelectAll();
                txtCatSearch_pnlCategory.Focus();
            }
        }


        // Button to add Category.
        private void btnCreate_pnlCategory_Click(object sender, EventArgs e)
        {
            // Calling Function to insert category in database and check whether text boxes have correct value
            if (isCategory_Panel_Valid)
            {
                insert_Category_to_database();
            }
            else {
                MessageBox.Show("Please fill the textboxes correctly");
            }
        }

        // Function to add Category in database.
        void insert_Category_to_database()
        {
            try
            {
                // Database Settings
                AD.InsertCommand = new SqlCommand("INSERT INTO [Canteen_Database].[dbo].[Categories] VALUES ('" + txtCatName_pnlCategory.Text + "')", DBContext.con);
                DBContext.openConnection();
                AD.InsertCommand.ExecuteNonQuery();
                DBContext.closeConnection();

                //Clear textbox and show all data
                txtCatName_pnlCategory.Clear();
                showAllCategories(null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Bind data when click on a row in gride veiw ---> CATEGORY PANEL.
        private void dgvCategory_pnlCategory_Click(object sender, EventArgs e)
        {
            txtCatName_pnlCategory.Text = dgvCategory_pnlCategory.CurrentRow.Cells[1].FormattedValue.ToString();
            strCatID_ProductPanel = "";
            strCatID_ProductPanel = dgvCategory_pnlCategory.CurrentRow.Cells[0].FormattedValue.ToString();

        }

        // Update button in CATEGORY PANEL 
        private void btnUpdate_pnlCategory_Click(object sender, EventArgs e)
        {
            // Call function to update category and pass the id which resived by gridveiw click event.
            // and check for validation
            if (isCategory_Panel_Valid)
            {
                updateCategory_on_Database(strCatID_ProductPanel);
            }
            else
            {
                MessageBox.Show("Please fill the form correctly.");
            }
        }

        // Function to Update Category ---> Category PANEL
        void updateCategory_on_Database(String search)
        {
            try
            {
                var result = MessageBox.Show("Are you sure to update selected category?.", "Info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    String QUR = "UPDATE [Canteen_Database].[dbo].[Categories] SET [catName] = '" + txtCatName_pnlCategory.Text + "' WHERE [catID] = " + search;
                    AD.UpdateCommand = new SqlCommand(QUR, DBContext.con);
                    DBContext.openConnection();
                    AD.UpdateCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                    // Text Boxes ---> Category PANEL
                    txtCatName_pnlCategory.Clear();
                    // SHOW Categories
                    showAllCategories(null);

                }
                else
                {
                    MessageBox.Show("Operating Canceled");
                    // SHOW Categories
                    showAllCategories(null);

                }
            }
            catch (Exception ex)
            {
                // SHOW Categories
                showAllCategories(null);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_pnlCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure to delete selected category?.", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AD.DeleteCommand = new SqlCommand("DELETE FROM [Canteen_Database].[dbo].[Categories] WHERE catID = " + strCatID_ProductPanel, DBContext.con);
                    DBContext.openConnection();
                    AD.DeleteCommand.ExecuteNonQuery();
                    DBContext.closeConnection();
                    showAllCategories(null);
                    txtCatName_pnlCategory.Clear();
                    MessageBox.Show("Category Deleted");
                }
                else
                {
                    MessageBox.Show("Operating Canceled");
                    // SHOW Categories
                    showAllCategories(null);
                    txtCatName_pnlCategory.Clear();

                }


            }
            catch (Exception ex)
            {
                // SHOW Categories
                showAllCategories(null);
                MessageBox.Show(ex.Message);
            }
        }



        /*----------------------------------------------------------
                 Validation Codding 

         ---------------------------------------------------------*/

        // Category Name Validation
        private void txtCatName_pnlCategory_TextChanged(object sender, EventArgs e)
        {
            isCategory_Panel_Valid = Validation.validateCategoryName(txtCatName_pnlCategory.Text);
            if (isCategory_Panel_Valid)
            {
                PicBox_validate_CategoryName_pnlCategory.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\Yes.ico");
            }
            else
            {
                PicBox_validate_CategoryName_pnlCategory.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\No.ico");
                txtCatName_pnlCategory.Focus();
            }

        }

      

       

        
    }
}
