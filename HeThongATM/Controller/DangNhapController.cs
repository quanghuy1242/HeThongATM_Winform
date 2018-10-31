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
    class DangNhapController
    {
        public CdbController m_dangnhap;
        public DangNhapController()
        {
            m_dangnhap = new CdbController();
        }

        public string getSoThe(TextBox txtsothe, TextBox txtpass)
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllUser");
            cmd.CommandType = CommandType.StoredProcedure;
            string sothe = txtsothe.Text.ToString();
            string pass = txtpass.Text.ToString();

            DataTable dt = m_dangnhap.OpenDataSet(cmd).Tables[0];
            string sothedt, passworddt;
            int numofRow = dt.Rows.Count;

            for (int i = 0; i < numofRow; i++)
            {
                passworddt = (string)dt.Rows[i][0];
                sothedt = (string)dt.Rows[i][1];

                if (sothedt == sothe && passworddt == pass)
                {
                    return sothedt;
                }
            }
            return "";
        }

        public bool checkDangNhap(TextBox txtsothe, TextBox txtpass)
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllUser");
            cmd.CommandType = CommandType.StoredProcedure;

            string sothe = txtsothe.Text.ToString();
            string pass = txtpass.Text.ToString();

            DataTable dt = m_dangnhap.OpenDataSet(cmd).Tables[0];
            string sothedt, passworddt, hoten, soTaiKhoan;
            int numofRow = dt.Rows.Count;

            for (int i = 0; i < numofRow; i++)
            {
                passworddt = (string)dt.Rows[i][0];
                sothedt = (string)dt.Rows[i][1];
                hoten = (string)dt.Rows[i][2];
                soTaiKhoan = (string)dt.Rows[i][3];

                if (sothedt == sothe && passworddt == pass)
                {
                    GlobalVariable.mathe = sothedt;
                    GlobalVariable.hoTen = hoten;
                    GlobalVariable.sotaikhoan = soTaiKhoan;
                    GlobalVariable.matkhau = passworddt;
                    return true;
                }
            }
            return false;
        }
    }
}
