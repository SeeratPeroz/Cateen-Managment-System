namespace Cateen_Cashier
{
    partial class frmCustomerSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerSearch));
            this.pnlCustomerSearch = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSearchBy = new System.Windows.Forms.PictureBox();
            this.lblSearchBY = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlCustomerSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchBy)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomerSearch
            // 
            this.pnlCustomerSearch.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCustomerSearch.Controls.Add(this.panel2);
            this.pnlCustomerSearch.Controls.Add(this.panel1);
            this.pnlCustomerSearch.Controls.Add(this.lblSearchBY);
            this.pnlCustomerSearch.Controls.Add(this.txtSearch);
            this.pnlCustomerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerSearch.Name = "pnlCustomerSearch";
            this.pnlCustomerSearch.Size = new System.Drawing.Size(1063, 688);
            this.pnlCustomerSearch.TabIndex = 28;
            this.pnlCustomerSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCustomerSearch_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(862, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 688);
            this.panel2.TabIndex = 91;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // picSearch
            // 
            this.picSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSearch.BackColor = System.Drawing.Color.Transparent;
            this.picSearch.ErrorImage = null;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.InitialImage = null;
            this.picSearch.Location = new System.Drawing.Point(4, 335);
            this.picSearch.Margin = new System.Windows.Forms.Padding(2);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(73, 61);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 89;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            this.picSearch.MouseLeave += new System.EventHandler(this.picSearch_MouseLeave);
            this.picSearch.MouseHover += new System.EventHandler(this.picSearch_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picSearchBy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 688);
            this.panel1.TabIndex = 90;
            // 
            // picSearchBy
            // 
            this.picSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.picSearchBy.ErrorImage = null;
            this.picSearchBy.Image = ((System.Drawing.Image)(resources.GetObject("picSearchBy.Image")));
            this.picSearchBy.InitialImage = null;
            this.picSearchBy.Location = new System.Drawing.Point(182, 335);
            this.picSearchBy.Margin = new System.Windows.Forms.Padding(2);
            this.picSearchBy.Name = "picSearchBy";
            this.picSearchBy.Size = new System.Drawing.Size(96, 61);
            this.picSearchBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchBy.TabIndex = 89;
            this.picSearchBy.TabStop = false;
            this.picSearchBy.Click += new System.EventHandler(this.picSearchBy_Click);
            this.picSearchBy.MouseLeave += new System.EventHandler(this.picSearchBy_MouseLeave);
            this.picSearchBy.MouseHover += new System.EventHandler(this.picSearchBy_MouseHover);
            // 
            // lblSearchBY
            // 
            this.lblSearchBY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchBY.AutoSize = true;
            this.lblSearchBY.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBY.ForeColor = System.Drawing.Color.Black;
            this.lblSearchBY.Location = new System.Drawing.Point(469, 248);
            this.lblSearchBY.Name = "lblSearchBY";
            this.lblSearchBY.Size = new System.Drawing.Size(227, 47);
            this.lblSearchBY.TabIndex = 7;
            this.lblSearchBY.Text = "Customer ID";
            this.lblSearchBY.Click += new System.EventHandler(this.lblSearchBY_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(282, 339);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '✶';
            this.txtSearch.Size = new System.Drawing.Size(580, 57);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // frmCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 688);
            this.Controls.Add(this.pnlCustomerSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCustomerSearch";
            this.Text = "frmCustomerSearch";
            this.Load += new System.EventHandler(this.frmCustomerSearch_Load);
            this.pnlCustomerSearch.ResumeLayout(false);
            this.pnlCustomerSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSearchBy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomerSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.PictureBox picSearchBy;
        private System.Windows.Forms.Label lblSearchBY;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}