namespace QuanLySinhVien
{
    partial class QLPhongDaoTao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaHe = new System.Windows.Forms.TextBox();
            this.lsvHeDaoTao = new System.Windows.Forms.ListView();
            this.btnThemHe = new System.Windows.Forms.Button();
            this.btnSuaHe = new System.Windows.Forms.Button();
            this.btnXoaHe = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.chkHe = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenHe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.lsvNganh = new System.Windows.Forms.ListView();
            this.bntThemNganh = new System.Windows.Forms.Button();
            this.btnSuaNganh = new System.Windows.Forms.Button();
            this.btnXoaNganh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkNganh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.txtMaHe);
            this.groupBox1.Controls.Add(this.lsvHeDaoTao);
            this.groupBox1.Controls.Add(this.btnThemHe);
            this.groupBox1.Controls.Add(this.btnSuaHe);
            this.groupBox1.Controls.Add(this.btnXoaHe);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.chkHe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenHe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 777);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hệ";
            // 
            // txtMaHe
            // 
            this.txtMaHe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHe.Location = new System.Drawing.Point(304, 116);
            this.txtMaHe.Name = "txtMaHe";
            this.txtMaHe.Size = new System.Drawing.Size(283, 32);
            this.txtMaHe.TabIndex = 63;
            this.txtMaHe.Visible = false;
            // 
            // lsvHeDaoTao
            // 
            this.lsvHeDaoTao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvHeDaoTao.Location = new System.Drawing.Point(6, 325);
            this.lsvHeDaoTao.Name = "lsvHeDaoTao";
            this.lsvHeDaoTao.Size = new System.Drawing.Size(837, 446);
            this.lsvHeDaoTao.TabIndex = 62;
            this.lsvHeDaoTao.UseCompatibleStateImageBehavior = false;
            this.lsvHeDaoTao.SelectedIndexChanged += new System.EventHandler(this.lsvHeDaoTao_SelectedIndexChanged);
            // 
            // btnThemHe
            // 
            this.btnThemHe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemHe.BackColor = System.Drawing.Color.White;
            this.btnThemHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHe.Image = global::QuanLySinhVien.Properties.Resources.add_2_icon1;
            this.btnThemHe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHe.Location = new System.Drawing.Point(141, 247);
            this.btnThemHe.Name = "btnThemHe";
            this.btnThemHe.Size = new System.Drawing.Size(154, 48);
            this.btnThemHe.TabIndex = 58;
            this.btnThemHe.Text = "Thêm";
            this.btnThemHe.UseVisualStyleBackColor = false;
            this.btnThemHe.Click += new System.EventHandler(this.btnThemHe_Click);
            // 
            // btnSuaHe
            // 
            this.btnSuaHe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaHe.BackColor = System.Drawing.Color.White;
            this.btnSuaHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHe.Image = global::QuanLySinhVien.Properties.Resources.images;
            this.btnSuaHe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHe.Location = new System.Drawing.Point(336, 247);
            this.btnSuaHe.Name = "btnSuaHe";
            this.btnSuaHe.Size = new System.Drawing.Size(154, 48);
            this.btnSuaHe.TabIndex = 56;
            this.btnSuaHe.Text = "Sửa";
            this.btnSuaHe.UseVisualStyleBackColor = false;
            this.btnSuaHe.Click += new System.EventHandler(this.btnSuaHe_Click);
            // 
            // btnXoaHe
            // 
            this.btnXoaHe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaHe.BackColor = System.Drawing.Color.White;
            this.btnXoaHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHe.Image = global::QuanLySinhVien.Properties.Resources._130884_exit_256x256;
            this.btnXoaHe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHe.Location = new System.Drawing.Point(540, 247);
            this.btnXoaHe.Name = "btnXoaHe";
            this.btnXoaHe.Size = new System.Drawing.Size(154, 48);
            this.btnXoaHe.TabIndex = 55;
            this.btnXoaHe.Text = "Xóa";
            this.btnXoaHe.UseVisualStyleBackColor = false;
            this.btnXoaHe.Click += new System.EventHandler(this.btnXoaHe_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(132, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(546, 51);
            this.label10.TabIndex = 54;
            this.label10.Text = "QUẢN LÝ THÔNG TIN HỆ";
            // 
            // chkHe
            // 
            this.chkHe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkHe.AutoSize = true;
            this.chkHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHe.Location = new System.Drawing.Point(369, 174);
            this.chkHe.Name = "chkHe";
            this.chkHe.Size = new System.Drawing.Size(119, 30);
            this.chkHe.TabIndex = 52;
            this.chkHe.Text = "Áp Dụng";
            this.chkHe.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(184, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "Tình Trạng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên Hệ:";
            // 
            // txtTenHe
            // 
            this.txtTenHe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHe.Location = new System.Drawing.Point(304, 115);
            this.txtTenHe.Name = "txtTenHe";
            this.txtTenHe.Size = new System.Drawing.Size(283, 32);
            this.txtTenHe.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.txtMaNganh);
            this.groupBox2.Controls.Add(this.lsvNganh);
            this.groupBox2.Controls.Add(this.bntThemNganh);
            this.groupBox2.Controls.Add(this.btnSuaNganh);
            this.groupBox2.Controls.Add(this.btnXoaNganh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkNganh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenNganh);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(862, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 777);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Ngành";
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNganh.Location = new System.Drawing.Point(281, 119);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(283, 32);
            this.txtMaNganh.TabIndex = 64;
            this.txtMaNganh.Visible = false;
            // 
            // lsvNganh
            // 
            this.lsvNganh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvNganh.Location = new System.Drawing.Point(6, 325);
            this.lsvNganh.Name = "lsvNganh";
            this.lsvNganh.Size = new System.Drawing.Size(830, 446);
            this.lsvNganh.TabIndex = 63;
            this.lsvNganh.UseCompatibleStateImageBehavior = false;
            this.lsvNganh.SelectedIndexChanged += new System.EventHandler(this.lsvNganh_SelectedIndexChanged);
            // 
            // bntThemNganh
            // 
            this.bntThemNganh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntThemNganh.BackColor = System.Drawing.Color.White;
            this.bntThemNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThemNganh.Image = global::QuanLySinhVien.Properties.Resources.add_2_icon1;
            this.bntThemNganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThemNganh.Location = new System.Drawing.Point(131, 247);
            this.bntThemNganh.Name = "bntThemNganh";
            this.bntThemNganh.Size = new System.Drawing.Size(154, 48);
            this.bntThemNganh.TabIndex = 61;
            this.bntThemNganh.Text = "Thêm";
            this.bntThemNganh.UseVisualStyleBackColor = false;
            this.bntThemNganh.Click += new System.EventHandler(this.bntThemNganh_Click);
            // 
            // btnSuaNganh
            // 
            this.btnSuaNganh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaNganh.BackColor = System.Drawing.Color.White;
            this.btnSuaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNganh.Image = global::QuanLySinhVien.Properties.Resources.images;
            this.btnSuaNganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNganh.Location = new System.Drawing.Point(338, 247);
            this.btnSuaNganh.Name = "btnSuaNganh";
            this.btnSuaNganh.Size = new System.Drawing.Size(154, 48);
            this.btnSuaNganh.TabIndex = 60;
            this.btnSuaNganh.Text = "Sửa";
            this.btnSuaNganh.UseVisualStyleBackColor = false;
            this.btnSuaNganh.Click += new System.EventHandler(this.btnSuaNganh_Click);
            // 
            // btnXoaNganh
            // 
            this.btnXoaNganh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaNganh.BackColor = System.Drawing.Color.White;
            this.btnXoaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNganh.Image = global::QuanLySinhVien.Properties.Resources._130884_exit_256x256;
            this.btnXoaNganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNganh.Location = new System.Drawing.Point(543, 247);
            this.btnXoaNganh.Name = "btnXoaNganh";
            this.btnXoaNganh.Size = new System.Drawing.Size(154, 48);
            this.btnXoaNganh.TabIndex = 59;
            this.btnXoaNganh.Text = "Xóa";
            this.btnXoaNganh.UseVisualStyleBackColor = false;
            this.btnXoaNganh.Click += new System.EventHandler(this.btnXoaNganh_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(104, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(644, 51);
            this.label4.TabIndex = 55;
            this.label4.Text = "QUẢN LÝ THÔNG TIN NGÀNH";
            // 
            // chkNganh
            // 
            this.chkNganh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkNganh.AutoSize = true;
            this.chkNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNganh.Location = new System.Drawing.Point(346, 178);
            this.chkNganh.Name = "chkNganh";
            this.chkNganh.Size = new System.Drawing.Size(119, 30);
            this.chkNganh.TabIndex = 52;
            this.chkNganh.Text = "Áp Dụng";
            this.chkNganh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tình Trạng:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên Ngành:";
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNganh.Location = new System.Drawing.Point(281, 119);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(283, 32);
            this.txtTenNganh.TabIndex = 11;
            // 
            // QLPhongDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 799);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLPhongDaoTao";
            this.Text = "QLPhongDaoTao";
            this.Load += new System.EventHandler(this.QLPhongDaoTao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenHe;
        private System.Windows.Forms.CheckBox chkHe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNganh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemHe;
        private System.Windows.Forms.Button btnSuaHe;
        private System.Windows.Forms.Button btnXoaHe;
        private System.Windows.Forms.Button bntThemNganh;
        private System.Windows.Forms.Button btnSuaNganh;
        private System.Windows.Forms.Button btnXoaNganh;
        private System.Windows.Forms.ListView lsvHeDaoTao;
        private System.Windows.Forms.ListView lsvNganh;
        private System.Windows.Forms.TextBox txtMaHe;
        private System.Windows.Forms.TextBox txtMaNganh;
    }
}