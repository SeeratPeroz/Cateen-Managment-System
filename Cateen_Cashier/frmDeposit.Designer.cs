namespace Cateen_Cashier
{
    partial class frmDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeposit));
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.grb_CustomerDetails_pnlDeposit = new System.Windows.Forms.GroupBox();
            this.lblCustCard = new System.Windows.Forms.Label();
            this.btn_Transaction_pnlDeposit = new System.Windows.Forms.Button();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustBalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.pnl_pic = new System.Windows.Forms.Panel();
            this.pic_depositeAmount_pnlDeposit = new System.Windows.Forms.PictureBox();
            this.pnl_label = new System.Windows.Forms.Panel();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.pnlUpdate_Child_pnlDeposit = new System.Windows.Forms.Panel();
            this.dgvCustomerDeposit_List_pnlDeposit = new System.Windows.Forms.DataGridView();
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit = new System.Windows.Forms.GroupBox();
            this.label321 = new System.Windows.Forms.Label();
            this.btn_Update_DpMoeney_pnlDeposit = new System.Windows.Forms.Button();
            this.txtPriceUpdate = new CustomControls.RJControls.RJTextBox();
            this.btn_Add2Balance1 = new CustomControls.RJControls.RJButton();
            this.txtDepositAmount1 = new CustomControls.RJControls.RJTextBox();
            this.pnlDeposit.SuspendLayout();
            this.grb_CustomerDetails_pnlDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.pnl_pic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_depositeAmount_pnlDeposit)).BeginInit();
            this.pnl_label.SuspendLayout();
            this.pnlUpdate_Child_pnlDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDeposit_List_pnlDeposit)).BeginInit();
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDeposit.Controls.Add(this.btn_Add2Balance1);
            this.pnlDeposit.Controls.Add(this.txtDepositAmount1);
            this.pnlDeposit.Controls.Add(this.grb_CustomerDetails_pnlDeposit);
            this.pnlDeposit.Controls.Add(this.pnl_pic);
            this.pnlDeposit.Controls.Add(this.pnl_label);
            this.pnlDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeposit.Location = new System.Drawing.Point(0, 0);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(1079, 760);
            this.pnlDeposit.TabIndex = 91;
            // 
            // grb_CustomerDetails_pnlDeposit
            // 
            this.grb_CustomerDetails_pnlDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_CustomerDetails_pnlDeposit.BackColor = System.Drawing.Color.AliceBlue;
            this.grb_CustomerDetails_pnlDeposit.Controls.Add(this.lblCustCard);
            this.grb_CustomerDetails_pnlDeposit.Controls.Add(this.btn_Transaction_pnlDeposit);
            this.grb_CustomerDetails_pnlDeposit.Controls.Add(this.pic_User);
            this.grb_CustomerDetails_pnlDeposit.Controls.Add(this.label6);
            this.grb_CustomerDetails_pnlDeposit.Controls.Add(this.lblCustBalance);
            this.grb_CustomerDetails_pnlDeposit.Controls.Add(this.label7);
            this.grb_CustomerDetails_pnlDeposit.Controls.Add(this.lblCustName);
            this.grb_CustomerDetails_pnlDeposit.Controls.Add(this.label8);
            this.grb_CustomerDetails_pnlDeposit.Controls.Add(this.lblCustID);
            this.grb_CustomerDetails_pnlDeposit.Location = new System.Drawing.Point(31, 110);
            this.grb_CustomerDetails_pnlDeposit.Name = "grb_CustomerDetails_pnlDeposit";
            this.grb_CustomerDetails_pnlDeposit.Padding = new System.Windows.Forms.Padding(7);
            this.grb_CustomerDetails_pnlDeposit.Size = new System.Drawing.Size(1009, 240);
            this.grb_CustomerDetails_pnlDeposit.TabIndex = 4;
            this.grb_CustomerDetails_pnlDeposit.TabStop = false;
            this.grb_CustomerDetails_pnlDeposit.Text = "User Details";
            // 
            // lblCustCard
            // 
            this.lblCustCard.AutoSize = true;
            this.lblCustCard.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustCard.Location = new System.Drawing.Point(985, 16);
            this.lblCustCard.Name = "lblCustCard";
            this.lblCustCard.Size = new System.Drawing.Size(46, 24);
            this.lblCustCard.TabIndex = 3;
            this.lblCustCard.Text = "N/A";
            this.lblCustCard.Visible = false;
            // 
            // btn_Transaction_pnlDeposit
            // 
            this.btn_Transaction_pnlDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Transaction_pnlDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transaction_pnlDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Transaction_pnlDeposit.Image")));
            this.btn_Transaction_pnlDeposit.Location = new System.Drawing.Point(788, 200);
            this.btn_Transaction_pnlDeposit.Name = "btn_Transaction_pnlDeposit";
            this.btn_Transaction_pnlDeposit.Size = new System.Drawing.Size(180, 32);
            this.btn_Transaction_pnlDeposit.TabIndex = 2;
            this.btn_Transaction_pnlDeposit.Text = "Transactions";
            this.btn_Transaction_pnlDeposit.UseVisualStyleBackColor = true;
            this.btn_Transaction_pnlDeposit.Click += new System.EventHandler(this.btn_Transaction_pnlDeposit_Click);
            // 
            // pic_User
            // 
            this.pic_User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_User.ErrorImage = null;
            this.pic_User.Image = global::Cateen_Cashier.Properties.Resources.avatart;
            this.pic_User.Location = new System.Drawing.Point(788, 43);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(180, 143);
            this.pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_User.TabIndex = 1;
            this.pic_User.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Current Balance:";
            // 
            // lblCustBalance
            // 
            this.lblCustBalance.AutoSize = true;
            this.lblCustBalance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustBalance.Location = new System.Drawing.Point(212, 180);
            this.lblCustBalance.Name = "lblCustBalance";
            this.lblCustBalance.Size = new System.Drawing.Size(175, 24);
            this.lblCustBalance.TabIndex = 0;
            this.lblCustBalance.Text = "Not Deposited yet!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name: ";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(212, 128);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(46, 24);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(212, 71);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(46, 24);
            this.lblCustID.TabIndex = 0;
            this.lblCustID.Text = "N/A";
            // 
            // pnl_pic
            // 
            this.pnl_pic.Controls.Add(this.pic_depositeAmount_pnlDeposit);
            this.pnl_pic.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_pic.Location = new System.Drawing.Point(904, 0);
            this.pnl_pic.Name = "pnl_pic";
            this.pnl_pic.Size = new System.Drawing.Size(175, 760);
            this.pnl_pic.TabIndex = 11;
            // 
            // pic_depositeAmount_pnlDeposit
            // 
            this.pic_depositeAmount_pnlDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_depositeAmount_pnlDeposit.Image = ((System.Drawing.Image)(resources.GetObject("pic_depositeAmount_pnlDeposit.Image")));
            this.pic_depositeAmount_pnlDeposit.Location = new System.Drawing.Point(3, 469);
            this.pic_depositeAmount_pnlDeposit.Name = "pic_depositeAmount_pnlDeposit";
            this.pic_depositeAmount_pnlDeposit.Size = new System.Drawing.Size(40, 44);
            this.pic_depositeAmount_pnlDeposit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_depositeAmount_pnlDeposit.TabIndex = 7;
            this.pic_depositeAmount_pnlDeposit.TabStop = false;
            // 
            // pnl_label
            // 
            this.pnl_label.Controls.Add(this.lblDepositAmount);
            this.pnl_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_label.Location = new System.Drawing.Point(0, 0);
            this.pnl_label.Name = "pnl_label";
            this.pnl_label.Size = new System.Drawing.Size(264, 760);
            this.pnl_label.TabIndex = 10;
            this.pnl_label.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmount.Location = new System.Drawing.Point(47, 477);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(203, 31);
            this.lblDepositAmount.TabIndex = 3;
            this.lblDepositAmount.Text = "Deposit Amount";
            // 
            // pnlUpdate_Child_pnlDeposit
            // 
            this.pnlUpdate_Child_pnlDeposit.Controls.Add(this.dgvCustomerDeposit_List_pnlDeposit);
            this.pnlUpdate_Child_pnlDeposit.Controls.Add(this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit);
            this.pnlUpdate_Child_pnlDeposit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdate_Child_pnlDeposit.Location = new System.Drawing.Point(0, 348);
            this.pnlUpdate_Child_pnlDeposit.Name = "pnlUpdate_Child_pnlDeposit";
            this.pnlUpdate_Child_pnlDeposit.Size = new System.Drawing.Size(1079, 412);
            this.pnlUpdate_Child_pnlDeposit.TabIndex = 99;
            // 
            // dgvCustomerDeposit_List_pnlDeposit
            // 
            this.dgvCustomerDeposit_List_pnlDeposit.AllowUserToAddRows = false;
            this.dgvCustomerDeposit_List_pnlDeposit.AllowUserToDeleteRows = false;
            this.dgvCustomerDeposit_List_pnlDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerDeposit_List_pnlDeposit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerDeposit_List_pnlDeposit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustomerDeposit_List_pnlDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDeposit_List_pnlDeposit.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCustomerDeposit_List_pnlDeposit.Location = new System.Drawing.Point(31, 168);
            this.dgvCustomerDeposit_List_pnlDeposit.Name = "dgvCustomerDeposit_List_pnlDeposit";
            this.dgvCustomerDeposit_List_pnlDeposit.ReadOnly = true;
            this.dgvCustomerDeposit_List_pnlDeposit.Size = new System.Drawing.Size(1009, 206);
            this.dgvCustomerDeposit_List_pnlDeposit.TabIndex = 1;
            this.dgvCustomerDeposit_List_pnlDeposit.Click += new System.EventHandler(this.dgvCustomerDeposit_List_pnlDeposit_Click);
            // 
            // grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit
            // 
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.Controls.Add(this.txtPriceUpdate);
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.Controls.Add(this.label321);
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.Controls.Add(this.btn_Update_DpMoeney_pnlDeposit);
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.Location = new System.Drawing.Point(166, 46);
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.Name = "grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit";
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.Size = new System.Drawing.Size(793, 109);
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.TabIndex = 0;
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.TabStop = false;
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.Text = "Deposited Details";
            // 
            // label321
            // 
            this.label321.AutoSize = true;
            this.label321.Location = new System.Drawing.Point(101, 52);
            this.label321.Name = "label321";
            this.label321.Size = new System.Drawing.Size(158, 24);
            this.label321.TabIndex = 1;
            this.label321.Text = "Deposited Money";
            // 
            // btn_Update_DpMoeney_pnlDeposit
            // 
            this.btn_Update_DpMoeney_pnlDeposit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Update_DpMoeney_pnlDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update_DpMoeney_pnlDeposit.Image")));
            this.btn_Update_DpMoeney_pnlDeposit.Location = new System.Drawing.Point(671, 34);
            this.btn_Update_DpMoeney_pnlDeposit.Name = "btn_Update_DpMoeney_pnlDeposit";
            this.btn_Update_DpMoeney_pnlDeposit.Size = new System.Drawing.Size(64, 60);
            this.btn_Update_DpMoeney_pnlDeposit.TabIndex = 1;
            this.btn_Update_DpMoeney_pnlDeposit.UseVisualStyleBackColor = true;
            this.btn_Update_DpMoeney_pnlDeposit.Click += new System.EventHandler(this.btn_Update_DpMoeney_pnlDeposit_Click_1);
            // 
            // txtPriceUpdate
            // 
            this.txtPriceUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.txtPriceUpdate.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPriceUpdate.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPriceUpdate.BorderRadius = 8;
            this.txtPriceUpdate.BorderSize = 2;
            this.txtPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtPriceUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPriceUpdate.Location = new System.Drawing.Point(275, 50);
            this.txtPriceUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriceUpdate.Multiline = false;
            this.txtPriceUpdate.Name = "txtPriceUpdate";
            this.txtPriceUpdate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPriceUpdate.PasswordChar = false;
            this.txtPriceUpdate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPriceUpdate.PlaceholderText = "";
            this.txtPriceUpdate.Size = new System.Drawing.Size(365, 44);
            this.txtPriceUpdate.TabIndex = 2;
            this.txtPriceUpdate.Texts = "";
            this.txtPriceUpdate.UnderlinedStyle = false;
            // 
            // btn_Add2Balance1
            // 
            this.btn_Add2Balance1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add2Balance1.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add2Balance1.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Add2Balance1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add2Balance1.BorderRadius = 15;
            this.btn_Add2Balance1.BorderSize = 3;
            this.btn_Add2Balance1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add2Balance1.FlatAppearance.BorderSize = 4;
            this.btn_Add2Balance1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Add2Balance1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add2Balance1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add2Balance1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add2Balance1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add2Balance1.Location = new System.Drawing.Point(386, 543);
            this.btn_Add2Balance1.Name = "btn_Add2Balance1";
            this.btn_Add2Balance1.Size = new System.Drawing.Size(381, 57);
            this.btn_Add2Balance1.TabIndex = 13;
            this.btn_Add2Balance1.Text = "Add to Balance";
            this.btn_Add2Balance1.TextColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add2Balance1.UseVisualStyleBackColor = false;
            this.btn_Add2Balance1.Click += new System.EventHandler(this.btn_Add2Balance_Click);
            this.btn_Add2Balance1.MouseEnter += new System.EventHandler(this.Add_MouseEnter);
            this.btn_Add2Balance1.MouseLeave += new System.EventHandler(this.Add_MouseLeave);
            // 
            // txtDepositAmount1
            // 
            this.txtDepositAmount1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepositAmount1.BackColor = System.Drawing.SystemColors.Window;
            this.txtDepositAmount1.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.txtDepositAmount1.BorderFocusColor = System.Drawing.Color.LawnGreen;
            this.txtDepositAmount1.BorderRadius = 20;
            this.txtDepositAmount1.BorderSize = 2;
            this.txtDepositAmount1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositAmount1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDepositAmount1.Location = new System.Drawing.Point(269, 466);
            this.txtDepositAmount1.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepositAmount1.Multiline = false;
            this.txtDepositAmount1.Name = "txtDepositAmount1";
            this.txtDepositAmount1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDepositAmount1.PasswordChar = false;
            this.txtDepositAmount1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDepositAmount1.PlaceholderText = "";
            this.txtDepositAmount1.Size = new System.Drawing.Size(628, 49);
            this.txtDepositAmount1.TabIndex = 3;
            this.txtDepositAmount1.Texts = "";
            this.txtDepositAmount1.UnderlinedStyle = false;
            this.txtDepositAmount1._TextChanged += new System.EventHandler(this.txtDepositAmount_TextChanged);
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 760);
            this.Controls.Add(this.pnlUpdate_Child_pnlDeposit);
            this.Controls.Add(this.pnlDeposit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDeposit";
            this.Text = "frmDeposit";
            this.Load += new System.EventHandler(this.frmDeposit_Load);
            this.pnlDeposit.ResumeLayout(false);
            this.grb_CustomerDetails_pnlDeposit.ResumeLayout(false);
            this.grb_CustomerDetails_pnlDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.pnl_pic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_depositeAmount_pnlDeposit)).EndInit();
            this.pnl_label.ResumeLayout(false);
            this.pnl_label.PerformLayout();
            this.pnlUpdate_Child_pnlDeposit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDeposit_List_pnlDeposit)).EndInit();
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.ResumeLayout(false);
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeposit;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.GroupBox grb_CustomerDetails_pnlDeposit;
        private System.Windows.Forms.Button btn_Transaction_pnlDeposit;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCustBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.PictureBox pic_depositeAmount_pnlDeposit;
        private System.Windows.Forms.Label lblCustCard;
        private System.Windows.Forms.Panel pnl_label;
        private System.Windows.Forms.Panel pnl_pic;
        private CustomControls.RJControls.RJTextBox txtDepositAmount1;
        private CustomControls.RJControls.RJButton btn_Add2Balance1;
        private System.Windows.Forms.Panel pnlUpdate_Child_pnlDeposit;
        private System.Windows.Forms.DataGridView dgvCustomerDeposit_List_pnlDeposit;
        private System.Windows.Forms.GroupBox grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit;
        private System.Windows.Forms.Label label321;
        private System.Windows.Forms.Button btn_Update_DpMoeney_pnlDeposit;
        private CustomControls.RJControls.RJTextBox txtPriceUpdate;
    }
}