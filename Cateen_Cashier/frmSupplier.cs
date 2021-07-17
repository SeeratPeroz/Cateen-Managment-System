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
    public partial class frmSupplier : Form
    {
        SqlDataAdapter AD;
        // Customer Panel
        bool isCustomerValid_pnlCustomer = false;


        public frmSupplier()
        {
            InitializeComponent();
            DBContext.createConnection(Program.userName, Program.userPass);
            AD = new SqlDataAdapter();
        }


        




        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            isCustomerValid_pnlCustomer = Validation.validateCategoryName(txtAddress.Text);
            if (isCustomerValid_pnlCustomer)
            {
                pic_address.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_address.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }
            // ---------------------------------------------------------------------------------------



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
            // Validating Customer Email  -> Custmer Panel
            private void txtCustEmail_TextChanged(object sender, EventArgs e)
            {
                bool isCustEmailValid = Validation.validateCustEmail(txtCustEmail.Text);
                if (isCustEmailValid || txtCustEmail.Text == "")
                {
                isCustomerValid_pnlCustomer = true;
                    pic_customerEmailValidate_pnlCustomer.Image = Cateen_Cashier.Properties.Resources.Yes;
                }
                else
                {
                isCustomerValid_pnlCustomer = false;
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

           

            /*
            ---------------------------------------
                        Supplier PANEL
            ---------------------------------------
            */
            
            private void showAllCustomers()
            {
                try
                {
                    DataSet dws = new DataSet();
                    AD.SelectCommand = new SqlCommand("SELECT sup_ID as 'Supplier ID', sup_Name as 'Supplier Name', sup_Address as 'Address', sup_Phone as 'Phone', sup_Email as 'Email' FROM [Canteen_Database].[dbo].[Supplier]", DBContext.con);
                    AD.Fill(dws);
                    dgvCustomer.DataSource = dws.Tables[0];

                    //AD.SelectCommand = new SqlCommand("select * from Customers", DBContext.con);

                    // txtCustCard.DataBindings.Add(new Binding("Text", bsTable, "custCard"));
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
                        AD.InsertCommand = new SqlCommand("INSERT INTO [Canteen_Database].[dbo].[Supplier] VALUES ('"+txtCustName.Text+"','"+txtCustEmail.Text+"','"+txtCustPhone.Text+"','"+txtAddress.Text+"')", DBContext.con);
                        DBContext.openConnection();
                        AD.InsertCommand.ExecuteNonQuery();
                        DBContext.closeConnection();
                        MessageBox.Show("Supplier added successfully.");

                     
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
                        AD.DeleteCommand = new SqlCommand("DELETE FROM [Canteen_Database].[dbo].[Supplier] WHERE sup_ID = '" + supID.Text + "'", DBContext.con);
                        DBContext.openConnection();
                        AD.DeleteCommand.ExecuteNonQuery();
                        DBContext.closeConnection();
                        showAllCustomers();
                        clearTextBoxes();
                        MessageBox.Show("Supplier Deleted");
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
                txtCustEmail.Clear();
                supID.Clear();
                txtCustName.Clear();
                txtAddress.Clear();
                txtCustPhone.Clear();
            }


            // On Grid View Click  ----> CUSTOMER PANEL
            private void dgvCustomer_Click(object sender, EventArgs e)
            {
                try
                {
                supID.Text = dgvCustomer.CurrentRow.Cells[0].FormattedValue.ToString();
                txtCustName.Text = dgvCustomer.CurrentRow.Cells[1].FormattedValue.ToString();
                txtCustEmail.Text = dgvCustomer.CurrentRow.Cells[4].FormattedValue.ToString();
                txtCustPhone.Text = dgvCustomer.CurrentRow.Cells[3].FormattedValue.ToString();
                txtAddress.Text = dgvCustomer.CurrentRow.Cells[2].FormattedValue.ToString();
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
                        AD.UpdateCommand = new SqlCommand("UPDATE [Canteen_Database].[dbo].[Supplier] SET [sup_Name] = '"+txtCustName.Text+"',[sup_Email] = '"+txtCustEmail.Text+"',[sup_Phone] = '"+txtCustPhone.Text+"',[sup_Address] = '"+txtAddress.Text+"' WHERE sup_ID = "+supID.Text, DBContext.con);
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
        

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            // Call function to show all Customers in Customer Panel Grid View
            showAllCustomers();
            clearTextBoxes();
        }

        private void btn_Clear(object sender, EventArgs e)
        {
            clearTextBoxes();
            showAllCustomers();
        }
        
        
    }
}
