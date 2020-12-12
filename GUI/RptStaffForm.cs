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
    public partial class RptStaffForm : Form
    {
        public RptStaffForm()
        {
            InitializeComponent();
            Staff_BUS staff = new Staff_BUS();
            List<Staff_DTO> list = staff.ListStaff();
            CrystalStaff crystal = new CrystalStaff();
            crystal.SetDataSource(list);
            crystalReportViewer1.ReportSource = crystal;
        }
    }
}
