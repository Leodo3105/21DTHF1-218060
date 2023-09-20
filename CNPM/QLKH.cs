using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmQLKH : DevExpress.XtraEditors.XtraForm
    {
        public frmQLKH()
        {
            InitializeComponent();
        }

        private int GetSelectedRow(string customerID)
        {
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                if (dgvCustomer.Rows[i].Cells[0].Value.ToString() == customerID)
                    return i;
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvCustomer.Rows[selectedRow].Cells[0].Value = txtCustomerID.Text;
            dgvCustomer.Rows[selectedRow].Cells[1].Value = txtFullName.Text;
            dgvCustomer.Rows[selectedRow].Cells[2].Value = otpFemale.Checked ? "Nữ" : "Nam";
            dgvCustomer.Rows[selectedRow].Cells[3].Value = txtBirthday.Text;
            dgvCustomer.Rows[selectedRow].Cells[4].Value = txtPhoneNumber.Text;
            dgvCustomer.Rows[selectedRow].Cells[4].Value = txtAddress.Text;
        }
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerID.Text == "" || txtFullName.Text == "" || txtBirthday.Text == "" || txtPhoneNumber.Text == "" || txtAddress.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin khách hàng!");
                if (txtCustomerID.Text.Length > 10)
                {
                    throw new Exception("Mã số khách hàng không hợp lệ ");
                }
                if (!(txtFullName.Text.Length >= 3 && txtFullName.Text.Length < 100))
                {
                    throw new Exception("Vui lòng nhập đầy đủ họ tên");
                }
                if (!(txtAddress.Text.Length >= 3 && txtAddress.Text.Length < 100))
                {
                    throw new Exception("Vui lòng nhập đầy đủ đại chỉ");
                }
                int selectedRow = GetSelectedRow(txtCustomerID.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvCustomer.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtCustomerID.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy Mã KH cần xoá!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvCustomer.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xoá khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
            
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvCustomer.CurrentRow.Selected = true;
                    txtCustomerID.Text = dgvCustomer.Rows[e.RowIndex].Cells["dgvCustomerID"].FormattedValue.ToString();
                    txtFullName.Text = dgvCustomer.Rows[e.RowIndex].Cells["dgvFullName"].FormattedValue.ToString();
                    txtBirthday.Text = dgvCustomer.Rows[e.RowIndex].Cells["dgvBirthday"].FormattedValue.ToString();
                    txtPhoneNumber.Text = dgvCustomer.Rows[e.RowIndex].Cells["dgvPhoneNumber"].FormattedValue.ToString();
                    txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells["dgvAddress"].FormattedValue.ToString();
                    if (dgvCustomer.Rows[e.RowIndex].Cells["dgvGener"].FormattedValue.ToString() == "Nữ")
                    {
                        otpFemale.Checked = true;
                    }
                    else
                    {
                        otpMale.Checked = true;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblQLKH_Click(object sender, EventArgs e)
        {

        }
    }
}
