namespace GUI
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pan545 = new System.Windows.Forms.Panel();
            this.panel235 = new System.Windows.Forms.Panel();
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
            this.btnProductCancel = new System.Windows.Forms.Button();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.Customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportProduct = new System.Windows.Forms.Button();
            this.btnProductSearch = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbProductTotal = new System.Windows.Forms.CheckBox();
            this.cbProductID = new System.Windows.Forms.CheckBox();
            this.cbProductColor = new System.Windows.Forms.CheckBox();
            this.btnAscProduct = new FontAwesome.Sharp.IconButton();
            this.cbProductName = new System.Windows.Forms.CheckBox();
            this.btnDescProduct = new FontAwesome.Sharp.IconButton();
            this.cboProductSearch = new System.Windows.Forms.ComboBox();
            this.pan545.SuspendLayout();
            this.panel235.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan545
            // 
            this.pan545.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pan545.Controls.Add(this.panel235);
            this.pan545.Controls.Add(this.btnProductCancel);
            this.pan545.Controls.Add(this.btnProductSave);
            this.pan545.Controls.Add(this.btnDeleteProduct);
            this.pan545.Controls.Add(this.btnUpdateProduct);
            this.pan545.Controls.Add(this.btnAddProduct);
            this.pan545.ForeColor = System.Drawing.Color.White;
            this.pan545.Location = new System.Drawing.Point(810, 4);
            this.pan545.Name = "pan545";
            this.pan545.Size = new System.Drawing.Size(435, 685);
            this.pan545.TabIndex = 10;
            // 
            // panel235
            // 
            this.panel235.Controls.Add(this.cboProductRAM);
            this.panel235.Controls.Add(this.cboProductSupplier);
            this.panel235.Controls.Add(this.cboProductColor);
            this.panel235.Controls.Add(this.dtProductDate);
            this.panel235.Controls.Add(this.txtProductTotal);
            this.panel235.Controls.Add(this.txtProductHard);
            this.panel235.Controls.Add(this.txtProductName);
            this.panel235.Controls.Add(this.txtProductID);
            this.panel235.Controls.Add(this.label9);
            this.panel235.Controls.Add(this.label8);
            this.panel235.Controls.Add(this.label7);
            this.panel235.Controls.Add(this.label6);
            this.panel235.Controls.Add(this.label5);
            this.panel235.Controls.Add(this.label4);
            this.panel235.Controls.Add(this.label3);
            this.panel235.Controls.Add(this.label2);
            this.panel235.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel235.Location = new System.Drawing.Point(0, 0);
            this.panel235.Name = "panel235";
            this.panel235.Size = new System.Drawing.Size(435, 435);
            this.panel235.TabIndex = 6;
            // 
            // cboProductRAM
            // 
            this.cboProductRAM.Enabled = false;
            this.cboProductRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProductRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductRAM.FormattingEnabled = true;
            this.cboProductRAM.Items.AddRange(new object[] {
            "2GB",
            "4GB",
            "8GB",
            "12GB"});
            this.cboProductRAM.Location = new System.Drawing.Point(179, 275);
            this.cboProductRAM.Name = "cboProductRAM";
            this.cboProductRAM.Size = new System.Drawing.Size(248, 33);
            this.cboProductRAM.TabIndex = 5;
            // 
            // cboProductSupplier
            // 
            this.cboProductSupplier.Enabled = false;
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
            this.cboProductSupplier.Location = new System.Drawing.Point(179, 221);
            this.cboProductSupplier.Name = "cboProductSupplier";
            this.cboProductSupplier.Size = new System.Drawing.Size(248, 33);
            this.cboProductSupplier.TabIndex = 4;
            // 
            // cboProductColor
            // 
            this.cboProductColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProductColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProductColor.Enabled = false;
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
            this.cboProductColor.Location = new System.Drawing.Point(179, 113);
            this.cboProductColor.Name = "cboProductColor";
            this.cboProductColor.Size = new System.Drawing.Size(248, 33);
            this.cboProductColor.TabIndex = 2;
            // 
            // dtProductDate
            // 
            this.dtProductDate.CustomFormat = "MM/dd/yyyy";
            this.dtProductDate.Enabled = false;
            this.dtProductDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtProductDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtProductDate.Location = new System.Drawing.Point(179, 170);
            this.dtProductDate.Name = "dtProductDate";
            this.dtProductDate.Size = new System.Drawing.Size(248, 30);
            this.dtProductDate.TabIndex = 3;
            // 
            // txtProductTotal
            // 
            this.txtProductTotal.Enabled = false;
            this.txtProductTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTotal.Location = new System.Drawing.Point(179, 383);
            this.txtProductTotal.Name = "txtProductTotal";
            this.txtProductTotal.Size = new System.Drawing.Size(248, 30);
            this.txtProductTotal.TabIndex = 7;
            // 
            // txtProductHard
            // 
            this.txtProductHard.Enabled = false;
            this.txtProductHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductHard.Location = new System.Drawing.Point(179, 329);
            this.txtProductHard.Name = "txtProductHard";
            this.txtProductHard.Size = new System.Drawing.Size(248, 30);
            this.txtProductHard.TabIndex = 6;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(179, 59);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(248, 30);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(179, 5);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(248, 30);
            this.txtProductID.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ổ cứng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "RAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nhà sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Màu sắc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // btnProductCancel
            // 
            this.btnProductCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnProductCancel.Enabled = false;
            this.btnProductCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnProductCancel.FlatAppearance.BorderSize = 5;
            this.btnProductCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnProductCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnProductCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductCancel.Location = new System.Drawing.Point(223, 576);
            this.btnProductCancel.Name = "btnProductCancel";
            this.btnProductCancel.Size = new System.Drawing.Size(205, 60);
            this.btnProductCancel.TabIndex = 4;
            this.btnProductCancel.Text = "Hủy";
            this.btnProductCancel.UseVisualStyleBackColor = false;
            this.btnProductCancel.Click += new System.EventHandler(this.btnProductCancel_Click);
            // 
            // btnProductSave
            // 
            this.btnProductSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnProductSave.Enabled = false;
            this.btnProductSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnProductSave.FlatAppearance.BorderSize = 5;
            this.btnProductSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnProductSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSave.Location = new System.Drawing.Point(8, 576);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(205, 60);
            this.btnProductSave.TabIndex = 3;
            this.btnProductSave.Text = "Lưu";
            this.btnProductSave.UseVisualStyleBackColor = false;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDeleteProduct.FlatAppearance.BorderSize = 5;
            this.btnDeleteProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnDeleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(223, 510);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(205, 60);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnUpdateProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUpdateProduct.FlatAppearance.BorderSize = 5;
            this.btnUpdateProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnUpdateProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(8, 510);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(205, 60);
            this.btnUpdateProduct.TabIndex = 1;
            this.btnUpdateProduct.Text = "Sửa";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 5;
            this.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(8, 444);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(420, 60);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm Sản Phẩm";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dtgProduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_id,
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProduct.Location = new System.Drawing.Point(12, 116);
            this.dtgProduct.Name = "dtgProduct";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProduct.RowHeadersWidth = 51;
            this.dtgProduct.RowTemplate.Height = 24;
            this.dtgProduct.Size = new System.Drawing.Size(790, 575);
            this.dtgProduct.TabIndex = 2;
            this.dtgProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgProduct_CellClick);
            // 
            // Customer_id
            // 
            this.Customer_id.DataPropertyName = "product_id";
            this.Customer_id.HeaderText = "Mã SP";
            this.Customer_id.MinimumWidth = 6;
            this.Customer_id.Name = "Customer_id";
            this.Customer_id.Width = 70;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "full_name";
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "hard_drive";
            this.Column7.HeaderText = "Ổ cứng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ram";
            this.Column2.HeaderText = "RAM";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cpu";
            this.Column3.HeaderText = "CPU";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "color";
            this.Column4.HeaderText = "Màu sắc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "supplier_id";
            this.Column6.HeaderText = "Nhà sản xuất";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 170;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "total";
            this.Column5.HeaderText = "Giá";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnReportProduct);
            this.panel1.Controls.Add(this.btnProductSearch);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cboProductSearch);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 106);
            this.panel1.TabIndex = 1;
            // 
            // btnReportProduct
            // 
            this.btnReportProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnReportProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReportProduct.FlatAppearance.BorderSize = 2;
            this.btnReportProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnReportProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnReportProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportProduct.Location = new System.Drawing.Point(490, 50);
            this.btnReportProduct.Name = "btnReportProduct";
            this.btnReportProduct.Size = new System.Drawing.Size(285, 42);
            this.btnReportProduct.TabIndex = 3;
            this.btnReportProduct.Text = "Báo cáo";
            this.btnReportProduct.UseVisualStyleBackColor = false;
            this.btnReportProduct.Click += new System.EventHandler(this.BtnReportProduct_Click);
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnProductSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnProductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProductSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProductSearch.IconColor = System.Drawing.Color.Black;
            this.btnProductSearch.IconSize = 16;
            this.btnProductSearch.Location = new System.Drawing.Point(700, 15);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Rotation = 0D;
            this.btnProductSearch.Size = new System.Drawing.Size(75, 28);
            this.btnProductSearch.TabIndex = 2;
            this.btnProductSearch.Text = "Tìm kiếm";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.cbProductTotal);
            this.groupBox1.Controls.Add(this.cbProductID);
            this.groupBox1.Controls.Add(this.cbProductColor);
            this.groupBox1.Controls.Add(this.btnAscProduct);
            this.groupBox1.Controls.Add(this.cbProductName);
            this.groupBox1.Controls.Add(this.btnDescProduct);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // cbProductTotal
            // 
            this.cbProductTotal.AutoSize = true;
            this.cbProductTotal.Location = new System.Drawing.Point(216, 30);
            this.cbProductTotal.Name = "cbProductTotal";
            this.cbProductTotal.Size = new System.Drawing.Size(56, 21);
            this.cbProductTotal.TabIndex = 4;
            this.cbProductTotal.Text = "Giá ";
            this.cbProductTotal.UseVisualStyleBackColor = true;
            this.cbProductTotal.Click += new System.EventHandler(this.cbProductTotal_CheckedChanged);
            // 
            // cbProductID
            // 
            this.cbProductID.AutoSize = true;
            this.cbProductID.Location = new System.Drawing.Point(6, 30);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(43, 21);
            this.cbProductID.TabIndex = 1;
            this.cbProductID.Text = "ID";
            this.cbProductID.UseVisualStyleBackColor = true;
            this.cbProductID.Click += new System.EventHandler(this.cbProductID_CheckedChanged);
            // 
            // cbProductColor
            // 
            this.cbProductColor.AutoSize = true;
            this.cbProductColor.Location = new System.Drawing.Point(128, 30);
            this.cbProductColor.Name = "cbProductColor";
            this.cbProductColor.Size = new System.Drawing.Size(83, 21);
            this.cbProductColor.TabIndex = 3;
            this.cbProductColor.Text = "Màu sắc";
            this.cbProductColor.UseVisualStyleBackColor = true;
            this.cbProductColor.Click += new System.EventHandler(this.cbProductColor_CheckedChanged);
            // 
            // btnAscProduct
            // 
            this.btnAscProduct.BackColor = System.Drawing.Color.White;
            this.btnAscProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAscProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAscProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAscProduct.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUpAlt;
            this.btnAscProduct.IconColor = System.Drawing.Color.Black;
            this.btnAscProduct.IconSize = 30;
            this.btnAscProduct.Location = new System.Drawing.Point(315, 23);
            this.btnAscProduct.Name = "btnAscProduct";
            this.btnAscProduct.Rotation = 0D;
            this.btnAscProduct.Size = new System.Drawing.Size(50, 50);
            this.btnAscProduct.TabIndex = 5;
            this.btnAscProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAscProduct.UseVisualStyleBackColor = false;
            this.btnAscProduct.Click += new System.EventHandler(this.btnAscProduct_Click);
            // 
            // cbProductName
            // 
            this.cbProductName.AutoSize = true;
            this.cbProductName.Location = new System.Drawing.Point(67, 30);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(55, 21);
            this.cbProductName.TabIndex = 2;
            this.cbProductName.Text = "Tên";
            this.cbProductName.UseVisualStyleBackColor = true;
            this.cbProductName.Click += new System.EventHandler(this.cbProductName_CheckedChanged);
            // 
            // btnDescProduct
            // 
            this.btnDescProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnDescProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDescProduct.ForeColor = System.Drawing.Color.White;
            this.btnDescProduct.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDownAlt;
            this.btnDescProduct.IconColor = System.Drawing.Color.White;
            this.btnDescProduct.IconSize = 30;
            this.btnDescProduct.Location = new System.Drawing.Point(371, 23);
            this.btnDescProduct.Name = "btnDescProduct";
            this.btnDescProduct.Rotation = 0D;
            this.btnDescProduct.Size = new System.Drawing.Size(50, 50);
            this.btnDescProduct.TabIndex = 0;
            this.btnDescProduct.UseVisualStyleBackColor = false;
            this.btnDescProduct.Click += new System.EventHandler(this.btnDescProduct_Click);
            // 
            // cboProductSearch
            // 
            this.cboProductSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProductSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductSearch.FormattingEnabled = true;
            this.cboProductSearch.Location = new System.Drawing.Point(490, 15);
            this.cboProductSearch.Name = "cboProductSearch";
            this.cboProductSearch.Size = new System.Drawing.Size(254, 28);
            this.cboProductSearch.TabIndex = 1;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1250, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgProduct);
            this.Controls.Add(this.pan545);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductForm_KeyDown);
            this.pan545.ResumeLayout(false);
            this.panel235.ResumeLayout(false);
            this.panel235.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan545;
        private System.Windows.Forms.Button btnProductCancel;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dtgProduct;
        private System.Windows.Forms.Panel panel235;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReportProduct;
        private FontAwesome.Sharp.IconButton btnProductSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbProductTotal;
        private System.Windows.Forms.CheckBox cbProductID;
        private System.Windows.Forms.CheckBox cbProductColor;
        private FontAwesome.Sharp.IconButton btnAscProduct;
        private System.Windows.Forms.CheckBox cbProductName;
        private FontAwesome.Sharp.IconButton btnDescProduct;
        private System.Windows.Forms.ComboBox cboProductSearch;
        private System.Windows.Forms.ComboBox cboProductRAM;
        private System.Windows.Forms.ComboBox cboProductSupplier;
        private System.Windows.Forms.ComboBox cboProductColor;
        private System.Windows.Forms.DateTimePicker dtProductDate;
        private System.Windows.Forms.TextBox txtProductTotal;
        private System.Windows.Forms.TextBox txtProductHard;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}