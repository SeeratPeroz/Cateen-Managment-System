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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_login_2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }

        private void btn_login_2_Click_1(object sender, EventArgs e)
        {
            try
            {
                DBContext.createConnection(txt_Username.Text, txt_Password.Text);
                DBContext.openConnection();
                Program.isUserValid = true;

                createUser();

                SqlDataAdapter AD = new SqlDataAdapter();
                String Qur = "SELECT [empLogin],[empRole] FROM [Canteen_Database].[dbo].[Employee] WHERE [empid] = '" + Program.userName + "'";
                AD.SelectCommand = new SqlCommand(Qur, DBContext.con);
                DataTable dt = new DataTable();
                AD.Fill(dt);
                String userRole = dt.Rows[0][0].ToString();
                Program.userRole = dt.Rows[0][1].ToString();
                if (userRole == "1")
                {
                    Program.isUserValid = true;
                }
                else
                {
                    Program.isUserValid = false;
                    MessageBox.Show("Account is disabled. Please contact admin");

                }

                DBContext.closeConnection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            //btn_login_2.PerformClick();
        }

        // Creating user

        private void createUser()
        {
            if (Program.isUserValid)
            {
                try
                {
                    SqlDataAdapter AD = new SqlDataAdapter();
                    DBContext.createConnection(Program.userName, Program.userPass);
                    String Qur = "SELECT COUNT([empID]) FROM [Canteen_Database].[dbo].[Employee] WHERE [empid] = '" + Program.userName + "'";
                    AD.SelectCommand = new SqlCommand(Qur, DBContext.con);
                    DataTable dt = new DataTable();
                    AD.Fill(dt);
                    DBContext.closeConnection();
                    String userCount = dt.Rows[0][0].ToString();
                    //MessageBox.Show(userCount);

                    if (userCount == "0")
                    {
                        DBContext.createConnection(Program.userName, Program.userPass);
                        DBContext.openConnection();
                        String image = @"" + Application.StartupPath.ToString() + @"\Users\Untitled-11.png";

                        AD.InsertCommand = new SqlCommand("INSERT INTO [Canteen_Database].[dbo].[Employee] VALUES ('" + Program.userName + "','','',2,'','','','" + image + "',1)", DBContext.con);
                        AD.InsertCommand.ExecuteNonQuery();
                        DBContext.closeConnection();
                        MessageBox.Show("Welcome " + Program.userName, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //MessageBox.Show("Welcome", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login Page error: " + ex.Message);
                }
            }


        }
    }
}
