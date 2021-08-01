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
            this.label2 = new System.Windows.Forms.Label();
            this.toggle_OutOFstock = new CustomControls.RJControls.RJToggleButton();
            this.lbl_totalProducts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Email = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.dgv_OnStock = new System.Windows.Forms.DataGridView();
            this.pnl_Tools.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OnStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Tools.Controls.Add(this.label2);
            this.pnl_Tools.Controls.Add(this.toggle_OutOFstock);
            this.pnl_Tools.Controls.Add(this.lbl_totalProducts);
            this.pnl_Tools.Controls.Add(this.label1);
            this.pnl_Tools.Controls.Add(this.groupBox2);
            this.pnl_Tools.Controls.Add(this.groupBox3);
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(1095, 317);
            this.pnl_Tools.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 108;
            this.label2.Text = "Out of stock products:";
            // 
            // toggle_OutOFstock
            // 
            this.toggle_OutOFstock.AutoSize = true;
            this.toggle_OutOFstock.Location = new System.Drawing.Point(825, 272);
            this.toggle_OutOFstock.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggle_OutOFstock.Name = "toggle_OutOFstock";
            this.toggle_OutOFstock.OffBackColor = System.Drawing.Color.Gray;
            this.toggle_OutOFstock.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggle_OutOFstock.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggle_OutOFstock.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggle_OutOFstock.Size = new System.Drawing.Size(45, 22);
            this.toggle_OutOFstock.TabIndex = 107;
            this.toggle_OutOFstock.UseVisualStyleBackColor = true;
            this.toggle_OutOFstock.CheckedChanged += new System.EventHandler(this.toggle_OutOFstock_CheckedChanged);
            // 
            // lbl_totalProducts
            // 
            this.lbl_totalProducts.AutoSize = true;
            this.lbl_totalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalProducts.Location = new System.Drawing.Point(267, 258);
            this.lbl_totalProducts.Name = "lbl_totalProducts";
            this.lbl_totalProducts.Size = new System.Drawing.Size(171, 24);
            this.lbl_totalProducts.TabIndex = 106;
            this.lbl_totalProducts.Text = "On Stock Products:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 106;
            this.label1.Text = "On Stock Products:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(76, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 86);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.Orange;
            this.txtSearch.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(139, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(20, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "     Search Here...";
            this.txtSearch.Size = new System.Drawing.Size(305, 35);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Restart);
            this.groupBox3.Controls.Add(this.btn_Email);
            this.groupBox3.Controls.Add(this.btn_Excel);
            this.groupBox3.Controls.Add(this.btn_Print);
            this.groupBox3.Location = new System.Drawing.Point(556, 131);
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
            this.btn_Email.Click += new System.EventHandler(this.btn_Email_Click);
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
            // dgv_OnStock
            // 
            this.dgv_OnStock.AllowUserToAddRows = false;
            this.dgv_OnStock.AllowUserToDeleteRows = false;
            this.dgv_OnStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_OnStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_OnStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OnStock.Location = new System.Drawing.Point(76, 353);
            this.dgv_OnStock.Name = "dgv_OnStock";
            this.dgv_OnStock.ReadOnly = true;
            this.dgv_OnStock.Size = new System.Drawing.Size(950, 385);
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
            this.pnl_Tools.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private CustomControls.RJControls.RJTextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_totalProducts;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJToggleButton toggle_OutOFstock;
    }
}