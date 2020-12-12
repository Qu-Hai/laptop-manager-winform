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
    public partial class PayForm : Form
    {
        private string _full_name;
        private string _id;
        private int total = 0;
        private int? temp;
        public PayForm(string id, string fullname)
        {
            
            InitializeComponent();
            _full_name = fullname;
            _id = id;
            LoadData();

        }
        void LoadData()
        {
            Product_BUS product = new Product_BUS();
            List<Product_DTO> list = product.ListProduct();
            dtgInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgInvoice.AutoGenerateColumns = false;
            dtgInvoice.MultiSelect = false;
            dtgInvoice.DataSource = list;
            txtSName.Text = _id+" "+_full_name;
            ProviderID();

        }
        void ProviderID()
        {
            Product_BUS product = new Product_BUS();
            int index = product.CountID();
            txtInvoiceID.Text = "HD" + index;
        }
        private void DtgInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInvoice.SelectedRows.Count > 0)
            {
                Product_DTO dto = (Product_DTO)dtgInvoice.SelectedRows[0].DataBoundItem;
                txtPID.Text = dto.Product_id;
                txtPName.Text = dto.Full_name;
                txtPrice.Text = dto.Total.ToString();
                txtAmount.Text = dto.Amount.ToString();
                temp = dto.Amount;
            }
            
        }

        private void btnInsertInvoice_Click(object sender, EventArgs e)
        {
            if (txtPName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK);
            }
            else if (txtAmount.Text.Equals(string.Empty))
            {
                MessageBox.Show("Chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK);
                txtAmount.Text = "1";
            }
            else if (int.Parse(txtAmount.Text) > temp)
            {
                MessageBox.Show("Không đủ số lượng", "Thông báo", MessageBoxButtons.OK);
                txtAmount.Text = "1";
            }
            else
            {
                int price = (int.Parse(txtAmount.Text) * int.Parse(txtPrice.Text));
                total += price;
                string[] row = { txtPName.Text, txtAmount.Text, txtPrice.Text, price.ToString() };
                ListViewItem item = new ListViewItem(row);
                lvInvoice.Items.Add(item);
                txtInvoiceTotal.Text = total.ToString();
            }
            
        }

        public void BtnSearchCustomer_1_Click(object sender, EventArgs e)
        {
            string obj = txtCSearch.Text;
            Customer_BUS bus = new Customer_BUS();
            List<Customer_DTO> list = bus.Search(obj);
            PayForm pf = this;
            InvoiceSearch ifm = new InvoiceSearch(list,pf);
            ifm.ShowDialog();
            
        }

        private void BtnAddInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void BtnInsertCustomer_Click(object sender, EventArgs e)
        {
            txtCustomer.Text = txtCID.Text + " " + txtCName.Text;
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            string obj = textBox3.Text;
            Product_BUS bus = new Product_BUS();
            dtgInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgInvoice.AutoGenerateColumns = false;
            dtgInvoice.MultiSelect = false;
            List<Product_DTO> list = bus.Search(obj);
            dtgInvoice.DataSource = list;
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
