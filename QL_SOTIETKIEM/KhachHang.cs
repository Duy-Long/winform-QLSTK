using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_SOTIETKIEM
{
    public partial class KhachHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source = DESKTOP-IQ17TA1\SQLEXPRESS ; Initial Catalog =STK1; Integrated Security=True"; //duong dan toi sv cua csdl
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable(); //thongtin ve Khach hang

        public KhachHang()
        {
            InitializeComponent();
        }

        void LoadKhachHang()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dgvKH.DataSource = table1;  

        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x;
            x = dgvKH.CurrentRow.Index;
            txtMaKH.Text = dgvKH.Rows[x].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKH.Rows[x].Cells[1].Value.ToString();
            txtCMND.Text = dgvKH.Rows[x].Cells[2].Value.ToString();
            dtpNgayCap.Text = dgvKH.Rows[x].Cells[3].Value.ToString();
            txtNoiCap.Text = dgvKH.Rows[x].Cells[4].Value.ToString();
            txtDiachi.Text = dgvKH.Rows[x].Cells[5].Value.ToString();
            txtsoDT.Text = dgvKH.Rows[x].Cells[6].Value.ToString();
        }

        private void KhachHang_Load_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadKhachHang();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into KhachHang values ('" + txtMaKH.Text + "','" + txtTenKH.Text + "','" + txtCMND.Text + "','" + dtpNgayCap.Value.ToString() + "','" + txtNoiCap.Text + "','" + txtDiachi.Text + "','" + txtsoDT.Text + "')";
                command.ExecuteNonQuery();
                LoadKhachHang();
                MessageBox.Show("Đã thêm thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã số hàng hóa !", "Cảnh Báo!");
            }
           
           
        }
        
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from KhachHang where MaKH='" + txtMaKH.Text + "'";
                command.ExecuteNonQuery();
                LoadKhachHang();
                MessageBox.Show("Đã xóa thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại !", "Cảnh Báo!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KhachHang set MaKH='" + txtMaKH.Text + "',TenKH='" + txtTenKH.Text + "',CMND='" + txtCMND.Text + "',NgayCap='" + dtpNgayCap.Value.ToString() + "',NoiCap='" + txtNoiCap.Text + "',DiaChi='" + txtDiachi.Text + "',DienThoai='" + txtsoDT.Text + "'Where MaKH='" + txtMaKH.Text + "'";
            command.ExecuteNonQuery();
            LoadKhachHang();
            MessageBox.Show("Đã sửa thành công!", "Thông báo");
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang where TenKH like '%" + txtTim.Text + "%'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dgvKH.DataSource = dt;
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

        
    }
}
