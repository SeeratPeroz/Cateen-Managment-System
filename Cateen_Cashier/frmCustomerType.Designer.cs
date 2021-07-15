namespace Cateen_Cashier
{
    partial class frmCustomerType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerType));
            this.grpCustomerAccount = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pic_customerNameValidate_pnlCustomer = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.grpCustomerAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerNameValidate_pnlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.pnlCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerAccount
            // 
            this.grpCustomerAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerAccount.Controls.Add(this.btnSave);
            this.grpCustomerAccount.Controls.Add(this.btn_Clean);
            this.grpCustomerAccount.Controls.Add(this.btnUpdate);
            this.grpCustomerAccount.Controls.Add(this.btnDelete);
            this.grpCustomerAccount.Controls.Add(this.pic_customerNameValidate_pnlCustomer);
            this.grpCustomerAccount.Controls.Add(this.label9);
            this.grpCustomerAccount.Controls.Add(this.txtCustName);
            this.grpCustomerAccount.Location = new System.Drawing.Point(25, 33);
            this.grpCustomerAccount.Name = "grpCustomerAccount";
            this.grpCustomerAccount.Size = new System.Drawing.Size(575, 332);
            this.grpCustomerAccount.TabIndex = 39;
            this.grpCustomerAccount.TabStop = false;
            this.grpCustomerAccount.Text = "Add Supplier";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(52, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(499, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_Clean
            // 
            this.btn_Clean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clean.Location = new System.Drawing.Point(52, 265);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(499, 32);
            this.btn_Clean.TabIndex = 7;
            this.btn_Clean.Text = "Clear";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(52, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(499, 32);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(52, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(499, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pic_customerNameValidate_pnlCustomer
            // 
            this.pic_customerNameValidate_pnlCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pic_customerNameValidate_pnlCustomer.Image")));
            this.pic_customerNameValidate_pnlCustomer.Location = new System.Drawing.Point(509, 74);
            this.pic_customerNameValidate_pnlCustomer.Name = "pic_customerNameValidate_pnlCustomer";
            this.pic_customerNameValidate_pnlCustomer.Size = new System.Drawing.Size(32, 24);
            this.pic_customerNameValidate_pnlCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_customerNameValidate_pnlCustomer.TabIndex = 40;
            this.pic_customerNameValidate_pnlCustomer.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Supplier Name";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(256, 74);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(250, 26);
            this.txtCustName.TabIndex = 1;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
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
            this.dgvCustomer.Size = new System.Drawing.Size(575, 134);
            this.dgvCustomer.TabIndex = 40;
            this.dgvCustomer.Click += new System.EventHandler(this.dgvCustomer_Click);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCustomer.Controls.Add(this.dgvCustomer);
            this.pnlCustomer.Controls.Add(this.grpCustomerAccount);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(634, 527);
            this.pnlCustomer.TabIndex = 94;
            // 
            // frmCustomerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 527);
            this.Controls.Add(this.pnlCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCustomerType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Type";
            this.grpCustomerAccount.ResumeLayout(false);
            this.grpCustomerAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerNameValidate_pnlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.pnlCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerAccount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pic_customerNameValidate_pnlCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Panel pnlCustomer;
    }
}