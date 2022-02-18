using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_SOTIETKIEM.DAL;

namespace QL_SOTIETKIEM
{
    public partial class KhachHang : Form
    {
        private STKEntities data = new STKEntities();

        public KhachHang()
        {
            InitializeComponent();
            LoadThongTinKH();
            ChangeGridViewHeaderName();
        }

        private void ChangeGridViewHeaderName()
        {
            dgv1.Columns[0].HeaderText = "Mã Khách Hàng";
            dgv1.Columns[1].HeaderText = "Tên Khách Hàng";
            dgv1.Columns[2].HeaderText = "Số CMND";
            dgv1.Columns[3].HeaderText = "Ngày Cấp";
            dgv1.Columns[4].HeaderText = "Nơi Cấp";
            dgv1.Columns[5].HeaderText = "Địa Chỉ";
            dgv1.Columns[6].HeaderText = "Điện Thoại";
        }

        private void AddLopHocBinding()
        {
            //Refresh lại
            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            dtpNgayCap.DataBindings.Clear();
            txtNoiCap.DataBindings.Clear();
            txtDiachi.DataBindings.Clear();
            txtsoDT.DataBindings.Clear();
            
            //Add lại binding
            txtMaKH.DataBindings.Add("Text", dgv1.DataSource, "MaKH");
            txtTenKH.DataBindings.Add("Text", dgv1.DataSource, "HoTen");
            txtCMND.DataBindings.Add("Text", dgv1.DataSource, "CMND");
            dtpNgayCap.DataBindings.Add("Text", dgv1.DataSource, "NgayCap");
            txtNoiCap.DataBindings.Add("Text", dgv1.DataSource, "NoiCap");
            txtDiachi.DataBindings.Add("Text", dgv1.DataSource, "DiaChi");
            txtsoDT.DataBindings.Add("Text", dgv1.DataSource, "DienThoai");
            
        }
        private void LoadThongTinKH()
        {
            var ds = from KH in data.KhachHangs
                           select new { Makh = KH.MaKH, Hoten = KH.HoTen, cmnd = KH.CMND, Ngaycap = KH.NgayCap, Noicap = KH.NoiCap,
                                               Diachi = KH.DiaChi, Dienthoai = KH.DienThoai };
            dgv1.DataSource = ds.ToList();
            //Add binding
            AddLopHocBinding();
        }



        private void btThoat_Click(object sender, EventArgs e)
        {
            var DR = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Cảnh Báo", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                this.Hide();
                Form1 d = new Form1();
                d.Show();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
            string MaKH = txtMaKH.Text;
            string TenKH = txtTenKH.Text;
            string CMND = txtCMND.Text;
            string NgayCap = dtpNgayCap.Text;
            string NoiCap = txtNoiCap.Text;
            string DiaChi = txtDiachi.Text;
            string DienThoai = txtsoDT.Text;

            //Da xuat hien trong CSDL
            KhachHang kh = data.KhachHangs.Where(k => k.MaKH == MaKH).SingleOrDefault();
            if (MaKH != null)
            {
                MessageBox.Show("Mã lớp học đã tồn tại");
                return;
            }
            else if (String.IsNullOrEmpty(MaKH) || String.IsNullOrEmpty(TenKH))
            {
                MessageBox.Show("Mã lớp hoặc Tên lớp không được để trống");
                return;
            }
            else
            {
                lop = new LOPHOC();
                lop.MALOP = MaLop;
                lop.TENLOP = TenLop;
                data.LOPHOCs.Add(lop);
                data.SaveChanges();
                LoadThongTinLop();
                MessageBox.Show("Thêm mới lớp học thành công");
            }
        
        }
    }
}
