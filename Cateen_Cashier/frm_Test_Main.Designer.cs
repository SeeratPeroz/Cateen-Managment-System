namespace Cateen_Cashier
{
    partial class frm_Test_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Test_Main));
            this.rjDatePicker1 = new CustomControls.RJControls.RJDatePicker();
            this.rjToggleButton1 = new CustomControls.RJControls.RJToggleButton();
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit = new System.Windows.Forms.GroupBox();
            this.btn_Update_DpMoeney_pnlDeposit = new System.Windows.Forms.Button();
            this.label321 = new System.Windows.Forms.Label();
            this.txtPriceUpdate = new CustomControls.RJControls.RJTextBox();
            this.dgvCustomerDeposit_List_pnlDeposit = new System.Windows.Forms.DataGridView();
            this.pnlUpdate_Child_pnlDeposit = new System.Windows.Forms.Panel();
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDeposit_List_pnlDeposit)).BeginInit();
            this.pnlUpdate_Child_pnlDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 1;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker1.Location = new System.Drawing.Point(144, 59);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(223, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.MediumSpringGreen;
            this.rjDatePicker1.TabIndex = 0;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(255, 212);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 1;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
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
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.Size = new System.Drawing.Size(443, 109);
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.TabIndex = 0;
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.TabStop = false;
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.Text = "Deposited Details";
            // 
            // btn_Update_DpMoeney_pnlDeposit
            // 
            this.btn_Update_DpMoeney_pnlDeposit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Update_DpMoeney_pnlDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update_DpMoeney_pnlDeposit.Image")));
            this.btn_Update_DpMoeney_pnlDeposit.Location = new System.Drawing.Point(321, 34);
            this.btn_Update_DpMoeney_pnlDeposit.Name = "btn_Update_DpMoeney_pnlDeposit";
            this.btn_Update_DpMoeney_pnlDeposit.Size = new System.Drawing.Size(64, 60);
            this.btn_Update_DpMoeney_pnlDeposit.TabIndex = 1;
            this.btn_Update_DpMoeney_pnlDeposit.UseVisualStyleBackColor = true;
            // 
            // label321
            // 
            this.label321.AutoSize = true;
            this.label321.Location = new System.Drawing.Point(101, 52);
            this.label321.Name = "label321";
            this.label321.Size = new System.Drawing.Size(90, 13);
            this.label321.TabIndex = 1;
            this.label321.Text = "Deposited Money";
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
            this.dgvCustomerDeposit_List_pnlDeposit.Size = new System.Drawing.Size(659, 206);
            this.dgvCustomerDeposit_List_pnlDeposit.TabIndex = 1;
            // 
            // pnlUpdate_Child_pnlDeposit
            // 
            this.pnlUpdate_Child_pnlDeposit.Controls.Add(this.dgvCustomerDeposit_List_pnlDeposit);
            this.pnlUpdate_Child_pnlDeposit.Controls.Add(this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit);
            this.pnlUpdate_Child_pnlDeposit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdate_Child_pnlDeposit.Location = new System.Drawing.Point(0, 27);
            this.pnlUpdate_Child_pnlDeposit.Name = "pnlUpdate_Child_pnlDeposit";
            this.pnlUpdate_Child_pnlDeposit.Size = new System.Drawing.Size(729, 412);
            this.pnlUpdate_Child_pnlDeposit.TabIndex = 98;
            // 
            // frm_Test_Main
            // 
            this.ClientSize = new System.Drawing.Size(729, 439);
            this.Controls.Add(this.pnlUpdate_Child_pnlDeposit);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.rjDatePicker1);
            this.Name = "frm_Test_Main";
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.ResumeLayout(false);
            this.grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDeposit_List_pnlDeposit)).EndInit();
            this.pnlUpdate_Child_pnlDeposit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnContactUs;
        private System.Windows.Forms.Button btnCalender;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Panel pnl_Child_Form;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private CustomControls.RJControls.RJDatePicker rjDatePicker1;
        private CustomControls.RJControls.RJToggleButton rjToggleButton1;
        private System.Windows.Forms.Panel pnlUpdate_Child_pnlDeposit;
        private System.Windows.Forms.DataGridView dgvCustomerDeposit_List_pnlDeposit;
        private System.Windows.Forms.Button btn_Update_DpMoeney_pnlDeposit;
        private System.Windows.Forms.Label label321;
        private CustomControls.RJControls.RJTextBox txtPriceUpdate;
        private System.Windows.Forms.GroupBox grb_UpdateDepositeText_child_pnlUpdate_pnlDeposit;
    }
}