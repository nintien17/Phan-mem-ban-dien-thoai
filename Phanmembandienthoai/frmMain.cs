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



namespace Phanmembandienthoai
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frm = new frmDMChatLieu();
                frm.ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHang frm = new frmDMHang();
          
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanvien frm = new frmDMNhanvien();
            
            frm.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.Show();
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            frmGioiThieu frm = new frmGioiThieu();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
