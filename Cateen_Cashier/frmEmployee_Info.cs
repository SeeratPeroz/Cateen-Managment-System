
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cateen_Cashier
{
    public partial class frmEmployee_Info : Form
    {
        // 
        String Image_Path2 = "";
        SqlDataAdapter AD;
        bool isEmpFormValid = false;


        int t = 0;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse

  );
        public frmEmployee_Info()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            DBContext.createConnection(Program.userName, Program.userPass);
            AD = new SqlDataAdapter();
            

        }

        void updateEmpInfo()
        {
            try
            {
                DBContext.openConnection();
                String QRU = "UPDATE [Canteen_Database].[dbo].[Employee] SET [empName] = '" + txtEmpName1.Texts + "',[empLastName] = '" + txtEmpLastName.Texts + "',[empEmail] = '" + txtEmpEmail.Texts + "',[empPhone] = '" + txtEmpPhone.Texts + "',[empAddress] = '" + txtempAddress.Texts + "' ,[empImage] = '" + Image_Path2 + "' WHERE [empID] = '" + Program.userName + "'";
                AD.UpdateCommand = new SqlCommand(QRU, DBContext.con);
                AD.UpdateCommand.ExecuteNonQuery();
                DBContext.closeConnection();
                showAll_Emp_Data();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while saving changes: " + ex.Message);
            }
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            if (isEmpFormValid)
                this.Close();
            else
                lblMessage.Text = "Please fill the form correctly";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (isEmpFormValid)
            {
                updateEmpInfo();
                MessageBox.Show("Changes saved");
                this.Close();
                //frmMain fr = new frmMain();
                //fr.setImage();
                //fr.logo.Image = new Bitmap(Image_Path2);
            }
            else
            {
                lblMessage.Text = "Please fill the form correctly.";
            }
        }

        void showAll_Emp_Data()
        {
            try
            {
                String Qur = "SELECT * FROM [Canteen_Database].[dbo].[Employee] WHERE [empid] = '" + Program.userName + "'";
                AD.SelectCommand = new SqlCommand(Qur, DBContext.con);
                DataTable dt = new DataTable();
                AD.Fill(dt);

                txtEmpUser.Texts = dt.Rows[0][0].ToString();
                txtEmpName1.Texts = dt.Rows[0][1].ToString();
                txtEmpLastName.Texts = dt.Rows[0][2].ToString();
                txtEmpRole.Texts = dt.Rows[0][3].ToString();
                txtEmpEmail.Texts = dt.Rows[0][4].ToString();
                txtEmpPhone.Texts = dt.Rows[0][5].ToString();
                txtempAddress.Texts = dt.Rows[0][6].ToString();
                pic_Image_User.Image = new Bitmap(dt.Rows[0][7].ToString());
                Image_Path2 = @""+dt.Rows[0][7].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while displaying data: " + ex.Message);
            }
           
            
        }
        private void frmEmployee_Info_Load(object sender, EventArgs e)
        {
            showAll_Emp_Data();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpg; *.png; *.jpeg; *.gif;)|*.gif; *.jpg; *.png; *.jpeg;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    lbl_ImagePath.Text = open.FileName;
                    pic_Image_User.Image = new Bitmap(open.FileName);
                }
                //MessageBox.Show("Image path: "+lbl_ImagePath.Text);
                //MessageBox.Show("Image path: "+ Path.GetFileName(lbl_ImagePath.Text));
                //MessageBox.Show(Application.StartupPath.ToString());
                //File.Copy(lbl_ImagePath.Text, Path.Combine(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\Images\", Path.GetFileName(lbl_ImagePath.Text)), true);
                //Image_Path2 = @"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\Images\" + Path.GetFileName(txtImage_Path.Text);
                //txtImage_Path.Text = Image_Path2;
                File.Copy(lbl_ImagePath.Text, Path.Combine(@""+ Application.StartupPath.ToString() + @"\Users\", Path.GetFileName(lbl_ImagePath.Text)), true);
                Image_Path2 = @"" + Application.StartupPath.ToString() + @"\Users\" + Path.GetFileName(lbl_ImagePath.Text);
                //txtempAddress.Texts = Image_Path2;
                //MessageBox.Show(@"" + Application.StartupPath.ToString() + @"\Users");
                //MessageBox.Show(Image_Path2);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while importing image: " + ex.Message);
            }
        }

        private void txtEmpName1__TextChanged(object sender, EventArgs e)
        {
            isEmpFormValid = Validation.validateCustName(txtEmpName1.Texts);
            if (isEmpFormValid)
            {
                pic_Name_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\Yes.ico");
            }
            else
            {
                pic_Name_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\No.ico");
            }
        }

        private void txtEmpLastName__TextChanged(object sender, EventArgs e)
        {
            isEmpFormValid = Validation.validateCustName(txtEmpLastName.Texts);
            if (isEmpFormValid)
            {
                pic_LastName_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\Yes.ico");
            }
            else
            {
                pic_LastName_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\No.ico");
            }
        }

        private void txtempAddress__TextChanged(object sender, EventArgs e)
        {
            isEmpFormValid = Validation.validateAdderss(txtempAddress.Texts);
            if (isEmpFormValid)
            {
                pic_Address_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\Yes.ico");
            }
            else
            {
                pic_Address_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\No.ico");
            }
        }

        private void txtEmpPhone__TextChanged(object sender, EventArgs e)
        {
            isEmpFormValid = Validation.validateCustPhone(txtEmpPhone.Texts);
            if (isEmpFormValid)
            {
                pic_Phone_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\Yes.ico");
            }
            else
            {
                pic_Phone_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\No.ico");
            }
        }

        private void txtEmpEmail__TextChanged(object sender, EventArgs e)
        {
            bool emailValid = Validation.validateCustEmail(txtEmpEmail.Texts);

            if (emailValid | txtEmpEmail.Texts == "")
            {
                pic_Email_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\Yes.ico");
                isEmpFormValid = true;
            }
            else
            {
                pic_Email_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\No.ico");
                isEmpFormValid = false;
            }
        }

        private void pic_Name_Validate_Click(object sender, EventArgs e)
        {
            txtEmpName1.Texts = "";
        }

        private void pic_LastName_Validate_Click(object sender, EventArgs e)
        {
            txtEmpLastName.Texts = "";
        }

        private void pic_Address_Validate_Click(object sender, EventArgs e)
        {
            txtempAddress.Texts = "";
        }

        private void pic_Phone_Validate_Click(object sender, EventArgs e)
        {
            txtEmpPhone.Texts = "";
        }

        private void pic_Email_Validate_Click(object sender, EventArgs e)
        {
            txtEmpEmail.Texts = "";
        }
    }
}
