namespace Cateen_Cashier
{
    partial class frmSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReport));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_pk_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_pk_To = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_OnStock = new System.Windows.Forms.DataGridView();
            this.pnl_Tools.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OnStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Tools.Controls.Add(this.groupBox3);
            this.pnl_Tools.Controls.Add(this.groupBox2);
            this.pnl_Tools.Controls.Add(this.groupBox1);
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(1095, 423);
            this.pnl_Tools.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Restart);
            this.groupBox3.Controls.Add(this.btn_Email);
            this.groupBox3.Controls.Add(this.btn_Excel);
            this.groupBox3.Controls.Add(this.btn_Print);
            this.groupBox3.Location = new System.Drawing.Point(321, 321);
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
            this.groupBox2.Location = new System.Drawing.Point(91, 241);
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
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(484, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(363, 29);
            this.txtSearch.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_pk_From);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dt_pk_To);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(91, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date ";
            // 
            // dt_pk_From
            // 
            this.dt_pk_From.Location = new System.Drawing.Point(94, 41);
            this.dt_pk_From.Margin = new System.Windows.Forms.Padding(6);
            this.dt_pk_From.Name = "dt_pk_From";
            this.dt_pk_From.Size = new System.Drawing.Size(363, 29);
            this.dt_pk_From.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "From:";
            // 
            // dt_pk_To
            // 
            this.dt_pk_To.Location = new System.Drawing.Point(549, 41);
            this.dt_pk_To.Margin = new System.Windows.Forms.Padding(6);
            this.dt_pk_To.Name = "dt_pk_To";
            this.dt_pk_To.Size = new System.Drawing.Size(363, 29);
            this.dt_pk_To.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "To:";
            // 
            // dgv_OnStock
            // 
            this.dgv_OnStock.AllowUserToAddRows = false;
            this.dgv_OnStock.AllowUserToDeleteRows = false;
            this.dgv_OnStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_OnStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OnStock.Location = new System.Drawing.Point(76, 464);
            this.dgv_OnStock.Name = "dgv_OnStock";
            this.dgv_OnStock.ReadOnly = true;
            this.dgv_OnStock.Size = new System.Drawing.Size(950, 288);
            this.dgv_OnStock.TabIndex = 10;
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 766);
            this.Controls.Add(this.pnl_Tools);
            this.Controls.Add(this.dgv_OnStock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSalesReport";
            this.Text = "frmSalesReport";
            this.pnl_Tools.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OnStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_pk_From;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_pk_To;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_OnStock;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Email;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnl_Tools;
    }
}