using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace HeThongATM.Controller
{
    class GiaoDichDaThucHienController
    {
        public CdbController m_ketnoi;

        public GiaoDichDaThucHienController()
        {
            m_ketnoi = new CdbController();
        }

        public void loadData(DataGridView dtgv)
        {
            SqlCommand cmd = new SqlCommand("sp_xemGiaoDich");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@sotk", SqlDbType.NVarChar, 20).Value = GlobalVariable.sotaikhoan;

            DataTable dt = m_ketnoi.OpenDataSet(cmd).Tables[0];
            dtgv.DataSource = dt;
        }

        public void SaveExcel(DataGridView dtgv)
        {
            // Tạo mới file
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            // Tạo workbook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            // tạo trang tính mới
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            //app.Visible = true;

            // Tham chiếu đến Sheet1
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            // Lưu header
            for (int i = 1; i < dtgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtgv.Columns[i - 1].HeaderText;
            }

            // Lưu mỗi dòng và cột
            for (int i = 0; i < dtgv.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dtgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Lưu file
            workbook.SaveAs(@"GiaoDich.xls");
            workbook.Close(null, null, null);
            #region Kill process
            app.Quit();
            if (app != null)
            {
                int excelProcessId = -1;
                GetWindowThreadProcessId(new IntPtr(app.Hwnd), ref excelProcessId);

                Process ExcelProc = Process.GetProcessById(excelProcessId);
                if (ExcelProc != null)
                {
                    ExcelProc.Kill();
                }
            }
            #endregion
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessId);
    }
}
