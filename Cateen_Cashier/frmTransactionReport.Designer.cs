namespace Cateen_Cashier
{
    partial class frmTransactionReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionReport));
            this.dgv_Sales = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpk_From = new CustomControls.RJControls.RJDatePicker();
            this.dtpk_To = new CustomControls.RJControls.RJDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Export_to_exel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            this.pnl_Tools = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sales)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnl_Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Sales
            // 
            this.dgv_Sales.AllowUserToAddRows = false;
            this.dgv_Sales.AllowUserToDeleteRows = false;
            this.dgv_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Sales.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_Sales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sales.Location = new System.Drawing.Point(76, 426);
            this.dgv_Sales.Name = "dgv_Sales";
            this.dgv_Sales.ReadOnly = true;
            this.dgv_Sales.RowHeadersVisible = false;
            this.dgv_Sales.Size = new System.Drawing.Size(950, 337);
            this.dgv_Sales.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 407);
            this.panel1.TabIndex = 10;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "To:";
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
            this.dtpk_From.ValueChanged += new System.EventHandler(this.dtpk_From_ValueChanged_1);
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
            this.dtpk_To.ValueChanged += new System.EventHandler(this.dtpk_To_ValueChanged_1);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Reset);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.btn_Export_to_exel);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(91, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 86);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(280, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 56);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
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
            // pnl_Tools
            // 
            this.pnl_Tools.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Tools.Controls.Add(this.panel1);
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(1095, 407);
            this.pnl_Tools.TabIndex = 13;
            // 
            // frmTransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 766);
            this.Controls.Add(this.pnl_Tools);
            this.Controls.Add(this.dgv_Sales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmTransactionReport";
            this.Text = "frmTransactionReport";
            this.Load += new System.EventHandler(this.frmTransactionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnl_Tools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Sales;
        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJDatePicker dtpk_From;
        private CustomControls.RJControls.RJDatePicker dtpk_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Export_to_exel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.GroupBox groupBox4;
        private CustomControls.RJControls.RJTextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}