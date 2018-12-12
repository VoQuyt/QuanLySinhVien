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
    public partial class QLPhongDaoTao : Form
    {
        public QLPhongDaoTao()
        {
            InitializeComponent();
        }

        private static QLPhongDaoTao _Instance = null;

        public static QLPhongDaoTao Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLPhongDaoTao();
                return _Instance;
            }
        }

        private void QLPhongDaoTao_Load(object sender, EventArgs e)
        {
            List<HeDaoTaoDTO> listHe = HeDaoTaoBUS.LayDanhSachTatCaHe();
            lsvHeDaoTao.Columns.Add("Mã Hệ", 100, HorizontalAlignment.Center);
            lsvHeDaoTao.Columns.Add("Tên Hệ", 250, HorizontalAlignment.Center);
            lsvHeDaoTao.Columns.Add("Trạng Thái", 180, HorizontalAlignment.Center);


            List<NganhDTO> listNganh = NganhBUS.LayDanhSachTatCaNganh();
            lsvNganh.Columns.Add("Mã Ngành", 100, HorizontalAlignment.Center);
            lsvNganh.Columns.Add("Tên Ngành", 250, HorizontalAlignment.Center);
            lsvNganh.Columns.Add("Trạng Thái", 180, HorizontalAlignment.Center);


            lsvHeDaoTao.View = View.Details;
            lsvHeDaoTao.GridLines = true;
            lsvHeDaoTao.FullRowSelect = true;

            lsvNganh.View = View.Details;
            lsvNganh.GridLines = true;
            lsvNganh.FullRowSelect = true;


            LoadHeDaoTao(listHe);
            LoadNganh(listNganh);
        }

        private void LoadHeDaoTao(List<HeDaoTaoDTO> listHe)
        {
            lsvHeDaoTao.Items.Clear();
            for (int i = 0; i < listHe.Count(); i++)
            {
                HeDaoTaoDTO he = listHe[i];
                ListViewItem liv = new ListViewItem();
                liv.Text = he.MaHe.ToString();
                liv.SubItems.Add(he.TenHe);
                if(he.TrangThai == true)
                    liv.SubItems.Add("Còn Áp Dụng");
                else
                    liv.SubItems.Add("Hết Áp Dụng");
                liv.Tag = he;
                lsvHeDaoTao.Items.Add(liv);
            }
        }
        private void LoadNganh(List<NganhDTO> listNganh)
        {
            lsvNganh.Items.Clear();
            for (int i = 0; i < listNganh.Count(); i++)
            {
                NganhDTO nganh = listNganh[i];
                ListViewItem liv = new ListViewItem();
                liv.Text = nganh.MaNganh.ToString();
                liv.SubItems.Add(nganh.TenNganh);
                if (nganh.TrangThai == true)
                    liv.SubItems.Add("Còn Áp Dụng");
                else
                    liv.SubItems.Add("Hết Áp Dụng");
                liv.Tag = nganh;
                lsvNganh.Items.Add(liv);
            }
        }

        private void lsvHeDaoTao_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnThemHe.Enabled = false;
            bntThemNganh.Enabled = false;
            if (lsvHeDaoTao.SelectedItems.Count > 0)
            {
                ListViewItem liv = lsvHeDaoTao.SelectedItems[0];
                HeDaoTaoDTO he = (HeDaoTaoDTO)liv.Tag;
                txtMaHe.Text = he.MaHe.ToString();
                txtTenHe.Text = he.TenHe;
                if (he.TrangThai == true)
                    chkHe.Checked = true;
                else
                    chkHe.Checked = false;
            }
            else
            {
                ClearHe();
            }
        }

        private void lsvNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnThemHe.Enabled = false;
            bntThemNganh.Enabled = false;
            if (lsvNganh.SelectedItems.Count > 0)
            {     
                ListViewItem liv = lsvNganh.SelectedItems[0];
                NganhDTO nganh = (NganhDTO)liv.Tag;
                txtMaNganh.Text = nganh.MaNganh.ToString();
                txtTenNganh.Text = nganh.TenNganh;
                if (nganh.TrangThai == true)
                    chkNganh.Checked = true;
                else
                    chkNganh.Checked = false;
            }
            else
            {
                ClearNganh();
            }
        }

        private void ClearHe()
        {
            txtMaHe.Text = txtTenHe.Text = "";
            chkHe.Checked = false;
            btnThemHe.Enabled = true;
            bntThemNganh.Enabled = true;
        }

        private void ClearNganh()
        {
            txtMaNganh.Text = txtTenNganh.Text = "";
            chkNganh.Checked = false;
            btnThemHe.Enabled = true;
            bntThemNganh.Enabled = true;
        }

        private void btnThemHe_Click(object sender, EventArgs e)
        {
            if (txtTenHe.Text == "")
            {
                MessageBox.Show("Thêm thất bại");
            }
            else
            {
                HeDaoTaoDTO he = new HeDaoTaoDTO();
                he.TenHe = txtTenHe.Text;
                if (chkHe.Checked == true)
                    he.TrangThai = true;
                else
                    he.TrangThai = false;
                if (HeDaoTaoBUS.ThemHeDaoTao(he))
                {
                    MessageBox.Show("Thêm thành công");
                    List<HeDaoTaoDTO> lstHe = HeDaoTaoBUS.LayDanhSachHe();
                    LoadHeDaoTao(lstHe);
                    ClearHe();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    he = null;
                }
            }
        }

        private void bntThemNganh_Click(object sender, EventArgs e)
        {
            if (txtTenNganh.Text == "")
            {
                MessageBox.Show("Thêm thất bại");
            }
            else
            {
                NganhDTO nganh = new NganhDTO();
                nganh.TenNganh = txtTenNganh.Text;
                if (chkNganh.Checked == true)
                    nganh.TrangThai = true;
                else
                    nganh.TrangThai = false;

                if (NganhBUS.ThemNganh(nganh))
                {
                    MessageBox.Show("Thêm thành công");
                    List<NganhDTO> lstNganh = NganhBUS.LayDanhSachNganh();
                    LoadNganh(lstNganh);
                    ClearNganh();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    nganh = null;
                }
            }
        }

        private void btnSuaHe_Click(object sender, EventArgs e)
        {
            if (txtTenHe.Text == "")
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            else
            {
                HeDaoTaoDTO he = new HeDaoTaoDTO();
                he.MaHe = Convert.ToInt32(txtMaHe.Text);
                he.TenHe = txtTenHe.Text;
                if (chkHe.Checked == true)
                    he.TrangThai = true;
                else
                    he.TrangThai = false;
                if (HeDaoTaoBUS.CapNhatHeDaoTao(he))
                {
                    MessageBox.Show("Cập nhật thành công");
                    List<HeDaoTaoDTO> lstHe = HeDaoTaoBUS.LayDanhSachHe();
                    LoadHeDaoTao(lstHe);
                    ClearHe();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private void btnSuaNganh_Click(object sender, EventArgs e)
        {
            if (txtTenNganh.Text == "")
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            else
            {
                NganhDTO nganh = new NganhDTO();
                nganh.MaNganh = Convert.ToInt32(txtMaNganh.Text);
                nganh.TenNganh = txtTenNganh.Text;
                if (chkNganh.Checked == true)
                    nganh.TrangThai = true;
                else
                    nganh.TrangThai = false;
                if (NganhBUS.CapNhatNganh(nganh))
                {
                    MessageBox.Show("Cập nhật thành công");
                    List<NganhDTO> lstNganh = NganhBUS.LayDanhSachNganh();
                    LoadNganh(lstNganh);
                    ClearNganh();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private void btnXoaHe_Click(object sender, EventArgs e)
        {
            if (txtTenHe.Text == "")
            {
                MessageBox.Show("Xóa thất bại");
            }
            else
            {
                HeDaoTaoDTO he = new HeDaoTaoDTO();
                he.MaHe = Convert.ToInt32(txtMaHe.Text);
                if (he != null)
                {
                    DialogResult dr = MessageBox.Show("BẠN CÓ CHẮC MUỐN XÓA HỆ " + txtTenHe.Text, "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (HeDaoTaoBUS.XoaHeDaoTao(he.MaHe))
                        {
                            MessageBox.Show("Xóa Thành Công");
                            List<HeDaoTaoDTO> lstHe = HeDaoTaoBUS.LayDanhSachHe();
                            LoadHeDaoTao(lstHe);
                            txtMaHe.Enabled = true;
                            ClearHe();
                        }
                        else
                        {
                            MessageBox.Show("Xóa Thất Bại");
                        }
                    }
                }
            }
        }

        private void btnXoaNganh_Click(object sender, EventArgs e)
        {
            if (txtTenHe.Text == "")
            {
                MessageBox.Show("Xóa thất bại");
            }
            else
            {
                NganhDTO nganh = new NganhDTO();
                nganh.MaNganh = Convert.ToInt32(txtMaNganh.Text);
                if (nganh != null)
                {
                    DialogResult dr = MessageBox.Show("BẠN CÓ CHẮC MUỐN XÓA NGÀNH " + txtTenNganh.Text, "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (NganhBUS.XoaNganh(nganh.MaNganh))
                        {
                            MessageBox.Show("Xóa Thành Công");
                            List<NganhDTO> lstNganh = NganhBUS.LayDanhSachNganh();
                            LoadNganh(lstNganh);
                            txtMaNganh.Enabled = true;
                            ClearNganh();
                        }
                        else
                        {
                            MessageBox.Show("Xóa Thất Bại");
                        }
                    }
                }
            }
        }
    }
}
