namespace GUI
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCustomerDate = new System.Windows.Forms.CheckBox();
            this.cbCustomerID = new System.Windows.Forms.CheckBox();
            this.cbCustomerGender = new System.Windows.Forms.CheckBox();
            this.cbCustomerName = new System.Windows.Forms.CheckBox();
            this.cboCustomerSearch = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.btnCancelCustomer = new System.Windows.Forms.Button();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboCustomerCity = new System.Windows.Forms.ComboBox();
            this.dtCustomerDate = new System.Windows.Forms.DateTimePicker();
            this.cboCustomerGender = new System.Windows.Forms.ComboBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.btnCustomerSearch = new FontAwesome.Sharp.IconButton();
            this.btnAscCustomer = new FontAwesome.Sharp.IconButton();
            this.btnDescCustomer = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCustomerSearch);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cboCustomerSearch);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 106);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(490, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Báo cáo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.cbCustomerDate);
            this.groupBox1.Controls.Add(this.cbCustomerID);
            this.groupBox1.Controls.Add(this.cbCustomerGender);
            this.groupBox1.Controls.Add(this.btnAscCustomer);
            this.groupBox1.Controls.Add(this.cbCustomerName);
            this.groupBox1.Controls.Add(this.btnDescCustomer);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // cbCustomerDate
            // 
            this.cbCustomerDate.AutoSize = true;
            this.cbCustomerDate.Location = new System.Drawing.Point(216, 30);
            this.cbCustomerDate.Name = "cbCustomerDate";
            this.cbCustomerDate.Size = new System.Drawing.Size(93, 21);
            this.cbCustomerDate.TabIndex = 11;
            this.cbCustomerDate.Text = "Ngày sinh";
            this.cbCustomerDate.UseVisualStyleBackColor = true;
            this.cbCustomerDate.Click += new System.EventHandler(this.CbCustomerDate_Click);
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.AutoSize = true;
            this.cbCustomerID.Location = new System.Drawing.Point(6, 30);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(43, 21);
            this.cbCustomerID.TabIndex = 8;
            this.cbCustomerID.Text = "ID";
            this.cbCustomerID.UseVisualStyleBackColor = true;
            this.cbCustomerID.Click += new System.EventHandler(this.CbCustomerID_Click);
            // 
            // cbCustomerGender
            // 
            this.cbCustomerGender.AutoSize = true;
            this.cbCustomerGender.Location = new System.Drawing.Point(128, 30);
            this.cbCustomerGender.Name = "cbCustomerGender";
            this.cbCustomerGender.Size = new System.Drawing.Size(82, 21);
            this.cbCustomerGender.TabIndex = 10;
            this.cbCustomerGender.Text = "Giới tính";
            this.cbCustomerGender.UseVisualStyleBackColor = true;
            this.cbCustomerGender.Click += new System.EventHandler(this.CbCustomerGender_Click);
            // 
            // cbCustomerName
            // 
            this.cbCustomerName.AutoSize = true;
            this.cbCustomerName.Location = new System.Drawing.Point(67, 30);
            this.cbCustomerName.Name = "cbCustomerName";
            this.cbCustomerName.Size = new System.Drawing.Size(55, 21);
            this.cbCustomerName.TabIndex = 9;
            this.cbCustomerName.Text = "Tên";
            this.cbCustomerName.UseVisualStyleBackColor = true;
            this.cbCustomerName.Click += new System.EventHandler(this.CbCustomerName_Click);
            // 
            // cboCustomerSearch
            // 
            this.cboCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerSearch.FormattingEnabled = true;
            this.cboCustomerSearch.Location = new System.Drawing.Point(490, 15);
            this.cboCustomerSearch.Name = "cboCustomerSearch";
            this.cboCustomerSearch.Size = new System.Drawing.Size(254, 28);
            this.cboCustomerSearch.TabIndex = 16;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAddCustomer.FlatAppearance.BorderSize = 5;
            this.btnAddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(8, 444);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(420, 60);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Thêm khách hàng";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnCustomerAdd_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnUpdateCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUpdateCustomer.FlatAppearance.BorderSize = 5;
            this.btnUpdateCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnUpdateCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(8, 510);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(205, 60);
            this.btnUpdateCustomer.TabIndex = 1;
            this.btnUpdateCustomer.Text = "Sửa";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnDeleteCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDeleteCustomer.FlatAppearance.BorderSize = 5;
            this.btnDeleteCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnDeleteCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(223, 510);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(205, 60);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSaveCustomer.Enabled = false;
            this.btnSaveCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSaveCustomer.FlatAppearance.BorderSize = 5;
            this.btnSaveCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSaveCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSaveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCustomer.Location = new System.Drawing.Point(8, 576);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(205, 60);
            this.btnSaveCustomer.TabIndex = 3;
            this.btnSaveCustomer.Text = "Lưu";
            this.btnSaveCustomer.UseVisualStyleBackColor = false;
            this.btnSaveCustomer.Click += new System.EventHandler(this.BtnSaveCustomer_Click);
            // 
            // btnCancelCustomer
            // 
            this.btnCancelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnCancelCustomer.Enabled = false;
            this.btnCancelCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnCancelCustomer.FlatAppearance.BorderSize = 5;
            this.btnCancelCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnCancelCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnCancelCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCustomer.Location = new System.Drawing.Point(223, 576);
            this.btnCancelCustomer.Name = "btnCancelCustomer";
            this.btnCancelCustomer.Size = new System.Drawing.Size(205, 60);
            this.btnCancelCustomer.TabIndex = 4;
            this.btnCancelCustomer.Text = "Hủy";
            this.btnCancelCustomer.UseVisualStyleBackColor = false;
            this.btnCancelCustomer.Click += new System.EventHandler(this.BtnCancelCustomer_Click);
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelInput.Controls.Add(this.panel2);
            this.panelInput.Controls.Add(this.btnCancelCustomer);
            this.panelInput.Controls.Add(this.btnSaveCustomer);
            this.panelInput.Controls.Add(this.btnDeleteCustomer);
            this.panelInput.Controls.Add(this.btnUpdateCustomer);
            this.panelInput.Controls.Add(this.btnAddCustomer);
            this.panelInput.ForeColor = System.Drawing.Color.White;
            this.panelInput.Location = new System.Drawing.Point(810, 4);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(435, 685);
            this.panelInput.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboCustomerCity);
            this.panel2.Controls.Add(this.dtCustomerDate);
            this.panel2.Controls.Add(this.cboCustomerGender);
            this.panel2.Controls.Add(this.txtCustomerPhone);
            this.panel2.Controls.Add(this.txtCustomerEmail);
            this.panel2.Controls.Add(this.txtCustomerLastName);
            this.panel2.Controls.Add(this.txtCustomerFirstName);
            this.panel2.Controls.Add(this.txtCustomerID);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 435);
            this.panel2.TabIndex = 5;
            // 
            // cboCustomerCity
            // 
            this.cboCustomerCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomerCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomerCity.Enabled = false;
            this.cboCustomerCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerCity.FormattingEnabled = true;
            this.cboCustomerCity.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bạc Liêu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Dương",
            "Bình Định",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Cần Thơ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Đồng Nai",
            "Đồng Tháp",
            "Điện Biên",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hòa Bình",
            "Hậu Giang",
            "Hưng Yên",
            "Thành phố Hồ Chí Minh",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lào Cai",
            "Lạng Sơn",
            "Lâm Đồng",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên - Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cboCustomerCity.Location = new System.Drawing.Point(180, 221);
            this.cboCustomerCity.Margin = new System.Windows.Forms.Padding(4);
            this.cboCustomerCity.Name = "cboCustomerCity";
            this.cboCustomerCity.Size = new System.Drawing.Size(247, 33);
            this.cboCustomerCity.TabIndex = 16;
            // 
            // dtCustomerDate
            // 
            this.dtCustomerDate.CustomFormat = "MM/dd/yyyy";
            this.dtCustomerDate.Enabled = false;
            this.dtCustomerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCustomerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCustomerDate.Location = new System.Drawing.Point(180, 170);
            this.dtCustomerDate.Name = "dtCustomerDate";
            this.dtCustomerDate.Size = new System.Drawing.Size(248, 30);
            this.dtCustomerDate.TabIndex = 15;
            // 
            // cboCustomerGender
            // 
            this.cboCustomerGender.Enabled = false;
            this.cboCustomerGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCustomerGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerGender.FormattingEnabled = true;
            this.cboCustomerGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboCustomerGender.Location = new System.Drawing.Point(180, 275);
            this.cboCustomerGender.Name = "cboCustomerGender";
            this.cboCustomerGender.Size = new System.Drawing.Size(248, 33);
            this.cboCustomerGender.TabIndex = 14;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Enabled = false;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(180, 383);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(248, 30);
            this.txtCustomerPhone.TabIndex = 12;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Enabled = false;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.Location = new System.Drawing.Point(180, 329);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(248, 30);
            this.txtCustomerEmail.TabIndex = 11;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Enabled = false;
            this.txtCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerLastName.Location = new System.Drawing.Point(180, 59);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(248, 30);
            this.txtCustomerLastName.TabIndex = 10;
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Enabled = false;
            this.txtCustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerFirstName.Location = new System.Drawing.Point(180, 113);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(248, 30);
            this.txtCustomerFirstName.TabIndex = 9;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(180, 5);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(248, 30);
            this.txtCustomerID.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tỉnh, thành phố";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ, tên đệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // dtgCustomer
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column9});
            this.dtgCustomer.Location = new System.Drawing.Point(12, 116);
            this.dtgCustomer.Name = "dtgCustomer";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCustomer.RowHeadersWidth = 51;
            this.dtgCustomer.RowTemplate.Height = 24;
            this.dtgCustomer.Size = new System.Drawing.Size(790, 575);
            this.dtgCustomer.TabIndex = 5;
            this.dtgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgCustomer_CellClick_1);
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnCustomerSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCustomerSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCustomerSearch.IconColor = System.Drawing.Color.Black;
            this.btnCustomerSearch.IconSize = 16;
            this.btnCustomerSearch.Location = new System.Drawing.Point(700, 15);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Rotation = 0D;
            this.btnCustomerSearch.Size = new System.Drawing.Size(75, 28);
            this.btnCustomerSearch.TabIndex = 17;
            this.btnCustomerSearch.Text = "Tìm kiếm";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.BtnCustomerSearch_Click);
            // 
            // btnAscCustomer
            // 
            this.btnAscCustomer.BackColor = System.Drawing.Color.White;
            this.btnAscCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAscCustomer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAscCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnAscCustomer.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUpAlt;
            this.btnAscCustomer.IconColor = System.Drawing.Color.Black;
            this.btnAscCustomer.IconSize = 30;
            this.btnAscCustomer.Location = new System.Drawing.Point(315, 23);
            this.btnAscCustomer.Name = "btnAscCustomer";
            this.btnAscCustomer.Rotation = 0D;
            this.btnAscCustomer.Size = new System.Drawing.Size(50, 50);
            this.btnAscCustomer.TabIndex = 6;
            this.btnAscCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAscCustomer.UseVisualStyleBackColor = false;
            this.btnAscCustomer.Click += new System.EventHandler(this.BtnAscCustomer_Click);
            // 
            // btnDescCustomer
            // 
            this.btnDescCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnDescCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescCustomer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDescCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDescCustomer.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDownAlt;
            this.btnDescCustomer.IconColor = System.Drawing.Color.White;
            this.btnDescCustomer.IconSize = 30;
            this.btnDescCustomer.Location = new System.Drawing.Point(371, 23);
            this.btnDescCustomer.Name = "btnDescCustomer";
            this.btnDescCustomer.Rotation = 0D;
            this.btnDescCustomer.Size = new System.Drawing.Size(50, 50);
            this.btnDescCustomer.TabIndex = 7;
            this.btnDescCustomer.UseVisualStyleBackColor = false;
            this.btnDescCustomer.Click += new System.EventHandler(this.BtnDescCustomer_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã KH";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "last_name";
            this.Column2.HeaderText = "Họ, tên đệm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "firt_name";
            this.Column8.HeaderText = "Tên";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "date_of_birth";
            this.Column6.HeaderText = "Ngày sinh";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "city";
            this.Column3.HeaderText = "Tỉnh,Thành phố";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gender";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "phone_number";
            this.Column7.HeaderText = "Số điện thoại";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "email";
            this.Column9.HeaderText = "Email";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1250, 695);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAscCustomer;
        private FontAwesome.Sharp.IconButton btnDescCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Button btnCancelCustomer;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbCustomerDate;
        private System.Windows.Forms.CheckBox cbCustomerID;
        private System.Windows.Forms.CheckBox cbCustomerGender;
        private System.Windows.Forms.CheckBox cbCustomerName;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtCustomerDate;
        private System.Windows.Forms.ComboBox cboCustomerGender;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCustomerCity;
        private FontAwesome.Sharp.IconButton btnCustomerSearch;
        private System.Windows.Forms.ComboBox cboCustomerSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}