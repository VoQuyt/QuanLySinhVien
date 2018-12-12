using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLySinhVien
{
    public partial class QLDiem : Form
    {
        public QLDiem()
        {
            InitializeComponent();
            btnSua.Enabled = false;
        }

        private static QLDiem _Instance = null;

        public static QLDiem Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLDiem();
                return _Instance;
            }
        }

        Label Name = new Label();

        public void LayMaGV(TextBox txtTKFrmHome)
        {
            Name.Text = txtTKFrmHome.Text;
        }
        private void QLDiem_Load(object sender, EventArgs e)
        {
            List<LopHocDTO> lstLop = new List<LopHocDTO>();
            List<DiemDTO> lstDiem = new List<DiemDTO>();

            if (TaiKhoanBUS.CheckQuyenHan(Name.Text) == 3)
            {
                lstLop = LopHocBUS.LayDSlopTheoGiangVien(Name.Text);
                cboHe.Visible = false;
                cboNganh.Visible = false;
                lblHDT.Visible = false;
                lblNganh.Visible = false;
            }

            else if (TaiKhoanBUS.CheckQuyenHan(Name.Text) == 1)
            {
                lstLop = LopHocBUS.LayDanhSachTatCaLopHoc();
                lstDiem = DiemBUS.LayDanhSachDiem();
                cboHe.Visible = true;
                cboNganh.Visible = true;
                lblHDT.Visible = true;
                lblNganh.Visible = true;
            }

            List<NganhDTO> listNganh = NganhBUS.LayDanhSachNganh();
            NganhDTO all = new NganhDTO();
            all.MaNganh = 0;
            all.TenNganh = "Tất Cả";
            all.TrangThai = false;
            listNganh.Insert(0, all);
            //
            cboNganh.DisplayMember = "TenNganh";
            cboNganh.ValueMember = "MaNganh";
            cboNganh.DataSource = listNganh;
            cboNganh.SelectedValue = 0;

            List<HeDaoTaoDTO> listHeDaoTao = HeDaoTaoBUS.LayDanhSachHe();
            HeDaoTaoDTO alL = new HeDaoTaoDTO();
            alL.MaHe = 0;
            alL.TenHe = "Tất Cả";
            alL.TrangThai = false;
            listHeDaoTao.Insert(0, alL);
            //
            cboHe.DisplayMember = "TenHe";
            cboHe.ValueMember = "MaHe";
            cboHe.DataSource = listHeDaoTao;
            cboHe.SelectedValue = 0;

            List<SinhVienDTO> lstSV = SinhVienBUS.GetListSinhVien();
            cboMaSV.DisplayMember = "Ten";
            cboMaSV.ValueMember = "MaSV";
            cboMaSV.DataSource = lstSV;
            LopHocDTO aLL = new LopHocDTO();
            aLL.MaLop = 0;
            aLL.TenLop = "Tất Cả";
            lstLop.Insert(0, aLL);
            //
            cboMaLop.DisplayMember = "TenLop";
            cboMaLop.ValueMember = "MaLop";
            cboMaLop.DataSource = lstLop;
            cboMaLop.SelectedValue = 0;

            if (TaiKhoanBUS.CheckQuyenHan(Name.Text) == 3)
            {
                cboMaLop.SelectedIndex = 1;
                lstDiem = DiemBUS.LayDanhSachDiemSVTheoLop(cboMaLop.SelectedValue.ToString());
            }

            lsvDiem.Columns.Add("TÊN LỚP", 450, HorizontalAlignment.Center);
            lsvDiem.Columns.Add("HỌ", 250, HorizontalAlignment.Center);
            lsvDiem.Columns.Add("TÊN", 120, HorizontalAlignment.Center);
            lsvDiem.Columns.Add("ĐIỂM CHUYÊN CẦN", 180, HorizontalAlignment.Center);
            lsvDiem.Columns.Add("ĐIỂM TBKT", 120, HorizontalAlignment.Center);
            lsvDiem.Columns.Add("ĐIỂM THI", 120, HorizontalAlignment.Center);
            lsvDiem.Columns.Add("ĐIỂM TỔNG", 120, HorizontalAlignment.Center);

            lsvDiem.View = View.Details;
            lsvDiem.GridLines = true;
            lsvDiem.FullRowSelect = true;
            LoadDiem(lstDiem);
        }

        private void LoadDiem(List<DiemDTO> lstDiem)
        {
            lsvDiem.Items.Clear();
            for (int i = 0; i < lstDiem.Count; i++)
            {
                DiemDTO sp = lstDiem[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (sp.MaLop.ToString());
                lvi.SubItems.Add(sp.TenSV.ToString());
                lvi.SubItems.Add(sp.MaSV.ToString());
                lvi.Tag = sp;
                lvi.SubItems.Add(sp.DiemChuyenCan.ToString());
                lvi.SubItems.Add(sp.DiemTBKT.ToString());
                lvi.SubItems.Add(sp.DiemThi.ToString());
                sp.DiemTong = sp.DiemChuyenCan * 0.1 + sp.DiemTBKT * 0.4 + sp.DiemThi * 0.5;
                lvi.SubItems.Add(sp.DiemTong.ToString());
                lsvDiem.Items.Add(lvi);
            }
        }

        private void lsvDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            if (lsvDiem.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvDiem.SelectedItems[0];
                DiemDTO diem = (DiemDTO)lvi.Tag;
                cboMaLop.Text = diem.MaLop;
                txtTenSinhVien.Text = diem.TenSV + " "+ diem.MaSV;
                txtDiemChuyenCan.Text = diem.DiemChuyenCan.ToString();
                txtTBKT.Text = diem.DiemTBKT.ToString();
                txtDiemThi.Text = diem.DiemThi.ToString();
                cboMaSV.Text = diem.MaSV;
            }
            else
            {
                txtTBKT.Text = txtTenSinhVien.Text = txtDiemChuyenCan.Text = txtDiemThi.Text = "";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DiemDTO diemDTO = new DiemDTO();
            diemDTO.MaLop = cboMaLop.SelectedValue.ToString();
            diemDTO.MaSV = cboMaSV.SelectedValue.ToString();
            diemDTO.DiemChuyenCan = Convert.ToDouble(txtDiemChuyenCan.Text);
            diemDTO.DiemTBKT = Convert.ToDouble(txtTBKT.Text);
            diemDTO.DiemThi = Convert.ToDouble(txtDiemThi.Text);
            diemDTO.DiemTong =  diemDTO.DiemChuyenCan * 0.1 + diemDTO.DiemTBKT * 0.4 + diemDTO.DiemThi * 0.5;
            if (DiemBUS.CapNhatDiem(diemDTO))
            {
                MessageBox.Show("Cập Nhật Thành Công!!!");
                Clear();
            }
            else
            {
                MessageBox.Show("Cập Nhật Thất Bại!!!");
                //List<DiemDTO> listDiem = DiemBUS.LayDanhSachDiem();
                //LoadDiem(listDiem);
            }
        }

        private void Clear()
        {
            btnSua.Enabled = false;
            txtTBKT.Text = txtTenSinhVien.Text = txtDiemChuyenCan.Text = txtDiemThi.Text = "";
            cboHe.SelectedIndex = cboMaLop.SelectedIndex = cboNganh.SelectedIndex = 0;
            List<DiemDTO> lstDiem = new List<DiemDTO>();

            if (TaiKhoanBUS.CheckQuyenHan(Name.Text) == 3)
            {
                cboHe.Enabled = false;
                cboNganh.Enabled = false;
                cboMaLop.SelectedIndex = 1;
                lstDiem = DiemBUS.LayDanhSachDiemSVTheoLop(cboMaLop.SelectedValue.ToString());
            }

            else if (TaiKhoanBUS.CheckQuyenHan(Name.Text) == 1)
            {
                lstDiem = DiemBUS.LayDanhSachDiem();
            }
            LoadDiem(lstDiem);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<DiemDTO> listSV;
            if (cboMaLop.Text != "Tất Cả" && txtTenSinhVien.Text == "")
                listSV = DiemBUS.LayDanhSachDiemSVTheoLop(cboMaLop.SelectedValue.ToString());
            else
            {
                if (txtTenSinhVien.Text == "" && cboNganh.Text == "Tất Cả" && cboHe.Text == "Tất Cả")
                    listSV = DiemBUS.LayDanhSachDiem();
                else
                    listSV = DiemBUS.Timkiemsinhvien(txtTenSinhVien.Text, cboNganh.SelectedValue.ToString(), cboHe.SelectedValue.ToString());
            }
            LoadDiem(listSV);
        }
    }
}
