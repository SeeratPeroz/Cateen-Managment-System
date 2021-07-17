namespace Cateen_Cashier
{
    partial class frmOnStockProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOnStockProducts));
            this.pnl_Tools = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Email = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgv_OnStock = new System.Windows.Forms.DataGridView();
            this.pnl_Tools.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OnStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Tools.Controls.Add(this.groupBox3);
            this.pnl_Tools.Controls.Add(this.groupBox2);
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(1095, 385);
            this.pnl_Tools.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Restart);
            this.groupBox3.Controls.Add(this.btn_Email);
            this.groupBox3.Controls.Add(this.btn_Excel);
            this.groupBox3.Controls.Add(this.btn_Print);
            this.groupBox3.Location = new System.Drawing.Point(310, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 86);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackColor = System.Drawing.Color.Transparent;
            this.btn_Restart.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restart.Image")));
            this.btn_Restart.Location = new System.Drawing.Point(388, 28);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(60, 52);
            this.btn_Restart.TabIndex = 5;
            this.btn_Restart.UseVisualStyleBackColor = false;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // btn_Email
            // 
            this.btn_Email.BackColor = System.Drawing.Color.Transparent;
            this.btn_Email.Image = ((System.Drawing.Image)(resources.GetObject("btn_Email.Image")));
            this.btn_Email.Location = new System.Drawing.Point(280, 26);
            this.btn_Email.Name = "btn_Email";
            this.btn_Email.Size = new System.Drawing.Size(74, 56);
            this.btn_Email.TabIndex = 4;
            this.btn_Email.UseVisualStyleBackColor = false;
            // 
            // btn_Excel
            // 
            this.btn_Excel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel.Image")));
            this.btn_Excel.Location = new System.Drawing.Point(200, 24);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(74, 56);
            this.btn_Excel.TabIndex = 4;
            this.btn_Excel.UseVisualStyleBackColor = false;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.Transparent;
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.Location = new System.Drawing.Point(108, 24);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(74, 56);
            this.btn_Print.TabIndex = 4;
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSearchBy);
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(91, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Product ID",
            "Product Name",
            "Category Name",
            "Quantity"});
            this.cmbSearchBy.Location = new System.Drawing.Point(96, 28);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(363, 32);
            this.cmbSearchBy.TabIndex = 2;
            this.cmbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBy_SelectedIndexChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(860, 28);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(60, 37);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(484, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(363, 29);
            this.txtSearch.TabIndex = 3;
            // 
            // dgv_OnStock
            // 
            this.dgv_OnStock.AllowUserToAddRows = false;
            this.dgv_OnStock.AllowUserToDeleteRows = false;
            this.dgv_OnStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_OnStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OnStock.Location = new System.Drawing.Point(76, 413);
            this.dgv_OnStock.Name = "dgv_OnStock";
            this.dgv_OnStock.ReadOnly = true;
            this.dgv_OnStock.Size = new System.Drawing.Size(950, 325);
            this.dgv_OnStock.TabIndex = 8;
            // 
            // frmOnStockProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1095, 766);
            this.Controls.Add(this.dgv_OnStock);
            this.Controls.Add(this.pnl_Tools);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmOnStockProducts";
            this.Text = "frmOnStockProducts";
            this.Load += new System.EventHandler(this.frmOnStockProducts_Load);
            this.pnl_Tools.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OnStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.DataGridView dgv_OnStock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Email;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}