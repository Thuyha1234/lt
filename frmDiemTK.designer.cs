namespace QLSV_NHOM6
{
    partial class frmDiemTK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crwDiemTK = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crwDiemTK
            // 
            this.crwDiemTK.ActiveViewIndex = -1;
            this.crwDiemTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crwDiemTK.Cursor = System.Windows.Forms.Cursors.Default;
            this.crwDiemTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crwDiemTK.Location = new System.Drawing.Point(0, 0);
            this.crwDiemTK.Name = "crwDiemTK";
            this.crwDiemTK.Size = new System.Drawing.Size(665, 325);
            this.crwDiemTK.TabIndex = 0;
            this.crwDiemTK.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmDiemTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 325);
            this.Controls.Add(this.crwDiemTK);
            this.Name = "frmDiemTK";
            this.Text = "frmDiemTK";
            this.Load += new System.EventHandler(this.frmDiemTK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crwDiemTK;
    }
}