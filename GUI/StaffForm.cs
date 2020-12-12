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
    public partial class StaffForm : Form
    {
        private bool IsAsc = true;
        public StaffForm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            Staff_BUS staff = new Staff_BUS();
            List<Staff_DTO> list = staff.ListStaff();
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.MultiSelect = false;
            dgvStaff.DataSource = list;
            string[] arr = staff.ListAutoComplete();
            cboStaffSearch.DataSource = arr;
            cboStaffSearch.SelectedIndex = -1;
        }

        #region Check Textbox
        private bool CheckTextbox()
        {
            if (txtStaffID.Text.Equals(string.Empty))
                return false;
            return true;
        }

        #endregion
        #region Enable
        private void EnabledTextbox(bool state) => txtStaffLastName.Enabled = txtStaffFirstName.Enabled = txtStaffPhone.Enabled = txtStaffEmail.Enabled = dtStaffDate.Enabled = cboStaffCity.Enabled = cboStaffGender.Enabled = cboPosition.Enabled = state;

        private void EnabledButton(bool state) => btnSaveStaff.Enabled = btnCancelStaff.Enabled = state;

        private void DisabledCheckBox() => cbStaffID.Checked = cbStaffName.Checked = cbStaffGender.Checked = cbStaffDate.Checked = false;
        #endregion
        #region Cell Click
        private void DgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                Staff_DTO staff = (Staff_DTO)dgvStaff.SelectedRows[0].DataBoundItem;
                txtStaffID.Text = staff.Id;
                txtStaffLastName.Text = staff.Last_name;
                txtStaffFirstName.Text = staff.Firt_name;
                dtStaffDate.Text = staff.Date_of_birth;
                cboStaffCity.SelectedItem = staff.City;
                cboStaffGender.SelectedItem = staff.Gender;
                cboPosition.SelectedItem = staff.Position;
                txtStaffPhone.Text = staff.Phone_number.ToString();
                txtStaffEmail.Text = staff.Email;
            }
        }
        #endregion
        #region CRUD
        private void BtnStaffAdd_Click(object sender, EventArgs e)
        {
            bool state = true;
            FormUser fu = new FormUser(state);
            fu.ShowDialog();
            if (fu.IsDisposed)
            {
                LoadData();
            }
        }
        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void BtnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (!CheckTextbox())
            {
                MessageBox.Show("Chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else if (MessageBox.Show("Chắc chắn xóa nhân viên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                string id = txtStaffID.Text;
                Staff_BUS bus = new Staff_BUS();
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
        private void BtnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (CheckTextbox())
            {
                EnabledTextbox(true);
                EnabledButton(true);
                btnUpdateStaff.Enabled = false;
                btnAddStaff.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chọn nhân viên cần sửa", "Thông báo", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Save Cancel
        private void BtnCancelStaff_Click(object sender, EventArgs e)
        {
            EnabledTextbox(false);
            EnabledButton(false);
            btnDeleteStaff.Enabled = btnAddStaff.Enabled = btnUpdateStaff.Enabled = true;
        }

        private void BtnSaveStaff_Click(object sender, EventArgs e)
        {
            EnabledTextbox(false);
            EnabledButton(false);
            btnUpdateStaff.Enabled = true;
            btnAddStaff.Enabled = true; ;
            Staff_DTO dto = new Staff_DTO();
            Staff_BUS bus = new Staff_BUS();
            dto.Id = txtStaffID.Text;
            dto.Last_name = txtStaffLastName.Text;
            dto.Firt_name = txtStaffFirstName.Text;
            dto.Date_of_birth = dtStaffDate.Text;
            dto.City = cboStaffCity.Text;
            dto.Gender = cboStaffGender.Text;
            dto.Phone_number = txtStaffPhone.Text;
            dto.Email = txtStaffEmail.Text;
            dto.Position = cboPosition.Text;
            if (bus.Update(dto))
            {
                MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
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
        private void CbStaffID_Click(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbStaffID.Checked = true;
            SortData("id");
        }

        private void CbStaffName_Click(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbStaffName.Checked = true;
            SortData("firt_name");
        }

        private void CbStaffGender_Click(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbStaffGender.Checked = true;
            SortData("gender");
        }

        private void CbStaffDate_Click(object sender, EventArgs e)
        {
            DisabledCheckBox();
            cbStaffDate.Checked = true;
            SortData("date");
        }
        #endregion
        #region Sort
        private void SortData(string name)
        {
            Staff_BUS bus = new Staff_BUS();
            List<Staff_DTO> list = bus.ListSort(name, IsAsc);
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.MultiSelect = false;
            dgvStaff.DataSource = list;
        }
        #endregion
        #region Button Sort
        private void BtnAscStaff_Click(object sender, EventArgs e)
        {
            btnDescStaff.ForeColor = System.Drawing.Color.White;
            btnDescStaff.IconColor = System.Drawing.Color.White;
            btnDescStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            btnAscStaff.ForeColor = System.Drawing.Color.Black;
            btnAscStaff.IconColor = System.Drawing.Color.Black;
            btnAscStaff.BackColor = System.Drawing.Color.White;
            IsAsc = true;
            string gender = "gender";
            string firt_name = "firt_name";
            string date = "date";
            string id = "id";
            Staff_BUS bus = new Staff_BUS();
            List<Staff_DTO> list = new List<Staff_DTO>();
            if (cbStaffGender.Checked)
            {
                list = bus.ListSort(gender, true);
            }
            else if (cbStaffDate.Checked)
            {
                list = bus.ListSort(date, true);
            }
            else if (cbStaffName.Checked)
            {
                list = bus.ListSort(firt_name, true);
            }
            else if (cbStaffID.Checked)
            {
                list = bus.ListSort(id, true);
            }
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.MultiSelect = false;
            dgvStaff.DataSource = list;
        }

        private void BtnDescStaff_Click(object sender, EventArgs e)
        {
            IsAsc = false;
            btnAscStaff.ForeColor = System.Drawing.Color.White;
            btnAscStaff.IconColor = System.Drawing.Color.White;
            btnAscStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            btnDescStaff.ForeColor = System.Drawing.Color.Black;
            btnDescStaff.IconColor = System.Drawing.Color.Black;
            btnDescStaff.BackColor = System.Drawing.Color.White;
            string gender = "gender";
            string firt_name = "firt_name";
            string date = "date";
            string id = "id";
            Staff_BUS bus = new Staff_BUS();
            List<Staff_DTO> list = new List<Staff_DTO>();
            if (cbStaffGender.Checked)
            {
                list = bus.ListSort(gender, false);
            }
            else if (cbStaffDate.Checked)
            {
                list = bus.ListSort(date, false);
            }
            else if (cbStaffName.Checked)
            {
                list = bus.ListSort(firt_name, false);
            }
            else if (cbStaffID.Checked)
            {
                list = bus.ListSort(id, false);
            }
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.MultiSelect = false;
            dgvStaff.DataSource = list;
        }
        #endregion
        #region Button Search
        private void BtnStaffSearch_Click(object sender, EventArgs e)
        {
            string obj = cboStaffSearch.Text;
            Staff_BUS bus = new Staff_BUS();
            List<Staff_DTO> list = bus.Search(obj);
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.MultiSelect = false;
            dgvStaff.DataSource = list;
        }
        #endregion
        #region Report
        private void BtnReportStaff_Click(object sender, EventArgs e)
        {
            RptStaffForm rpt = new RptStaffForm();
            rpt.ShowDialog();
        }
        #endregion
    }
}