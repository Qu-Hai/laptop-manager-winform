namespace GUI
{
    partial class StaffForm
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboStaffCity = new System.Windows.Forms.ComboBox();
            this.dtStaffDate = new System.Windows.Forms.DateTimePicker();
            this.cboStaffGender = new System.Windows.Forms.ComboBox();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.txtStaffEmail = new System.Windows.Forms.TextBox();
            this.txtStaffLastName = new System.Windows.Forms.TextBox();
            this.txtStaffFirstName = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelStaff = new System.Windows.Forms.Button();
            this.btnSaveStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportStaff = new System.Windows.Forms.Button();
            this.btnStaffSearch = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStaffDate = new System.Windows.Forms.CheckBox();
            this.cbStaffID = new System.Windows.Forms.CheckBox();
            this.cbStaffGender = new System.Windows.Forms.CheckBox();
            this.btnAscStaff = new FontAwesome.Sharp.IconButton();
            this.cbStaffName = new System.Windows.Forms.CheckBox();
            this.btnDescStaff = new FontAwesome.Sharp.IconButton();
            this.cboStaffSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panelInput.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column9});
            this.dgvStaff.Location = new System.Drawing.Point(12, 116);
            this.dgvStaff.Name = "dgvStaff";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(790, 575);
            this.dgvStaff.TabIndex = 3;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStaff_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã NV";
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
            // Column5
            // 
            this.Column5.DataPropertyName = "position";
            this.Column5.HeaderText = "Chức vụ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
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
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelInput.Controls.Add(this.panel2);
            this.panelInput.Controls.Add(this.btnCancelStaff);
            this.panelInput.Controls.Add(this.btnSaveStaff);
            this.panelInput.Controls.Add(this.btnDeleteStaff);
            this.panelInput.Controls.Add(this.btnUpdateStaff);
            this.panelInput.Controls.Add(this.btnAddStaff);
            this.panelInput.ForeColor = System.Drawing.Color.White;
            this.panelInput.Location = new System.Drawing.Point(810, 4);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(435, 685);
            this.panelInput.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboPosition);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cboStaffCity);
            this.panel2.Controls.Add(this.dtStaffDate);
            this.panel2.Controls.Add(this.cboStaffGender);
            this.panel2.Controls.Add(this.txtStaffPhone);
            this.panel2.Controls.Add(this.txtStaffEmail);
            this.panel2.Controls.Add(this.txtStaffLastName);
            this.panel2.Controls.Add(this.txtStaffFirstName);
            this.panel2.Controls.Add(this.txtStaffID);
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
            // cboPosition
            // 
            this.cboPosition.Enabled = false;
            this.cboPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cboPosition.Location = new System.Drawing.Point(180, 238);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(248, 33);
            this.cboPosition.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Chức vụ";
            // 
            // cboStaffCity
            // 
            this.cboStaffCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStaffCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStaffCity.Enabled = false;
            this.cboStaffCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStaffCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffCity.FormattingEnabled = true;
            this.cboStaffCity.Items.AddRange(new object[] {
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
            this.cboStaffCity.Location = new System.Drawing.Point(180, 189);
            this.cboStaffCity.Margin = new System.Windows.Forms.Padding(4);
            this.cboStaffCity.Name = "cboStaffCity";
            this.cboStaffCity.Size = new System.Drawing.Size(247, 33);
            this.cboStaffCity.TabIndex = 16;
            // 
            // dtStaffDate
            // 
            this.dtStaffDate.CustomFormat = "MM/dd/yyyy";
            this.dtStaffDate.Enabled = false;
            this.dtStaffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStaffDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStaffDate.Location = new System.Drawing.Point(180, 143);
            this.dtStaffDate.Name = "dtStaffDate";
            this.dtStaffDate.Size = new System.Drawing.Size(248, 30);
            this.dtStaffDate.TabIndex = 15;
            // 
            // cboStaffGender
            // 
            this.cboStaffGender.Enabled = false;
            this.cboStaffGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStaffGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffGender.FormattingEnabled = true;
            this.cboStaffGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboStaffGender.Location = new System.Drawing.Point(180, 287);
            this.cboStaffGender.Name = "cboStaffGender";
            this.cboStaffGender.Size = new System.Drawing.Size(248, 33);
            this.cboStaffGender.TabIndex = 14;
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Enabled = false;
            this.txtStaffPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffPhone.Location = new System.Drawing.Point(180, 382);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(248, 30);
            this.txtStaffPhone.TabIndex = 12;
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.Enabled = false;
            this.txtStaffEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffEmail.Location = new System.Drawing.Point(180, 336);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(248, 30);
            this.txtStaffEmail.TabIndex = 11;
            // 
            // txtStaffLastName
            // 
            this.txtStaffLastName.Enabled = false;
            this.txtStaffLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffLastName.Location = new System.Drawing.Point(180, 51);
            this.txtStaffLastName.Name = "txtStaffLastName";
            this.txtStaffLastName.Size = new System.Drawing.Size(248, 30);
            this.txtStaffLastName.TabIndex = 10;
            // 
            // txtStaffFirstName
            // 
            this.txtStaffFirstName.Enabled = false;
            this.txtStaffFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffFirstName.Location = new System.Drawing.Point(180, 97);
            this.txtStaffFirstName.Name = "txtStaffFirstName";
            this.txtStaffFirstName.Size = new System.Drawing.Size(248, 30);
            this.txtStaffFirstName.TabIndex = 9;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(180, 5);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(248, 30);
            this.txtStaffID.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tỉnh, thành phố";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 55);
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
            // btnCancelStaff
            // 
            this.btnCancelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnCancelStaff.Enabled = false;
            this.btnCancelStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnCancelStaff.FlatAppearance.BorderSize = 5;
            this.btnCancelStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnCancelStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnCancelStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelStaff.Location = new System.Drawing.Point(223, 576);
            this.btnCancelStaff.Name = "btnCancelStaff";
            this.btnCancelStaff.Size = new System.Drawing.Size(205, 60);
            this.btnCancelStaff.TabIndex = 4;
            this.btnCancelStaff.Text = "Hủy";
            this.btnCancelStaff.UseVisualStyleBackColor = false;
            this.btnCancelStaff.Click += new System.EventHandler(this.BtnCancelStaff_Click);
            // 
            // btnSaveStaff
            // 
            this.btnSaveStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSaveStaff.Enabled = false;
            this.btnSaveStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSaveStaff.FlatAppearance.BorderSize = 5;
            this.btnSaveStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSaveStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSaveStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStaff.Location = new System.Drawing.Point(8, 576);
            this.btnSaveStaff.Name = "btnSaveStaff";
            this.btnSaveStaff.Size = new System.Drawing.Size(205, 60);
            this.btnSaveStaff.TabIndex = 3;
            this.btnSaveStaff.Text = "Lưu";
            this.btnSaveStaff.UseVisualStyleBackColor = false;
            this.btnSaveStaff.Click += new System.EventHandler(this.BtnSaveStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnDeleteStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDeleteStaff.FlatAppearance.BorderSize = 5;
            this.btnDeleteStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnDeleteStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.Location = new System.Drawing.Point(223, 510);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(205, 60);
            this.btnDeleteStaff.TabIndex = 2;
            this.btnDeleteStaff.Text = "Xóa";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.BtnDeleteStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnUpdateStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUpdateStaff.FlatAppearance.BorderSize = 5;
            this.btnUpdateStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnUpdateStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.Location = new System.Drawing.Point(8, 510);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(205, 60);
            this.btnUpdateStaff.TabIndex = 1;
            this.btnUpdateStaff.Text = "Sửa";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            this.btnUpdateStaff.Click += new System.EventHandler(this.BtnUpdateStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAddStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAddStaff.FlatAppearance.BorderSize = 5;
            this.btnAddStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAddStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(8, 444);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(420, 60);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Thêm nhân viên";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.BtnStaffAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnReportStaff);
            this.panel1.Controls.Add(this.btnStaffSearch);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cboStaffSearch);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 106);
            this.panel1.TabIndex = 11;
            // 
            // btnReportStaff
            // 
            this.btnReportStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnReportStaff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReportStaff.FlatAppearance.BorderSize = 2;
            this.btnReportStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnReportStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnReportStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportStaff.Location = new System.Drawing.Point(490, 55);
            this.btnReportStaff.Name = "btnReportStaff";
            this.btnReportStaff.Size = new System.Drawing.Size(285, 42);
            this.btnReportStaff.TabIndex = 6;
            this.btnReportStaff.Text = "Báo cáo";
            this.btnReportStaff.UseVisualStyleBackColor = false;
            this.btnReportStaff.Click += new System.EventHandler(this.BtnReportStaff_Click);
            // 
            // btnStaffSearch
            // 
            this.btnStaffSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnStaffSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnStaffSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStaffSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnStaffSearch.IconColor = System.Drawing.Color.Black;
            this.btnStaffSearch.IconSize = 16;
            this.btnStaffSearch.Location = new System.Drawing.Point(700, 15);
            this.btnStaffSearch.Name = "btnStaffSearch";
            this.btnStaffSearch.Rotation = 0D;
            this.btnStaffSearch.Size = new System.Drawing.Size(75, 28);
            this.btnStaffSearch.TabIndex = 17;
            this.btnStaffSearch.Text = "Tìm kiếm";
            this.btnStaffSearch.UseVisualStyleBackColor = true;
            this.btnStaffSearch.Click += new System.EventHandler(this.BtnStaffSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.cbStaffDate);
            this.groupBox1.Controls.Add(this.cbStaffID);
            this.groupBox1.Controls.Add(this.cbStaffGender);
            this.groupBox1.Controls.Add(this.btnAscStaff);
            this.groupBox1.Controls.Add(this.cbStaffName);
            this.groupBox1.Controls.Add(this.btnDescStaff);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // cbStaffDate
            // 
            this.cbStaffDate.AutoSize = true;
            this.cbStaffDate.Location = new System.Drawing.Point(216, 30);
            this.cbStaffDate.Name = "cbStaffDate";
            this.cbStaffDate.Size = new System.Drawing.Size(93, 21);
            this.cbStaffDate.TabIndex = 11;
            this.cbStaffDate.Text = "Ngày sinh";
            this.cbStaffDate.UseVisualStyleBackColor = true;
            this.cbStaffDate.Click += new System.EventHandler(this.CbStaffDate_Click);
            // 
            // cbStaffID
            // 
            this.cbStaffID.AutoSize = true;
            this.cbStaffID.Location = new System.Drawing.Point(6, 30);
            this.cbStaffID.Name = "cbStaffID";
            this.cbStaffID.Size = new System.Drawing.Size(43, 21);
            this.cbStaffID.TabIndex = 8;
            this.cbStaffID.Text = "ID";
            this.cbStaffID.UseVisualStyleBackColor = true;
            this.cbStaffID.Click += new System.EventHandler(this.CbStaffID_Click);
            // 
            // cbStaffGender
            // 
            this.cbStaffGender.AutoSize = true;
            this.cbStaffGender.Location = new System.Drawing.Point(128, 30);
            this.cbStaffGender.Name = "cbStaffGender";
            this.cbStaffGender.Size = new System.Drawing.Size(82, 21);
            this.cbStaffGender.TabIndex = 10;
            this.cbStaffGender.Text = "Giới tính";
            this.cbStaffGender.UseVisualStyleBackColor = true;
            this.cbStaffGender.Click += new System.EventHandler(this.CbStaffGender_Click);
            // 
            // btnAscStaff
            // 
            this.btnAscStaff.BackColor = System.Drawing.Color.White;
            this.btnAscStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAscStaff.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAscStaff.ForeColor = System.Drawing.Color.Black;
            this.btnAscStaff.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUpAlt;
            this.btnAscStaff.IconColor = System.Drawing.Color.Black;
            this.btnAscStaff.IconSize = 30;
            this.btnAscStaff.Location = new System.Drawing.Point(315, 23);
            this.btnAscStaff.Name = "btnAscStaff";
            this.btnAscStaff.Rotation = 0D;
            this.btnAscStaff.Size = new System.Drawing.Size(50, 50);
            this.btnAscStaff.TabIndex = 6;
            this.btnAscStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAscStaff.UseVisualStyleBackColor = false;
            this.btnAscStaff.Click += new System.EventHandler(this.BtnAscStaff_Click);
            // 
            // cbStaffName
            // 
            this.cbStaffName.AutoSize = true;
            this.cbStaffName.Location = new System.Drawing.Point(67, 30);
            this.cbStaffName.Name = "cbStaffName";
            this.cbStaffName.Size = new System.Drawing.Size(55, 21);
            this.cbStaffName.TabIndex = 9;
            this.cbStaffName.Text = "Tên";
            this.cbStaffName.UseVisualStyleBackColor = true;
            this.cbStaffName.Click += new System.EventHandler(this.CbStaffName_Click);
            // 
            // btnDescStaff
            // 
            this.btnDescStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnDescStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescStaff.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDescStaff.ForeColor = System.Drawing.Color.White;
            this.btnDescStaff.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDownAlt;
            this.btnDescStaff.IconColor = System.Drawing.Color.White;
            this.btnDescStaff.IconSize = 30;
            this.btnDescStaff.Location = new System.Drawing.Point(371, 23);
            this.btnDescStaff.Name = "btnDescStaff";
            this.btnDescStaff.Rotation = 0D;
            this.btnDescStaff.Size = new System.Drawing.Size(50, 50);
            this.btnDescStaff.TabIndex = 7;
            this.btnDescStaff.UseVisualStyleBackColor = false;
            this.btnDescStaff.Click += new System.EventHandler(this.BtnDescStaff_Click);
            // 
            // cboStaffSearch
            // 
            this.cboStaffSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStaffSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStaffSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffSearch.FormattingEnabled = true;
            this.cboStaffSearch.Location = new System.Drawing.Point(490, 15);
            this.cboStaffSearch.Name = "cboStaffSearch";
            this.cboStaffSearch.Size = new System.Drawing.Size(254, 28);
            this.cboStaffSearch.TabIndex = 16;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1250, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.dgvStaff);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.Text = "Xuất báo cáo nhân viên";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboStaffCity;
        private System.Windows.Forms.DateTimePicker dtStaffDate;
        private System.Windows.Forms.ComboBox cboStaffGender;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.TextBox txtStaffLastName;
        private System.Windows.Forms.TextBox txtStaffFirstName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelStaff;
        private System.Windows.Forms.Button btnSaveStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnStaffSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbStaffDate;
        private System.Windows.Forms.CheckBox cbStaffID;
        private System.Windows.Forms.CheckBox cbStaffGender;
        private FontAwesome.Sharp.IconButton btnAscStaff;
        private System.Windows.Forms.CheckBox cbStaffName;
        private FontAwesome.Sharp.IconButton btnDescStaff;
        private System.Windows.Forms.ComboBox cboStaffSearch;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReportStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}