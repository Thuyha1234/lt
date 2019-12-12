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
    public partial class frmDiemTP : Form
    {
        public frmDiemTP()
        {
            InitializeComponent();
        }

        private void crwDiemTP_Load(object sender, EventArgs e)
        {
            crDiemTP rpt = new crDiemTP();
            crwDiemTP.ReportSource = rpt;
        }
    }
}
