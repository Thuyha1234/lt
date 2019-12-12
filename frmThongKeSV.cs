using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_NHOM6
{
    public partial class frmThongKeSV : Form
    {
        public frmThongKeSV()
        {
            InitializeComponent();
        }


        private void crystalReportViewer2_Load_1(object sender, EventArgs e)
        {
            crThongKeSV rpt = new crThongKeSV();
            crystalReportViewer2.ReportSource = rpt;
        }
    }
}
