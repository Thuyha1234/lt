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
    public partial class frmHocBong : Form
    {
        public frmHocBong()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crHocBong rpt = new crHocBong();
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
