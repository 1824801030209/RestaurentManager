using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNHAHANG.BUS
{
    interface IDangNhap
    {
        string TenDangNhap { get; set; }
        string MatKhau { get; set; }
        bool CheckDangNhap(SqlConnection conn, int ID);
        void NhoMK(SqlConnection conn);
        void HuyNhoMK(SqlConnection conn);
        DataTable LoadNhoMatKhau(SqlConnection conn);
    }
}
