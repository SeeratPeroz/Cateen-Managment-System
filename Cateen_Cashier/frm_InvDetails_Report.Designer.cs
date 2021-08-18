namespace Cateen_Cashier
{
    partial class frm_InvDetails_Report
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
            this.Invoice_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Sales_Invoice1 = new Cateen_Cashier.Sales_Invoice();
            this.Sales_Invoice2 = new Cateen_Cashier.Sales_Invoice();
            this.SuspendLayout();
            // 
            // Invoice_Report
            // 
            this.Invoice_Report.ActiveViewIndex = 0;
            this.Invoice_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Invoice_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.Invoice_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Invoice_Report.Location = new System.Drawing.Point(0, 0);
            this.Invoice_Report.Name = "Invoice_Report";
            this.Invoice_Report.ReportSource = this.Sales_Invoice2;
            this.Invoice_Report.Size = new System.Drawing.Size(749, 616);
            this.Invoice_Report.TabIndex = 0;
            this.Invoice_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.Invoice_Report.Load += new System.EventHandler(this.Invoice_Report_Load);
            // 
            // Sales_Invoice1
            // 
            this.Sales_Invoice1.FileName = "rassdk://C:\\Users\\LOPI\\AppData\\Local\\Temp\\temp_e0ba4a36-8af6-4a85-bb03-3511a1bf20" +
    "1c.rpt";
            // 
            // frm_InvDetails_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 616);
            this.Controls.Add(this.Invoice_Report);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_InvDetails_Report";
            this.Text = "Invoice Details";
            this.Load += new System.EventHandler(this.frm_InvDetails_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Invoice_Report;
        private Cateen_Cashier.Sales_Invoice Sales_Invoice1;
        private Sales_Invoice Sales_Invoice2;
    }
}