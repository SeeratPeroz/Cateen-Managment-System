namespace Cateen_Cashier
{
    partial class frmEmail
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
            this.pic_Name_Validate = new System.Windows.Forms.PictureBox();
            this.btn_Close = new CustomControls.RJControls.RJButton();
            this.txtEmail = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Title = new CustomControls.RJControls.RJTextBox();
            this.txtbody = new CustomControls.RJControls.RJTextBox();
            this.btn_sendEmail = new CustomControls.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAttached = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Name_Validate)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Name_Validate
            // 
            this.pic_Name_Validate.BackColor = System.Drawing.Color.Transparent;
            this.pic_Name_Validate.Image = global::Cateen_Cashier.Properties.Resources.No;
            this.pic_Name_Validate.Location = new System.Drawing.Point(380, 85);
            this.pic_Name_Validate.Name = "pic_Name_Validate";
            this.pic_Name_Validate.Size = new System.Drawing.Size(23, 22);
            this.pic_Name_Validate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Name_Validate.TabIndex = 103;
            this.pic_Name_Validate.TabStop = false;
            this.pic_Name_Validate.Click += new System.EventHandler(this.pic_Name_Validate_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Aqua;
            this.btn_Close.BackgroundColor = System.Drawing.Color.Aqua;
            this.btn_Close.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Close.BorderRadius = 5;
            this.btn_Close.BorderSize = 0;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Location = new System.Drawing.Point(55, 484);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(360, 34);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.TextColor = System.Drawing.Color.Black;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderColor = System.Drawing.Color.Aqua;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(138, 85);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 15, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.White;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(277, 31);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            this.txtEmail._TextChanged += new System.EventHandler(this.txtEmail__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(51, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 101;
            this.label1.Text = "Send to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(51, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 101;
            this.label2.Text = "Subject:";
            // 
            // txt_Title
            // 
            this.txt_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Title.BorderColor = System.Drawing.Color.Aqua;
            this.txt_Title.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Title.BorderRadius = 10;
            this.txt_Title.BorderSize = 2;
            this.txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.ForeColor = System.Drawing.Color.White;
            this.txt_Title.Location = new System.Drawing.Point(138, 130);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Title.Multiline = false;
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Padding = new System.Windows.Forms.Padding(10, 7, 15, 7);
            this.txt_Title.PasswordChar = false;
            this.txt_Title.PlaceholderColor = System.Drawing.Color.White;
            this.txt_Title.PlaceholderText = "";
            this.txt_Title.Size = new System.Drawing.Size(277, 31);
            this.txt_Title.TabIndex = 2;
            this.txt_Title.Texts = "";
            this.txt_Title.UnderlinedStyle = true;
            // 
            // txtbody
            // 
            this.txtbody.BackColor = System.Drawing.Color.Snow;
            this.txtbody.BorderColor = System.Drawing.Color.Aqua;
            this.txtbody.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbody.BorderRadius = 10;
            this.txtbody.BorderSize = 2;
            this.txtbody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbody.ForeColor = System.Drawing.Color.Black;
            this.txtbody.Location = new System.Drawing.Point(55, 215);
            this.txtbody.Margin = new System.Windows.Forms.Padding(4);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Padding = new System.Windows.Forms.Padding(10, 7, 15, 7);
            this.txtbody.PasswordChar = false;
            this.txtbody.PlaceholderColor = System.Drawing.Color.White;
            this.txtbody.PlaceholderText = "";
            this.txtbody.Size = new System.Drawing.Size(360, 203);
            this.txtbody.TabIndex = 3;
            this.txtbody.Texts = "";
            this.txtbody.UnderlinedStyle = false;
            // 
            // btn_sendEmail
            // 
            this.btn_sendEmail.BackColor = System.Drawing.Color.Aqua;
            this.btn_sendEmail.BackgroundColor = System.Drawing.Color.Aqua;
            this.btn_sendEmail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_sendEmail.BorderRadius = 5;
            this.btn_sendEmail.BorderSize = 0;
            this.btn_sendEmail.FlatAppearance.BorderSize = 0;
            this.btn_sendEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_sendEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btn_sendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendEmail.ForeColor = System.Drawing.Color.Black;
            this.btn_sendEmail.Location = new System.Drawing.Point(55, 448);
            this.btn_sendEmail.Name = "btn_sendEmail";
            this.btn_sendEmail.Size = new System.Drawing.Size(360, 34);
            this.btn_sendEmail.TabIndex = 4;
            this.btn_sendEmail.Text = "Send Mail";
            this.btn_sendEmail.TextColor = System.Drawing.Color.Black;
            this.btn_sendEmail.UseVisualStyleBackColor = false;
            this.btn_sendEmail.Click += new System.EventHandler(this.btn_sendEmail_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(51, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 105;
            this.label3.Text = "Atteched:";
            // 
            // lblAttached
            // 
            this.lblAttached.AutoSize = true;
            this.lblAttached.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttached.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAttached.Location = new System.Drawing.Point(148, 176);
            this.lblAttached.Name = "lblAttached";
            this.lblAttached.Size = new System.Drawing.Size(24, 18);
            this.lblAttached.TabIndex = 106;
            this.lblAttached.Text = "....";
            this.lblAttached.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(96, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 37);
            this.label4.TabIndex = 107;
            this.label4.Text = "Enter Email Details";
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(453, 540);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAttached);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.pic_Name_Validate);
            this.Controls.Add(this.btn_sendEmail);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmail";
            this.Load += new System.EventHandler(this.frmEmail_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEmail_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Name_Validate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public CustomControls.RJControls.RJTextBox txtEmail;
        private CustomControls.RJControls.RJButton btn_Close;
        private System.Windows.Forms.PictureBox pic_Name_Validate;
        private System.Windows.Forms.Label label2;
        public CustomControls.RJControls.RJTextBox txt_Title;
        public CustomControls.RJControls.RJTextBox txtbody;
        private CustomControls.RJControls.RJButton btn_sendEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAttached;
        private System.Windows.Forms.Label label4;
    }
}