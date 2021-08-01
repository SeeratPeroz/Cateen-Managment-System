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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Tools = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtInviceSearch = new CustomControls.RJControls.RJTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_SendEmail = new System.Windows.Forms.Button();
            this.btn_Export_to_exel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpk_To = new CustomControls.RJControls.RJDatePicker();
            this.dtpk_From = new CustomControls.RJControls.RJDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Email = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.dgv_Sales = new System.Windows.Forms.DataGridView();
            this.pnl_Tools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Tools.Controls.Add(this.panel1);
            this.pnl_Tools.Controls.Add(this.groupBox3);
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(1095, 416);
            this.pnl_Tools.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 431);
            this.panel1.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtInviceSearch);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Location = new System.Drawing.Point(411, 345);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 80);
            this.groupBox5.TabIndex = 105;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Specific Invoice";
            // 
            // txtInviceSearch
            // 
            this.txtInviceSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtInviceSearch.BorderColor = System.Drawing.Color.Orange;
            this.txtInviceSearch.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.txtInviceSearch.BorderRadius = 10;
            this.txtInviceSearch.BorderSize = 2;
            this.txtInviceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInviceSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInviceSearch.Location = new System.Drawing.Point(161, 29);
            this.txtInviceSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtInviceSearch.Multiline = false;
            this.txtInviceSearch.Name = "txtInviceSearch";
            this.txtInviceSearch.Padding = new System.Windows.Forms.Padding(15, 7, 10, 7);
            this.txtInviceSearch.PasswordChar = false;
            this.txtInviceSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtInviceSearch.PlaceholderText = "   Enter Invoice #";
            this.txtInviceSearch.Size = new System.Drawing.Size(194, 31);
            this.txtInviceSearch.TabIndex = 6;
            this.txtInviceSearch.Texts = "";
            this.txtInviceSearch.UnderlinedStyle = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(44, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 43);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(556, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 86);
            this.groupBox2.TabIndex = 104;
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
            this.txtSearch._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Reset);
            this.groupBox4.Controls.Add(this.btn_SendEmail);
            this.groupBox4.Controls.Add(this.btn_Export_to_exel);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(91, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 86);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.Location = new System.Drawing.Point(373, 28);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(60, 52);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.BackColor = System.Drawing.Color.Transparent;
            this.btn_SendEmail.Image = ((System.Drawing.Image)(resources.GetObject("btn_SendEmail.Image")));
            this.btn_SendEmail.Location = new System.Drawing.Point(280, 26);
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(74, 56);
            this.btn_SendEmail.TabIndex = 4;
            this.btn_SendEmail.UseVisualStyleBackColor = false;
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // btn_Export_to_exel
            // 
            this.btn_Export_to_exel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Export_to_exel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Export_to_exel.Image")));
            this.btn_Export_to_exel.Location = new System.Drawing.Point(200, 24);
            this.btn_Export_to_exel.Name = "btn_Export_to_exel";
            this.btn_Export_to_exel.Size = new System.Drawing.Size(74, 56);
            this.btn_Export_to_exel.TabIndex = 4;
            this.btn_Export_to_exel.UseVisualStyleBackColor = false;
            this.btn_Export_to_exel.Click += new System.EventHandler(this.btn_Export_to_exel_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(108, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 56);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpk_To);
            this.groupBox1.Controls.Add(this.dtpk_From);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(91, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 100);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "From:";
            // 
            // dtpk_To
            // 
            this.dtpk_To.BorderColor = System.Drawing.Color.PapayaWhip;
            this.dtpk_To.BorderSize = 0;
            this.dtpk_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpk_To.Location = new System.Drawing.Point(546, 41);
            this.dtpk_To.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpk_To.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpk_To.Name = "dtpk_To";
            this.dtpk_To.Size = new System.Drawing.Size(363, 35);
            this.dtpk_To.SkinColor = System.Drawing.Color.Orange;
            this.dtpk_To.TabIndex = 10;
            this.dtpk_To.TextColor = System.Drawing.Color.White;
            this.dtpk_To.ValueChanged += new System.EventHandler(this.dtpk_To_ValueChanged);
            // 
            // dtpk_From
            // 
            this.dtpk_From.BorderColor = System.Drawing.Color.PapayaWhip;
            this.dtpk_From.BorderSize = 0;
            this.dtpk_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpk_From.Location = new System.Drawing.Point(93, 41);
            this.dtpk_From.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpk_From.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpk_From.Name = "dtpk_From";
            this.dtpk_From.Size = new System.Drawing.Size(363, 35);
            this.dtpk_From.SkinColor = System.Drawing.Color.Orange;
            this.dtpk_From.TabIndex = 10;
            this.dtpk_From.TextColor = System.Drawing.Color.White;
            this.dtpk_From.ValueChanged += new System.EventHandler(this.dtpk_From_ValueChanged);
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
            // dgv_Sales
            // 
            this.dgv_Sales.AllowUserToAddRows = false;
            this.dgv_Sales.AllowUserToDeleteRows = false;
            this.dgv_Sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Sales.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_Sales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sales.Location = new System.Drawing.Point(76, 446);
            this.dgv_Sales.Name = "dgv_Sales";
            this.dgv_Sales.ReadOnly = true;
            this.dgv_Sales.RowHeadersVisible = false;
            this.dgv_Sales.Size = new System.Drawing.Size(950, 308);
            this.dgv_Sales.TabIndex = 10;
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1095, 766);
            this.Controls.Add(this.dgv_Sales);
            this.Controls.Add(this.pnl_Tools);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSalesReport";
            this.Text = "frmSalesReport";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            this.pnl_Tools.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Email;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.DataGridView dgv_Sales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_SendEmail;
        private System.Windows.Forms.Button btn_Export_to_exel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJDatePicker dtpk_From;
        private CustomControls.RJControls.RJDatePicker dtpk_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomControls.RJControls.RJTextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button5;
        private CustomControls.RJControls.RJTextBox txtInviceSearch;
    }
}