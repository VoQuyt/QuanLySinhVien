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
    public partial class QLMonHoc : Form
    {
        public QLMonHoc()
        {
            InitializeComponent();
            btnXoa.Visible = false;
            btnSua.Enabled = false;
        }

        private static QLMonHoc _Instance = null;

        public static QLMonHoc Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLMonHoc();
                return _Instance;
            }
        }

        private void QLMonHoc_Load(object sender, EventArgs e)
        {
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

            List<MonHocDTO> lstMonHoc = MonHocBUS.LayDanhSachTatCaMonHoc();
            lsvMonHoc.Columns.Add("MÃ MÔN HỌC", 50, HorizontalAlignment.Center);
            lsvMonHoc.Columns.Add("TÊN MÔN HỌC", 250, HorizontalAlignment.Left);
            lsvMonHoc.Columns.Add("SỐ TÍN CHỈ", 150, HorizontalAlignment.Center);
            lsvMonHoc.Columns.Add("NGÀNH", 250, HorizontalAlignment.Left);
            lsvMonHoc.Columns.Add("HỆ ĐÀO TẠO", 250, HorizontalAlignment.Left);
            lsvMonHoc.Columns.Add("TRẠNG THÁI", 250, HorizontalAlignment.Left);


            lsvMonHoc.View = View.Details;
            lsvMonHoc.GridLines = true;
            lsvMonHoc.FullRowSelect = true;
            LoadMonHoc(lstMonHoc);
        }

        private void LoadMonHoc(List<MonHocDTO> lstMonHoc)
        {
            lsvMonHoc.Items.Clear();
            for (int i = 0; i < lstMonHoc.Count; i++)
            {
                MonHocDTO sp = lstMonHoc[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sp.MaMonHoc.ToString();
                lvi.Tag = sp;
                lvi.SubItems.Add(sp.TenMonHoc);
                lvi.SubItems.Add(sp.SoTinChi.ToString());
                lvi.SubItems.Add(sp.MaNganh.ToString());
                lvi.SubItems.Add(sp.MaHe.ToString());
                if (sp.TrangThai == true)
                    lvi.SubItems.Add("Còn áp dụng");
                else
                {
                    lvi.SubItems.Add("Hết áp dụng");
                }
                lsvMonHoc.Items.Add(lvi);
            }
        }

        private void lsvMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnThem.Enabled = false;
            if (lsvMonHoc.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvMonHoc.SelectedItems[0];
                MonHocDTO sp = (MonHocDTO)lvi.Tag;
                txtMaMH.Text = sp.MaMonHoc.ToString();
                txtTenMonHoc.Text = sp.TenMonHoc;
                txtSoTinChi.Text = sp.SoTinChi.ToString();
                cboNganh.Text = sp.MaNganh;
                cboHe.Text = sp.MaHe;
                if (sp.TrangThai == true)
                {
                    chkTrangThai.Checked = true;
                }
                else
                {
                    chkTrangThai.Checked = false;
                }
            }
            else
            {
                cboNganh.SelectedIndex = -1;
                cboHe.SelectedIndex = -1;
                txtSoTinChi.Text = "";
                txtMaMH.Text = txtTenMonHoc.Text = "";
                chkTrangThai.Checked = false;
            }
        }

        private void Clear()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            cboNganh.SelectedIndex = 0;
            cboHe.SelectedIndex = 0;
            txtSoTinChi.Text = "";
            txtMaMH.Text = txtTenMonHoc.Text = "";
            chkTrangThai.Checked = false;
            List<MonHocDTO> lstMonHoc = MonHocBUS.LayDanhSachTatCaMonHoc();
            LoadMonHoc(lstMonHoc);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<MonHocDTO> listMH;
            if (txtTenMonHoc.Text == "" && cboNganh.Text == "Tất Cả" && cboHe.Text == "Tất Cả")
                listMH = MonHocBUS.LayDanhSachTatCaMonHoc();
            else
                listMH = MonHocBUS.TimKiemMonHoc(txtTenMonHoc.Text, cboNganh.SelectedValue.ToString(), cboHe.SelectedValue.ToString());
            LoadMonHoc(listMH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMonHoc.Text == "")
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            else
            {
                MonHocDTO mh = new MonHocDTO();
                mh.TenMonHoc = txtTenMonHoc.Text;
                mh.MaNganh = cboNganh.SelectedValue.ToString();
                mh.MaHe = cboHe.SelectedValue.ToString();
                mh.SoTinChi = Convert.ToInt32(txtSoTinChi.Text);
                if (chkTrangThai.Checked)
                {
                    mh.TrangThai = true;
                }
                else
                {
                    mh.TrangThai = false;
                }
                if (MonHocBUS.ThemMonHoc(mh))
                {
                    MessageBox.Show("Thêm thành công");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    mh = null;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MonHocDTO mh = new MonHocDTO();
            mh.MaMonHoc = Convert.ToInt32(txtMaMH.Text);
            mh.TenMonHoc = txtTenMonHoc.Text;
            mh.SoTinChi = Convert.ToInt32(txtSoTinChi.Text);
            mh.MaNganh = cboNganh.SelectedValue.ToString();
            mh.MaHe = cboHe.SelectedValue.ToString();
            if (chkTrangThai.Checked)
            {
                mh.TrangThai = true;
            }
            else
            {
                mh.TrangThai = false;
            }
            if (MonHocBUS.CapNhatMonHoc(mh))
            {
                MessageBox.Show("Cập nhật thành công");
                Clear();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
