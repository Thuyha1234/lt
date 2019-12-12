namespace QLSV_NHOM6
{
    partial class frmInsv
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
            this.crystalReportViewer_sv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_sv
            // 
            this.crystalReportViewer_sv.ActiveViewIndex = -1;
            this.crystalReportViewer_sv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_sv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_sv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_sv.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_sv.Name = "crystalReportViewer_sv";
            this.crystalReportViewer_sv.Size = new System.Drawing.Size(511, 275);
            this.crystalReportViewer_sv.TabIndex = 0;
            this.crystalReportViewer_sv.Load += new System.EventHandler(this.crystalReportViewer_sv_Load);
            // 
            // frmInsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 275);
            this.Controls.Add(this.crystalReportViewer_sv);
            this.Name = "frmInsv";
            this.Text = "frmInsv";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_sv;
    }
}