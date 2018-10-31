using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongATM.Controller;

namespace HeThongATM.GiaoDien
{
    public partial class frmGiaoDichDaThucHien : Form
    {
        GiaoDichDaThucHienController gd_controller;
        public frmGiaoDichDaThucHien()
        {
            InitializeComponent();
            gd_controller = new GiaoDichDaThucHienController();
            dtgvGiaoDich.AutoGenerateColumns = false;
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGiaoDichDaThucHien_Load(object sender, EventArgs e)
        {
            gd_controller.loadData(dtgvGiaoDich);
        }

        private void btnInGiaoDich_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Ingiaodich);
            thread.IsBackground = true;
            thread.Start();
        }
        void Ingiaodich()
        {
            txtLoading.Text = "Đang lưu...";
            btnInGiaoDich.Enabled = false;
            btnDong.Enabled = false;
            gd_controller.SaveExcel(dtgvGiaoDich);
            MessageBox.Show("File được lưu ở Document!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtLoading.Text = "";
            btnInGiaoDich.Enabled = true;
            btnDong.Enabled = true;
        }
    }
}
