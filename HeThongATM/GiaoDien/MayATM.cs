using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongATM.Controller;

namespace HeThongATM.GiaoDien
{
    public partial class MayATM : Form
    {
        GiaoDien.GiaoDich gd;
        GiaoDien.TaiKhoan tk;
        public MayATM()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            GiaoDien.frmDangNhap dn = new frmDangNhap();
            dn.Show();
            this.Close();
        }

        private void btnGuiTien_Click(object sender, EventArgs e)
        {
            gd = new GiaoDich();
            gd.changetab(2);
            gd.ShowDialog();
        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {
            gd = new GiaoDich();
            gd.ShowDialog();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            tk = new TaiKhoan();
            tk.ShowDialog();
        }

        private void MayATM_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Xin chào, " + GlobalVariable.hoTen;
        }

        private void btnGiaoDichThucHien_Click(object sender, EventArgs e)
        {
            GiaoDien.frmGiaoDichDaThucHien gd = new frmGiaoDichDaThucHien();
            gd.ShowDialog();
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            gd = new GiaoDich();
            gd.changetab(3);
            gd.ShowDialog();
        }
    }
}
