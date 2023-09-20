namespace CNPM
{
    partial class frmQLKH
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
            this.lblQLKH = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblGener = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.RichTextBox();
            this.txtFullName = new System.Windows.Forms.RichTextBox();
            this.txtBirthday = new System.Windows.Forms.RichTextBox();
            this.txtPhoneNumber = new System.Windows.Forms.RichTextBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.otpMale = new System.Windows.Forms.CheckBox();
            this.otpFemale = new System.Windows.Forms.CheckBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.dgvCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLKH
            // 
            this.lblQLKH.AutoSize = true;
            this.lblQLKH.BackColor = System.Drawing.SystemColors.Control;
            this.lblQLKH.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLKH.Location = new System.Drawing.Point(422, 38);
            this.lblQLKH.Name = "lblQLKH";
            this.lblQLKH.Size = new System.Drawing.Size(361, 40);
            this.lblQLKH.TabIndex = 0;
            this.lblQLKH.Text = "Quản Lý Khách Hàng";
            this.lblQLKH.Click += new System.EventHandler(this.lblQLKH_Click);
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(28, 150);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(213, 24);
            this.lblCustomerInfo.TabIndex = 1;
            this.lblCustomerInfo.Text = "Thông Tin Khách Hàng";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(45, 200);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 24);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Mã KH";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(45, 250);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(70, 24);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Họ tên";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(46, 455);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 24);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(46, 405);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(47, 24);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "SĐT";
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDay.Location = new System.Drawing.Point(46, 348);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(97, 24);
            this.lblBirthDay.TabIndex = 1;
            this.lblBirthDay.Text = "Ngày sinh";
            // 
            // lblGener
            // 
            this.lblGener.AutoSize = true;
            this.lblGener.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGener.Location = new System.Drawing.Point(45, 303);
            this.lblGener.Name = "lblGener";
            this.lblGener.Size = new System.Drawing.Size(84, 24);
            this.lblGener.TabIndex = 1;
            this.lblGener.Text = "Giới tính";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(149, 200);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(123, 29);
            this.txtCustomerID.TabIndex = 2;
            this.txtCustomerID.Text = "";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(149, 254);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(263, 42);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.Text = "";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthday.Location = new System.Drawing.Point(149, 352);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(123, 34);
            this.txtBirthday.TabIndex = 2;
            this.txtBirthday.Text = "";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(149, 402);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(123, 37);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.Text = "";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(149, 455);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(263, 34);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "";
            // 
            // otpMale
            // 
            this.otpMale.AutoSize = true;
            this.otpMale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpMale.Location = new System.Drawing.Point(149, 303);
            this.otpMale.Name = "otpMale";
            this.otpMale.Size = new System.Drawing.Size(73, 28);
            this.otpMale.TabIndex = 3;
            this.otpMale.Text = "Nam";
            this.otpMale.UseVisualStyleBackColor = true;
            // 
            // otpFemale
            // 
            this.otpFemale.AutoSize = true;
            this.otpFemale.Checked = true;
            this.otpFemale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.otpFemale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpFemale.Location = new System.Drawing.Point(266, 303);
            this.otpFemale.Name = "otpFemale";
            this.otpFemale.Size = new System.Drawing.Size(57, 28);
            this.otpFemale.TabIndex = 3;
            this.otpFemale.Text = "Nữ";
            this.otpFemale.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCustomerID,
            this.dgvFullName,
            this.dgvGener,
            this.dgvBirthday,
            this.dgvPhoneNumber,
            this.dgvAddress});
            this.dgvCustomer.Location = new System.Drawing.Point(418, 150);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(791, 368);
            this.dgvCustomer.TabIndex = 4;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // dgvCustomerID
            // 
            this.dgvCustomerID.HeaderText = "Mã KH";
            this.dgvCustomerID.MinimumWidth = 6;
            this.dgvCustomerID.Name = "dgvCustomerID";
            this.dgvCustomerID.ReadOnly = true;
            this.dgvCustomerID.Width = 125;
            // 
            // dgvFullName
            // 
            this.dgvFullName.HeaderText = "Họ tên";
            this.dgvFullName.MinimumWidth = 6;
            this.dgvFullName.Name = "dgvFullName";
            this.dgvFullName.ReadOnly = true;
            this.dgvFullName.Width = 125;
            // 
            // dgvGener
            // 
            this.dgvGener.HeaderText = "Giới tính";
            this.dgvGener.MinimumWidth = 6;
            this.dgvGener.Name = "dgvGener";
            this.dgvGener.ReadOnly = true;
            this.dgvGener.Width = 125;
            // 
            // dgvBirthday
            // 
            this.dgvBirthday.HeaderText = "Ngày sinh";
            this.dgvBirthday.MinimumWidth = 6;
            this.dgvBirthday.Name = "dgvBirthday";
            this.dgvBirthday.ReadOnly = true;
            this.dgvBirthday.Width = 125;
            // 
            // dgvPhoneNumber
            // 
            this.dgvPhoneNumber.HeaderText = "SĐT";
            this.dgvPhoneNumber.MinimumWidth = 6;
            this.dgvPhoneNumber.Name = "dgvPhoneNumber";
            this.dgvPhoneNumber.ReadOnly = true;
            this.dgvPhoneNumber.Width = 125;
            // 
            // dgvAddress
            // 
            this.dgvAddress.HeaderText = "Địa chỉ";
            this.dgvAddress.MinimumWidth = 6;
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            this.dgvAddress.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(49, 506);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 64);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Thêm / Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(245, 506);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 64);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(1076, 530);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(107, 64);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmQLKH
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 606);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.otpFemale);
            this.Controls.Add(this.otpMale);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblGener);
            this.Controls.Add(this.lblBirthDay);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblCustomerInfo);
            this.Controls.Add(this.lblQLKH);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLKH";
            this.Text = "Quản Lý Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLKH;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblGener;
        private System.Windows.Forms.RichTextBox txtCustomerID;
        private System.Windows.Forms.RichTextBox txtFullName;
        private System.Windows.Forms.RichTextBox txtBirthday;
        private System.Windows.Forms.RichTextBox txtPhoneNumber;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.CheckBox otpMale;
        private System.Windows.Forms.CheckBox otpFemale;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGener;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
    }
}

