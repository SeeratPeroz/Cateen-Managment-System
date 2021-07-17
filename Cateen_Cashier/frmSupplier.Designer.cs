namespace Cateen_Cashier
{
    partial class frmSupplier
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
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.grpCustomerAccount = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pic_address = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pic_customerPhoneValidate_pnlCustomer = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pic_customerEmailValidate_pnlCustomer = new System.Windows.Forms.PictureBox();
            this.pic_customerNameValidate_pnlCustomer = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.supID = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.grpCustomerAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerPhoneValidate_pnlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerEmailValidate_pnlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerNameValidate_pnlCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCustomer.Controls.Add(this.dgvCustomer);
            this.pnlCustomer.Controls.Add(this.grpCustomerAccount);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(703, 587);
            this.pnlCustomer.TabIndex = 93;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(25, 381);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(644, 194);
            this.dgvCustomer.TabIndex = 40;
            this.dgvCustomer.Click += new System.EventHandler(this.dgvCustomer_Click);
            // 
            // grpCustomerAccount
            // 
            this.grpCustomerAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerAccount.Controls.Add(this.btnSave);
            this.grpCustomerAccount.Controls.Add(this.pic_address);
            this.grpCustomerAccount.Controls.Add(this.btn_Clean);
            this.grpCustomerAccount.Controls.Add(this.btnUpdate);
            this.grpCustomerAccount.Controls.Add(this.pic_customerPhoneValidate_pnlCustomer);
            this.grpCustomerAccount.Controls.Add(this.btnDelete);
            this.grpCustomerAccount.Controls.Add(this.pic_customerEmailValidate_pnlCustomer);
            this.grpCustomerAccount.Controls.Add(this.pic_customerNameValidate_pnlCustomer);
            this.grpCustomerAccount.Controls.Add(this.txtAddress);
            this.grpCustomerAccount.Controls.Add(this.txtCustPhone);
            this.grpCustomerAccount.Controls.Add(this.label1);
            this.grpCustomerAccount.Controls.Add(this.label4);
            this.grpCustomerAccount.Controls.Add(this.label2);
            this.grpCustomerAccount.Controls.Add(this.label9);
            this.grpCustomerAccount.Controls.Add(this.txtCustEmail);
            this.grpCustomerAccount.Controls.Add(this.supID);
            this.grpCustomerAccount.Controls.Add(this.txtCustName);
            this.grpCustomerAccount.Controls.Add(this.label3);
            this.grpCustomerAccount.Location = new System.Drawing.Point(25, 33);
            this.grpCustomerAccount.Name = "grpCustomerAccount";
            this.grpCustomerAccount.Size = new System.Drawing.Size(644, 332);
            this.grpCustomerAccount.TabIndex = 39;
            this.grpCustomerAccount.TabStop = false;
            this.grpCustomerAccount.Text = "Add Supplier";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(93, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(457, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pic_address
            // 
            this.pic_address.Image = global::Cateen_Cashier.Properties.Resources.No;
            this.pic_address.Location = new System.Drawing.Point(518, 106);
            this.pic_address.Name = "pic_address";
            this.pic_address.Size = new System.Drawing.Size(32, 24);
            this.pic_address.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_address.TabIndex = 40;
            this.pic_address.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(93, 246);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(457, 32);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pic_customerPhoneValidate_pnlCustomer
            // 
            this.pic_customerPhoneValidate_pnlCustomer.Image = global::Cateen_Cashier.Properties.Resources.No;
            this.pic_customerPhoneValidate_pnlCustomer.Location = new System.Drawing.Point(518, 77);
            this.pic_customerPhoneValidate_pnlCustomer.Name = "pic_customerPhoneValidate_pnlCustomer";
            this.pic_customerPhoneValidate_pnlCustomer.Size = new System.Drawing.Size(32, 24);
            this.pic_customerPhoneValidate_pnlCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_customerPhoneValidate_pnlCustomer.TabIndex = 40;
            this.pic_customerPhoneValidate_pnlCustomer.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(93, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(457, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pic_customerEmailValidate_pnlCustomer
            // 
            this.pic_customerEmailValidate_pnlCustomer.Image = global::Cateen_Cashier.Properties.Resources.Yes;
            this.pic_customerEmailValidate_pnlCustomer.Location = new System.Drawing.Point(519, 132);
            this.pic_customerEmailValidate_pnlCustomer.Name = "pic_customerEmailValidate_pnlCustomer";
            this.pic_customerEmailValidate_pnlCustomer.Size = new System.Drawing.Size(32, 24);
            this.pic_customerEmailValidate_pnlCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_customerEmailValidate_pnlCustomer.TabIndex = 40;
            this.pic_customerEmailValidate_pnlCustomer.TabStop = false;
            // 
            // pic_customerNameValidate_pnlCustomer
            // 
            this.pic_customerNameValidate_pnlCustomer.Image = global::Cateen_Cashier.Properties.Resources.No;
            this.pic_customerNameValidate_pnlCustomer.Location = new System.Drawing.Point(519, 50);
            this.pic_customerNameValidate_pnlCustomer.Name = "pic_customerNameValidate_pnlCustomer";
            this.pic_customerNameValidate_pnlCustomer.Size = new System.Drawing.Size(32, 24);
            this.pic_customerNameValidate_pnlCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_customerNameValidate_pnlCustomer.TabIndex = 40;
            this.pic_customerNameValidate_pnlCustomer.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(266, 106);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 22);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(266, 78);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(250, 22);
            this.txtCustPhone.TabIndex = 2;
            this.txtCustPhone.TextChanged += new System.EventHandler(this.txtCustPhone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Supplier Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Supplier Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Supplier ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Supplier Name";
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(266, 134);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(250, 22);
            this.txtCustEmail.TabIndex = 4;
            this.txtCustEmail.TextChanged += new System.EventHandler(this.txtCustEmail_TextChanged);
            // 
            // supID
            // 
            this.supID.Enabled = false;
            this.supID.Location = new System.Drawing.Point(266, 22);
            this.supID.Name = "supID";
            this.supID.Size = new System.Drawing.Size(250, 22);
            this.supID.TabIndex = 0;
            this.supID.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(266, 50);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(250, 22);
            this.txtCustName.TabIndex = 1;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Supplier Email";
            // 
            // btn_Clean
            // 
            this.btn_Clean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clean.Location = new System.Drawing.Point(93, 281);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(457, 32);
            this.btn_Clean.TabIndex = 7;
            this.btn_Clean.Text = "Clear";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clear);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 587);
            this.Controls.Add(this.pnlCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.pnlCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.grpCustomerAccount.ResumeLayout(false);
            this.grpCustomerAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerPhoneValidate_pnlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerEmailValidate_pnlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerNameValidate_pnlCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.GroupBox grpCustomerAccount;
        private System.Windows.Forms.PictureBox pic_customerPhoneValidate_pnlCustomer;
        private System.Windows.Forms.PictureBox pic_customerEmailValidate_pnlCustomer;
        private System.Windows.Forms.PictureBox pic_customerNameValidate_pnlCustomer;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_address;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supID;
        private System.Windows.Forms.Button btn_Clean;
    }
}