namespace Cateen_Cashier
{
    partial class frmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.pnlCart = new System.Windows.Forms.Panel();
            this.grbCartCustomer = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCustBalanceCart = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtStdID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.grbCartProduct = new System.Windows.Forms.GroupBox();
            this.pic_UnitPrice_Valid = new System.Windows.Forms.PictureBox();
            this.pic_prdNameValidate_pnlProduct = new System.Windows.Forms.PictureBox();
            this.pic_prdIDValidate_pnlProduct = new System.Windows.Forms.PictureBox();
            this.lblPrd = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.cmbPrdID = new System.Windows.Forms.ComboBox();
            this.txtPrdID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteCart = new System.Windows.Forms.Button();
            this.chk_Manual = new System.Windows.Forms.CheckBox();
            this.chkPrdSearch = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUpdateCart = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtPrdQuantity = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlCart.SuspendLayout();
            this.grbCartCustomer.SuspendLayout();
            this.grbCartProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UnitPrice_Valid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prdNameValidate_pnlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prdIDValidate_pnlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCart
            // 
            this.pnlCart.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCart.Controls.Add(this.grbCartCustomer);
            this.pnlCart.Controls.Add(this.grbCartProduct);
            this.pnlCart.Controls.Add(this.dgvProduct);
            this.pnlCart.Controls.Add(this.label18);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCart.Location = new System.Drawing.Point(0, 0);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(1079, 727);
            this.pnlCart.TabIndex = 93;
            // 
            // grbCartCustomer
            // 
            this.grbCartCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCartCustomer.Controls.Add(this.label13);
            this.grbCartCustomer.Controls.Add(this.lblTotal);
            this.grbCartCustomer.Controls.Add(this.label14);
            this.grbCartCustomer.Controls.Add(this.lblCustBalanceCart);
            this.grbCartCustomer.Controls.Add(this.btnSubmit);
            this.grbCartCustomer.Controls.Add(this.txtStdID);
            this.grbCartCustomer.Controls.Add(this.label16);
            this.grbCartCustomer.Location = new System.Drawing.Point(640, 113);
            this.grbCartCustomer.Name = "grbCartCustomer";
            this.grbCartCustomer.Size = new System.Drawing.Size(386, 360);
            this.grbCartCustomer.TabIndex = 96;
            this.grbCartCustomer.TabStop = false;
            this.grbCartCustomer.Text = "Cart Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 24);
            this.label13.TabIndex = 80;
            this.label13.Text = "Total Cost:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(140, 78);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 24);
            this.lblTotal.TabIndex = 82;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 24);
            this.label14.TabIndex = 79;
            this.label14.Text = "Customer Balance:";
            // 
            // lblCustBalanceCart
            // 
            this.lblCustBalanceCart.AutoSize = true;
            this.lblCustBalanceCart.Location = new System.Drawing.Point(224, 144);
            this.lblCustBalanceCart.Name = "lblCustBalanceCart";
            this.lblCustBalanceCart.Size = new System.Drawing.Size(0, 24);
            this.lblCustBalanceCart.TabIndex = 81;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(73, 285);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(269, 33);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtStdID
            // 
            this.txtStdID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStdID.Location = new System.Drawing.Point(135, 222);
            this.txtStdID.Name = "txtStdID";
            this.txtStdID.Size = new System.Drawing.Size(216, 29);
            this.txtStdID.TabIndex = 6;
            this.txtStdID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStdID_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 24);
            this.label16.TabIndex = 83;
            this.label16.Text = "Student ID";
            // 
            // grbCartProduct
            // 
            this.grbCartProduct.Controls.Add(this.pic_UnitPrice_Valid);
            this.grbCartProduct.Controls.Add(this.pic_prdNameValidate_pnlProduct);
            this.grbCartProduct.Controls.Add(this.pic_prdIDValidate_pnlProduct);
            this.grbCartProduct.Controls.Add(this.lblPrd);
            this.grbCartProduct.Controls.Add(this.btnClearCart);
            this.grbCartProduct.Controls.Add(this.cmbPrdID);
            this.grbCartProduct.Controls.Add(this.txtPrdID);
            this.grbCartProduct.Controls.Add(this.btnAdd);
            this.grbCartProduct.Controls.Add(this.btnDeleteCart);
            this.grbCartProduct.Controls.Add(this.chk_Manual);
            this.grbCartProduct.Controls.Add(this.chkPrdSearch);
            this.grbCartProduct.Controls.Add(this.label1);
            this.grbCartProduct.Controls.Add(this.label15);
            this.grbCartProduct.Controls.Add(this.btnUpdateCart);
            this.grbCartProduct.Controls.Add(this.txtUnitPrice);
            this.grbCartProduct.Controls.Add(this.txtPrdQuantity);
            this.grbCartProduct.Location = new System.Drawing.Point(47, 113);
            this.grbCartProduct.Name = "grbCartProduct";
            this.grbCartProduct.Size = new System.Drawing.Size(566, 371);
            this.grbCartProduct.TabIndex = 95;
            this.grbCartProduct.TabStop = false;
            this.grbCartProduct.Text = "Add to Cart";
            // 
            // pic_UnitPrice_Valid
            // 
            this.pic_UnitPrice_Valid.Image = ((System.Drawing.Image)(resources.GetObject("pic_UnitPrice_Valid.Image")));
            this.pic_UnitPrice_Valid.Location = new System.Drawing.Point(326, 195);
            this.pic_UnitPrice_Valid.Name = "pic_UnitPrice_Valid";
            this.pic_UnitPrice_Valid.Size = new System.Drawing.Size(30, 24);
            this.pic_UnitPrice_Valid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_UnitPrice_Valid.TabIndex = 95;
            this.pic_UnitPrice_Valid.TabStop = false;
            // 
            // pic_prdNameValidate_pnlProduct
            // 
            this.pic_prdNameValidate_pnlProduct.Image = ((System.Drawing.Image)(resources.GetObject("pic_prdNameValidate_pnlProduct.Image")));
            this.pic_prdNameValidate_pnlProduct.Location = new System.Drawing.Point(326, 148);
            this.pic_prdNameValidate_pnlProduct.Name = "pic_prdNameValidate_pnlProduct";
            this.pic_prdNameValidate_pnlProduct.Size = new System.Drawing.Size(30, 24);
            this.pic_prdNameValidate_pnlProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_prdNameValidate_pnlProduct.TabIndex = 95;
            this.pic_prdNameValidate_pnlProduct.TabStop = false;
            // 
            // pic_prdIDValidate_pnlProduct
            // 
            this.pic_prdIDValidate_pnlProduct.Image = ((System.Drawing.Image)(resources.GetObject("pic_prdIDValidate_pnlProduct.Image")));
            this.pic_prdIDValidate_pnlProduct.Location = new System.Drawing.Point(326, 101);
            this.pic_prdIDValidate_pnlProduct.Name = "pic_prdIDValidate_pnlProduct";
            this.pic_prdIDValidate_pnlProduct.Size = new System.Drawing.Size(30, 24);
            this.pic_prdIDValidate_pnlProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_prdIDValidate_pnlProduct.TabIndex = 95;
            this.pic_prdIDValidate_pnlProduct.TabStop = false;
            // 
            // lblPrd
            // 
            this.lblPrd.AutoSize = true;
            this.lblPrd.Location = new System.Drawing.Point(19, 101);
            this.lblPrd.Name = "lblPrd";
            this.lblPrd.Size = new System.Drawing.Size(102, 24);
            this.lblPrd.TabIndex = 77;
            this.lblPrd.Text = "Product ID:";
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(73, 317);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(466, 34);
            this.btnClearCart.TabIndex = 5;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // cmbPrdID
            // 
            this.cmbPrdID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrdID.FormattingEnabled = true;
            this.cmbPrdID.Location = new System.Drawing.Point(165, 95);
            this.cmbPrdID.Name = "cmbPrdID";
            this.cmbPrdID.Size = new System.Drawing.Size(180, 32);
            this.cmbPrdID.TabIndex = 90;
            this.cmbPrdID.SelectedValueChanged += new System.EventHandler(this.cmbPrdID_SelectedValueChanged);
            // 
            // txtPrdID
            // 
            this.txtPrdID.Location = new System.Drawing.Point(131, 98);
            this.txtPrdID.Name = "txtPrdID";
            this.txtPrdID.Size = new System.Drawing.Size(193, 29);
            this.txtPrdID.TabIndex = 0;
            this.txtPrdID.TextChanged += new System.EventHandler(this.txtPrdID_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(367, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 80);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteCart
            // 
            this.btnDeleteCart.Location = new System.Drawing.Point(74, 277);
            this.btnDeleteCart.Name = "btnDeleteCart";
            this.btnDeleteCart.Size = new System.Drawing.Size(466, 34);
            this.btnDeleteCart.TabIndex = 4;
            this.btnDeleteCart.Text = "Delete";
            this.btnDeleteCart.UseVisualStyleBackColor = true;
            this.btnDeleteCart.Click += new System.EventHandler(this.btnDelete_ClickCart);
            // 
            // chk_Manual
            // 
            this.chk_Manual.AutoSize = true;
            this.chk_Manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Manual.Location = new System.Drawing.Point(385, 184);
            this.chk_Manual.Name = "chk_Manual";
            this.chk_Manual.Size = new System.Drawing.Size(108, 29);
            this.chk_Manual.TabIndex = 91;
            this.chk_Manual.Text = " Manual";
            this.chk_Manual.UseVisualStyleBackColor = true;
            this.chk_Manual.CheckedChanged += new System.EventHandler(this.chk_Manual_CheckedChanged);
            // 
            // chkPrdSearch
            // 
            this.chkPrdSearch.AutoSize = true;
            this.chkPrdSearch.Location = new System.Drawing.Point(27, 49);
            this.chkPrdSearch.Name = "chkPrdSearch";
            this.chkPrdSearch.Size = new System.Drawing.Size(120, 28);
            this.chkPrdSearch.TabIndex = 91;
            this.chkPrdSearch.Text = " Search By";
            this.chkPrdSearch.UseVisualStyleBackColor = true;
            this.chkPrdSearch.CheckedChanged += new System.EventHandler(this.chkPrdSearch_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 78;
            this.label1.Text = "Unit Price:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 24);
            this.label15.TabIndex = 78;
            this.label15.Text = "Quantity:";
            // 
            // btnUpdateCart
            // 
            this.btnUpdateCart.Location = new System.Drawing.Point(73, 234);
            this.btnUpdateCart.Name = "btnUpdateCart";
            this.btnUpdateCart.Size = new System.Drawing.Size(466, 34);
            this.btnUpdateCart.TabIndex = 3;
            this.btnUpdateCart.Text = "Update";
            this.btnUpdateCart.UseVisualStyleBackColor = true;
            this.btnUpdateCart.Click += new System.EventHandler(this.btnUpdateCart_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtUnitPrice.Location = new System.Drawing.Point(131, 191);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(193, 31);
            this.txtUnitPrice.TabIndex = 1;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // txtPrdQuantity
            // 
            this.txtPrdQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtPrdQuantity.Location = new System.Drawing.Point(131, 144);
            this.txtPrdQuantity.Name = "txtPrdQuantity";
            this.txtPrdQuantity.Size = new System.Drawing.Size(193, 31);
            this.txtPrdQuantity.TabIndex = 1;
            this.txtPrdQuantity.TextChanged += new System.EventHandler(this.txtPrdQuantity_TextChanged);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(57, 506);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(978, 201);
            this.dgvProduct.TabIndex = 89;
            this.dgvProduct.Click += new System.EventHandler(this.dgvProduct_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.CausesValidation = false;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(500, 40, 450, 0);
            this.label18.Size = new System.Drawing.Size(1145, 76);
            this.label18.TabIndex = 76;
            this.label18.Text = "Sell Products";
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 727);
            this.Controls.Add(this.pnlCart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCart";
            this.Text = "frmCart";
            this.Load += new System.EventHandler(this.frmCart_Load);
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            this.grbCartCustomer.ResumeLayout(false);
            this.grbCartCustomer.PerformLayout();
            this.grbCartProduct.ResumeLayout(false);
            this.grbCartProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UnitPrice_Valid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prdNameValidate_pnlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prdIDValidate_pnlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.GroupBox grbCartCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCustBalanceCart;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtStdID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grbCartProduct;
        private System.Windows.Forms.PictureBox pic_prdNameValidate_pnlProduct;
        private System.Windows.Forms.PictureBox pic_prdIDValidate_pnlProduct;
        private System.Windows.Forms.Label lblPrd;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.ComboBox cmbPrdID;
        private System.Windows.Forms.TextBox txtPrdID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteCart;
        private System.Windows.Forms.CheckBox chkPrdSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUpdateCart;
        private System.Windows.Forms.TextBox txtPrdQuantity;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pic_UnitPrice_Valid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.CheckBox chk_Manual;
    }
}