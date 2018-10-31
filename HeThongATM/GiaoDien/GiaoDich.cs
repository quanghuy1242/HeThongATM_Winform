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
using System.Text.RegularExpressions;

namespace HeThongATM.GiaoDien
{
    public partial class GiaoDich : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        GiaoDichController GiaoDichController;
        TextBox focusTextBox = null;
        public GiaoDich()
        {
            InitializeComponent();
            GiaoDichController = new GiaoDichController();
            foreach (TextBox tb in this.tabPage1.Controls.OfType<TextBox>())
            {
                if (tb != txtSoDu)
                {
                    tb.Enter += textBox_Enter;
                }
            }
            foreach (TextBox tb in this.tabPage2.Controls.OfType<TextBox>())
            {
                if (tb != txtSoDu2)
                {
                    tb.Enter += textBox_Enter;
                }
            }
            foreach (TextBox tb in this.tabPage3.Controls.OfType<TextBox>())
            {
                if (tb != txtSoDu3)
                {
                    tb.Enter += textBox_Enter;
                }
            }
        }
        #region virtual keyboard
        private void textBox_Enter(object sender, EventArgs e)
        {
            focusTextBox = sender as TextBox;
        }
        private void btn0_Click(object sender, EventArgs e)
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

        public void changetab(int n)
        {
            if (n == 2) tabControl1.SelectedTab = tabPage2;
            if (n == 3) tabControl1.SelectedTab = tabPage3;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRut_Click(object sender, EventArgs e)
        {
            if (!GiaoDichController.inputValidation(txtTien, txtSoDu, 1)) return;
            if (!GiaoDichController.rutTien(txtTien))
            {
                MessageBox.Show("Giao dịch thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Bạn đã rút thành công " + txtTien.Text + " đồng", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTien.Text = "";
                errorProvider.Clear();
                GiaoDichController.loadData(txtSoDu);
                GiaoDichController.loadData(txtSoDu2);
                GiaoDichController.loadData(txtSoDu3);
                return;
            }
        }

        private void GiaoDich_Load(object sender, EventArgs e)
        {
            GiaoDichController.loadData(txtSoDu);
            GiaoDichController.loadData(txtSoDu2);
            GiaoDichController.loadData(txtSoDu3);
        }

        private void txtTKNhan_TextChanged(object sender, EventArgs e)
        {
            if (!GiaoDichController.checkUserReceive(txtTKNhan))
            {
                txtTKNhan.Focus();
                this.errorProvider.SetError(txtTKNhan, "Không tìm thấy tài khoản này!");
            }
            else
            {
                this.errorProvider.Clear();
            }
        }

        private void btnGuiTien_Click(object sender, EventArgs e)
        {
            if (!GiaoDichController.inputValidation(txtTienGui, txtSoDu2, 1)) return;
            if (errorProvider.GetError(txtTKNhan).Length > 0 || txtTKNhan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập chính xác số tài khoản nhận!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!GiaoDichController.guiTien(txtTKNhan, txtTienGui))
            {
                MessageBox.Show("Giao dịch thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Bạn đã chuyển thành công " + txtTienGui.Text + " đồng cho số tài khoản " + txtTKNhan.Text, "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTienGui.Text = "";
                txtTKNhan.Text = "";
                errorProvider.Clear();
                GiaoDichController.loadData(txtSoDu);
                GiaoDichController.loadData(txtSoDu2);
                GiaoDichController.loadData(txtSoDu3);
                return;
            }
        }
        

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            if (!GiaoDichController.inputValidation(txtTienNap, txtSoDu3, 2)) return;
            if (!GiaoDichController.napTien(txtTienNap))
            {
                MessageBox.Show("Giao dịch thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Bạn đã nạp thành công " + txtTienNap.Text + " đồng", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTienNap.Text = "";
                errorProvider.Clear();
                GiaoDichController.loadData(txtSoDu);
                GiaoDichController.loadData(txtSoDu2);
                GiaoDichController.loadData(txtSoDu3);
                return;
            }
        }

        private void btnClEp_Click(object sender, EventArgs e)
        {
            if (this.Width != 306)
            {
                this.Width = 306;
                btnClEp.Text = ">>";
            }
            else
            {
                this.Width = 505;
                btnClEp.Text = "<<";
            }
        }
    }
}
