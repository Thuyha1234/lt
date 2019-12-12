using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace QLSV_NHOM6
{
    public partial class frmDiemTK : Form
    {
        public frmDiemTK()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            crDiemTK rpt = new crDiemTK();
            crwDiemTK.ReportSource = rpt;
            
        }

        private void frmDiemTK_Load(object sender, EventArgs e)
        {

        }
    }
}
