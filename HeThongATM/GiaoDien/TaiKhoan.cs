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
    public partial class TaiKhoan : Form
    {
        TaiKhoanController tkcontroller;
        public TaiKhoan()
        {
            InitializeComponent();
            tkcontroller = new TaiKhoanController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            tkcontroller.DisplayInfo(txtHo, txtTen, txtSoTaiKhoan, txtLoaiTaiKhoan, txtSoSuTaiKhoan);
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            GiaoDien.DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.ShowDialog();
        }
    }
}
