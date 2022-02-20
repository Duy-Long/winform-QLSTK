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
    public partial class PhongGiaoDich : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source = DESKTOP-IQ17TA1\SQLEXPRESS ; Initial Catalog =STK1; Integrated Security=True"; 
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable(); 

        public PhongGiaoDich()
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
            dgv.DataSource = table1;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x;
            x = dgv.CurrentRow.Index;
            txtMaso.Text = dgv.Rows[x].Cells[0].Value.ToString();
            txtMaKH.Text = dgv.Rows[x].Cells[1].Value.ToString();
            txtTenKH.Text = dgv.Rows[x].Cells[2].Value.ToString();
            txtloai.Text = dgv.Rows[x].Cells[3].Value.ToString();
            txtLai.Text = dgv.Rows[x].Cells[4].Value.ToString();
            txtsodu.Text = dgv.Rows[x].Cells[5].Value.ToString();
            dtpMoso.Text = dgv.Rows[x].Cells[6].Value.ToString();
            dtpHH.Text = dgv.Rows[x].Cells[7].Value.ToString();
        }

        private void PhongGiaoDich_Load_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadSo();
        }

        private void btThêm_Click(object sender, EventArgs e)
        {
            int SoTienCL = 0;
            string strTong = txtsodu.Text;
            int intTong;
            bool isParsable = Int32.TryParse(strTong, out intTong);
            string strRut = txtSoTien.Text;
            int intRut;
            bool isParsable2 = Int32.TryParse(strRut, out intRut);

            try
            {
                if (intTong < intRut)
                {
                    MessageBox.Show("Tiền trong sổ không còn đủ để rút\n Vui Lòng Kiểm Tra Lại!", "Chú Ý!");
                }
                else
                {
                    SoTienCL = intTong - intRut;
                    txtsodu.Text = SoTienCL.ToString();
                    command = connection.CreateCommand();
                    command.CommandText = "update SoTK set MaSoTK='" + txtMaso.Text + "',MaKH='" + txtMaKH.Text + "',TenKH='" + txtTenKH.Text + "',LoaiKyHan='" + txtloai.Text + "',LaiSuat='" + txtLai.Text + "',SoDu='" + txtsodu.Text + "',NgayMS='" + dtpMoso.Value.ToString() + "',NgayHH='" + dtpHH.Value.ToString() + "'Where MaSoTK='" + txtMaso.Text + "'";
                    command.ExecuteNonQuery();
                    LoadSo();
                    MessageBox.Show("Đã rút thành công!", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại !", "Cảnh Báo!");
            }
        }
        
        private void btTim_Click(object sender, EventArgs e)
        {
            if(cBKH.Checked == true)
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

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadSo();
        }

        private void btSTK_Click(object sender, EventArgs e)
        {
            MoSoTK M = new MoSoTK();
            this.Hide();
            M.Show();
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
