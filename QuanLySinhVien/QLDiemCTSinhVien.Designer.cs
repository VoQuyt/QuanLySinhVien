namespace QuanLySinhVien
{
    partial class QLDiemCTSinhVien
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
            this.lblmasv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lsvDiem = new System.Windows.Forms.ListView();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblmasv
            // 
            this.lblmasv.AutoSize = true;
            this.lblmasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmasv.ForeColor = System.Drawing.Color.Black;
            this.lblmasv.Location = new System.Drawing.Point(314, 144);
            this.lblmasv.Name = "lblmasv";
            this.lblmasv.Size = new System.Drawing.Size(53, 20);
            this.lblmasv.TabIndex = 7;
            this.lblmasv.Text = "label1";
            this.lblmasv.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(307, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 58);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bảng Điểm";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTenSV.Location = new System.Drawing.Point(313, 105);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(76, 26);
            this.lblTenSV.TabIndex = 5;
            this.lblTenSV.Text = "label1";
            // 
            // lsvDiem
            // 
            this.lsvDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDiem.Location = new System.Drawing.Point(12, 179);
            this.lsvDiem.Name = "lsvDiem";
            this.lsvDiem.Size = new System.Drawing.Size(943, 562);
            this.lsvDiem.TabIndex = 4;
            this.lsvDiem.UseCompatibleStateImageBehavior = false;
            this.lsvDiem.SelectedIndexChanged += new System.EventHandler(this.lsvDiem_SelectedIndexChanged);
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(395, 107);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(121, 24);
            this.cboMaLop.TabIndex = 8;
            this.cboMaLop.Visible = false;
            // 
            // QLDiemCTSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 753);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.lblmasv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.lsvDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QLDiemCTSinhVien";
            this.Text = "QLDiemCTSinhVien";
            this.Load += new System.EventHandler(this.QLDiemCTSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmasv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.ListView lsvDiem;
        private System.Windows.Forms.ComboBox cboMaLop;
    }
}