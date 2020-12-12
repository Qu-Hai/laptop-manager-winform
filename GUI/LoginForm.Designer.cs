namespace GUI
{
    partial class LoginForm
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
            this.HeaderLogin = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtNTFU = new System.Windows.Forms.Label();
            this.txtNTFP = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.circularBox1 = new GUI.CircularBox();
            this.HeaderLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLogin
            // 
            this.HeaderLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.HeaderLogin.Controls.Add(this.btnClose);
            this.HeaderLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderLogin.Location = new System.Drawing.Point(0, 0);
            this.HeaderLogin.Name = "HeaderLogin";
            this.HeaderLogin.Size = new System.Drawing.Size(450, 50);
            this.HeaderLogin.TabIndex = 0;
            this.HeaderLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderLogin_MouseDown);
            this.HeaderLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderLogin_MouseMove);
            this.HeaderLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderLogin_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconSize = 15;
            this.btnClose.Location = new System.Drawing.Point(385, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(53, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(89, 281);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(315, 30);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.TxtUsername_Click);
            this.txtUsername.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_MouseDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(89, 354);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(315, 30);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Click += new System.EventHandler(this.TxtPassword_Click);
            this.txtPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_MouseDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnLogin.FlatAppearance.BorderSize = 5;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(18, 484);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(420, 60);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin);
            // 
            // txtNTFU
            // 
            this.txtNTFU.AutoSize = true;
            this.txtNTFU.ForeColor = System.Drawing.Color.Red;
            this.txtNTFU.Location = new System.Drawing.Point(89, 314);
            this.txtNTFU.Name = "txtNTFU";
            this.txtNTFU.Size = new System.Drawing.Size(203, 17);
            this.txtNTFU.TabIndex = 14;
            this.txtNTFU.Text = "Vui lòng điền đầy đủ thông tin !";
            this.txtNTFU.Visible = false;
            // 
            // txtNTFP
            // 
            this.txtNTFP.AutoSize = true;
            this.txtNTFP.ForeColor = System.Drawing.Color.Red;
            this.txtNTFP.Location = new System.Drawing.Point(89, 387);
            this.txtNTFP.Name = "txtNTFP";
            this.txtNTFP.Size = new System.Drawing.Size(203, 17);
            this.txtNTFP.TabIndex = 15;
            this.txtNTFP.Text = "Vui lòng điền đầy đủ thông tin !";
            this.txtNTFP.Visible = false;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(45, 346);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(38, 38);
            this.iconButton3.TabIndex = 12;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(45, 273);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(38, 38);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // circularBox1
            // 
            this.circularBox1.BackColor = System.Drawing.Color.White;
            this.circularBox1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.circularBox1.FlatAppearance.BorderSize = 0;
            this.circularBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.circularBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.circularBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.circularBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.circularBox1.IconSize = 100;
            this.circularBox1.Location = new System.Drawing.Point(153, 76);
            this.circularBox1.Name = "circularBox1";
            this.circularBox1.Rotation = 0D;
            this.circularBox1.Size = new System.Drawing.Size(150, 150);
            this.circularBox1.TabIndex = 8;
            this.circularBox1.TabStop = false;
            this.circularBox1.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(450, 572);
            this.Controls.Add(this.txtNTFP);
            this.Controls.Add(this.txtNTFU);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.circularBox1);
            this.Controls.Add(this.HeaderLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.HeaderLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderLogin;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnClose;
        private CircularBox circularBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label txtNTFU;
        private System.Windows.Forms.Label txtNTFP;
    }
}