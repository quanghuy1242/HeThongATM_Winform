using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HeThongATM.Controller
{
    class TaiKhoanController
    {
        public CdbController m_taikhoan;
        public DangNhapController dn = new DangNhapController();

        public TaiKhoanController()
        {
            m_taikhoan = new CdbController();
        }

        public void DisplayInfo(TextBox ho, TextBox ten, TextBox soTaiKhoan, TextBox loaiTK, TextBox soDu)
        {
            SqlCommand cmd = new SqlCommand("sp_GetInfoAllUser");
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = m_taikhoan.OpenDataSet(cmd).Tables[0];
            int numofRow = dt.Rows.Count;

            string mathe = GlobalVariable.mathe;
            string sothedt;
            for (int i = 0; i < numofRow; i++)
            {
                sothedt = (string)dt.Rows[i][0];
                if(sothedt == mathe)
                {
                    ho.Text = (string)dt.Rows[i][1];
                    ten.Text = (string)dt.Rows[i][2];
                    soTaiKhoan.Text = (string)dt.Rows[i][3];
                    loaiTK.Text = (string)dt.Rows[i][4];
                    soDu.Text = (dt.Rows[i][5]).ToString();
                    return;
                }
            }
        }


    }
}
