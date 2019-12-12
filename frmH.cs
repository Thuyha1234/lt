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
    public partial class frmH : Form
    {
        public frmH()
        {
            InitializeComponent();
        }

        private void frmH_Load(object sender, EventArgs e)
        {
            crH c = new crH();
            crystalReportViewer5.ReportSource = c;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
