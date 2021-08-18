namespace Cateen_Cashier
{
    partial class Stock_Print
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystal_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Sales_Invoice1 = new Cateen_Cashier.Sales_Invoice();
            this.SuspendLayout();
            // 
            // crystal_Report
            // 
            this.crystal_Report.ActiveViewIndex = 0;
            this.crystal_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_Report.Location = new System.Drawing.Point(0, 0);
            this.crystal_Report.Name = "crystal_Report";
            this.crystal_Report.ReportSource = "E:\\Drive E\\BCS\\PROJECTS\\Cateen_Management_System\\Cateen_Cashier\\bin\\Debug\\Crystal" +
    "Report1.rpt";
            this.crystal_Report.Size = new System.Drawing.Size(769, 577);
            this.crystal_Report.TabIndex = 0;
            this.crystal_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystal_Report.Load += new System.EventHandler(this.crystal_Report_Load);
            // 
            // Sales_Invoice1
            // 
            this.Sales_Invoice1.FileName = "rassdk://C:\\Users\\LOPI\\AppData\\Local\\Temp\\temp_cfbbdcf6-59ff-4215-a112-92ad490eea" +
    "de.rpt";
            // 
            // Stock_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 577);
            this.Controls.Add(this.crystal_Report);
            this.Name = "Stock_Print";
            this.Text = "Stock_Print";
            this.Load += new System.EventHandler(this.Stock_Print_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_Report;
        private Cateen_Cashier.Sales_Invoice Sales_Invoice1;
    }
}