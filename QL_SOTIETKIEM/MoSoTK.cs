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
    public partial class MoSoTK : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source = DESKTOP-IQ17TA1\SQLEXPRESS ; Initial Catalog =STK1; Integrated Security=True"; 
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable(); 

        public MoSoTK()
        {
            InitializeComponent();
        }

        void LoadSo()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SoTK";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
        }

        private void MoSoTK_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }
            
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into SoTK values ('" + txtMaso.Text + "','" + txtMaKH.Text + "','" + txtTenKH.Text + "','" + txtloai.Text + "','" + txtLai.Text + "','" + txtSodu.Text + "','" + dtpNgayMS.Value.ToString() + "','" + dtpNgayHH.Value.ToString() + "')";
                command.ExecuteNonQuery();
                LoadSo();
                MessageBox.Show("Đã thêm thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã số hàng hóa !", "Cảnh Báo!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DanhSachSoTK D = new DanhSachSoTK();
            this.Hide();
            D.Show();
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
