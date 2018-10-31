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
    public partial class DoiMatKhau : Form
    {
        DoiMatKhauController doiMatKhauController;
        TextBox focusTextBox = null;

        public DoiMatKhau()
        {
            InitializeComponent();
            doiMatKhauController = new DoiMatKhauController();
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
            if (focusTextBox != null)
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string loi = "";
            try
            {
                Convert.ToInt32(txtNewPass.Text);
            }
            catch
            {
                loi += "Mật khẩu mới chỉ chứa số\n";
            }
            if (txtOldPass.Text != GlobalVariable.matkhau)
            {
                loi += "Mật khẩu cũ không khớp\n";
            }
            if (txtNewPass.Text != txtRePass.Text)
            {
                loi += "Mật khẩu nhập vào không khớp\n";
            }
            if (txtNewPass.Text == "")
            {
                loi += "Mật khẩu mới không thể để trống\n";
            }
            if (txtNewPass.Text.Length != 6)
            {
                loi += "Mật khẩu phải có đủ 6 kí tự số";
            }
            if(loi.Length > 0)
            {
                MessageBox.Show(loi, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!doiMatKhauController.changePassword(txtNewPass))
            {
                MessageBox.Show("Đã có lỗi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Đổi thành công!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnClEp_Click(object sender, EventArgs e)
        {
            if (this.Width != 296)
            {
                this.Width = 296;
                btnClEp.Text = ">>";
            }
            else
            {
                this.Width = 501;
                btnClEp.Text = "<<";
            }
        }
    }
}
