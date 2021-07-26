using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cateen_Cashier
{
    public partial class frmEmployee : Form
    {
        
        SqlDataAdapter AD;
        String userID = "";
        String ImagePath = "";
        String ImagePath1 = "";
        String ImagePath2 = "";
        String LoginStatus = "";
        bool isEmplouyeeFormValid = false;
        public frmEmployee()
        {
            InitializeComponent();
            DBContext.createConnection(Program.userName, Program.userPass);
            AD = new SqlDataAdapter();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void btn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpg; *.png; *.jpeg; *.gif;)|*.gif; *.jpg; *.png; *.jpeg;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    ImagePath1 = open.FileName;
                    pic_userImage.Image = new Bitmap(open.FileName);
                }
              
                File.Copy(ImagePath1, Path.Combine(@"" + Application.StartupPath.ToString() + @"\Users\", Path.GetFileName(ImagePath1)), true);
                ImagePath2 = @"" + Application.StartupPath.ToString() + @"\Users\" + Path.GetFileName(ImagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while importing image: " + ex.Message);
            }
        }

        private void btn_Browse_MouseEnter(object sender, EventArgs e)
        {
            btn_Browse.ForeColor = Color.White;
            btn_Browse.BorderColor = Color.Orange;
        }

        private void btn_Browse_MouseLeave(object sender, EventArgs e)
        {
            btn_Browse.ForeColor = Color.DodgerBlue;
            btn_Browse.BorderColor = Color.DodgerBlue;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

            showAllEmployees(null); showRoles(null);chkLoginStatus.Checked = true;
            Clear_Btn();
           
        }

        // Function to show employee list on gride view
        void showAllEmployees(String search)
        {
            String QUR = "";
            if (search == null)
            {
               QUR = "SELECT *  FROM [Canteen_Database].[dbo].[vw_EmployeeList]";
            }
            else
            {
                QUR = "SELECT*  FROM [Canteen_Database].[dbo].[vw_EmployeeList] WHERE [User ID] LIKE '%"+search+"%' OR [Full Name] LIKE '%"+search+"%' OR [Role] LIKE '%"+search+"%'";
            }
            AD.SelectCommand = new SqlCommand(QUR, DBContext.con);
            DataTable dt = new DataTable();
            AD.Fill(dt);
            dgvEmployee.DataSource = dt;
            DBContext.closeConnection();
        }
        // Function to show roles on combo box 
        void showRoles(String roleName)
        {
            String QUR = "";
            if (roleName == null)
            {
                QUR = "SELECT *  FROM [Canteen_Database].[dbo].[emp_Role]";

            }
            else
            {
                QUR = "SELECT *  FROM [Canteen_Database].[dbo].[emp_Role] WHERE [role] = '"+roleName+"'";
            }

            try
            {
                AD.SelectCommand = new SqlCommand(QUR, DBContext.con);
                DataTable dt = new DataTable();
                AD.Fill(dt);
               
                cmbUserRole.DataSource = dt;
                cmbUserRole.DisplayMember = "role";
                cmbUserRole.ValueMember = "roleID"; }
            catch(Exception ex)
            {
                MessageBox.Show("Role not found.");
            }
        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                userID = dgvEmployee.CurrentRow.Cells[0].FormattedValue.ToString();
                String QUR = "SELECT *  FROM [Canteen_Database].[dbo].[Employee] WHERE [empID] = '"+userID+"'";
                AD.SelectCommand = new SqlCommand(QUR, DBContext.con);
                DataTable dt = new DataTable();
                AD.Fill(dt);
                txtUserID.Texts = dt.Rows[0][0].ToString();
                txtUserName.Texts = dt.Rows[0][1].ToString();
                txtUserLastName.Texts = dt.Rows[0][2].ToString();
                txtUserEmail.Texts = dt.Rows[0][4].ToString();
                txtUserPhone.Texts = dt.Rows[0][5].ToString();
                txtUserAddress.Texts = dt.Rows[0][6].ToString();

              

                // Get image 
                ImagePath = dt.Rows[0][7].ToString();
                ImagePath2 = dt.Rows[0][7].ToString();
                pic_userImage.Image = new Bitmap(@"" + ImagePath);

                // Get user Role
                showRoles(dgvEmployee.CurrentRow.Cells[2].FormattedValue.ToString());

                // Get Login Status
                LoginStatus = dt.Rows[0][8].ToString();
                if (LoginStatus == "1")
                {
                    chkLoginStatus.Checked = true;
                    lblLoginStatus.Text = "Enable";
                }
                else
                {
                    chkLoginStatus.Checked = false;
                    lblLoginStatus.Text = "Disable";
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void cmbUserRole_Click(object sender, EventArgs e)
        {
            showRoles(null);
        }

       

        private void chkLoginStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoginStatus.Checked)
            {
                lblLoginStatus.Text = "Enable";
                LoginStatus = "1";
            }
            else
            {
                lblLoginStatus.Text = "Disable";
                LoginStatus = "0";

            }
        }

        
        // Clear Panel Contents.
        private void btn_Show_Click(object sender, EventArgs e)
        {
            showAllEmployees(null);
            showRoles(null);
            
            txtUserID.Texts = "";
            txtUserName.Texts = "";
            txtUserLastName.Texts = "";
            txtUserEmail.Texts = "";
            txtUserPhone.Texts = "";
            txtUserAddress.Texts = "";
            LoginStatus = "0";
            ImagePath = "";
            ImagePath1 = "";
            ImagePath2 = "";
            chkLoginStatus.Checked = false;
            pic_userImage.Image = new Bitmap(@"E:\Drive E\BCS\PROJECTS\Cateen_Management_System\Cateen_Cashier\bin\Debug\Users\Untitled-11.png");
            txtSearch.Texts = "";
        }

        // Function to update the employee details.
        void updateEmpInfo()
        {
            try
            {
               var result = MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    DBContext.openConnection();
                    String QRU = "UPDATE [Canteen_Database].[dbo].[Employee] SET [empName] = '" + txtUserName.Texts + "',[empLastName] = '" + txtUserLastName.Texts + "' ,[empRole] = "+cmbUserRole.SelectedValue+" ,[empEmail] = '" + txtUserEmail.Texts + "',[empPhone] = '" + txtUserPhone.Texts + "',[empAddress] = '" + txtUserAddress.Texts + "' ,[empImage] = '" + ImagePath2 + "' ,[empLogin] = " + LoginStatus + " WHERE [empID] = '" + txtUserID.Texts + "'";
                    AD.UpdateCommand = new SqlCommand(QRU, DBContext.con);
                    AD.UpdateCommand.ExecuteNonQuery();
                    DBContext.closeConnection();

                    if(LoginStatus == "1")
                    {
                        DBContext.openConnection();
                        AD.UpdateCommand = new SqlCommand("ALTER LOGIN ["+ txtUserID.Texts+ "]  ENABLE", DBContext.con);
                        DBContext.closeConnection();
                    }
                    else
                    {
                        DBContext.openConnection();
                        AD.UpdateCommand = new SqlCommand("ALTER LOGIN [" + txtUserID.Texts + "]  DISABLE", DBContext.con);
                        DBContext.closeConnection();
                    }


                    MessageBox.Show("Changes saved successfully");

                    // Clearing Contents
                    btn_Clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Operation canceled");
                    // Clearing Contents
                    btn_Clear.PerformClick();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving changes: " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (isEmplouyeeFormValid)
            {
                updateEmpInfo();

            }
            else
            {
                MessageBox.Show("Please fill the form correctly.");
            }
        }

        // function to hide all clear buttons next to text box.
        void Clear_Btn()
        {
            btn_ClearAddress.Hide();
            btn_ClearName.Hide();
            btn_ClearLastName.Hide();
            btn_ClearPhone.Hide();
            btn_ClearEmail.Hide();
        }


        private void txtUserName__TextChanged(object sender, EventArgs e)
        {
            if(txtUserName.Texts == "")
            {
                btn_ClearName.Hide();
            }
            else
            {
                btn_ClearName.Show();
            }


            // Validation 
            isEmplouyeeFormValid = Validation.validateCustName(txtUserName.Texts);
            if (isEmplouyeeFormValid)
            {
                pic_ValidateName.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_ValidateName.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }

        private void txtUserLastName__TextChanged(object sender, EventArgs e)
        {
            if (txtUserLastName.Texts == "")
            {
                btn_ClearLastName.Hide();
            }
            else
            {
                btn_ClearLastName.Show();
            }

            // Validation 
            isEmplouyeeFormValid = Validation.validateCustName(txtUserLastName.Texts);
            if (isEmplouyeeFormValid)
            {
                pic_ValidateLastName.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_ValidateLastName.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }

        private void txtUserEmail__TextChanged(object sender, EventArgs e)
        {
            if (txtUserEmail.Texts == "")
            {
                btn_ClearEmail.Hide();
            }
            else
            {
                btn_ClearEmail.Show();
            }


            // Validation 
            bool emailValidate = Validation.validateCustEmail(txtUserEmail.Texts);

            if (emailValidate || txtUserEmail.Texts == "")
            {
                isEmplouyeeFormValid = true;
                pic_ValidateEmail.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                isEmplouyeeFormValid = false;
                pic_ValidateEmail.Image = Cateen_Cashier.Properties.Resources.No;
            }

        }

        private void txtUserPhone__TextChanged(object sender, EventArgs e)
        {
            if (txtUserPhone.Texts == "")
            {
                btn_ClearPhone.Hide();
            }
            else
            {
                btn_ClearPhone.Show();
            }

            // Validation 
            isEmplouyeeFormValid = Validation.validateCustPhone(txtUserPhone.Texts);
            if (isEmplouyeeFormValid)
            {
                pic_ValidatePhone.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_ValidatePhone.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }

        private void txtUserAddress__TextChanged(object sender, EventArgs e)
        {
            if (txtUserAddress.Texts == "")
            {
                btn_ClearAddress.Hide();
            }
            else
            {
                btn_ClearAddress.Show();
            }

            // Validation 
            isEmplouyeeFormValid = Validation.validateAdderss(txtUserAddress.Texts);
            if (isEmplouyeeFormValid)
            {
                pic_ValidateAddress.Image = Cateen_Cashier.Properties.Resources.Yes;
            }
            else
            {
                pic_ValidateAddress.Image = Cateen_Cashier.Properties.Resources.No;
            }
        }

        private void btn_ClearName_Click(object sender, EventArgs e)
        {
            txtUserName.Texts = "";
        }

        private void btn_ClearLastName_Click(object sender, EventArgs e)
        {
            txtUserLastName.Texts = "";
        }

        private void btn_ClearEmail_Click(object sender, EventArgs e)
        {
            txtUserEmail.Texts = "";
        }

        private void btn_ClearPhone_Click(object sender, EventArgs e)
        {
            txtUserPhone.Texts = "";
        }

        private void btn_ClearAddress_Click(object sender, EventArgs e)
        {
            txtUserAddress.Texts = "";
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts == "" || Validation.validateSeach(txtSearch.Texts))
            {
                if (txtSearch.Texts == "")
                {
                    dgvEmployee.DefaultCellStyle.BackColor = Color.White;
                    showAllEmployees(null);
                }
                else
                {
                    showAllEmployees(txtSearch.Texts);
                    dgvEmployee.DefaultCellStyle.BackColor = Color.LightBlue;
                }

            }
            else
            {
                MessageBox.Show("Special Symbols are not allowed");
            }
        }

        private void cmbUserRole_Click_1(object sender, EventArgs e)
        {
            showRoles(null);
        }
    }

   
}
