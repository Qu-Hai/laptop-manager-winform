namespace GUI
{
    partial class FormAddProduct
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProuctClose = new FontAwesome.Sharp.IconButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboProductRAM = new System.Windows.Forms.ComboBox();
            this.cboProductSupplier = new System.Windows.Forms.ComboBox();
            this.cboProductColor = new System.Windows.Forms.ComboBox();
            this.dtProductDate = new System.Windows.Forms.DateTimePicker();
            this.txtProductTotal = new System.Windows.Forms.TextBox();
            this.txtProductHard = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(790, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 490);
            this.panel4.TabIndex = 86;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 490);
            this.panel3.TabIndex = 85;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 10);
            this.panel2.TabIndex = 84;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 38);
            this.lblTitle.TabIndex = 60;
            this.lblTitle.Text = "Title";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAddUser.FlatAppearance.BorderSize = 5;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(16, 470);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(205, 60);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Thêm";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnProuctClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 63;
            // 
            // btnProuctClose
            // 
            this.btnProuctClose.BackColor = System.Drawing.Color.Red;
            this.btnProuctClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProuctClose.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnProuctClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnProuctClose.IconColor = System.Drawing.Color.White;
            this.btnProuctClose.IconSize = 15;
            this.btnProuctClose.Location = new System.Drawing.Point(731, 11);
            this.btnProuctClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProuctClose.Name = "btnProuctClose";
            this.btnProuctClose.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnProuctClose.Rotation = 0D;
            this.btnProuctClose.Size = new System.Drawing.Size(53, 25);
            this.btnProuctClose.TabIndex = 1;
            this.btnProuctClose.UseVisualStyleBackColor = false;
            this.btnProuctClose.Click += new System.EventHandler(this.btnProuctClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnExit.FlatAppearance.BorderSize = 5;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(579, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 60);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboProductRAM
            // 
            this.cboProductRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProductRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductRAM.FormattingEnabled = true;
            this.cboProductRAM.Items.AddRange(new object[] {
            "2GB",
            "4GB",
            "8GB",
            "12GB"});
            this.cboProductRAM.Location = new System.Drawing.Point(573, 414);
            this.cboProductRAM.Name = "cboProductRAM";
            this.cboProductRAM.Size = new System.Drawing.Size(211, 33);
            this.cboProductRAM.TabIndex = 7;
            // 
            // cboProductSupplier
            // 
            this.cboProductSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProductSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductSupplier.FormattingEnabled = true;
            this.cboProductSupplier.Items.AddRange(new object[] {
            "DELL",
            "ASSUS",
            "HP",
            "LENOVO",
            "MSI",
            "ACER",
            "APPLE",
            "RAZER",
            "SAMSUNG"});
            this.cboProductSupplier.Location = new System.Drawing.Point(573, 209);
            this.cboProductSupplier.Name = "cboProductSupplier";
            this.cboProductSupplier.Size = new System.Drawing.Size(211, 33);
            this.cboProductSupplier.TabIndex = 5;
            // 
            // cboProductColor
            // 
            this.cboProductColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProductColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProductColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProductColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductColor.FormattingEnabled = true;
            this.cboProductColor.Items.AddRange(new object[] {
            "Trắng",
            "Đen",
            "Xám",
            "Hồng",
            "Xanh",
            "Bạc",
            "Vàng",
            "Đỏ",
            "Da cam",
            "Lục",
            "Lam",
            "Chàm",
            "Tím"});
            this.cboProductColor.Location = new System.Drawing.Point(573, 308);
            this.cboProductColor.Name = "cboProductColor";
            this.cboProductColor.Size = new System.Drawing.Size(211, 33);
            this.cboProductColor.TabIndex = 6;
            // 
            // dtProductDate
            // 
            this.dtProductDate.CustomFormat = "MM/dd/yyyy";
            this.dtProductDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtProductDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtProductDate.Location = new System.Drawing.Point(573, 81);
            this.dtProductDate.Name = "dtProductDate";
            this.dtProductDate.Size = new System.Drawing.Size(211, 30);
            this.dtProductDate.TabIndex = 4;
            // 
            // txtProductTotal
            // 
            this.txtProductTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTotal.Location = new System.Drawing.Point(155, 422);
            this.txtProductTotal.Name = "txtProductTotal";
            this.txtProductTotal.Size = new System.Drawing.Size(211, 30);
            this.txtProductTotal.TabIndex = 3;
            // 
            // txtProductHard
            // 
            this.txtProductHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductHard.Location = new System.Drawing.Point(155, 305);
            this.txtProductHard.Name = "txtProductHard";
            this.txtProductHard.Size = new System.Drawing.Size(211, 30);
            this.txtProductHard.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(155, 202);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(211, 30);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(155, 76);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(211, 30);
            this.txtProductID.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 94;
            this.label9.Text = "Ổ cứng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 93;
            this.label8.Text = "RAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 92;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 91;
            this.label6.Text = "Nhà sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 90;
            this.label5.Text = "Ngày sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 89;
            this.label4.Text = "Màu sắc";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 88;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Mã sản phẩm";
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.cboProductRAM);
            this.Controls.Add(this.cboProductSupplier);
            this.Controls.Add(this.cboProductColor);
            this.Controls.Add(this.dtProductDate);
            this.Controls.Add(this.txtProductTotal);
            this.Controls.Add(this.txtProductHard);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddProduct";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnProuctClose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboProductRAM;
        private System.Windows.Forms.ComboBox cboProductSupplier;
        private System.Windows.Forms.ComboBox cboProductColor;
        private System.Windows.Forms.DateTimePicker dtProductDate;
        private System.Windows.Forms.TextBox txtProductTotal;
        private System.Windows.Forms.TextBox txtProductHard;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}