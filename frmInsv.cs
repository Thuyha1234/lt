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
    public partial class frmInsv : Form
    {
        public frmInsv()
        {
            InitializeComponent();
        }

        private void crystalReportViewer_sv_Load(object sender, EventArgs e)
        {
            
            CrystalReport_sv rpt = new CrystalReport_sv();
            crystalReportViewer_sv.ReportSource = rpt;
        }
    }
}
