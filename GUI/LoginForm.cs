using System.Windows.Forms;

using System.Drawing;
using BCrypt.Net;
using BUS;
using DTO;

namespace GUI
{
    public partial class LoginForm : Form
    {
        private bool drag = false;
        Point start_point = new Point(0, 0);
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            this.KeyPreview = true;
        }
        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        #region Drag and drop
        private void HeaderLogin_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void HeaderLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void HeaderLogin_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion
        #region EventClick
        private void TxtUsername_Click(object sender, System.EventArgs e)
        {

            if (txtUsername.Text.Equals("Username"))
            {
                txtUsername.Text = "";
                
            }

        }

        private void TxtPassword_Click(object sender, System.EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }else if (txtPassword.Text.Equals(string.Empty))
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void Txt_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        #endregion
        private void BtnLogin(object sender, System.EventArgs e)
        {

            if (txtUsername.Text != "Username" && txtPassword.Text != "Password")
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                //string hashed = BCrypt.Net.BCrypt.HashPassword(password, 12);
                Staff_BUS bus = new Staff_BUS();
                Staff_DTO user = bus.Login(username);
                if (user.Username == null)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool verify = BCrypt.Net.BCrypt.Verify(password, user.Password);
                    if (verify)
                    {
                        LoginForm lg = this;
                        FormMain fm = new FormMain(user, lg);
                        this.Hide();
                        fm.Show();
                        txtPassword.Text = string.Empty;
   
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng. Nhập lại", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Text = "";
                    }
                }
            }
            if (txtUsername.Text == "Username" && txtPassword.Text == "Password")
            {
                txtNTFU.Visible = true;
                txtNTFP.Visible = true;
            }
            else if (txtUsername.Text == "Username")
            {
                txtNTFU.Visible = true;
            }
            else if (txtPassword.Text == "Password")
            {
                txtNTFP.Visible = true;
            }

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnLogin.PerformClick();
            } 

        }
    }
}
