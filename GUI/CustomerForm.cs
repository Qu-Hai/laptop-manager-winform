using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class CustomerForm : Form
    {
        private bool IsAsc = true;
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            cbCustomerID.Checked = true;
            LoadData();
        }
        #region Check Textbox
        private bool CheckTextbox()
        {
            if (txtCustomerID.Text.Equals(string.Empty))
                return false;
            return true;
        }

        #endregion
        #region Enable
        private void EnabledTextbox(bool state) => txtCustomerLastName.Enabled = txtCustomerFirstName.Enabled = txtCustomerPhone.Enabled = txtCustomerEmail.Enabled = dtCustomerDate.Enabled = cboCustomerCity.Enabled = cboCustomerGender.Enabled = state;

        private void EnabledButton(bool state) => btnSaveCustomer.Enabled = btnCancelCustomer.Enabled = state;

        private void DisabledCheckBox() => cbCustomerID.Checked = cbCustomerName.Checked = cbCustomerGender.Checked = cbCustomerDate.Checked = false;
        #endregion
        #region Cell Click
        private void DtgCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCustomer.SelectedRows.Count > 0)
            {
                Customer_DTO customer = (Customer_DTO)dtgCustomer.SelectedRows[0].DataBoundItem;
                txtCustomerID.Text = customer.Id;
                txtCustomerLastName.Text = customer.Last_name;
                txtCustomerFirstName.Text = customer.Firt_name;
                dtCustomerDate.Text = customer.Date_of_birth;
                cboCustomerCity.SelectedItem = customer.City;
                cboCustomerGender.SelectedItem = customer.Gender;
                txtCustomerPhone.Text = customer.Phone_number.ToString();
                txtCustomerEmail.Text = customer.Email;
            }
        }
        #endregion
        #region CRUD
        private void BtnCustomerAdd_Click(object sender, EventArgs e)
        {
            bool state = false;
            FormUser fu = new FormUser(state);
            fu.ShowDialog();
            if (fu.IsDisposed)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            Customer_BUS bus = new Customer_BUS();
            List<Customer_DTO> list = bus.List();
            string[] arr = bus.ListAutoComplete();
            dtgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCustomer.AutoGenerateColumns = false;
            dtgCustomer.MultiSelect = false;
            dtgCustomer.DataSource = list;
            cboCustomerSearch.DataSource = arr;
            cboCustomerSearch.SelectedIndex = -1;


        }
        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (!CheckTextbox())
            {
                MessageBox.Show("Chọn khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else if (MessageBox.Show("Chắc chắn xóa khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                string id = txtCustomerID.Text;
                Customer_BUS bus = new Customer_BUS();
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
        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (CheckTextbox())
            {
                EnabledTextbox(true);
                EnabledButton(true);
                btnUpdateCustomer.Enabled = false;
                btnAddCustomer.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chọn khách hàng cần sửa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        #endregion
        #region Save Cancel
        private void BtnCancelCustomer_Click(object sender, EventArgs e)
        {
            EnabledTextbox(false);
            EnabledButton(false);
            btnDeleteCustomer.Enabled = btnAddCustomer.Enabled = btnUpdateCustomer.Enabled = true;
        }

        private void BtnSaveCustomer_Click(object sender, EventArgs e)
        {
            EnabledTextbox(false);
            EnabledButton(false);
            btnUpdateCustomer.Enabled = true;
            btnAddCustomer.Enabled = true; ;
            Customer_DTO dto = new Customer_DTO();
            Customer_BUS bus = new Customer_BUS();
            dto.Id = txtCustomerID.Text;
            dto.Last_name = txtCustomerLastName.Text;
            dto.Firt_name = txtCustomerFirstName.Text;
            dto.Date_of_birth = dtCustomerDate.Text;
            dto.City = cboCustomerCity.Text;
            dto.Gender = cboCustomerGender.Text;
            dto.Phone_number = txtCustomerPhone.Text;
            dto.Email = txtCustomerEmail.Text;
            if (bus.Update(dto))
            {
                MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng thất bại", "Thông báo", MessageBoxButtons.OK);
                LoadData();
            }
        }
        #endregion
        #region Event Click Check Box
        private void CbCustomerID_Click(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbCustomerID.Checked = true;
            SortData("id");
        }

        private void CbCustomerName_Click(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbCustomerName.Checked = true;
            SortData("firt_name");
        }

        private void CbCustomerGender_Click(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbCustomerGender.Checked = true;
            SortData("gender");
        }

        private void CbCustomerDate_Click(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbCustomerDate.Checked = true;
            SortData("date");
        }
        #endregion
        #region Sort
        private void SortData(string name)
        {
            Customer_BUS bus = new Customer_BUS();
            List<Customer_DTO> list = bus.ListSort(name, IsAsc);
            dtgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCustomer.AutoGenerateColumns = false;
            dtgCustomer.MultiSelect = false;
            dtgCustomer.DataSource = list;
        }
        #endregion
        #region Button Sort
        private void BtnAscCustomer_Click(object sender, EventArgs e)
        {
            btnDescCustomer.ForeColor = System.Drawing.Color.White;
            btnDescCustomer.IconColor = System.Drawing.Color.White;
            btnDescCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            btnAscCustomer.ForeColor = System.Drawing.Color.Black;
            btnAscCustomer.IconColor = System.Drawing.Color.Black;
            btnAscCustomer.BackColor = System.Drawing.Color.White;
            IsAsc = true;
            string gender = "gender";
            string firt_name = "firt_name";
            string date = "date";
            string id = "id";
            Customer_BUS bus = new Customer_BUS();
            List<Customer_DTO> list = new List<Customer_DTO>();
            if (cbCustomerGender.Checked)
            {
                list = bus.ListSort(gender, true);
            }
            else if (cbCustomerDate.Checked)
            {
                list = bus.ListSort(date, true);
            }
            else if (cbCustomerName.Checked)
            {
                list = bus.ListSort(firt_name, true);
            }
            else if (cbCustomerID.Checked)
            {
                list = bus.ListSort(id, true);
            }
            dtgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCustomer.AutoGenerateColumns = false;
            dtgCustomer.MultiSelect = false;
            dtgCustomer.DataSource = list;
        }

        private void BtnDescCustomer_Click(object sender, EventArgs e)
        {
            IsAsc = false;
            btnAscCustomer.ForeColor = System.Drawing.Color.White;
            btnAscCustomer.IconColor = System.Drawing.Color.White;
            btnAscCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            btnDescCustomer.ForeColor = System.Drawing.Color.Black;
            btnDescCustomer.IconColor = System.Drawing.Color.Black;
            btnDescCustomer.BackColor = System.Drawing.Color.White;
            string gender = "gender";
            string firt_name = "firt_name";
            string date = "date";
            string id = "id";
            Customer_BUS bus = new Customer_BUS();
            List<Customer_DTO> list = new List<Customer_DTO>();
            if (cbCustomerGender.Checked)
            {
                list = bus.ListSort(gender, false);
            }
            else if (cbCustomerDate.Checked)
            {
                list = bus.ListSort(date, false);
            }
            else if (cbCustomerName.Checked)
            {
                list = bus.ListSort(firt_name, false);
            }
            else if (cbCustomerID.Checked)
            {
                list = bus.ListSort(id, false);
            }
            dtgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCustomer.AutoGenerateColumns = false;
            dtgCustomer.MultiSelect = false;
            dtgCustomer.DataSource = list;
        }
        #endregion
        #region Button Search
        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            string obj = cboCustomerSearch.Text;
            Customer_BUS bus = new Customer_BUS();
            List<Customer_DTO> list = bus.Search(obj);
            dtgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCustomer.AutoGenerateColumns = false;
            dtgCustomer.MultiSelect = false;
            dtgCustomer.DataSource = list;
        }
        #endregion
        #region Report
        private void Button1_Click(object sender, EventArgs e)
        {
            
            RptCustomerForm rc = new RptCustomerForm();
            rc.ShowDialog();
        }
        #endregion
    }

}
