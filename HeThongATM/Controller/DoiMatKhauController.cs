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
    class DoiMatKhauController
    {
        public CdbController m_ketnoi;
        public DoiMatKhauController()
        {
            m_ketnoi = new CdbController();
        }

        public bool changePassword(TextBox txtNewPass)
        {
            SqlCommand cmd = new SqlCommand("sp_ChangePassword");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@newPass", SqlDbType.NVarChar, 20).Value = txtNewPass.Text;
            cmd.Parameters.Add("@soTk", SqlDbType.NVarChar, 20).Value = GlobalVariable.sotaikhoan;

            bool rs = m_ketnoi.ExecuteNonQuery(cmd);
            return rs;

        }
    }
}
