using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HeThongATM.Controller
{
    class GiaoDichController
    {
        public CdbController m_dangnhap;
        public GiaoDichController()
        {
            m_dangnhap = new CdbController();
        }
        public bool rutTien(TextBox txtTien)
        {
            SqlCommand cmd = new SqlCommand("sp_RutTien");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@tien", SqlDbType.Money).Value = Convert.ToDecimal(txtTien.Text);
            cmd.Parameters.Add("@soTk", SqlDbType.NVarChar, 20).Value = GlobalVariable.sotaikhoan;

            bool re = m_dangnhap.ExecuteNonQuery(cmd);
            return re;
        }
        public void loadData(TextBox txtsoDu)
        {
            SqlCommand cmd = new SqlCommand("sp_GetInfoAllUser");
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = m_dangnhap.OpenDataSet(cmd).Tables[0];

            string sothedt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sothedt = (string)dt.Rows[i][0];
                if (GlobalVariable.mathe == sothedt)
                {
                    txtsoDu.Text = (dt.Rows[i][5]).ToString();
                }
            }
        }
        public bool checkUserReceive(TextBox txtNhan)
        {
            SqlCommand cmd = new SqlCommand("sp_GetInfoAllUser");
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = m_dangnhap.OpenDataSet(cmd).Tables[0];

            string soTkNhan;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                soTkNhan = (string)dt.Rows[i][3];
                if(txtNhan.Text == soTkNhan)
                {
                    return true;
                }
            }
            return false;
        }
        public bool guiTien(TextBox txtNhan, TextBox txtTien)
        {
            SqlCommand cmd = new SqlCommand("sp_guiTien");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@tien", SqlDbType.Money).Value = Convert.ToDecimal(txtTien.Text);
            cmd.Parameters.Add("@soTk", SqlDbType.NVarChar, 20).Value = GlobalVariable.sotaikhoan;
            cmd.Parameters.Add("@soTkNhan", SqlDbType.NVarChar, 20).Value = txtNhan.Text;

            bool re = m_dangnhap.ExecuteNonQuery(cmd);
            return re;
        }
        public bool napTien(TextBox txtTien)
        {
            SqlCommand cmd = new SqlCommand("sp_NapTien");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@tien", SqlDbType.Money).Value = Convert.ToDecimal(txtTien.Text);
            cmd.Parameters.Add("@sotk", SqlDbType.NVarChar, 20).Value = GlobalVariable.sotaikhoan;

            bool re = m_dangnhap.ExecuteNonQuery(cmd);
            return re;
        }
        public bool inputValidation(TextBox tien, TextBox soDu, int kieu)
        {
            string loi = "";
            decimal num = 0;
            decimal sodu = Convert.ToDecimal(soDu.Text);
            try
            {
                num = Convert.ToDecimal(tien.Text);
            }
            catch
            {
                loi += "Số tiền nhập vào phải là số và không lẻ\n";
            }
            if(num <= 0)
            {
                loi += "Số tiền nhập phải lớn hơn 0\n";
            }
            if(num > sodu && kieu == 1)
            {
                loi += "Số tiền nhập phải bé hơn số tiền hiện có\n";
            }
            if(loi.Length > 0)
            {
                MessageBox.Show(loi, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
