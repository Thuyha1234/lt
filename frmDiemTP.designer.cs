namespace QLSV_NHOM6
{
    partial class frmDiemTP
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
            this.crwDiemTP = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crwDiemTP
            // 
            this.crwDiemTP.ActiveViewIndex = -1;
            this.crwDiemTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crwDiemTP.Cursor = System.Windows.Forms.Cursors.Default;
            this.crwDiemTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crwDiemTP.Location = new System.Drawing.Point(0, 0);
            this.crwDiemTP.Name = "crwDiemTP";
            this.crwDiemTP.Size = new System.Drawing.Size(609, 338);
            this.crwDiemTP.TabIndex = 0;
            this.crwDiemTP.Load += new System.EventHandler(this.crwDiemTP_Load);
            // 
            // frmDiemTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 338);
            this.Controls.Add(this.crwDiemTP);
            this.Name = "frmDiemTP";
            this.Text = "frmDiemTP";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crwDiemTP;
    }
}