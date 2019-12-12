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
    public partial class frmK : Form
    {
        public frmK()
        {
            InitializeComponent();
        }

        private void frmK_Load(object sender, EventArgs e)
        {
            CrystalReport2 c = new CrystalReport2();
            crystalReportViewer1.ReportSource = c;
        }
    }
}
