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
    public partial class FormUser : Form
    {
        private bool _state;
        public FormUser(bool state)
        {
            _state = state;
            InitializeComponent();
            LoadData();
            
        }

        void LoadData()
        {
            
            if (!_state)
            {
                lblTitle.Text = "Thêm khách hàng";
            }
            else
            {
                lblTitle.Text = "Đăng ký nhân viên";
                lblUN.Visible = txtUN.Visible = txtPW.Visible = lblPW.Visible = true;
            }
                ProviderID();        
            cboCity.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
        }
        private void ProviderID()
        {
            string id;
            string index;

            if (!_state)
            {
                Customer_BUS bus = new Customer_BUS();
                index = (bus.CountID() + 1).ToString();
                id = "KH" + index;
                txtID.Text = id;
            }
            else if (_state)
            {
                Staff_BUS bus = new Staff_BUS();
                index = (bus.CountID() + 1).ToString();
                id = "NV" + index;
                txtID.Text = id;
            }
        }
        #region Validate Email
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        void InsertCustomer()
        {
            if (!_state)
            {
                Customer_DTO dto = new Customer_DTO();
                Customer_BUS bus = new Customer_BUS();
                dto.Id = txtID.Text;
                dto.Last_name = txtLastName.Text;
                dto.Firt_name = txtFirstName.Text;
                dto.Date_of_birth = dtDate.Text;
                dto.City = cboCity.Text;
                dto.Gender = cboGender.Text;
                dto.Phone_number = txtPhone.Text;
                dto.Email = txtEmail.Text;               
                bus.Insert(dto);
            }
            else
            {
                Staff_DTO dto = new Staff_DTO();
                Staff_BUS bus = new Staff_BUS();
                dto.Id = txtID.Text;
                dto.Last_name = txtLastName.Text;
                dto.Firt_name = txtFirstName.Text;
                dto.Date_of_birth = dtDate.Text;
                dto.City = cboCity.Text;
                dto.Gender = cboGender.Text;
                dto.Phone_number = txtPhone.Text;
                dto.Email = txtEmail.Text;
                dto.Username = txtUN.Text;
                dto.Password = txtPW.Text;
                bus.Insert(dto);
            }
        }
        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            InsertCustomer();
            this.Dispose();
        }
        private void TxtEmail_MouseLeave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (email.Equals(string.Empty))
            {
                lblValidateEmail.Visible = false;
            }
            else if (!IsValidEmail(email))
            {
                lblValidateEmail.Visible = true;
            }
            else
            {
                lblValidateEmail.Visible = false;
            }
        }

        private void TxtUN_Click(object sender, EventArgs e)
        {
            if(txtUN.Text.Equals(string.Empty)&& txtEmail.Text != string.Empty&& IsValidEmail(txtEmail.Text))
            {
                txtUN.Text = txtEmail.Text.Split('@')[0];
            }
        }
    }
}
