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
    public partial class FormAddProduct : Form
    {

        public FormAddProduct()
        {
            InitializeComponent();
            LoadData();

        }
        void LoadData()
        {

            lblTitle.Text = "Thêm sản phẩm";
            ProviderID();
            cboProductRAM.SelectedIndex = 0;
            cboProductColor.SelectedIndex = 0;
            cboProductSupplier.SelectedIndex = 0;

        }
        private void ProviderID()
        {
            string id;
            int index;
            Product_BUS bus = new Product_BUS();
            index = bus.CountID()+1;
            id = "SP" + index;
            txtProductID.Text = id;
        }

        void InsertProduct()
        {
            Product_DTO dto = new Product_DTO();
            Product_BUS bus = new Product_BUS();
            dto.Color = cboProductColor.Text;
            dto.CPU = cboProductRAM.Text;
            dto.Full_name = txtProductName.Text;
            dto.Hard_drive = txtProductHard.Text; ;
            dto.Product_id = txtProductID.Text;
            dto.Ram = cboProductRAM.Text;
            dto.Supplier_id = cboProductSupplier.Text;
            dto.Total = int.Parse(txtProductTotal.Text);
            bus.Insert(dto);
        }





        private void FormAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnProuctClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            InsertProduct();
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
