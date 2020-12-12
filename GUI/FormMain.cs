using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using DTO;

namespace GUI
{

    public partial class FormMain : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        private IconButton currentBtn;
        private Panel leftPanel;
        private Form currentChildForm;
        private Staff_DTO user;
        public LoginForm _lg;
        private string full_name;
        private string id;
        public FormMain(Staff_DTO user, LoginForm lg)
        {
            _lg = lg;
            InitializeComponent();
            HideButton();
            Authorization(user);
            leftPanel = new Panel();
            leftPanel.Size = new Size(5, 50);
            leftPanel.BackColor = System.Drawing.Color.White;
            panelMenu.Controls.Add(leftPanel);
            leftPanel.Visible = false;

        }
        private void Authorization(Staff_DTO user)
        {
            full_name = user.Last_name + " " + user.Firt_name;
            id =  user.Id;
            lblIDStaff.Text = "Mã NV : " + id;
            btnInfo.Text = full_name;
            if (user.Position.Equals("Nhân viên"))
            {
                btnStaff.Enabled = false;
                btnStaff.IconColor = System.Drawing.Color.Black;
            }
        }
        #region Header
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion
        #region Active Menu
        private void activeMenu(object senderButton)
        {
            if (senderButton != null)
            {
                disableActive();
                currentBtn = (IconButton)senderButton;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftPanel.Location = new Point(0, currentBtn.Location.Y);
                leftPanel.Visible = true;
                leftPanel.BringToFront();
            }
        }
        private void disableActive()
        {
            if (currentBtn != null)
            {
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void BtnProduct_Click(object sender, EventArgs e)
        {
            activeMenu(sender);
            openChildForm(new ProductForm());
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            activeMenu(sender);
            openChildForm(new DashboardForm());
        }

        private void BtnBussiness_Click(object sender, EventArgs e)
        {
            activeMenu(sender);
        }
        private void BtnPay_Click(object sender, EventArgs e)
        {
            activeMenu(sender);
            openChildForm(new PayForm(id,full_name));
        }
        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            activeMenu(sender);
            openChildForm(new CustomerForm());

        }
        private void BtnStaff_Click(object sender, EventArgs e)
        {
            activeMenu(sender);
            openChildForm(new StaffForm());
        }
        #endregion
        #region Child Form

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelPrimary.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }



        #endregion
        #region Set Buttons
        void HideButton()
        {
            btnChangePassword.Visible = false;
            btnLogout.Visible = false;
        }
        void ShowButton()
        {
            btnChangePassword.Visible = true;
            btnLogout.Visible = true;
        }
        #endregion
        private void BtnDown_Click(object sender, EventArgs e)
        {
            if (btnDown.Rotation == 0)
            {
                btnDown.Rotation = 180;
                ShowButton();
            }
            else
            {
                btnDown.Rotation = 0;
                HideButton();
            }

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn không?", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
                _lg.Show();
            }
        }

        private void BtnClose_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt == true && e.KeyCode == Keys.F4)
            {
                btnClose.PerformClick();
            }
        }
    }
}