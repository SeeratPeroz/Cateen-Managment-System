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
            this.SuspendLayout();
            // 
            // crystal_Report
            // 
            this.crystal_Report.ActiveViewIndex = -1;
            this.crystal_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_Report.Location = new System.Drawing.Point(0, 0);
            this.crystal_Report.Name = "crystal_Report";
            this.crystal_Report.Size = new System.Drawing.Size(570, 504);
            this.crystal_Report.TabIndex = 0;
            // 
            // Stock_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 504);
            this.Controls.Add(this.crystal_Report);
            this.Name = "Stock_Print";
            this.Text = "Stock_Print";
            this.Load += new System.EventHandler(this.Stock_Print_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_Report;
    }
}