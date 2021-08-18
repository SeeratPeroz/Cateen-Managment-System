using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cateen_Cashier
{
    public partial class frm_InvDetails_Report : Form
    {
        public frm_InvDetails_Report(String Invoice)
        {
            InitializeComponent();
        }

        private void frm_InvDetails_Report_Load(object sender, EventArgs e)
        {
            try { 
            // ReportDocument crypt = new ReportDocument();
            //    Sales_Invoice cr = new Sales_Invoice();
            
            //string path = Application.StartupPath + "\\Sales_Invoice.rpt";
            //crypt.Load(path);
            //    Invoice_Report.ReportSource = crypt;

               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Stock Print: " + ex.Message);
            }
        }

        private void Invoice_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
