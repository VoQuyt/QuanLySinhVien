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
    public partial class QLTaiKhoan : Form
    {
        public QLTaiKhoan()
        {
            InitializeComponent();
        }

        private static QLTaiKhoan _Instance = null;

        public static QLTaiKhoan Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLTaiKhoan();
                return _Instance;
            }
        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> lstTaiKhoan = TaiKhoanBUS.LayDanhSachTaiKhoan();

            lsvTaiKhoan.Columns.Add("ID", 50);
            lsvTaiKhoan.Columns.Add("Tên Tài Khoản", 180);
            lsvTaiKhoan.Columns.Add("Mật Khẩu", 200);
            lsvTaiKhoan.Columns.Add("Quyền Hạn", 150);
            lsvTaiKhoan.Columns.Add("Trạng Thái", 150);

            lsvTaiKhoan.View = View.Details;
            lsvTaiKhoan.GridLines = true;
            lsvTaiKhoan.FullRowSelect = true;
            LoadTaiKhoan(lstTaiKhoan);
        }

        private void LoadTaiKhoan(List<TaiKhoanDTO> lstTaiKhoan)
        {
            lsvTaiKhoan.Items.Clear();
            for (int i = 0; i < lstTaiKhoan.Count; i++)
            {
                TaiKhoanDTO sp = lstTaiKhoan[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sp.ID.ToString();
                lvi.SubItems.Add(sp.TenTaiKhoan);
                lvi.SubItems.Add(sp.MatKhau);
                lvi.Tag = sp;
                if (sp.PhanQuyen == 1)
                    lvi.SubItems.Add("Admin");
                else if (sp.PhanQuyen == 2)
                    lvi.SubItems.Add("Thu Ngân");
                else if (sp.PhanQuyen == 3)
                    lvi.SubItems.Add("Giáo Viên");
                if (sp.TrangThai == true)
                    lvi.SubItems.Add("Còn Sử dụng");
                else
                    lvi.SubItems.Add("Hết sử dụng");
                lsvTaiKhoan.Items.Add(lvi);
            }
        }

        private void lsvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvTaiKhoan.SelectedItems[0];
                TaiKhoanDTO sp = (TaiKhoanDTO)lvi.Tag;
                // txtTaiKhoan.Enabled = false;
                txtID.Text = sp.ID.ToString();
                txtTaiKhoan.Text = sp.TenTaiKhoan;
                txtMatKhau.Text = sp.MatKhau;
                if (sp.PhanQuyen == 1)
                    radAdmin.Checked = true;
                if(sp.PhanQuyen == 2)
                    radUser1.Checked = true;
                if (sp.PhanQuyen == 3)
                    radUser2.Checked = true;
                if (sp.TrangThai == true)
                    chkTrangThai.Checked = true;
                else
                    chkTrangThai.Checked = false;
            }

            else
            {
                txtTaiKhoan.Enabled = true;
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                radAdmin.Text = "Admin";
                radUser1.Text = "User";
                chkTrangThai.Checked = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenTaiKhoan = txtTaiKhoan.Text;
            tk.MatKhau = txtMatKhau.Text;
            if (radAdmin.Checked == true)
                tk.PhanQuyen = 1;
            else if (radUser1.Checked == true)
                tk.PhanQuyen = 2;
            else if (radUser2.Checked == true)
                tk.PhanQuyen = 3;

            if (chkTrangThai.Checked)
            {
                tk.TrangThai = true;
            }
            else
            {
                tk.TrangThai = false;
            }
            if (TaiKhoanBUS.KiemTraTaiKhoanTonTai(tk))
            {
                MessageBox.Show("Thêm thành công");
                Clear();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
                tk = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO sp = new TaiKhoanDTO();
            sp.ID = Convert.ToInt32(txtID.Text);
            sp.TenTaiKhoan = txtTaiKhoan.Text;
            sp.MatKhau = txtMatKhau.Text;
            if (radAdmin.Checked == true)
                sp.PhanQuyen = 1;
            else if (radUser1.Checked == true)
                sp.PhanQuyen = 2;
            else if (radUser2.Checked == true)
                sp.PhanQuyen = 3;
            if (chkTrangThai.Checked)
                sp.TrangThai = true;
            else
                sp.TrangThai = false;
            if (TaiKhoanBUS.KiemTraTrungTenTaiKhoan(sp.TenTaiKhoan) == true)
            {
                if (TaiKhoanBUS.CapNhatTaiKhoan(sp))
                {
                    MessageBox.Show("Cập nhật thành công");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Cập Nhật Thất Bại");
                    sp = null;
                }
            }
            else
            {
                MessageBox.Show("Tên Tài Khoản Đã Có Người Sữ Dụng");
                sp = null;
            }
            Clear();
        }

        private void Clear()
        {
            List<TaiKhoanDTO> lstTaiKhoan = TaiKhoanBUS.LayDanhSachTaiKhoan();
            LoadTaiKhoan(lstTaiKhoan);
            txtMatKhau.Text = txtTaiKhoan.Text = txtID.Text = "";
            radAdmin.Checked = radUser1.Checked = false;
            chkTrangThai.Checked = false;
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenTaiKhoan = txtTaiKhoan.Text;
            tk.ID = Convert.ToInt32(txtID.Text);
            if (tk != null)
            {
                DialogResult dr = MessageBox.Show("Xác nhận xóa tài khoản?", "Xóa tài khoản!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (TaiKhoanBUS.XoaTaiKhoan(tk.ID))
                    {
                        MessageBox.Show("Xóa tài khoản thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
            }
        }
    }
}
