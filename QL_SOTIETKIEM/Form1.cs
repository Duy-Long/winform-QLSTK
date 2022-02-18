using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SOTIETKIEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btKH_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            this.Hide();
            kh.Show();
        }

        private void btSTK_Click(object sender, EventArgs e)
        {
            MoSoTK M = new MoSoTK();
            this.Hide();
            M.Show();
        }

        private void btDSTK_Click(object sender, EventArgs e)
        {
            DanhSachSoTK D = new DanhSachSoTK();
            this.Hide();
            D.Show();
        }

        private void btRut_Click(object sender, EventArgs e)
        {
            PhongGiaoDich P = new PhongGiaoDich();
            this.Hide();
            P.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
                Application.Exit();
        }
    }
}

