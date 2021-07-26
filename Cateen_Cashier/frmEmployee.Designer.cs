namespace Cateen_Cashier
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.pic_ValidateName = new System.Windows.Forms.PictureBox();
            this.pic_ValidateLastName = new System.Windows.Forms.PictureBox();
            this.pic_ValidateEmail = new System.Windows.Forms.PictureBox();
            this.pic_ValidatePhone = new System.Windows.Forms.PictureBox();
            this.pic_ValidateAddress = new System.Windows.Forms.PictureBox();
            this.lblLoginStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.pic_userImage = new CustomControls.RJControls.RJCircularPictureBox();
            this.btn_ClearName = new CustomControls.RJControls.RJButton();
            this.btn_ClearLastName = new CustomControls.RJControls.RJButton();
            this.btn_ClearEmail = new CustomControls.RJControls.RJButton();
            this.btn_ClearPhone = new CustomControls.RJControls.RJButton();
            this.btn_ClearAddress = new CustomControls.RJControls.RJButton();
            this.chkLoginStatus = new CustomControls.RJControls.RJToggleButton();
            this.btn_Clear = new CustomControls.RJControls.RJButton();
            this.btn_Update = new CustomControls.RJControls.RJButton();
            this.btn_Browse = new CustomControls.RJControls.RJButton();
            this.txtUserAddress = new CustomControls.RJControls.RJTextBox();
            this.txtUserPhone = new CustomControls.RJControls.RJTextBox();
            this.txtUserEmail = new CustomControls.RJControls.RJTextBox();
            this.txtUserLastName = new CustomControls.RJControls.RJTextBox();
            this.txtUserName = new CustomControls.RJControls.RJTextBox();
            this.txtUserID = new CustomControls.RJControls.RJTextBox();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            this.pnlCustomer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ValidateName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ValidateLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ValidateEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ValidatePhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ValidateAddress)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCustomer.Controls.Add(this.pic_userImage);
            this.pnlCustomer.Controls.Add(this.groupBox2);
            this.pnlCustomer.Controls.Add(this.groupBox1);
            this.pnlCustomer.Controls.Add(this.dgvEmployee);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(1079, 745);
            this.pnlCustomer.TabIndex = 93;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbUserRole);
            this.groupBox2.Controls.Add(this.btn_ClearName);
            this.groupBox2.Controls.Add(this.btn_ClearLastName);
            this.groupBox2.Controls.Add(this.btn_ClearEmail);
            this.groupBox2.Controls.Add(this.btn_ClearPhone);
            this.groupBox2.Controls.Add(this.btn_ClearAddress);
            this.groupBox2.Controls.Add(this.pic_ValidateName);
            this.groupBox2.Controls.Add(this.pic_ValidateLastName);
            this.groupBox2.Controls.Add(this.pic_ValidateEmail);
            this.groupBox2.Controls.Add(this.pic_ValidatePhone);
            this.groupBox2.Controls.Add(this.pic_ValidateAddress);
            this.groupBox2.Controls.Add(this.chkLoginStatus);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.lblLoginStatus);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_Browse);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUserAddress);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUserPhone);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtUserEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtUserLastName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtUserID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(38, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 500);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(133, 270);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(250, 32);
            this.cmbUserRole.TabIndex = 43;
            this.cmbUserRole.Click += new System.EventHandler(this.cmbUserRole_Click_1);
            // 
            // pic_ValidateName
            // 
            this.pic_ValidateName.Image = ((System.Drawing.Image)(resources.GetObject("pic_ValidateName.Image")));
            this.pic_ValidateName.Location = new System.Drawing.Point(390, 64);
            this.pic_ValidateName.Name = "pic_ValidateName";
            this.pic_ValidateName.Size = new System.Drawing.Size(32, 24);
            this.pic_ValidateName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ValidateName.TabIndex = 41;
            this.pic_ValidateName.TabStop = false;
            // 
            // pic_ValidateLastName
            // 
            this.pic_ValidateLastName.Image = ((System.Drawing.Image)(resources.GetObject("pic_ValidateLastName.Image")));
            this.pic_ValidateLastName.Location = new System.Drawing.Point(390, 103);
            this.pic_ValidateLastName.Name = "pic_ValidateLastName";
            this.pic_ValidateLastName.Size = new System.Drawing.Size(32, 24);
            this.pic_ValidateLastName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ValidateLastName.TabIndex = 41;
            this.pic_ValidateLastName.TabStop = false;
            // 
            // pic_ValidateEmail
            // 
            this.pic_ValidateEmail.Image = global::Cateen_Cashier.Properties.Resources.Yes;
            this.pic_ValidateEmail.Location = new System.Drawing.Point(390, 142);
            this.pic_ValidateEmail.Name = "pic_ValidateEmail";
            this.pic_ValidateEmail.Size = new System.Drawing.Size(32, 24);
            this.pic_ValidateEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ValidateEmail.TabIndex = 41;
            this.pic_ValidateEmail.TabStop = false;
            // 
            // pic_ValidatePhone
            // 
            this.pic_ValidatePhone.Image = ((System.Drawing.Image)(resources.GetObject("pic_ValidatePhone.Image")));
            this.pic_ValidatePhone.Location = new System.Drawing.Point(390, 185);
            this.pic_ValidatePhone.Name = "pic_ValidatePhone";
            this.pic_ValidatePhone.Size = new System.Drawing.Size(32, 24);
            this.pic_ValidatePhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ValidatePhone.TabIndex = 41;
            this.pic_ValidatePhone.TabStop = false;
            // 
            // pic_ValidateAddress
            // 
            this.pic_ValidateAddress.Image = ((System.Drawing.Image)(resources.GetObject("pic_ValidateAddress.Image")));
            this.pic_ValidateAddress.Location = new System.Drawing.Point(390, 224);
            this.pic_ValidateAddress.Name = "pic_ValidateAddress";
            this.pic_ValidateAddress.Size = new System.Drawing.Size(32, 24);
            this.pic_ValidateAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ValidateAddress.TabIndex = 41;
            this.pic_ValidateAddress.TabStop = false;
            // 
            // lblLoginStatus
            // 
            this.lblLoginStatus.AutoSize = true;
            this.lblLoginStatus.ForeColor = System.Drawing.Color.Green;
            this.lblLoginStatus.Location = new System.Drawing.Point(246, 313);
            this.lblLoginStatus.Name = "lblLoginStatus";
            this.lblLoginStatus.Size = new System.Drawing.Size(70, 24);
            this.lblLoginStatus.TabIndex = 0;
            this.lblLoginStatus.Text = "Enable";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Login:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Image:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(500, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 73);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Employee";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvEmployee.Location = new System.Drawing.Point(500, 211);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(548, 512);
            this.dgvEmployee.TabIndex = 40;
            this.dgvEmployee.Click += new System.EventHandler(this.dgvEmployee_Click);
            // 
            // pic_userImage
            // 
            this.pic_userImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_userImage.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic_userImage.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic_userImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_userImage.BorderSize = 2;
            this.pic_userImage.GradientAngle = 50F;
            this.pic_userImage.Image = ((System.Drawing.Image)(resources.GetObject("pic_userImage.Image")));
            this.pic_userImage.Location = new System.Drawing.Point(183, 97);
            this.pic_userImage.Name = "pic_userImage";
            this.pic_userImage.Size = new System.Drawing.Size(147, 147);
            this.pic_userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_userImage.TabIndex = 43;
            this.pic_userImage.TabStop = false;
            // 
            // btn_ClearName
            // 
            this.btn_ClearName.BackColor = System.Drawing.Color.Transparent;
            this.btn_ClearName.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_ClearName.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ClearName.BorderRadius = 0;
            this.btn_ClearName.BorderSize = 0;
            this.btn_ClearName.FlatAppearance.BorderSize = 0;
            this.btn_ClearName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClearName.Location = new System.Drawing.Point(351, 64);
            this.btn_ClearName.Name = "btn_ClearName";
            this.btn_ClearName.Size = new System.Drawing.Size(33, 32);
            this.btn_ClearName.TabIndex = 42;
            this.btn_ClearName.Text = "X";
            this.btn_ClearName.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClearName.UseVisualStyleBackColor = false;
            this.btn_ClearName.Click += new System.EventHandler(this.btn_ClearName_Click);
            // 
            // btn_ClearLastName
            // 
            this.btn_ClearLastName.BackColor = System.Drawing.Color.Transparent;
            this.btn_ClearLastName.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_ClearLastName.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ClearLastName.BorderRadius = 0;
            this.btn_ClearLastName.BorderSize = 0;
            this.btn_ClearLastName.FlatAppearance.BorderSize = 0;
            this.btn_ClearLastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearLastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClearLastName.Location = new System.Drawing.Point(351, 102);
            this.btn_ClearLastName.Name = "btn_ClearLastName";
            this.btn_ClearLastName.Size = new System.Drawing.Size(33, 28);
            this.btn_ClearLastName.TabIndex = 42;
            this.btn_ClearLastName.Text = "X";
            this.btn_ClearLastName.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClearLastName.UseVisualStyleBackColor = false;
            this.btn_ClearLastName.Click += new System.EventHandler(this.btn_ClearLastName_Click);
            // 
            // btn_ClearEmail
            // 
            this.btn_ClearEmail.BackColor = System.Drawing.Color.Transparent;
            this.btn_ClearEmail.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_ClearEmail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ClearEmail.BorderRadius = 0;
            this.btn_ClearEmail.BorderSize = 0;
            this.btn_ClearEmail.FlatAppearance.BorderSize = 0;
            this.btn_ClearEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClearEmail.Location = new System.Drawing.Point(351, 142);
            this.btn_ClearEmail.Name = "btn_ClearEmail";
            this.btn_ClearEmail.Size = new System.Drawing.Size(33, 31);
            this.btn_ClearEmail.TabIndex = 42;
            this.btn_ClearEmail.Text = "X";
            this.btn_ClearEmail.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClearEmail.UseVisualStyleBackColor = false;
            this.btn_ClearEmail.Click += new System.EventHandler(this.btn_ClearEmail_Click);
            // 
            // btn_ClearPhone
            // 
            this.btn_ClearPhone.BackColor = System.Drawing.Color.Transparent;
            this.btn_ClearPhone.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_ClearPhone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ClearPhone.BorderRadius = 0;
            this.btn_ClearPhone.BorderSize = 0;
            this.btn_ClearPhone.FlatAppearance.BorderSize = 0;
            this.btn_ClearPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearPhone.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClearPhone.Location = new System.Drawing.Point(350, 179);
            this.btn_ClearPhone.Name = "btn_ClearPhone";
            this.btn_ClearPhone.Size = new System.Drawing.Size(33, 30);
            this.btn_ClearPhone.TabIndex = 42;
            this.btn_ClearPhone.Text = "X";
            this.btn_ClearPhone.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClearPhone.UseVisualStyleBackColor = false;
            this.btn_ClearPhone.Click += new System.EventHandler(this.btn_ClearPhone_Click);
            // 
            // btn_ClearAddress
            // 
            this.btn_ClearAddress.BackColor = System.Drawing.Color.Transparent;
            this.btn_ClearAddress.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_ClearAddress.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ClearAddress.BorderRadius = 0;
            this.btn_ClearAddress.BorderSize = 0;
            this.btn_ClearAddress.FlatAppearance.BorderSize = 0;
            this.btn_ClearAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClearAddress.Location = new System.Drawing.Point(350, 224);
            this.btn_ClearAddress.Name = "btn_ClearAddress";
            this.btn_ClearAddress.Size = new System.Drawing.Size(33, 31);
            this.btn_ClearAddress.TabIndex = 42;
            this.btn_ClearAddress.Text = "X";
            this.btn_ClearAddress.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClearAddress.UseVisualStyleBackColor = false;
            this.btn_ClearAddress.Click += new System.EventHandler(this.btn_ClearAddress_Click);
            // 
            // chkLoginStatus
            // 
            this.chkLoginStatus.AutoSize = true;
            this.chkLoginStatus.Location = new System.Drawing.Point(186, 313);
            this.chkLoginStatus.MinimumSize = new System.Drawing.Size(45, 22);
            this.chkLoginStatus.Name = "chkLoginStatus";
            this.chkLoginStatus.OffBackColor = System.Drawing.Color.Gray;
            this.chkLoginStatus.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.chkLoginStatus.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.chkLoginStatus.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.chkLoginStatus.Size = new System.Drawing.Size(45, 22);
            this.chkLoginStatus.TabIndex = 5;
            this.chkLoginStatus.UseVisualStyleBackColor = true;
            this.chkLoginStatus.CheckedChanged += new System.EventHandler(this.chkLoginStatus_CheckedChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Orange;
            this.btn_Clear.BackgroundColor = System.Drawing.Color.Orange;
            this.btn_Clear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Clear.BorderRadius = 10;
            this.btn_Clear.BorderSize = 0;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(32, 452);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(351, 36);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "CLear";
            this.btn_Clear.TextColor = System.Drawing.Color.White;
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Orange;
            this.btn_Update.BackgroundColor = System.Drawing.Color.Orange;
            this.btn_Update.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Update.BorderRadius = 10;
            this.btn_Update.BorderSize = 0;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(32, 410);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(351, 36);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextColor = System.Drawing.Color.White;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.Transparent;
            this.btn_Browse.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Browse.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Browse.BorderRadius = 15;
            this.btn_Browse.BorderSize = 2;
            this.btn_Browse.FlatAppearance.BorderSize = 0;
            this.btn_Browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Browse.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Browse.Location = new System.Drawing.Point(173, 354);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(162, 32);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            this.btn_Browse.MouseEnter += new System.EventHandler(this.btn_Browse_MouseEnter);
            this.btn_Browse.MouseLeave += new System.EventHandler(this.btn_Browse_MouseLeave);
            // 
            // txtUserAddress
            // 
            this.txtUserAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUserAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserAddress.BorderRadius = 0;
            this.txtUserAddress.BorderSize = 2;
            this.txtUserAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserAddress.Location = new System.Drawing.Point(133, 224);
            this.txtUserAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserAddress.Multiline = false;
            this.txtUserAddress.Name = "txtUserAddress";
            this.txtUserAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserAddress.PasswordChar = false;
            this.txtUserAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserAddress.PlaceholderText = "";
            this.txtUserAddress.Size = new System.Drawing.Size(250, 35);
            this.txtUserAddress.TabIndex = 1;
            this.txtUserAddress.Texts = "";
            this.txtUserAddress.UnderlinedStyle = true;
            this.txtUserAddress._TextChanged += new System.EventHandler(this.txtUserAddress__TextChanged);
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserPhone.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUserPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserPhone.BorderRadius = 0;
            this.txtUserPhone.BorderSize = 2;
            this.txtUserPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserPhone.Location = new System.Drawing.Point(133, 185);
            this.txtUserPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPhone.Multiline = false;
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserPhone.PasswordChar = false;
            this.txtUserPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserPhone.PlaceholderText = "";
            this.txtUserPhone.Size = new System.Drawing.Size(250, 35);
            this.txtUserPhone.TabIndex = 1;
            this.txtUserPhone.Texts = "";
            this.txtUserPhone.UnderlinedStyle = true;
            this.txtUserPhone._TextChanged += new System.EventHandler(this.txtUserPhone__TextChanged);
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUserEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserEmail.BorderRadius = 0;
            this.txtUserEmail.BorderSize = 2;
            this.txtUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserEmail.Location = new System.Drawing.Point(133, 142);
            this.txtUserEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserEmail.Multiline = false;
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserEmail.PasswordChar = false;
            this.txtUserEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserEmail.PlaceholderText = "";
            this.txtUserEmail.Size = new System.Drawing.Size(250, 35);
            this.txtUserEmail.TabIndex = 1;
            this.txtUserEmail.Texts = "";
            this.txtUserEmail.UnderlinedStyle = true;
            this.txtUserEmail._TextChanged += new System.EventHandler(this.txtUserEmail__TextChanged);
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserLastName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUserLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserLastName.BorderRadius = 0;
            this.txtUserLastName.BorderSize = 2;
            this.txtUserLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserLastName.Location = new System.Drawing.Point(133, 103);
            this.txtUserLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserLastName.Multiline = false;
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserLastName.PasswordChar = false;
            this.txtUserLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserLastName.PlaceholderText = "";
            this.txtUserLastName.Size = new System.Drawing.Size(250, 35);
            this.txtUserLastName.TabIndex = 1;
            this.txtUserLastName.Texts = "";
            this.txtUserLastName.UnderlinedStyle = true;
            this.txtUserLastName._TextChanged += new System.EventHandler(this.txtUserLastName__TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserName.BorderRadius = 0;
            this.txtUserName.BorderSize = 2;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.Location = new System.Drawing.Point(133, 64);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserName.PasswordChar = false;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.Size = new System.Drawing.Size(250, 35);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = true;
            this.txtUserName._TextChanged += new System.EventHandler(this.txtUserName__TextChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserID.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUserID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserID.BorderRadius = 0;
            this.txtUserID.BorderSize = 2;
            this.txtUserID.Enabled = false;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserID.Location = new System.Drawing.Point(133, 24);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.Multiline = false;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserID.PasswordChar = false;
            this.txtUserID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserID.PlaceholderText = "";
            this.txtUserID.Size = new System.Drawing.Size(250, 35);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.Texts = "";
            this.txtUserID.UnderlinedStyle = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(166, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(20, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "           Search Here...";
            this.txtSearch.Size = new System.Drawing.Size(342, 35);
            this.txtSearch.TabIndex = 45;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 745);
            this.Controls.Add(this.pnlCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.pnlCustomer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ValidateName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ValidateLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ValidateEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ValidatePhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ValidateAddress)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private CustomControls.RJControls.RJCircularPictureBox pic_userImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomControls.RJControls.RJTextBox txtUserAddress;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJTextBox txtUserPhone;
        private CustomControls.RJControls.RJTextBox txtUserEmail;
        private CustomControls.RJControls.RJTextBox txtUserLastName;
        private CustomControls.RJControls.RJTextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txtUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJButton btn_Clear;
        private CustomControls.RJControls.RJButton btn_Update;
        private CustomControls.RJControls.RJButton btn_Browse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJToggleButton chkLoginStatus;
        private System.Windows.Forms.Label lblLoginStatus;
        private System.Windows.Forms.PictureBox pic_ValidateName;
        private System.Windows.Forms.PictureBox pic_ValidateLastName;
        private System.Windows.Forms.PictureBox pic_ValidateEmail;
        private System.Windows.Forms.PictureBox pic_ValidatePhone;
        private System.Windows.Forms.PictureBox pic_ValidateAddress;
        private CustomControls.RJControls.RJButton btn_ClearName;
        private CustomControls.RJControls.RJButton btn_ClearLastName;
        private CustomControls.RJControls.RJButton btn_ClearEmail;
        private CustomControls.RJControls.RJButton btn_ClearPhone;
        private CustomControls.RJControls.RJButton btn_ClearAddress;
        private CustomControls.RJControls.RJTextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbUserRole;
    }
}