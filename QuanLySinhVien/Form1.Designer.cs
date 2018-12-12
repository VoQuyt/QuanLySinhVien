namespace QuanLySinhVien
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mnt = new System.Windows.Forms.MenuStrip();
            this.mntTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mntThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mntQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mntSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mntGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mntMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mntLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDaoTao = new System.Windows.Forms.ToolStripMenuItem();
            this.mntQLTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDSDangKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mntThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDSSinhVienTheoLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDanhSachDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDSDiemTheoLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDSDiemTheoSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnLui = new System.Windows.Forms.Button();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.mnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnt
            // 
            this.mnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntTaiKhoan,
            this.mntQuanLy,
            this.mntDSDangKy,
            this.mntThongKe});
            this.mnt.Location = new System.Drawing.Point(0, 0);
            this.mnt.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.mnt.Name = "mnt";
            this.mnt.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnt.Size = new System.Drawing.Size(1489, 66);
            this.mnt.TabIndex = 1;
            this.mnt.Text = "menuStrip1";
            // 
            // mntTaiKhoan
            // 
            this.mntTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntThongTin,
            this.mntDangNhap,
            this.mntDangXuat});
            this.mntTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.mntTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("mntTaiKhoan.Image")));
            this.mntTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntTaiKhoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntTaiKhoan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.mntTaiKhoan.Name = "mntTaiKhoan";
            this.mntTaiKhoan.Padding = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.mntTaiKhoan.Size = new System.Drawing.Size(205, 59);
            this.mntTaiKhoan.Text = "Tài Khoản";
            // 
            // mntThongTin
            // 
            this.mntThongTin.Image = ((System.Drawing.Image)(resources.GetObject("mntThongTin.Image")));
            this.mntThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntThongTin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntThongTin.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mntThongTin.Name = "mntThongTin";
            this.mntThongTin.Size = new System.Drawing.Size(274, 52);
            this.mntThongTin.Text = "Thông Tin";
            // 
            // mntDangNhap
            // 
            this.mntDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("mntDangNhap.Image")));
            this.mntDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntDangNhap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntDangNhap.Name = "mntDangNhap";
            this.mntDangNhap.Size = new System.Drawing.Size(274, 52);
            this.mntDangNhap.Text = "Đăng Nhập";
            this.mntDangNhap.Click += new System.EventHandler(this.mntDangNhap_Click);
            // 
            // mntDangXuat
            // 
            this.mntDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mntDangXuat.Image")));
            this.mntDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntDangXuat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntDangXuat.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mntDangXuat.Name = "mntDangXuat";
            this.mntDangXuat.Size = new System.Drawing.Size(274, 52);
            this.mntDangXuat.Text = "Đăng Xuất";
            this.mntDangXuat.Click += new System.EventHandler(this.mntDangXuat_Click);
            // 
            // mntQuanLy
            // 
            this.mntQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntSinhVien,
            this.mntGiangVien,
            this.mntMonHoc,
            this.mntLopHoc,
            this.mntDiem,
            this.mntDaoTao,
            this.mntQLTaiKhoan});
            this.mntQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("mntQuanLy.Image")));
            this.mntQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntQuanLy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntQuanLy.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.mntQuanLy.Name = "mntQuanLy";
            this.mntQuanLy.Padding = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.mntQuanLy.Size = new System.Drawing.Size(182, 59);
            this.mntQuanLy.Text = "Quản Lý";
            // 
            // mntSinhVien
            // 
            this.mntSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("mntSinhVien.Image")));
            this.mntSinhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntSinhVien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntSinhVien.Name = "mntSinhVien";
            this.mntSinhVien.Size = new System.Drawing.Size(269, 52);
            this.mntSinhVien.Text = "Sinh Viên";
            this.mntSinhVien.Click += new System.EventHandler(this.mntSinhVien_Click);
            // 
            // mntGiangVien
            // 
            this.mntGiangVien.Image = ((System.Drawing.Image)(resources.GetObject("mntGiangVien.Image")));
            this.mntGiangVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntGiangVien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntGiangVien.Name = "mntGiangVien";
            this.mntGiangVien.Size = new System.Drawing.Size(269, 52);
            this.mntGiangVien.Text = "Giảng Viên";
            this.mntGiangVien.Click += new System.EventHandler(this.mntGiangVien_Click);
            // 
            // mntMonHoc
            // 
            this.mntMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("mntMonHoc.Image")));
            this.mntMonHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntMonHoc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntMonHoc.Name = "mntMonHoc";
            this.mntMonHoc.Size = new System.Drawing.Size(269, 52);
            this.mntMonHoc.Text = "Môn Học";
            this.mntMonHoc.Click += new System.EventHandler(this.mntMonHoc_Click);
            // 
            // mntLopHoc
            // 
            this.mntLopHoc.Image = ((System.Drawing.Image)(resources.GetObject("mntLopHoc.Image")));
            this.mntLopHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntLopHoc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntLopHoc.Name = "mntLopHoc";
            this.mntLopHoc.Size = new System.Drawing.Size(269, 52);
            this.mntLopHoc.Text = "Lớp Học";
            this.mntLopHoc.Click += new System.EventHandler(this.mntLopHoc_Click);
            // 
            // mntDiem
            // 
            this.mntDiem.Image = ((System.Drawing.Image)(resources.GetObject("mntDiem.Image")));
            this.mntDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntDiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntDiem.Name = "mntDiem";
            this.mntDiem.Size = new System.Drawing.Size(269, 52);
            this.mntDiem.Text = "Điểm";
            this.mntDiem.Click += new System.EventHandler(this.mntDiem_Click);
            // 
            // mntDaoTao
            // 
            this.mntDaoTao.Name = "mntDaoTao";
            this.mntDaoTao.Size = new System.Drawing.Size(269, 52);
            this.mntDaoTao.Text = "Đào Tạo";
            this.mntDaoTao.Visible = false;
            this.mntDaoTao.Click += new System.EventHandler(this.mntDaoTao_Click);
            // 
            // mntQLTaiKhoan
            // 
            this.mntQLTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("mntQLTaiKhoan.Image")));
            this.mntQLTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntQLTaiKhoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntQLTaiKhoan.Name = "mntQLTaiKhoan";
            this.mntQLTaiKhoan.Size = new System.Drawing.Size(269, 52);
            this.mntQLTaiKhoan.Text = "Tài Khoản";
            this.mntQLTaiKhoan.Click += new System.EventHandler(this.mntQLTaiKhoan_Click);
            // 
            // mntDSDangKy
            // 
            this.mntDSDangKy.Image = ((System.Drawing.Image)(resources.GetObject("mntDSDangKy.Image")));
            this.mntDSDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntDSDangKy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntDSDangKy.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.mntDSDangKy.Name = "mntDSDangKy";
            this.mntDSDangKy.Padding = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.mntDSDangKy.Size = new System.Drawing.Size(231, 59);
            this.mntDSDangKy.Text = "DS Đăng Ký";
            this.mntDSDangKy.Click += new System.EventHandler(this.mntDSDangKy_Click);
            // 
            // mntThongKe
            // 
            this.mntThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntDSSinhVienTheoLop,
            this.mntDanhSachDiem});
            this.mntThongKe.Image = ((System.Drawing.Image)(resources.GetObject("mntThongKe.Image")));
            this.mntThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntThongKe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntThongKe.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.mntThongKe.Name = "mntThongKe";
            this.mntThongKe.Padding = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.mntThongKe.Size = new System.Drawing.Size(201, 59);
            this.mntThongKe.Text = "Thống Kê";
            // 
            // mntDSSinhVienTheoLop
            // 
            this.mntDSSinhVienTheoLop.Image = ((System.Drawing.Image)(resources.GetObject("mntDSSinhVienTheoLop.Image")));
            this.mntDSSinhVienTheoLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntDSSinhVienTheoLop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntDSSinhVienTheoLop.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.mntDSSinhVienTheoLop.Name = "mntDSSinhVienTheoLop";
            this.mntDSSinhVienTheoLop.Size = new System.Drawing.Size(425, 52);
            this.mntDSSinhVienTheoLop.Text = "DS Sinh Viên Theo Lớp";
            // 
            // mntDanhSachDiem
            // 
            this.mntDanhSachDiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntDSDiemTheoLop,
            this.mntDSDiemTheoSinhVien});
            this.mntDanhSachDiem.Image = ((System.Drawing.Image)(resources.GetObject("mntDanhSachDiem.Image")));
            this.mntDanhSachDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntDanhSachDiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntDanhSachDiem.Name = "mntDanhSachDiem";
            this.mntDanhSachDiem.Size = new System.Drawing.Size(425, 52);
            this.mntDanhSachDiem.Text = "Danh Sách Điểm";
            // 
            // mntDSDiemTheoLop
            // 
            this.mntDSDiemTheoLop.Image = ((System.Drawing.Image)(resources.GetObject("mntDSDiemTheoLop.Image")));
            this.mntDSDiemTheoLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntDSDiemTheoLop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntDSDiemTheoLop.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.mntDSDiemTheoLop.Name = "mntDSDiemTheoLop";
            this.mntDSDiemTheoLop.Size = new System.Drawing.Size(250, 52);
            this.mntDSDiemTheoLop.Text = "Lớp";
            // 
            // mntDSDiemTheoSinhVien
            // 
            this.mntDSDiemTheoSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("mntDSDiemTheoSinhVien.Image")));
            this.mntDSDiemTheoSinhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mntDSDiemTheoSinhVien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mntDSDiemTheoSinhVien.Name = "mntDSDiemTheoSinhVien";
            this.mntDSDiemTheoSinhVien.Size = new System.Drawing.Size(250, 52);
            this.mntDSDiemTheoSinhVien.Text = "Sinh Viên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(493, 196);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(476, 38);
            this.txtTimKiem.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(618, 240);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(233, 61);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::QuanLySinhVien.Properties.Resources.dich_vu_chup_anh_ki_yeu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1488, 641);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtTK
            // 
            this.txtTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(527, 315);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(425, 38);
            this.txtTK.TabIndex = 5;
            // 
            // txtMK
            // 
            this.txtMK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(527, 359);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(425, 38);
            this.txtMK.TabIndex = 6;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangNhap.BackColor = System.Drawing.Color.White;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.Location = new System.Drawing.Point(527, 412);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(238, 65);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnLui
            // 
            this.btnLui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLui.BackColor = System.Drawing.Color.White;
            this.btnLui.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLui.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLui.Image = ((System.Drawing.Image)(resources.GetObject("btnLui.Image")));
            this.btnLui.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLui.Location = new System.Drawing.Point(775, 412);
            this.btnLui.Name = "btnLui";
            this.btnLui.Size = new System.Drawing.Size(177, 65);
            this.btnLui.TabIndex = 8;
            this.btnLui.Text = "Lùi Lại";
            this.btnLui.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLui.UseVisualStyleBackColor = false;
            this.btnLui.Click += new System.EventHandler(this.btnLui_Click);
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(1326, 7);
            this.lblClock.Name = "lblClock";
            this.lblClock.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblClock.Size = new System.Drawing.Size(63, 34);
            this.lblClock.TabIndex = 9;
            this.lblClock.Text = "Now";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1333, 33);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTime.Size = new System.Drawing.Size(63, 34);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Now";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1489, 713);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnLui);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnt.ResumeLayout(false);
            this.mnt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnt;
        private System.Windows.Forms.ToolStripMenuItem mntTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mntThongTin;
        private System.Windows.Forms.ToolStripMenuItem mntDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mntDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mntQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mntSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mntMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mntLopHoc;
        private System.Windows.Forms.ToolStripMenuItem mntDiem;
        private System.Windows.Forms.ToolStripMenuItem mntDaoTao;
        private System.Windows.Forms.ToolStripMenuItem mntQLTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mntDSDangKy;
        private System.Windows.Forms.ToolStripMenuItem mntThongKe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnLui;
        private System.Windows.Forms.ToolStripMenuItem mntGiangVien;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolStripMenuItem mntDSSinhVienTheoLop;
        private System.Windows.Forms.ToolStripMenuItem mntDanhSachDiem;
        private System.Windows.Forms.ToolStripMenuItem mntDSDiemTheoLop;
        private System.Windows.Forms.ToolStripMenuItem mntDSDiemTheoSinhVien;
    }
}

