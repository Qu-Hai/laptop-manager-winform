﻿namespace GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblIDStaff = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.btnStaff = new FontAwesome.Sharp.IconButton();
            this.btnCustomers = new FontAwesome.Sharp.IconButton();
            this.btnPay = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.header = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrimary = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.header.SuspendLayout();
            this.panelPrimary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.lblIDStaff);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnChangePassword);
            this.panelMenu.Controls.Add(this.btnDown);
            this.panelMenu.Controls.Add(this.btnInfo);
            this.panelMenu.Controls.Add(this.btnStaff);
            this.panelMenu.Controls.Add(this.btnCustomers);
            this.panelMenu.Controls.Add(this.btnPay);
            this.panelMenu.Controls.Add(this.btnProduct);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 750);
            this.panelMenu.TabIndex = 0;
            // 
            // lblIDStaff
            // 
            this.lblIDStaff.AutoSize = true;
            this.lblIDStaff.ForeColor = System.Drawing.Color.White;
            this.lblIDStaff.Location = new System.Drawing.Point(134, 50);
            this.lblIDStaff.Name = "lblIDStaff";
            this.lblIDStaff.Size = new System.Drawing.Size(0, 17);
            this.lblIDStaff.TabIndex = 11;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnLogout.FlatAppearance.BorderSize = 5;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(136, 90);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(111, 39);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 5;
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(2, 90);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(128, 39);
            this.btnChangePassword.TabIndex = 9;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // btnDown
            // 
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            this.btnDown.IconColor = System.Drawing.Color.White;
            this.btnDown.IconSize = 30;
            this.btnDown.Location = new System.Drawing.Point(83, 54);
            this.btnDown.Name = "btnDown";
            this.btnDown.Rotation = 0D;
            this.btnDown.Size = new System.Drawing.Size(30, 30);
            this.btnDown.TabIndex = 8;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnInfo.IconColor = System.Drawing.Color.White;
            this.btnInfo.IconSize = 75;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 11);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInfo.Rotation = 0D;
            this.btnInfo.Size = new System.Drawing.Size(250, 73);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnStaff.IconColor = System.Drawing.Color.White;
            this.btnStaff.IconSize = 30;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 307);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Rotation = 0D;
            this.btnStaff.Size = new System.Drawing.Size(250, 50);
            this.btnStaff.TabIndex = 6;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnCustomers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnCustomers.IconColor = System.Drawing.Color.White;
            this.btnCustomers.IconSize = 30;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 253);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Rotation = 0D;
            this.btnCustomers.Size = new System.Drawing.Size(250, 50);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Khách hàng";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnPay.IconColor = System.Drawing.Color.White;
            this.btnPay.IconSize = 30;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(0, 145);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Rotation = 0D;
            this.btnPay.Size = new System.Drawing.Size(250, 50);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.btnProduct.IconColor = System.Drawing.Color.White;
            this.btnProduct.IconSize = 30;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 199);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Rotation = 0D;
            this.btnProduct.Size = new System.Drawing.Size(250, 50);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconSize = 30;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(2, 361);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Rotation = 0D;
            this.btnDashboard.Size = new System.Drawing.Size(250, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Thống kê";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.header.Controls.Add(this.btnClose);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(250, 0);
            this.header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1250, 50);
            this.header.TabIndex = 1;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconSize = 15;
            this.btnClose.Location = new System.Drawing.Point(1190, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(53, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnClose_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 5);
            this.panel1.TabIndex = 2;
            // 
            // panelPrimary
            // 
            this.panelPrimary.BackColor = System.Drawing.Color.LightGray;
            this.panelPrimary.Controls.Add(this.pictureBox1);
            this.panelPrimary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrimary.Location = new System.Drawing.Point(250, 55);
            this.panelPrimary.Name = "panelPrimary";
            this.panelPrimary.Size = new System.Drawing.Size(1250, 695);
            this.panelPrimary.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1250, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(250, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 695);
            this.panel2.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelPrimary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.header.ResumeLayout(false);
            this.panelPrimary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel header;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrimary;
        private FontAwesome.Sharp.IconButton btnPay;
        private FontAwesome.Sharp.IconButton btnCustomers;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnStaff;
        private FontAwesome.Sharp.IconButton btnInfo;
        private FontAwesome.Sharp.IconButton btnDown;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblIDStaff;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
