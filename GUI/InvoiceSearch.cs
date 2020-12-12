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
    public partial class InvoiceSearch : Form
    {
        public PayForm _pf;
        public InvoiceSearch(List<Customer_DTO> list,PayForm pf)
        {
            _pf = pf;
            InitializeComponent();
            dtgInvoiceCustomer.DataSource = list;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DtgInvoiceCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInvoiceCustomer.SelectedRows.Count > 0)
            {
                Customer_DTO dto = (Customer_DTO)dtgInvoiceCustomer.SelectedRows[0].DataBoundItem;
                _pf.txtCCity.Text = dto.City;
                _pf.txtCID.Text = dto.Id;
                _pf.txtCName.Text = dto.Last_name + " " + dto.Firt_name;
                _pf.txtCPhone.Text = dto.Phone_number;
            }
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
