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
    public partial class QLDangKy : Form
    {
        public QLDangKy()
        {
            InitializeComponent();
            btnSua.Enabled = false;
        }

        private static QLDangKy _Instance = null;

        public static QLDangKy Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLDangKy();
                return _Instance;
            }
        }

        private void QLDangKy_Load(object sender, EventArgs e)
        {
            List<LopHocDTO> lstLop = LopHocBUS.LayDanhSachLopHocChuaKhaiGiang();
            LopHocDTO aLL = new LopHocDTO();
            aLL.MaLop = 0;
            aLL.TenLop = "Tất Cả";
            lstLop.Insert(0, aLL);
            //
            cboMaLop.DisplayMember = "TenLop";
            cboMaLop.ValueMember = "MaLop";
            cboMaLop.DataSource = lstLop;
            cboMaLop.SelectedValue = 0;

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

            List<DangKyDTO> listDangKi = DangKiBUS.LayDanhSachDangKi();
            lsvDangKi.Columns.Add("TÊN LỚP", 450, HorizontalAlignment.Center);
            lsvDangKi.Columns.Add("HỌ", 200, HorizontalAlignment.Center);
            lsvDangKi.Columns.Add("TÊN", 150, HorizontalAlignment.Center);
            lsvDangKi.Columns.Add("NGÀY ĐĂNG KÝ", 200, HorizontalAlignment.Center);
            lsvDangKi.Columns.Add("TRẠNG THÁI", 200, HorizontalAlignment.Center);


            lsvDangKi.View = View.Details;
            lsvDangKi.GridLines = true;
            lsvDangKi.FullRowSelect = true;
            LoadDangKi(listDangKi);
        }

        private void LoadDangKi(List<DangKyDTO> listDangKi)
        {
            lsvDangKi.Items.Clear();
            for (int i = 0; i < listDangKi.Count; i++)
            {
                DangKyDTO sp = listDangKi[i];
                ListViewItem lvi = new ListViewItem(); 
                lvi.Text = sp.MaLop;
                lvi.SubItems.Add(sp.TenSV.ToString());
                lvi.Tag = sp;
                lvi.SubItems.Add(sp.MaSV);
                lvi.SubItems.Add(sp.NgayDangKi.ToString("dd/MM/yyyy"));
                if (sp.TrangThai == true)
                {
                    //if (DangKiBUS.Xoa(cboMaSV.SelectedValue.ToString(), cboMaLop.SelectedValue.ToString()))
                        lvi.SubItems.Add("Đã Đống Tiền");
                       // MessageBox.Show("ĐÃ XỬ LÝ");
                }
                else
                    lvi.SubItems.Add("Chưa Đống Tiền");
                lsvDangKi.Items.Add(lvi);
            }
        }

        private void lsvDangKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            if (lsvDangKi.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvDangKi.SelectedItems[0];
                DangKyDTO sp = (DangKyDTO)lvi.Tag;
                cboMaSV.Text = sp.MaSV;
                //MessageBox.Show(cboMaSV.SelectedValue.ToString());
                List<LopHocDTO> listLop = LopHocBUS.LayDanhSachLopHocTheoSV(cboMaSV.SelectedValue.ToString());
                cboMaLop.DisplayMember = "TenLop";
                cboMaLop.ValueMember = "MaLop";
                cboMaLop.DataSource = listLop;
                txtTenSinhVien.Text = sp.TenSV + " " + sp.MaSV;
                cboMaLop.Text = sp.MaLop;
                //MessageBox.Show(cboMaLop.SelectedValue.ToString());
                dtpTime.Text = sp.NgayDangKi.ToString();
                if (sp.TrangThai == true)
                {
                    chkTrangThai.Checked = true;
                    //chkTrangThai.Enabled = false;
                    btnSua.Enabled = false;
                }
                else
                {
                    chkTrangThai.Checked = false;
                    //chkTrangThai.Enabled = true;
                    btnSua.Enabled = true;
                }
            }
            else
            {
                Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DiemDTO diemDTO = new DiemDTO();
            //MessageBox.Show(cboMaLop.SelectedValue.ToString());
            diemDTO.MaLop = cboMaLop.SelectedValue.ToString();
            diemDTO.MaSV = cboMaSV.SelectedValue.ToString();
            diemDTO.DiemChuyenCan = 0;
            diemDTO.DiemTBKT = 0;
            diemDTO.DiemThi = 0;
            if (DiemBUS.KiemtraThemTraSinhVienVaoDSDiem(diemDTO))
            {
                if (DangKiBUS.Xoa(diemDTO.MaLop, diemDTO.MaSV))
                    MessageBox.Show("ĐÃ THÊM SINH VIÊN VÀO LỚP!!!");
                else
                    MessageBox.Show("THÊM SINH VIÊN VÀO LỚP THẤT BẠI!!!");
            }
            else
                MessageBox.Show("THÊM SINH VIÊN VÀO LỚP THẤT BẠI!!!");
            Clear();
        }


        private void Clear()
        {
            btnSua.Enabled = false; ;
            List<DangKyDTO> listDangKi = DangKiBUS.LayDanhSachDangKi();
            LoadDangKi(listDangKi);
            txtTenSinhVien.Text = cboMaSV.Text = "";
            cboNganh.SelectedIndex = cboHe.SelectedIndex = 0;
            chkTrangThai.Checked = false;
            List<LopHocDTO> lstLop = LopHocBUS.LayDanhSachLopHocDangHoc();
            LopHocDTO aLL = new LopHocDTO();
            aLL.MaLop = 0;
            aLL.TenLop = "Tất Cả";
            lstLop.Insert(0, aLL);
            //
            cboMaLop.DisplayMember = "TenLop";
            cboMaLop.ValueMember = "MaLop";
            cboMaLop.DataSource = lstLop;
            cboMaLop.SelectedValue = 0;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<DangKyDTO> listSV;
            if (cboMaLop.Text != "Tất Cả" && txtTenSinhVien.Text == "")
                listSV = DangKiBUS.LayDanhSachSVDangKiTheoLop(cboMaLop.SelectedValue.ToString());
            else
            {
                if (txtTenSinhVien.Text == "" && cboNganh.Text == "Tất Cả" && cboHe.Text == "Tất Cả")
                    listSV = DangKiBUS.LayDanhSachDangKi();
                else
                    listSV = DangKiBUS.Timkiemsinhvien(txtTenSinhVien.Text, cboNganh.SelectedValue.ToString(), cboHe.SelectedValue.ToString());
            }
            LoadDangKi(listSV);
        }
    }
}
