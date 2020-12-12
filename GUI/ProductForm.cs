using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ProductForm : Form
    {
        private bool IsAsc = true;
        public ProductForm()
        {
            InitializeComponent();
        }
        #region Cell Click
        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void DtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgProduct.SelectedRows.Count > 0)
            {
                Product_DTO dto = (Product_DTO)dtgProduct.SelectedRows[0].DataBoundItem;
                txtProductID.Text = dto.Product_id;
                txtProductName.Text = dto.Full_name;
                txtProductHard.Text = dto.Hard_drive;
                txtProductTotal.Text = dto.Total.ToString();
                cboProductColor.SelectedItem = dto.Color;
                cboProductRAM.SelectedItem = dto.Ram;
                cboProductSupplier.SelectedItem = dto.Supplier_id;

            }
        }
        #endregion
        #region Check TextBox
        private bool CheckTextbox()
        {
            if (txtProductID.Text.Equals(string.Empty))
                return false;
            return true;
        }
        #endregion
        #region Enabled
        private void EnabledTextbox(bool state) => txtProductName.Enabled = txtProductHard.Enabled = txtProductID.Enabled = txtProductTotal.Enabled = cboProductColor.Enabled = cboProductRAM.Enabled = cboProductSupplier.Enabled = dtProductDate.Enabled = state;
        private void DisabledCheckBox() => cbProductID.Checked = cbProductName.Checked = cbProductColor.Checked = cbProductTotal.Checked = false;
        private void EnabledButton(bool state) => btnProductSave.Enabled = btnProductCancel.Enabled = state;
        #endregion
        #region Save Cancel
        private void btnProductCancel_Click(object sender, EventArgs e)
        {
            EnabledTextbox(false);
            EnabledButton(false);
            btnAddProduct.Enabled = btnUpdateProduct.Enabled = btnDeleteProduct.Enabled = true;
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            EnabledTextbox(false);
            EnabledButton(false);
            btnUpdateProduct.Enabled = true;
            btnAddProduct.Enabled = true; ;
            Product_DTO dto = new Product_DTO();
            Product_BUS bus = new Product_BUS();
            dto.Color = cbProductColor.Text;
            dto.Date_of_manufacture = dtProductDate.Text;
            dto.Full_name = txtProductName.Text;
            dto.Hard_drive = txtProductHard.Text;
            dto.Ram = cboProductRAM.Text;
            dto.Product_id = txtProductID.Text;
            dto.Total = int.Parse(txtProductTotal.Text);
            dto.Supplier_id = cboProductSupplier.Text;
            if (bus.Update(dto))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        #endregion
        #region Checked
        private void cbProductID_CheckedChanged(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbProductID.Checked = true;
            SortData("id");
        }

        private void cbProductName_CheckedChanged(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbProductName.Checked = true;
            SortData("full_name");
        }

        private void cbProductColor_CheckedChanged(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbProductColor.Checked = true;
            SortData("color");
        }

        private void cbProductTotal_CheckedChanged(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbProductTotal.Checked = true;
            SortData("total");
        }
        #endregion
        #region Sort
        private void SortData(string name)
        {
            Product_BUS bus = new Product_BUS();
            List<Product_DTO> list = bus.ListSort(name, IsAsc);
            dtgProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProduct.AutoGenerateColumns = false;
            dtgProduct.MultiSelect = false;
            dtgProduct.DataSource = list;
        }
        private void btnAscProduct_Click(object sender, EventArgs e)
        {
            btnDescProduct.ForeColor = System.Drawing.Color.White;
            btnDescProduct.IconColor = System.Drawing.Color.White;
            btnDescProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            btnDescProduct.ForeColor = System.Drawing.Color.Black;
            btnDescProduct.IconColor = System.Drawing.Color.Black;
            btnDescProduct.BackColor = System.Drawing.Color.White;
            IsAsc = true;
            string id = "id";
            string full_name = "full_name";
            string color = "color";
            string total = "total";
            Product_BUS bus = new Product_BUS();
            List<Product_DTO> list = new List<Product_DTO>();
            if (cbProductID.Checked)
            {
                list = bus.ListSort(id, true);
            }
            else if (cbProductName.Checked)
            {
                list = bus.ListSort(full_name, true);
            }
            else if (cbProductColor.Checked)
            {
                list = bus.ListSort(color, true);
            }
            else if (cbProductTotal.Checked)
            {
                list = bus.ListSort(total, true);
            }
            dtgProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProduct.AutoGenerateColumns = false;
            dtgProduct.MultiSelect = false;
            dtgProduct.DataSource = list;
        }

        private void btnDescProduct_Click(object sender, EventArgs e)
        {
            IsAsc = true;
            btnDescProduct.ForeColor = System.Drawing.Color.White;
            btnDescProduct.IconColor = System.Drawing.Color.White;
            btnDescProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            btnDescProduct.ForeColor = System.Drawing.Color.Black;
            btnDescProduct.IconColor = System.Drawing.Color.Black;
            btnDescProduct.BackColor = System.Drawing.Color.White;
            string id = "id";
            string full_name = "full_name";
            string color = "color";
            string total = "total";
            Product_BUS bus = new Product_BUS();
            List<Product_DTO> list = new List<Product_DTO>();
            if (cbProductID.Checked)
            {
                list = bus.ListSort(id, false);
            }
            else if (cbProductName.Checked)
            {
                list = bus.ListSort(full_name, false);
            }
            else if (cbProductColor.Checked)
            {
                list = bus.ListSort(color, false);
            }
            else if (cbProductTotal.Checked)
            {
                list = bus.ListSort(total, false);
            }
            dtgProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProduct.AutoGenerateColumns = false;
            dtgProduct.MultiSelect = false;
            dtgProduct.DataSource = list;
        }
        #endregion
        #region Search
        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            string obj = cboProductSearch.Text;
            Product_BUS bus = new Product_BUS();
            dtgProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProduct.AutoGenerateColumns = false;
            dtgProduct.MultiSelect = false;
            List<Product_DTO> list = bus.Search(obj);
            dtgProduct.DataSource = list;
        }
        #endregion
        #region Report
        private void BtnReportProduct_Click(object sender, EventArgs e)
        {
            RptProductForm rp = new RptProductForm();
            rp.ShowDialog();
        }
        #endregion
        #region CRUD
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct fp = new FormAddProduct();
            fp.ShowDialog();
            if (fp.IsDisposed)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            Product_BUS product = new Product_BUS();
            List<Product_DTO> list = product.ListProduct();
            dtgProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProduct.AutoGenerateColumns = false;
            dtgProduct.MultiSelect = false;
            dtgProduct.DataSource = list;
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (CheckTextbox())
            {
                EnabledTextbox(true);
                EnabledButton(true);
                btnUpdateProduct.Enabled = false;
                btnAddProduct.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chọn khách hàng cần sửa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (!CheckTextbox())
            {
                MessageBox.Show("Chọn khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else if (MessageBox.Show("Chắc chắn xóa khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                string id = txtProductID.Text;
                Product_BUS bus = new Product_BUS();
                if (bus.Delete(id))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK);
                }

            }
        }
        #endregion

        private void ProductForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.N)
            {
                FormAddProduct fp = new FormAddProduct();
                fp.ShowDialog();
                if (fp.IsDisposed)
                {
                    LoadData();
                }
            }
        }
    }
}
