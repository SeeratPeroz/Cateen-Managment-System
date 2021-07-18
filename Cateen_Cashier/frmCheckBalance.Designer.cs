namespace Cateen_Cashier
{
    partial class frmCheckBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckBalance));
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCustBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_User2 = new CustomControls.RJControls.RJCircularPictureBox();
            this.pnlDeposit.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.BackColor = System.Drawing.Color.White;
            this.pnlDeposit.Controls.Add(this.pic_User2);
            this.pnlDeposit.Controls.Add(this.panel2);
            this.pnlDeposit.Controls.Add(this.panel1);
            this.pnlDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeposit.Location = new System.Drawing.Point(0, 0);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(1079, 727);
            this.pnlDeposit.TabIndex = 92;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.lblCustBalance);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblCustID);
            this.panel2.Controls.Add(this.lblCustName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(396, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 132);
            this.panel2.TabIndex = 7;
            // 
            // lblCustBalance
            // 
            this.lblCustBalance.AutoSize = true;
            this.lblCustBalance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustBalance.Location = new System.Drawing.Point(141, 82);
            this.lblCustBalance.Name = "lblCustBalance";
            this.lblCustBalance.Size = new System.Drawing.Size(230, 31);
            this.lblCustBalance.TabIndex = 0;
            this.lblCustBalance.Text = "Not Deposited yet!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Balance:";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(141, 9);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(61, 31);
            this.lblCustID.TabIndex = 0;
            this.lblCustID.Text = "N/A";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(141, 48);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(61, 31);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Location = new System.Drawing.Point(296, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 10);
            this.panel1.TabIndex = 6;
            // 
            // pic_User2
            // 
            this.pic_User2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_User2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_User2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic_User2.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic_User2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pic_User2.BorderSize = 5;
            this.pic_User2.GradientAngle = 20F;
            this.pic_User2.Image = ((System.Drawing.Image)(resources.GetObject("pic_User2.Image")));
            this.pic_User2.Location = new System.Drawing.Point(403, 104);
            this.pic_User2.Name = "pic_User2";
            this.pic_User2.Padding = new System.Windows.Forms.Padding(5);
            this.pic_User2.Size = new System.Drawing.Size(329, 329);
            this.pic_User2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_User2.TabIndex = 8;
            this.pic_User2.TabStop = false;
            // 
            // frmCheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 727);
            this.Controls.Add(this.pnlDeposit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCheckBalance";
            this.Text = "frmCheckBalance";
            this.pnlDeposit.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeposit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCustBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJCircularPictureBox pic_User2;
    }
}