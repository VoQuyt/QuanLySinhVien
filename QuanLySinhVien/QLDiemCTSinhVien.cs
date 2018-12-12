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
    public partial class QLDiemCTSinhVien : Form
    {
        public QLDiemCTSinhVien()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        public void LayMaSV(Label lblma, Label lblten)
        {
            lblTenSV.Text = lblten.Text;
            lblmasv.Text = lblma.Text;
        }
        private void LoadDiem(List<DiemDTO> lstDiem)
        {
            lsvDiem.Items.Clear();
            for (int i = 0; i < lstDiem.Count; i++)
            {
                DiemDTO sp = lstDiem[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sp.MaLop;
                //lvi.SubItems.Add(sp.MaSV);
                lvi.Tag = sp;
                lvi.SubItems.Add(sp.DiemChuyenCan.ToString());
                lvi.SubItems.Add(sp.DiemTBKT.ToString());
                lvi.SubItems.Add(sp.DiemThi.ToString());
                lvi.SubItems.Add((sp.DiemChuyenCan * 0.1 + sp.DiemTBKT * 0.4 + sp.DiemThi * 0.5).ToString());
                lsvDiem.Items.Add(lvi);
            }
        }
        private void QLDiemCTSinhVien_Load(object sender, EventArgs e)
        {

            //List<LopHocDTO> lstLop = LopHocBUS.LayDanhSachTatCaLopHoc();
            //LopHocDTO aLL = new LopHocDTO();
            //aLL.MaLop = 0;
            //aLL.TenLop = "Tất Cả";
            //lstLop.Insert(0, aLL);
            ////
            //cboMaLop.DisplayMember = "TenLop";
            //cboMaLop.ValueMember = "MaLop";
            //cboMaLop.DataSource = lstLop;
            //cboMaLop.SelectedValue = 0;

            List<DiemDTO> lstDiem = DiemBUS.LayDanhSachDiemTheoSV(lblmasv.Text);
            lsvDiem.Columns.Add("TÊN MÔN HỌC", 200, HorizontalAlignment.Center);
            lsvDiem.Columns.Add("ĐIỂM CHUYÊN CẦN", 180, HorizontalAlignment.Center);
            lsvDiem.Columns.Add("ĐIỂM TBKT", 100, HorizontalAlignment.Center);
            lsvDiem.Columns.Add("ĐIỂM THI", 100, HorizontalAlignment.Center);
            lsvDiem.Columns.Add("ĐIỂM TỔNG", 150, HorizontalAlignment.Center);

            lsvDiem.View = View.Details;
            lsvDiem.GridLines = true;
            lsvDiem.FullRowSelect = true;
            LoadDiem(lstDiem);
        }

        private void lsvDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lsvDiem.SelectedItems.Count > 0)
            //{
            //    ListViewItem liv = lsvDiem.SelectedItems[0];
            //    DiemDTO lop = (DiemDTO)liv.Tag;
            //    cboMaLop.Text = lop.MaLop.ToString();
            //}
            //MessageBox.Show(cboMaLop.SelectedValue.ToString());
        }
    }
}
