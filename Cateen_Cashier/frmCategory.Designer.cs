namespace Cateen_Cashier
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.pnlCateogry = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCatSearch_pnlCategory = new System.Windows.Forms.TextBox();
            this.grbCategoryPanel = new System.Windows.Forms.GroupBox();
            this.PicBox_validate_CategoryName_pnlCategory = new System.Windows.Forms.PictureBox();
            this.btnClear_pnlCategory = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnShow_pnlCategory = new System.Windows.Forms.Button();
            this.btnDelete_pnlCategory = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btnUpdate_pnlCategory = new System.Windows.Forms.Button();
            this.btnCreate_pnlCategory = new System.Windows.Forms.Button();
            this.txtCatName_pnlCategory = new System.Windows.Forms.TextBox();
            this.dgvCategory_pnlCategory = new System.Windows.Forms.DataGridView();
            this.pnlCateogry.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbCategoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_validate_CategoryName_pnlCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory_pnlCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCateogry
            // 
            this.pnlCateogry.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCateogry.Controls.Add(this.groupBox3);
            this.pnlCateogry.Controls.Add(this.grbCategoryPanel);
            this.pnlCateogry.Controls.Add(this.dgvCategory_pnlCategory);
            this.pnlCateogry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCateogry.Location = new System.Drawing.Point(0, 0);
            this.pnlCateogry.Name = "pnlCateogry";
            this.pnlCateogry.Size = new System.Drawing.Size(1079, 727);
            this.pnlCateogry.TabIndex = 99;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtCatSearch_pnlCategory);
            this.groupBox3.Location = new System.Drawing.Point(288, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 100);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Category";
            // 
            // txtCatSearch_pnlCategory
            // 
            this.txtCatSearch_pnlCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCatSearch_pnlCategory.Location = new System.Drawing.Point(41, 47);
            this.txtCatSearch_pnlCategory.Name = "txtCatSearch_pnlCategory";
            this.txtCatSearch_pnlCategory.Size = new System.Drawing.Size(389, 29);
            this.txtCatSearch_pnlCategory.TabIndex = 92;
            this.txtCatSearch_pnlCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCatSearch_pnlCategory.TextChanged += new System.EventHandler(this.txtCatSearch_pnlCategory_TextChanged);
            // 
            // grbCategoryPanel
            // 
            this.grbCategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCategoryPanel.Controls.Add(this.PicBox_validate_CategoryName_pnlCategory);
            this.grbCategoryPanel.Controls.Add(this.btnClear_pnlCategory);
            this.grbCategoryPanel.Controls.Add(this.label20);
            this.grbCategoryPanel.Controls.Add(this.btnShow_pnlCategory);
            this.grbCategoryPanel.Controls.Add(this.btnDelete_pnlCategory);
            this.grbCategoryPanel.Controls.Add(this.label22);
            this.grbCategoryPanel.Controls.Add(this.btnUpdate_pnlCategory);
            this.grbCategoryPanel.Controls.Add(this.btnCreate_pnlCategory);
            this.grbCategoryPanel.Controls.Add(this.txtCatName_pnlCategory);
            this.grbCategoryPanel.Location = new System.Drawing.Point(27, 120);
            this.grbCategoryPanel.Name = "grbCategoryPanel";
            this.grbCategoryPanel.Size = new System.Drawing.Size(972, 256);
            this.grbCategoryPanel.TabIndex = 95;
            this.grbCategoryPanel.TabStop = false;
            this.grbCategoryPanel.Text = "Add New Category";
            // 
            // PicBox_validate_CategoryName_pnlCategory
            // 
            this.PicBox_validate_CategoryName_pnlCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBox_validate_CategoryName_pnlCategory.BackColor = System.Drawing.Color.Transparent;
            this.PicBox_validate_CategoryName_pnlCategory.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_validate_CategoryName_pnlCategory.Image")));
            this.PicBox_validate_CategoryName_pnlCategory.Location = new System.Drawing.Point(697, 60);
            this.PicBox_validate_CategoryName_pnlCategory.Name = "PicBox_validate_CategoryName_pnlCategory";
            this.PicBox_validate_CategoryName_pnlCategory.Size = new System.Drawing.Size(32, 25);
            this.PicBox_validate_CategoryName_pnlCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_validate_CategoryName_pnlCategory.TabIndex = 94;
            this.PicBox_validate_CategoryName_pnlCategory.TabStop = false;
            // 
            // btnClear_pnlCategory
            // 
            this.btnClear_pnlCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear_pnlCategory.Location = new System.Drawing.Point(313, 200);
            this.btnClear_pnlCategory.Name = "btnClear_pnlCategory";
            this.btnClear_pnlCategory.Size = new System.Drawing.Size(333, 34);
            this.btnClear_pnlCategory.TabIndex = 91;
            this.btnClear_pnlCategory.Text = "Clear";
            this.btnClear_pnlCategory.UseVisualStyleBackColor = true;
            this.btnClear_pnlCategory.Click += new System.EventHandler(this.btnClear_pnlCategory_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(477, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 24);
            this.label20.TabIndex = 93;
            // 
            // btnShow_pnlCategory
            // 
            this.btnShow_pnlCategory.Location = new System.Drawing.Point(67, 157);
            this.btnShow_pnlCategory.Name = "btnShow_pnlCategory";
            this.btnShow_pnlCategory.Size = new System.Drawing.Size(381, 34);
            this.btnShow_pnlCategory.TabIndex = 90;
            this.btnShow_pnlCategory.Text = "Show";
            this.btnShow_pnlCategory.UseVisualStyleBackColor = true;
            this.btnShow_pnlCategory.Click += new System.EventHandler(this.btnShow_pnlCategory_Click);
            // 
            // btnDelete_pnlCategory
            // 
            this.btnDelete_pnlCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete_pnlCategory.Location = new System.Drawing.Point(500, 158);
            this.btnDelete_pnlCategory.Name = "btnDelete_pnlCategory";
            this.btnDelete_pnlCategory.Size = new System.Drawing.Size(381, 34);
            this.btnDelete_pnlCategory.TabIndex = 89;
            this.btnDelete_pnlCategory.Text = "Delete";
            this.btnDelete_pnlCategory.UseVisualStyleBackColor = true;
            this.btnDelete_pnlCategory.Click += new System.EventHandler(this.btnDelete_pnlCategory_Click);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(252, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 24);
            this.label22.TabIndex = 77;
            this.label22.Text = "Category Name:";
            // 
            // btnUpdate_pnlCategory
            // 
            this.btnUpdate_pnlCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_pnlCategory.Location = new System.Drawing.Point(500, 111);
            this.btnUpdate_pnlCategory.Name = "btnUpdate_pnlCategory";
            this.btnUpdate_pnlCategory.Size = new System.Drawing.Size(377, 34);
            this.btnUpdate_pnlCategory.TabIndex = 88;
            this.btnUpdate_pnlCategory.Text = "Update";
            this.btnUpdate_pnlCategory.UseVisualStyleBackColor = true;
            this.btnUpdate_pnlCategory.Click += new System.EventHandler(this.btnUpdate_pnlCategory_Click);
            // 
            // btnCreate_pnlCategory
            // 
            this.btnCreate_pnlCategory.Location = new System.Drawing.Point(67, 119);
            this.btnCreate_pnlCategory.Name = "btnCreate_pnlCategory";
            this.btnCreate_pnlCategory.Size = new System.Drawing.Size(381, 34);
            this.btnCreate_pnlCategory.TabIndex = 88;
            this.btnCreate_pnlCategory.Text = "Create";
            this.btnCreate_pnlCategory.UseVisualStyleBackColor = true;
            this.btnCreate_pnlCategory.Click += new System.EventHandler(this.btnCreate_pnlCategory_Click);
            // 
            // txtCatName_pnlCategory
            // 
            this.txtCatName_pnlCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCatName_pnlCategory.Location = new System.Drawing.Point(408, 58);
            this.txtCatName_pnlCategory.Name = "txtCatName_pnlCategory";
            this.txtCatName_pnlCategory.Size = new System.Drawing.Size(283, 29);
            this.txtCatName_pnlCategory.TabIndex = 84;
            this.txtCatName_pnlCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCatName_pnlCategory.TextChanged += new System.EventHandler(this.txtCatName_pnlCategory_TextChanged);
            // 
            // dgvCategory_pnlCategory
            // 
            this.dgvCategory_pnlCategory.AllowUserToAddRows = false;
            this.dgvCategory_pnlCategory.AllowUserToDeleteRows = false;
            this.dgvCategory_pnlCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategory_pnlCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory_pnlCategory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCategory_pnlCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory_pnlCategory.Location = new System.Drawing.Point(36, 495);
            this.dgvCategory_pnlCategory.Name = "dgvCategory_pnlCategory";
            this.dgvCategory_pnlCategory.ReadOnly = true;
            this.dgvCategory_pnlCategory.Size = new System.Drawing.Size(978, 210);
            this.dgvCategory_pnlCategory.TabIndex = 93;
            this.dgvCategory_pnlCategory.Click += new System.EventHandler(this.dgvCategory_pnlCategory_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 727);
            this.Controls.Add(this.pnlCateogry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.pnlCateogry.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbCategoryPanel.ResumeLayout(false);
            this.grbCategoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_validate_CategoryName_pnlCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory_pnlCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCateogry;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCatSearch_pnlCategory;
        private System.Windows.Forms.GroupBox grbCategoryPanel;
        private System.Windows.Forms.PictureBox PicBox_validate_CategoryName_pnlCategory;
        private System.Windows.Forms.Button btnClear_pnlCategory;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnShow_pnlCategory;
        private System.Windows.Forms.Button btnDelete_pnlCategory;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnUpdate_pnlCategory;
        private System.Windows.Forms.Button btnCreate_pnlCategory;
        private System.Windows.Forms.TextBox txtCatName_pnlCategory;
        private System.Windows.Forms.DataGridView dgvCategory_pnlCategory;
    }
}