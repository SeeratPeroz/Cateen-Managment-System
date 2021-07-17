using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            point_btn(btn_Transaction,1);
            changeColor(btn_Transaction, 1);
            showSubMenus(pnl_sub_Transaction);
        }

        private void btn_CheckBalance_Click_1(object sender, EventArgs e)
        {
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
            
            // ..
            // Code here
            // ..
            point_btn(btn_Stock,1);
            changeColor(btn_Stock, 1);
            showSubMenus(pnl_Sub_Stock);


        }

        private void btn_Categories_Click_1(object sender, EventArgs e)
        {
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
            point_btn(btn_Report,1);
            changeColor(btn_Report, 1);
            showSubMenus(pnl_sub_Report);
        }

        private void btn_Sales_Report_Click_1(object sender, EventArgs e)
        {
            point_btn(btn_Sales_Report,0);
            hide_Sub_Menu_Panels();
        }

        private void btn_Deposit_report_Click(object sender, EventArgs e)
        {
            // ..
            // Code here
            // ..
            point_btn(btn_Deposit_report,0);
            hide_Sub_Menu_Panels();
        }

        private void btn_stock_report_Click(object sender, EventArgs e)
        {
            
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
            // point_btn(btn_Add_Customer,1);
            //btn_Dashboard.PerformClick();
            openChildForm(new frmOnStockProducts());
            //changeColor(btn_Add_Customer, 1);

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

        private void pnl_Tittle_Bar_Paint(object sender, PaintEventArgs e)
        {
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
            label3.Text = "Dashboard";
            openChildForm(new frmDashboard());
            // ..
            // Code here
            // ..
            btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);
            hide_Sub_Menu_Panels();
            
        }


        private void btn_Purchase_Click(object sender, EventArgs e)
        {
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
            // ..
            // Code Here
            //...
            point_btn(btnInvetory, 1);
            changeColor(btnInvetory, 1);
            showSubMenus(pnlInventory);
        }
        

        private void btn_Purchase_Report_Click(object sender, EventArgs e)
        {
            // ..
            // Code here
            // ..
            point_btn(btn_Purchase, 0);
            hide_Sub_Menu_Panels();
        }

        private void btn_Sales_Report_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSalesReport());
            label3.Text = "Sales Report";
            // ..
            // Code here
            // ..
            point_btn(btn_Sales_Report, 0);
            hide_Sub_Menu_Panels();
        }
    }
}
