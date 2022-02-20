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
    public partial class DanhSachSoTK : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source = DESKTOP-IQ17TA1\SQLEXPRESS ; Initial Catalog =STK1; Integrated Security=True"; 
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable(); 

        public DanhSachSoTK()
        {
            InitializeComponent();
        }

        void LoadSo ()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SoTK";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dgv.DataSource = table1;
        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int x;
            x = dgv.CurrentRow.Index;
            txtMaso.Text = dgv.Rows[x].Cells[0].Value.ToString();
            txtMaKH.Text = dgv.Rows[x].Cells[1].Value.ToString();
            txtTenKH.Text = dgv.Rows[x].Cells[2].Value.ToString();
            txtLoai.Text = dgv.Rows[x].Cells[3].Value.ToString();
            txtLai.Text = dgv.Rows[x].Cells[4].Value.ToString();
            txtSodu.Text = dgv.Rows[x].Cells[5].Value.ToString();
            dtpMoso.Text = dgv.Rows[x].Cells[6].Value.ToString();
            dtpHH.Text = dgv.Rows[x].Cells[7].Value.ToString();
        }

        private void DanhSachSoTK_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadSo();
        }
      
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from SoTK where MaSoTK='" + txtMaso.Text + "'";
                command.ExecuteNonQuery();
                LoadSo();
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
            command.CommandText = "update SoTK set MaSoTK='" + txtMaso.Text + "',MaKH='" + txtMaKH.Text + "',TenKH='" + txtTenKH.Text + "',LoaiKyHan='" + txtLoai.Text + "',LaiSuat='" + txtLai.Text + "',SoDu='" + txtSodu.Text + "',NgayMS='" + dtpMoso.Value.ToString() + "',NgayHH='" + dtpHH.Value.ToString() + "'Where MaSoTK='" + txtMaso.Text + "'";
            command.ExecuteNonQuery();
            LoadSo();
            MessageBox.Show("Đã sửa thành công!", "Thông báo");
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (cBKH.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "select * from SoTK where TenKH like '%" + txtTim.Text + "%'";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            if (cBMa.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "select * from SoTK where MaSoTK like '%" + txtTim.Text + "%'";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSo();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            var DR = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Cảnh Báo", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
        }

        private void btRut_Click(object sender, EventArgs e)
        {
            PhongGiaoDich p = new PhongGiaoDich();
            this.Hide();
            p.Show();
        }

    }
}
