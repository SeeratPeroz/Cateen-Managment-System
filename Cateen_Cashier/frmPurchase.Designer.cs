namespace Cateen_Cashier
{
    partial class frmPurchase
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
            this.grbCartProduct = new System.Windows.Forms.GroupBox();
            this.pic_prdNameValidate_pnlProduct = new System.Windows.Forms.PictureBox();
            this.pic_prdRate_validation = new System.Windows.Forms.PictureBox();
            this.pic_prdIDValidate_pnlProduct = new System.Windows.Forms.PictureBox();
            this.lblPrd = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.cmbPrdID = new System.Windows.Forms.ComboBox();
            this.txtPrdID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteCart = new System.Windows.Forms.Button();
            this.chkPrdSearch = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btnUpdateCart = new System.Windows.Forms.Button();
            this.txtPrdQuantity = new System.Windows.Forms.TextBox();
            this.txtPrdRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add_Supplier = new System.Windows.Forms.Button();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.lblTotal_Cart = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.grbCartProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prdNameValidate_pnlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prdRate_validation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prdIDValidate_pnlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnlCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCartProduct
            // 
            this.grbCartProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCartProduct.Controls.Add(this.pic_prdNameValidate_pnlProduct);
            this.grbCartProduct.Controls.Add(this.pic_prdRate_validation);
            this.grbCartProduct.Controls.Add(this.pic_prdIDValidate_pnlProduct);
            this.grbCartProduct.Controls.Add(this.lblPrd);
            this.grbCartProduct.Controls.Add(this.btnClearCart);
            this.grbCartProduct.Controls.Add(this.cmbPrdID);
            this.grbCartProduct.Controls.Add(this.txtPrdID);
            this.grbCartProduct.Controls.Add(this.btnAdd);
            this.grbCartProduct.Controls.Add(this.btnDeleteCart);
            this.grbCartProduct.Controls.Add(this.chkPrdSearch);
            this.grbCartProduct.Controls.Add(this.label1);
            this.grbCartProduct.Controls.Add(this.label15);
            this.grbCartProduct.Controls.Add(this.btn_Clear);
            this.grbCartProduct.Controls.Add(this.btnUpdateCart);
            this.grbCartProduct.Controls.Add(this.txtPrdQuantity);
            this.grbCartProduct.Controls.Add(this.txtPrdRate);
            this.grbCartProduct.Location = new System.Drawing.Point(47, 98);
            this.grbCartProduct.Name = "grbCartProduct";
            this.grbCartProduct.Size = new System.Drawing.Size(972, 308);
            this.grbCartProduct.TabIndex = 95;
            this.grbCartProduct.TabStop = false;
            this.grbCartProduct.Text = "Add to Cart";
            // 
            // pic_prdNameValidate_pnlProduct
            // 
            this.pic_prdNameValidate_pnlProduct.Image = global::Cateen_Cashier.Properties.Resources.No;
            this.pic_prdNameValidate_pnlProduct.Location = new System.Drawing.Point(424, 197);
            this.pic_prdNameValidate_pnlProduct.Name = "pic_prdNameValidate_pnlProduct";
            this.pic_prdNameValidate_pnlProduct.Size = new System.Drawing.Size(30, 24);
            this.pic_prdNameValidate_pnlProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_prdNameValidate_pnlProduct.TabIndex = 95;
            this.pic_prdNameValidate_pnlProduct.TabStop = false;
            // 
            // pic_prdRate_validation
            // 
            this.pic_prdRate_validation.Image = global::Cateen_Cashier.Properties.Resources.No;
            this.pic_prdRate_validation.Location = new System.Drawing.Point(424, 143);
            this.pic_prdRate_validation.Name = "pic_prdRate_validation";
            this.pic_prdRate_validation.Size = new System.Drawing.Size(30, 24);
            this.pic_prdRate_validation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_prdRate_validation.TabIndex = 95;
            this.pic_prdRate_validation.TabStop = false;
            // 
            // pic_prdIDValidate_pnlProduct
            // 
            this.pic_prdIDValidate_pnlProduct.Image = global::Cateen_Cashier.Properties.Resources.No;
            this.pic_prdIDValidate_pnlProduct.Location = new System.Drawing.Point(424, 90);
            this.pic_prdIDValidate_pnlProduct.Name = "pic_prdIDValidate_pnlProduct";
            this.pic_prdIDValidate_pnlProduct.Size = new System.Drawing.Size(30, 24);
            this.pic_prdIDValidate_pnlProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_prdIDValidate_pnlProduct.TabIndex = 95;
            this.pic_prdIDValidate_pnlProduct.TabStop = false;
            // 
            // lblPrd
            // 
            this.lblPrd.AutoSize = true;
            this.lblPrd.Location = new System.Drawing.Point(18, 88);
            this.lblPrd.Name = "lblPrd";
            this.lblPrd.Size = new System.Drawing.Size(102, 24);
            this.lblPrd.TabIndex = 77;
            this.lblPrd.Text = "Product ID:";
            // 
            // btnClearCart
            // 
            this.btnClearCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearCart.Location = new System.Drawing.Point(560, 245);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(391, 34);
            this.btnClearCart.TabIndex = 13;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // cmbPrdID
            // 
            this.cmbPrdID.FormattingEnabled = true;
            this.cmbPrdID.Location = new System.Drawing.Point(164, 82);
            this.cmbPrdID.Name = "cmbPrdID";
            this.cmbPrdID.Size = new System.Drawing.Size(254, 32);
            this.cmbPrdID.TabIndex = 2;
            this.cmbPrdID.SelectedValueChanged += new System.EventHandler(this.cmbPrdID_SelectedValueChanged_1);
            // 
            // txtPrdID
            // 
            this.txtPrdID.Location = new System.Drawing.Point(130, 85);
            this.txtPrdID.Name = "txtPrdID";
            this.txtPrdID.Size = new System.Drawing.Size(288, 29);
            this.txtPrdID.TabIndex = 2;
            this.txtPrdID.TextChanged += new System.EventHandler(this.txtPrdID_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(427, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteCart
            // 
            this.btnDeleteCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCart.Location = new System.Drawing.Point(560, 139);
            this.btnDeleteCart.Name = "btnDeleteCart";
            this.btnDeleteCart.Size = new System.Drawing.Size(391, 34);
            this.btnDeleteCart.TabIndex = 12;
            this.btnDeleteCart.Text = "Delete";
            this.btnDeleteCart.UseVisualStyleBackColor = true;
            this.btnDeleteCart.Click += new System.EventHandler(this.btnDeleteCart_Click);
            // 
            // chkPrdSearch
            // 
            this.chkPrdSearch.AutoSize = true;
            this.chkPrdSearch.Location = new System.Drawing.Point(26, 36);
            this.chkPrdSearch.Name = "chkPrdSearch";
            this.chkPrdSearch.Size = new System.Drawing.Size(120, 28);
            this.chkPrdSearch.TabIndex = 1;
            this.chkPrdSearch.Text = " Search By";
            this.chkPrdSearch.UseVisualStyleBackColor = true;
            this.chkPrdSearch.CheckedChanged += new System.EventHandler(this.chkPrdSearch_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 78;
            this.label1.Text = "Quantity:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 24);
            this.label15.TabIndex = 78;
            this.label15.Text = "Rate:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.Location = new System.Drawing.Point(560, 195);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(391, 34);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btnUpdateCart
            // 
            this.btnUpdateCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCart.Location = new System.Drawing.Point(560, 90);
            this.btnUpdateCart.Name = "btnUpdateCart";
            this.btnUpdateCart.Size = new System.Drawing.Size(391, 34);
            this.btnUpdateCart.TabIndex = 11;
            this.btnUpdateCart.Text = "Update";
            this.btnUpdateCart.UseVisualStyleBackColor = true;
            this.btnUpdateCart.Click += new System.EventHandler(this.btnUpdateCart_Click);
            // 
            // txtPrdQuantity
            // 
            this.txtPrdQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtPrdQuantity.Location = new System.Drawing.Point(130, 191);
            this.txtPrdQuantity.Name = "txtPrdQuantity";
            this.txtPrdQuantity.Size = new System.Drawing.Size(288, 31);
            this.txtPrdQuantity.TabIndex = 4;
            this.txtPrdQuantity.TextChanged += new System.EventHandler(this.txtPrdQuantity_TextChanged);
            // 
            // txtPrdRate
            // 
            this.txtPrdRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtPrdRate.Location = new System.Drawing.Point(130, 137);
            this.txtPrdRate.Name = "txtPrdRate";
            this.txtPrdRate.Size = new System.Drawing.Size(288, 31);
            this.txtPrdRate.TabIndex = 3;
            this.txtPrdRate.TextChanged += new System.EventHandler(this.txtPrdRate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(841, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 96;
            this.label3.Text = "Total:";
            // 
            // btn_Add_Supplier
            // 
            this.btn_Add_Supplier.Location = new System.Drawing.Point(531, 428);
            this.btn_Add_Supplier.Name = "btn_Add_Supplier";
            this.btn_Add_Supplier.Size = new System.Drawing.Size(56, 32);
            this.btn_Add_Supplier.TabIndex = 96;
            this.btn_Add_Supplier.Text = "+";
            this.btn_Add_Supplier.UseVisualStyleBackColor = true;
            this.btn_Add_Supplier.Click += new System.EventHandler(this.btn_Add_Supplier_Click);
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(237, 428);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(288, 32);
            this.cmb_Supplier.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 78;
            this.label2.Text = "Supplier:";
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
            this.dgvProduct.Location = new System.Drawing.Point(57, 497);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(962, 179);
            this.dgvProduct.TabIndex = 89;
            this.dgvProduct.Click += new System.EventHandler(this.dgvProduct_Click_1);
            // 
            // pnlCart
            // 
            this.pnlCart.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCart.Controls.Add(this.lblTotal_Cart);
            this.pnlCart.Controls.Add(this.label3);
            this.pnlCart.Controls.Add(this.btn_Submit);
            this.pnlCart.Controls.Add(this.btn_Add_Supplier);
            this.pnlCart.Controls.Add(this.grbCartProduct);
            this.pnlCart.Controls.Add(this.dgvProduct);
            this.pnlCart.Controls.Add(this.label2);
            this.pnlCart.Controls.Add(this.cmb_Supplier);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCart.Location = new System.Drawing.Point(0, 0);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(1063, 688);
            this.pnlCart.TabIndex = 94;
            // 
            // lblTotal_Cart
            // 
            this.lblTotal_Cart.AutoSize = true;
            this.lblTotal_Cart.Location = new System.Drawing.Point(903, 432);
            this.lblTotal_Cart.Name = "lblTotal_Cart";
            this.lblTotal_Cart.Size = new System.Drawing.Size(0, 24);
            this.lblTotal_Cart.TabIndex = 96;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(642, 427);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(182, 34);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 688);
            this.Controls.Add(this.pnlCart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPurchase";
            this.Text = "frmPurchase";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.grbCartProduct.ResumeLayout(false);
            this.grbCartProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prdNameValidate_pnlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prdRate_validation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prdIDValidate_pnlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtPrdRate;
        private System.Windows.Forms.Button btnUpdateCart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkPrdSearch;
        private System.Windows.Forms.Button btnDeleteCart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPrdID;
        private System.Windows.Forms.ComboBox cmbPrdID;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Label lblPrd;
        private System.Windows.Forms.PictureBox pic_prdIDValidate_pnlProduct;
        private System.Windows.Forms.PictureBox pic_prdRate_validation;
        private System.Windows.Forms.GroupBox grbCartProduct;
        private System.Windows.Forms.PictureBox pic_prdNameValidate_pnlProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrdQuantity;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add_Supplier;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal_Cart;
    }
}