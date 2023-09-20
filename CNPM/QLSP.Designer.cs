namespace CNPM
{
    partial class frmQLSP
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
            this.lblQLSP = new System.Windows.Forms.Label();
            this.lblProductInfo = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductTypeID = new System.Windows.Forms.Label();
            this.lblProductStatus = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.RichTextBox();
            this.txtProductName = new System.Windows.Forms.RichTextBox();
            this.txtProductStatus = new System.Windows.Forms.RichTextBox();
            this.txtProductPrice = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.cmbProductTypeID = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.dgvProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLSP
            // 
            this.lblQLSP.AutoSize = true;
            this.lblQLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLSP.Location = new System.Drawing.Point(304, 46);
            this.lblQLSP.Name = "lblQLSP";
            this.lblQLSP.Size = new System.Drawing.Size(483, 38);
            this.lblQLSP.TabIndex = 0;
            this.lblQLSP.Text = "Quản Lý Thông Tin Sản Phẩm";
            this.lblQLSP.Click += new System.EventHandler(this.lblQLSP_Click);
            // 
            // lblProductInfo
            // 
            this.lblProductInfo.AutoSize = true;
            this.lblProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInfo.Location = new System.Drawing.Point(21, 131);
            this.lblProductInfo.Name = "lblProductInfo";
            this.lblProductInfo.Size = new System.Drawing.Size(264, 32);
            this.lblProductInfo.TabIndex = 1;
            this.lblProductInfo.Text = "Thông tin sản phẩm";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(23, 209);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(72, 25);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Mã SP";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(23, 305);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(79, 25);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Tên SP";
            this.lblProductName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProductTypeID
            // 
            this.lblProductTypeID.AutoSize = true;
            this.lblProductTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTypeID.Location = new System.Drawing.Point(23, 257);
            this.lblProductTypeID.Name = "lblProductTypeID";
            this.lblProductTypeID.Size = new System.Drawing.Size(107, 25);
            this.lblProductTypeID.TabIndex = 1;
            this.lblProductTypeID.Text = "Mã loại SP";
            // 
            // lblProductStatus
            // 
            this.lblProductStatus.AutoSize = true;
            this.lblProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductStatus.Location = new System.Drawing.Point(23, 352);
            this.lblProductStatus.Name = "lblProductStatus";
            this.lblProductStatus.Size = new System.Drawing.Size(100, 25);
            this.lblProductStatus.TabIndex = 1;
            this.lblProductStatus.Text = "Tình trạng";
            this.lblProductStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(23, 402);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(79, 25);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "Đơn giá";
            this.lblProductPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(196, 209);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 31);
            this.txtProductID.TabIndex = 2;
            this.txtProductID.Text = "";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(196, 305);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(236, 31);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.Text = "";
            // 
            // txtProductStatus
            // 
            this.txtProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductStatus.Location = new System.Drawing.Point(196, 352);
            this.txtProductStatus.Name = "txtProductStatus";
            this.txtProductStatus.Size = new System.Drawing.Size(100, 31);
            this.txtProductStatus.TabIndex = 2;
            this.txtProductStatus.Text = "";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(196, 399);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 31);
            this.txtProductPrice.TabIndex = 2;
            this.txtProductPrice.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(27, 488);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 43);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Thêm / Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductID,
            this.dgvProductTypeID,
            this.dgvProductName,
            this.dgvProductStatus,
            this.dgvProductPrice});
            this.dgvProduct.Location = new System.Drawing.Point(438, 168);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(684, 363);
            this.dgvProduct.TabIndex = 4;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // cmbProductTypeID
            // 
            this.cmbProductTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductTypeID.FormattingEnabled = true;
            this.cmbProductTypeID.Items.AddRange(new object[] {
            "CPU",
            "GPU",
            "RAM",
            "MB",
            "PSU",
            "FAN"});
            this.cmbProductTypeID.Location = new System.Drawing.Point(196, 257);
            this.cmbProductTypeID.Name = "cmbProductTypeID";
            this.cmbProductTypeID.Size = new System.Drawing.Size(121, 33);
            this.cmbProductTypeID.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(196, 488);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(934, 555);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(129, 43);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // dgvProductID
            // 
            this.dgvProductID.HeaderText = "Mã SP";
            this.dgvProductID.MinimumWidth = 6;
            this.dgvProductID.Name = "dgvProductID";
            this.dgvProductID.ReadOnly = true;
            this.dgvProductID.Width = 80;
            // 
            // dgvProductTypeID
            // 
            this.dgvProductTypeID.HeaderText = "Mã loại SP";
            this.dgvProductTypeID.MinimumWidth = 6;
            this.dgvProductTypeID.Name = "dgvProductTypeID";
            this.dgvProductTypeID.ReadOnly = true;
            // 
            // dgvProductName
            // 
            this.dgvProductName.HeaderText = "Tên SP";
            this.dgvProductName.MinimumWidth = 6;
            this.dgvProductName.Name = "dgvProductName";
            this.dgvProductName.ReadOnly = true;
            this.dgvProductName.Width = 200;
            // 
            // dgvProductStatus
            // 
            this.dgvProductStatus.HeaderText = "Tình trạng";
            this.dgvProductStatus.MinimumWidth = 6;
            this.dgvProductStatus.Name = "dgvProductStatus";
            this.dgvProductStatus.ReadOnly = true;
            this.dgvProductStatus.Width = 125;
            // 
            // dgvProductPrice
            // 
            this.dgvProductPrice.HeaderText = "Đơn giá";
            this.dgvProductPrice.MinimumWidth = 6;
            this.dgvProductPrice.Name = "dgvProductPrice";
            this.dgvProductPrice.ReadOnly = true;
            this.dgvProductPrice.Width = 125;
            // 
            // frmQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 610);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbProductTypeID);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductStatus);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductTypeID);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductStatus);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblProductInfo);
            this.Controls.Add(this.lblQLSP);
            this.Name = "frmQLSP";
            this.Text = "Quản Lý Thông Tin Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLSP;
        private System.Windows.Forms.Label lblProductInfo;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductTypeID;
        private System.Windows.Forms.Label lblProductStatus;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.RichTextBox txtProductID;
        private System.Windows.Forms.RichTextBox txtProductName;
        private System.Windows.Forms.RichTextBox txtProductStatus;
        private System.Windows.Forms.RichTextBox txtProductPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ComboBox cmbProductTypeID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductPrice;
    }
}