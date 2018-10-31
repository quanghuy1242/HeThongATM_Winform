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
    public partial class frmDangNhap : Form
    {
        DangNhapController m_dangnhapController;
        TaiKhoanController tkcontroller;
        public GiaoDien.TaiKhoan mainTK = new TaiKhoan();
        TextBox focusTextBox = null;
        public frmDangNhap()
        {
            InitializeComponent();
            m_dangnhapController = new DangNhapController();
            tkcontroller = new TaiKhoanController();
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Enter += textBox_Enter;
            }
        }
        #region virtual keyboard
        private void textBox_Enter(object sender, EventArgs e)
        {
            focusTextBox = sender as TextBox;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            if(focusTextBox != null)
            {
                focusTextBox.Text += a.Text;
            }
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            if (focusTextBox != null)
            {
                if (focusTextBox.Text != "")
                {
                    focusTextBox.Text = focusTextBox.Text.Remove(focusTextBox.Text.Length - 1);
                }
            }
        }
        #endregion

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            double val = 0;
            if (txtNhapMatKhau.Text.Length != 6)
            {
                MessageBox.Show("Mật khẩu phải có 6 kí tự!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(double.TryParse(txtSoThe.Text, out val)) 
            {
                if (m_dangnhapController.checkDangNhap(txtSoThe, txtNhapMatKhau))
                {
                    GiaoDien.MayATM mainATM = new MayATM();
                    this.Hide();
                    mainATM.Show();
                    return;
                }
                MessageBox.Show("Login Fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Mã thẻ không bao gồm chữ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnClEp_Click(object sender, EventArgs e)
        {
            if (this.Width != 291)
            {
                this.Width = 291;
                btnClEp.Text = ">>";
            }
            else
            {
                this.Width = 496;
                btnClEp.Text = "<<";
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
