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
    public partial class PhongGiaoDich : Form
    {
        public PhongGiaoDich()
        {
            InitializeComponent();
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
