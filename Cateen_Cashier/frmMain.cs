using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cateen_Cashier
{
    public partial class frmMain : Form
    {
        String imagePath = "";
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
        public frmMain()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // Hide all Sub Panel
            hide_all_sub_menus();
        }

        // To hide all Sub Panels
        private void hide_all_sub_menus()
        {
            pnl_sub_Transaction.Visible = false;
            pnl_Sub_Stock.Visible = false;
            pnl_sub_Report.Visible = false;
            pnlInventory.Visible = false;
        }

        // Hide the Submenus
        private void hide_Sub_Menu_Panels()
        {
            if (pnl_sub_Transaction.Visible)
            {
                pnl_sub_Transaction.Visible = false;
            }
            if (pnl_Sub_Stock.Visible)
            {
                pnl_Sub_Stock.Visible = false;
            }
            if (pnl_sub_Report.Visible)
            {
                pnl_sub_Report.Visible = false;
            }
            if (pnlInventory.Visible)
            {
                pnlInventory.Visible = false;
            }
        }

        // Show sub menus
        private void showSubMenus(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hide_Sub_Menu_Panels();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        void point_btn(Button btn,int flag)
        {
            if(flag != 0)
            {
                pnlNav.Visible = true;
                pnlNav.Height = btn.Height;
                pnlNav.Top = btn.Top;
                pnlNav.Left = btn.Left;
            }
            else
            {
                pnlNav.Visible = true;

            }

        }

        private void btn_Add_Customer_Click_1(object sender, EventArgs e)
        {
            setImage(); pnl_Clock.Visible = false;

            label3.Text = "Customers";
            openChildForm(new frmCustomer());
            // ..
            // Code here
            // ..
            changeColor(btn_Add_Customer,1);
            point_btn(btn_Add_Customer,1);
            hide_Sub_Menu_Panels();
        }

        private void btn_Transaction_Click_1(object sender, EventArgs e)
        {
            setImage();

            point_btn(btn_Transaction,1);
            changeColor(btn_Transaction, 1);
            showSubMenus(pnl_sub_Transaction);
        }

        private void btn_CheckBalance_Click_1(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;
            openChildForm(new frmCustomerSearch(null));
            label3.Text = "Check Balance";
            // ..
            // Code here
            // ..
            point_btn(btn_CheckBalance,0);
            hide_Sub_Menu_Panels();

        }

        private void btn_Deposit_Click_1(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;

            openChildForm(new frmCustomerSearch("DP"));
            label3.Text = "Deposit Money";
            // ..
            // Code here
            // ..
            point_btn(btn_Deposit,0);
            hide_Sub_Menu_Panels();
        }

        private void btn_Stock_Click_1(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;

            setImage();
            // ..
            // Code here
            // ..
            point_btn(btn_Stock,1);
            changeColor(btn_Stock, 1);
            showSubMenus(pnl_Sub_Stock);


        }

        private void btn_Categories_Click_1(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;

            openChildForm(new frmCategory());
            label3.Text = "Categories";
            // ..
            // Code here
            // ..
            point_btn(btn_Categories,0);
            hide_Sub_Menu_Panels();
        }

        private void btn_Products_Click_1(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;

            openChildForm(new frmProduct());
            label3.Text = "Products";
            // ..
            // Code here
            // ..
            point_btn(btn_Products,0);
            hide_Sub_Menu_Panels();
        }

        private void btnCart_Click_1(object sender, EventArgs e)
        {

            openChildForm(new frmCart());
            label3.Text = "Sale Products";
            // ..
            // Code here
            // ..
            //point_btn(btnInvetory,1);
            //changeColor(btnInvetory, 1);
            hide_Sub_Menu_Panels();
        }

        private void btn_Report_Click_1(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;
            setImage();
            point_btn(btn_Report,1);
            changeColor(btn_Report, 1);
            showSubMenus(pnl_sub_Report);
        }

        private void btn_Sales_Report_Click_1(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;
            point_btn(btn_Sales_Report,0);
            hide_Sub_Menu_Panels();
        }

        private void btn_Deposit_report_Click(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;
            label3.Text = "Transaction Report";

            // ..
            // Code here
            // ..
            openChildForm(new frmTransactionReport());
            point_btn(btn_Deposit_report,0);
            hide_Sub_Menu_Panels();
        }

        private void btn_stock_report_Click(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;

            openChildForm(new frmOnStockProducts());
            label3.Text = "Stock Report";
            // ..
            // Code here
            // ..
            point_btn(btn_stock_report,0);
            hide_Sub_Menu_Panels();
        }


        // to Open different form inside cantiner
        public static Form activeForm = null;
        public  static void openChildForm(Form childForm)
        {
            if(activeForm != null){
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.BringToFront();
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnl_Child_Form.Controls.Add(childForm);
            pnl_Child_Form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        


        private void frmMain_Load_1(object sender, EventArgs e)
        {            
            // Getting user Details

            SqlDataAdapter AD = new SqlDataAdapter();
            DBContext.createConnection(Program.userName, Program.userPass);
            String Qur = "SELECT empID, empName + ' ' + empLastName, empImage FROM dbo.Employee WHERE empID = '"+Program.userName +"'";
            AD.SelectCommand = new SqlCommand(Qur, DBContext.con);
            DataTable dt = new DataTable();
            AD.Fill(dt);
            DBContext.closeConnection();



            String userID = dt.Rows[0][0].ToString();
            String userName = dt.Rows[0][1].ToString();
            
            if(userName == "")
            {
                lbl_Title.Text = userID;
                frmEmployee_Info empInfo = new frmEmployee_Info();
                empInfo.ShowDialog();
            }
            else
            {
                lbl_Title.Text = userName;
                //MessageBox.Show(dt.Rows[0][7].ToString());
                logo.Image = new Bitmap(dt.Rows[0][2].ToString());
                imagePath = dt.Rows[0][2].ToString();
            }
            
            btn_Dashboard.PerformClick();
        }


        void changeColor(Button btn,int flag)
        {
            btn_Add_Customer.BackColor = Color.FromArgb(1, 1, 10);
            btn_Dashboard.BackColor = Color.FromArgb(1, 1, 10);
            btn_Stock.BackColor = Color.FromArgb(1, 1, 10);
            btn_Transaction.BackColor = Color.FromArgb(1, 1, 10);
            btn_Report.BackColor = Color.FromArgb(1, 1, 10);
            btnInvetory.BackColor = Color.FromArgb(1, 1, 10);
            btn_Add_Customer.ForeColor = Color.White;
            btn_Stock.ForeColor = Color.White;
            btn_Transaction.ForeColor = Color.White;
            btn_Report.ForeColor = Color.White;
            btnInvetory.ForeColor = Color.White;



                //  btn.BackColor = Color.FromArgb(46, 51, 73);
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
        }

       

        private void pnl_Tittle_Bar_DoubleClick(object sender, EventArgs e)
        {
            if(t == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                t = 1;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                t = 0;

            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            pnl_Clock.Visible = true;
            
            //tmCLock_Date.Stop();
            tmCLock_Date.Start();
            setImage();
            label3.Text = "Dashboard";
            pnl_Clock.Visible = true;
            openChildForm(new frmDashboard());
            // ..
            // Code here
            // ..
            btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);
            hide_Sub_Menu_Panels();
            
        }


        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;

            openChildForm(new frmPurchase());
            label3.Text = "Buy Products";
            // ..
            // Code here
            // ..
            //point_btn(btn_Purchase, 0);
            //changeColor(btn_Purchase, 0);
            hide_Sub_Menu_Panels();
        }

        private void btnInvetory_Click(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;

            // ..
            // Code Here
            //...
            point_btn(btnInvetory, 1);
            changeColor(btnInvetory, 1);
            showSubMenus(pnlInventory);
        }
        

        private void btn_Purchase_Report_Click(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;
            label3.Text = "Purchase Report";

            // ..
            // Code here
            // ..
            openChildForm(new frmPurchaseReport());
            point_btn(btn_Purchase, 0);
            hide_Sub_Menu_Panels();
        }

        private void btn_Sales_Report_Click(object sender, EventArgs e)
        {
            pnl_Clock.Visible = false;

            openChildForm(new frmSalesReport());
            label3.Text = "Sales Report";
            // ..
            // Code here
            // ..
            point_btn(btn_Sales_Report, 0);
            hide_Sub_Menu_Panels();
        }

       

        private void btn_Settings_Click_1(object sender, EventArgs e)
        {
            
            frmEmployee_Info empInfo = new frmEmployee_Info();   
            empInfo.ShowDialog();

            // ..
            // Code here
            // ..
            point_btn(btn_Purchase, 0);
            hide_Sub_Menu_Panels();
           
        }

       
        // Function to set image on side panel
        public void setImage()
        {
            try
            {
                SqlDataAdapter AD = new SqlDataAdapter();
                DBContext.createConnection(Program.userName, Program.userPass);
                String Qur = "SELECT empID, empName + ' ' + empLastName, empImage FROM dbo.Employee WHERE empID = '" + Program.userName + "'";
                AD.SelectCommand = new SqlCommand(Qur, DBContext.con);
                DataTable dt = new DataTable();
                AD.Fill(dt);
                DBContext.closeConnection();

                logo.Image = new Bitmap(dt.Rows[0][2].ToString());
                lbl_Title.Text = dt.Rows[0][1].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while updating page: " + ex.Message);
            }

        }

        private void pnl_Tittle_Bar_MouseDown(object sender, MouseEventArgs e)
        {
         
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        
    }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO---------------------------------------
        int lx, ly;
        int sw, sh;

        //Time and Date ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
            setImage();
        }

    private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }


        // ------------------ Employee -------------------------------------- \\

        private void btn_Employees_Click(object sender, EventArgs e)
        {
            setImage(); pnl_Clock.Visible = false;

            label3.Text = "Employees";
            openChildForm(new frmEmployee());
            // ..
            // Code here
            // ..
            ////////////changeColor(btn_Employees, 1);
            ////////////point_btn(btn_Employees, 1);
            hide_Sub_Menu_Panels();
        }

    }   
}
