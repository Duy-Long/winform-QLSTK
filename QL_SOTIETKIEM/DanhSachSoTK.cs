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
    public partial class DanhSachSoTK : Form
    {
        public DanhSachSoTK()
        {
            InitializeComponent();
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
