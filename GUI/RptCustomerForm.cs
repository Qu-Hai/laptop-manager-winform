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
    public partial class RptCustomerForm : Form
    {
        public RptCustomerForm()
        {
            InitializeComponent();
            Customer_BUS bus = new Customer_BUS();
            List<Customer_DTO> list = bus.List();
            CrystalCustomer crystal = new CrystalCustomer();
            crystal.SetDataSource(list);
            crystalReportViewer1.ReportSource = crystal;
        }
    }
}
