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
    public partial class RptProductForm : Form
    {
        public RptProductForm()
        {
            InitializeComponent();
            Product_BUS product = new Product_BUS();
            List<Product_DTO> list = product.ListProduct();
            CrystalProduct crystal = new CrystalProduct();
            crystal.SetDataSource(list);
            crystalReportViewer1.ReportSource = crystal;

        }
    }
}
