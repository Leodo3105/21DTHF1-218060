using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmQLSP : Form
    {
        public frmQLSP()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private int GetSelectedRow(string productID)
        {
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                if (dgvProduct.Rows[i].Cells[0].Value.ToString() == productID)
                    return i;
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvProduct.Rows[selectedRow].Cells[0].Value = txtProductID.Text;
            dgvProduct.Rows[selectedRow].Cells[0].Value = cmbProductTypeID.Text;
            dgvProduct.Rows[selectedRow].Cells[1].Value = txtProductName.Text;
            dgvProduct.Rows[selectedRow].Cells[3].Value = txtProductStatus.Text;
            dgvProduct.Rows[selectedRow].Cells[4].Value = txtProductPrice.Text;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text == "" || txtProductName.Text == "" || txtProductStatus.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                if (txtProductID.Text.Length > 10 && txtProductID.Text == "")
                {
                    throw new Exception("Mã sản phẩm không hợp lệ ");
                }
                if (!(txtProductName.Text.Length >= 3 && txtProductName.Text.Length < 100))
                {
                    throw new Exception("Vui lòng nhập đầy đủ tên sản phẩm");
                }
                if(!(txtProductStatus.Text.Length >= 3 && txtProductStatus.Text.Length < 100))
                {
                    throw new Exception("Vui lòng nhập đầy đủ tình trạng sản phẩm");
                }
                if (float.Parse(txtProductPrice.Text) < 0)
                {
                    throw new Exception("Vui lòng nhập đầy đủ đơn giá cảu sản phẩm");
                }
                int selectedRow = GetSelectedRow(txtProductID.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvProduct.Rows.Add();
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

        private void lblQLSP_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtProductID.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy mã SP cần xoá!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvProduct.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xoá sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvProduct.CurrentRow.Selected = true;
                    txtProductID.Text = dgvProduct.Rows[e.RowIndex].Cells["dgvProductID"].FormattedValue.ToString();
                    cmbProductTypeID.SelectedItem = dgvProduct.Rows[e.RowIndex].Cells["dgvProductTyperID"].FormattedValue.ToString();
                    txtProductName.Text = dgvProduct.Rows[e.RowIndex].Cells["dgvProductName"].FormattedValue.ToString();
                    txtProductStatus.Text = dgvProduct.Rows[e.RowIndex].Cells["dgvProductStatus"].FormattedValue.ToString();
                    txtProductPrice.Text = dgvProduct.Rows[e.RowIndex].Cells["dgvProductPrice"].FormattedValue.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
