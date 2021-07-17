namespace Cateen_Cashier
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerPanelSearch = new System.Windows.Forms.TextBox();
            this.grbCustomerControls = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_Clear_pnlCustomer = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.grpCustomerAccount = new System.Windows.Forms.GroupBox();
            this.btn_Add_custoper_Type = new System.Windows.Forms.Button();
            this.cmb_Cust_TYpe = new System.Windows.Forms.ComboBox();
            this.pic_customerPhoneValidate_pnlCustomer = new System.Windows.Forms.PictureBox();
            this.pic_customerEmailValidate_pnlCustomer = new System.Windows.Forms.PictureBox();
            this.pic_customerNameValidate_pnlCustomer = new System.Windows.Forms.PictureBox();
            this.pic_customerIDValidate_pnlCustomer = new System.Windows.Forms.PictureBox();
            this.pic_customerCardValidate_pnlCustomer = new System.Windows.Forms.PictureBox();
            this.lblImage_pnlCustomerAccount = new System.Windows.Forms.Label();
            this.pic_user_pnlCustomerAcc = new System.Windows.Forms.PictureBox();
            this.txtImage_Path = new System.Windows.Forms.TextBox();
            this.btnSave_Pic = new System.Windows.Forms.Button();
            this.lblPIC__pnlCUST = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.pnlCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbCustomerControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.grpCustomerAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerPhoneValidate_pnlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerEmailValidate_pnlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerNameValidate_pnlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerIDValidate_pnlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerCardValidate_pnlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user_pnlCustomerAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCustomer.Controls.Add(this.groupBox1);
            this.pnlCustomer.Controls.Add(this.grbCustomerControls);
            this.pnlCustomer.Controls.Add(this.dgvCustomer);
            this.pnlCustomer.Controls.Add(this.grpCustomerAccount);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(1095, 766);
            this.pnlCustomer.TabIndex = 92;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCustomerPanelSearch);
            this.groupBox1.Location = new System.Drawing.Point(208, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 73);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Customer";
            // 
            // txtCustomerPanelSearch
            // 
            this.txtCustomerPanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerPanelSearch.Location = new System.Drawing.Point(222, 28);
            this.txtCustomerPanelSearch.Name = "txtCustomerPanelSearch";
            this.txtCustomerPanelSearch.Size = new System.Drawing.Size(282, 29);
            this.txtCustomerPanelSearch.TabIndex = 25;
            this.txtCustomerPanelSearch.TextChanged += new System.EventHandler(this.txtCustomerPanelSearch_TextChanged);
            // 
            // grbCustomerControls
            // 
            this.grbCustomerControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCustomerControls.Controls.Add(this.btnSave);
            this.grbCustomerControls.Controls.Add(this.btn_Clear_pnlCustomer);
            this.grbCustomerControls.Controls.Add(this.btnShow);
            this.grbCustomerControls.Controls.Add(this.btnUpdate);
            this.grbCustomerControls.Controls.Add(this.btnDelete);
            this.grbCustomerControls.Location = new System.Drawing.Point(686, 103);
            this.grbCustomerControls.Name = "grbCustomerControls";
            this.grbCustomerControls.Size = new System.Drawing.Size(376, 310);
            this.grbCustomerControls.TabIndex = 41;
            this.grbCustomerControls.TabStop = false;
            this.grbCustomerControls.Text = "Controls";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(34, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(316, 32);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_Clear_pnlCustomer
            // 
            this.btn_Clear_pnlCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear_pnlCustomer.Location = new System.Drawing.Point(34, 258);
            this.btn_Clear_pnlCustomer.Name = "btn_Clear_pnlCustomer";
            this.btn_Clear_pnlCustomer.Size = new System.Drawing.Size(316, 32);
            this.btn_Clear_pnlCustomer.TabIndex = 33;
            this.btn_Clear_pnlCustomer.Text = "Clear ";
            this.btn_Clear_pnlCustomer.UseVisualStyleBackColor = true;
            this.btn_Clear_pnlCustomer.Click += new System.EventHandler(this.btn_Clear_pnlCustomer_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Location = new System.Drawing.Point(34, 214);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(316, 32);
            this.btnShow.TabIndex = 33;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(34, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(316, 32);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(34, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(316, 32);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.dgvCustomer.Location = new System.Drawing.Point(25, 559);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(1039, 202);
            this.dgvCustomer.TabIndex = 40;
            this.dgvCustomer.Click += new System.EventHandler(this.dgvCustomer_Click);
            // 
            // grpCustomerAccount
            // 
            this.grpCustomerAccount.Controls.Add(this.btn_Add_custoper_Type);
            this.grpCustomerAccount.Controls.Add(this.cmb_Cust_TYpe);
            this.grpCustomerAccount.Controls.Add(this.pic_customerPhoneValidate_pnlCustomer);
            this.grpCustomerAccount.Controls.Add(this.pic_customerEmailValidate_pnlCustomer);
            this.grpCustomerAccount.Controls.Add(this.pic_customerNameValidate_pnlCustomer);
            this.grpCustomerAccount.Controls.Add(this.pic_customerIDValidate_pnlCustomer);
            this.grpCustomerAccount.Controls.Add(this.pic_customerCardValidate_pnlCustomer);
            this.grpCustomerAccount.Controls.Add(this.lblImage_pnlCustomerAccount);
            this.grpCustomerAccount.Controls.Add(this.pic_user_pnlCustomerAcc);
            this.grpCustomerAccount.Controls.Add(this.txtImage_Path);
            this.grpCustomerAccount.Controls.Add(this.btnSave_Pic);
            this.grpCustomerAccount.Controls.Add(this.lblPIC__pnlCUST);
            this.grpCustomerAccount.Controls.Add(this.label11);
            this.grpCustomerAccount.Controls.Add(this.txtCustPhone);
            this.grpCustomerAccount.Controls.Add(this.txtCustCard);
            this.grpCustomerAccount.Controls.Add(this.label1);
            this.grpCustomerAccount.Controls.Add(this.label4);
            this.grpCustomerAccount.Controls.Add(this.label9);
            this.grpCustomerAccount.Controls.Add(this.txtCustEmail);
            this.grpCustomerAccount.Controls.Add(this.txtCustName);
            this.grpCustomerAccount.Controls.Add(this.label3);
            this.grpCustomerAccount.Controls.Add(this.label5);
            this.grpCustomerAccount.Controls.Add(this.txtCustID);
            this.grpCustomerAccount.Location = new System.Drawing.Point(23, 103);
            this.grpCustomerAccount.Name = "grpCustomerAccount";
            this.grpCustomerAccount.Size = new System.Drawing.Size(644, 357);
            this.grpCustomerAccount.TabIndex = 39;
            this.grpCustomerAccount.TabStop = false;
            this.grpCustomerAccount.Text = "Create Account";
            // 
            // btn_Add_custoper_Type
            // 
            this.btn_Add_custoper_Type.Location = new System.Drawing.Point(459, 222);
            this.btn_Add_custoper_Type.Name = "btn_Add_custoper_Type";
            this.btn_Add_custoper_Type.Size = new System.Drawing.Size(46, 32);
            this.btn_Add_custoper_Type.TabIndex = 97;
            this.btn_Add_custoper_Type.Text = "+";
            this.btn_Add_custoper_Type.UseVisualStyleBackColor = true;
            this.btn_Add_custoper_Type.Click += new System.EventHandler(this.btn_Add_Supplier_Click);
            // 
            // cmb_Cust_TYpe
            // 
            this.cmb_Cust_TYpe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cust_TYpe.FormattingEnabled = true;
            this.cmb_Cust_TYpe.Location = new System.Drawing.Point(220, 224);
            this.cmb_Cust_TYpe.Name = "cmb_Cust_TYpe";
            this.cmb_Cust_TYpe.Size = new System.Drawing.Size(233, 32);
            this.cmb_Cust_TYpe.TabIndex = 41;
            // 
            // pic_customerPhoneValidate_pnlCustomer
            // 
            this.pic_customerPhoneValidate_pnlCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pic_customerPhoneValidate_pnlCustomer.Image")));
            this.pic_customerPhoneValidate_pnlCustomer.Location = new System.Drawing.Point(472, 192);
            this.pic_customerPhoneValidate_pnlCustomer.Name = "pic_customerPhoneValidate_pnlCustomer";
            this.pic_customerPhoneValidate_pnlCustomer.Size = new System.Drawing.Size(32, 24);
            this.pic_customerPhoneValidate_pnlCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_customerPhoneValidate_pnlCustomer.TabIndex = 40;
            this.pic_customerPhoneValidate_pnlCustomer.TabStop = false;
            // 
            // pic_customerEmailValidate_pnlCustomer
            // 
            this.pic_customerEmailValidate_pnlCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pic_customerEmailValidate_pnlCustomer.Image")));
            this.pic_customerEmailValidate_pnlCustomer.Location = new System.Drawing.Point(472, 156);
            this.pic_customerEmailValidate_pnlCustomer.Name = "pic_customerEmailValidate_pnlCustomer";
            this.pic_customerEmailValidate_pnlCustomer.Size = new System.Drawing.Size(32, 24);
            this.pic_customerEmailValidate_pnlCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_customerEmailValidate_pnlCustomer.TabIndex = 40;
            this.pic_customerEmailValidate_pnlCustomer.TabStop = false;
            // 
            // pic_customerNameValidate_pnlCustomer
            // 
            this.pic_customerNameValidate_pnlCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pic_customerNameValidate_pnlCustomer.Image")));
            this.pic_customerNameValidate_pnlCustomer.Location = new System.Drawing.Point(473, 121);
            this.pic_customerNameValidate_pnlCustomer.Name = "pic_customerNameValidate_pnlCustomer";
            this.pic_customerNameValidate_pnlCustomer.Size = new System.Drawing.Size(32, 24);
            this.pic_customerNameValidate_pnlCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_customerNameValidate_pnlCustomer.TabIndex = 40;
            this.pic_customerNameValidate_pnlCustomer.TabStop = false;
            // 
            // pic_customerIDValidate_pnlCustomer
            // 
            this.pic_customerIDValidate_pnlCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pic_customerIDValidate_pnlCustomer.Image")));
            this.pic_customerIDValidate_pnlCustomer.Location = new System.Drawing.Point(472, 86);
            this.pic_customerIDValidate_pnlCustomer.Name = "pic_customerIDValidate_pnlCustomer";
            this.pic_customerIDValidate_pnlCustomer.Size = new System.Drawing.Size(32, 24);
            this.pic_customerIDValidate_pnlCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_customerIDValidate_pnlCustomer.TabIndex = 40;
            this.pic_customerIDValidate_pnlCustomer.TabStop = false;
            // 
            // pic_customerCardValidate_pnlCustomer
            // 
            this.pic_customerCardValidate_pnlCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pic_customerCardValidate_pnlCustomer.Image")));
            this.pic_customerCardValidate_pnlCustomer.Location = new System.Drawing.Point(473, 51);
            this.pic_customerCardValidate_pnlCustomer.Name = "pic_customerCardValidate_pnlCustomer";
            this.pic_customerCardValidate_pnlCustomer.Size = new System.Drawing.Size(32, 24);
            this.pic_customerCardValidate_pnlCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_customerCardValidate_pnlCustomer.TabIndex = 40;
            this.pic_customerCardValidate_pnlCustomer.TabStop = false;
            // 
            // lblImage_pnlCustomerAccount
            // 
            this.lblImage_pnlCustomerAccount.AutoSize = true;
            this.lblImage_pnlCustomerAccount.Location = new System.Drawing.Point(527, 66);
            this.lblImage_pnlCustomerAccount.Name = "lblImage_pnlCustomerAccount";
            this.lblImage_pnlCustomerAccount.Size = new System.Drawing.Size(106, 24);
            this.lblImage_pnlCustomerAccount.TabIndex = 39;
            this.lblImage_pnlCustomerAccount.Text = "User Image";
            // 
            // pic_user_pnlCustomerAcc
            // 
            this.pic_user_pnlCustomerAcc.ErrorImage = null;
            this.pic_user_pnlCustomerAcc.Image = ((System.Drawing.Image)(resources.GetObject("pic_user_pnlCustomerAcc.Image")));
            this.pic_user_pnlCustomerAcc.InitialImage = null;
            this.pic_user_pnlCustomerAcc.Location = new System.Drawing.Point(511, 100);
            this.pic_user_pnlCustomerAcc.Name = "pic_user_pnlCustomerAcc";
            this.pic_user_pnlCustomerAcc.Size = new System.Drawing.Size(122, 97);
            this.pic_user_pnlCustomerAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_user_pnlCustomerAcc.TabIndex = 38;
            this.pic_user_pnlCustomerAcc.TabStop = false;
            // 
            // txtImage_Path
            // 
            this.txtImage_Path.Enabled = false;
            this.txtImage_Path.Location = new System.Drawing.Point(524, 203);
            this.txtImage_Path.Name = "txtImage_Path";
            this.txtImage_Path.Size = new System.Drawing.Size(109, 29);
            this.txtImage_Path.TabIndex = 37;
            // 
            // btnSave_Pic
            // 
            this.btnSave_Pic.Location = new System.Drawing.Point(213, 264);
            this.btnSave_Pic.Name = "btnSave_Pic";
            this.btnSave_Pic.Size = new System.Drawing.Size(257, 32);
            this.btnSave_Pic.TabIndex = 36;
            this.btnSave_Pic.Text = "Browse";
            this.btnSave_Pic.UseVisualStyleBackColor = true;
            this.btnSave_Pic.Click += new System.EventHandler(this.btnSave_Pic_Click);
            // 
            // lblPIC__pnlCUST
            // 
            this.lblPIC__pnlCUST.AutoSize = true;
            this.lblPIC__pnlCUST.Location = new System.Drawing.Point(45, 266);
            this.lblPIC__pnlCUST.Name = "lblPIC__pnlCUST";
            this.lblPIC__pnlCUST.Size = new System.Drawing.Size(73, 24);
            this.lblPIC__pnlCUST.TabIndex = 26;
            this.lblPIC__pnlCUST.Text = "Picture:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Customer Card";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(220, 190);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(250, 29);
            this.txtCustPhone.TabIndex = 25;
            this.txtCustPhone.TextChanged += new System.EventHandler(this.txtCustPhone_TextChanged);
            // 
            // txtCustCard
            // 
            this.txtCustCard.Location = new System.Drawing.Point(220, 48);
            this.txtCustCard.Name = "txtCustCard";
            this.txtCustCard.Size = new System.Drawing.Size(250, 29);
            this.txtCustCard.TabIndex = 21;
            this.txtCustCard.TextChanged += new System.EventHandler(this.txtCustCard_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Customer Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Customer Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Customer Name";
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(220, 154);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(250, 29);
            this.txtCustEmail.TabIndex = 24;
            this.txtCustEmail.TextChanged += new System.EventHandler(this.txtCustEmail_TextChanged);
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(220, 119);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(250, 29);
            this.txtCustName.TabIndex = 23;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Customer Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Customer ID";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(220, 83);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(250, 29);
            this.txtCustID.TabIndex = 22;
            this.txtCustID.TextChanged += new System.EventHandler(this.txtCustID_TextChanged);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 766);
            this.Controls.Add(this.pnlCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.pnlCustomer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCustomerControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.grpCustomerAccount.ResumeLayout(false);
            this.grpCustomerAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerPhoneValidate_pnlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerEmailValidate_pnlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerNameValidate_pnlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerIDValidate_pnlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_customerCardValidate_pnlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user_pnlCustomerAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerPanelSearch;
        private System.Windows.Forms.GroupBox grbCustomerControls;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.GroupBox grpCustomerAccount;
        private System.Windows.Forms.PictureBox pic_customerPhoneValidate_pnlCustomer;
        private System.Windows.Forms.PictureBox pic_customerEmailValidate_pnlCustomer;
        private System.Windows.Forms.PictureBox pic_customerNameValidate_pnlCustomer;
        private System.Windows.Forms.PictureBox pic_customerIDValidate_pnlCustomer;
        private System.Windows.Forms.PictureBox pic_customerCardValidate_pnlCustomer;
        private System.Windows.Forms.Label lblImage_pnlCustomerAccount;
        private System.Windows.Forms.PictureBox pic_user_pnlCustomerAcc;
        private System.Windows.Forms.TextBox txtImage_Path;
        private System.Windows.Forms.Button btnSave_Pic;
        private System.Windows.Forms.Label lblPIC__pnlCUST;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Button btn_Clear_pnlCustomer;
        private System.Windows.Forms.ComboBox cmb_Cust_TYpe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add_custoper_Type;
    }
}