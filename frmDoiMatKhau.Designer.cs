namespace QLSV_NHOM6
{
    partial class frmDoiMatKhau
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblXNMK = new System.Windows.Forms.Label();
            this.txtXNMK = new System.Windows.Forms.TextBox();
            this.lblMKM = new System.Windows.Forms.Label();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lblTDN = new System.Windows.Forms.Label();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Enabled = false;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(184, 16);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(311, 37);
            this.lblTieuDe.TabIndex = 4;
            this.lblTieuDe.Text = "Thông tin tài khoản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.lblXNMK);
            this.panel1.Controls.Add(this.txtXNMK);
            this.panel1.Controls.Add(this.lblMKM);
            this.panel1.Controls.Add(this.txtMKM);
            this.panel1.Controls.Add(this.lblMK);
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.lblTDN);
            this.panel1.Controls.Add(this.txtTDN);
            this.panel1.Location = new System.Drawing.Point(35, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 330);
            this.panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(361, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 46);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(124, 260);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(130, 46);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Xác Nhận";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblXNMK
            // 
            this.lblXNMK.AutoSize = true;
            this.lblXNMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXNMK.Location = new System.Drawing.Point(47, 212);
            this.lblXNMK.Name = "lblXNMK";
            this.lblXNMK.Size = new System.Drawing.Size(157, 20);
            this.lblXNMK.TabIndex = 7;
            this.lblXNMK.Text = "Xác Nhận Mật Khẩu*";
            // 
            // txtXNMK
            // 
            this.txtXNMK.Location = new System.Drawing.Point(232, 212);
            this.txtXNMK.Name = "txtXNMK";
            this.txtXNMK.Size = new System.Drawing.Size(332, 20);
            this.txtXNMK.TabIndex = 6;
            // 
            // lblMKM
            // 
            this.lblMKM.AutoSize = true;
            this.lblMKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKM.Location = new System.Drawing.Point(47, 159);
            this.lblMKM.Name = "lblMKM";
            this.lblMKM.Size = new System.Drawing.Size(112, 20);
            this.lblMKM.TabIndex = 5;
            this.lblMKM.Text = "Mật Khẩu Mới*";
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(232, 159);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.Size = new System.Drawing.Size(332, 20);
            this.txtMKM.TabIndex = 4;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(47, 102);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(83, 20);
            this.lblMK.TabIndex = 3;
            this.lblMK.Text = "Mật Khẩu*";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(232, 102);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(332, 20);
            this.txtMK.TabIndex = 2;
            // 
            // lblTDN
            // 
            this.lblTDN.AutoSize = true;
            this.lblTDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDN.Location = new System.Drawing.Point(47, 52);
            this.lblTDN.Name = "lblTDN";
            this.lblTDN.Size = new System.Drawing.Size(127, 20);
            this.lblTDN.TabIndex = 1;
            this.lblTDN.Text = "Tên Đăng Nhập*";
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(232, 52);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(332, 20);
            this.txtTDN.TabIndex = 0;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 416);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.panel1);
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblXNMK;
        private System.Windows.Forms.TextBox txtXNMK;
        private System.Windows.Forms.Label lblMKM;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label lblTDN;
        private System.Windows.Forms.TextBox txtTDN;
    }
}