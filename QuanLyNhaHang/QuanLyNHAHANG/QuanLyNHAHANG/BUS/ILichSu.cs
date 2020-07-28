using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNHAHANG.BUS
{
    interface ILichSu
    {
        string KhuVuc { get; set; }
        string TenBan { get; set; }
        string Ngay { get; set; }
        string ThoiGian { get; set; }
        string TongCong { get; set; }
        string NguoiThanhToan { get; set; }
        string GhiChu { get; set; }
        DataTable LoadLichSu(SqlConnection conn);
        void InsertLichSu(SqlConnection conn);
        DataTable ThongKeTheoNgay(SqlConnection conn, string Ngay);
        DataTable ThongKeTheoThang(SqlConnection conn, string Thang, string Nam);
        DataTable ThongKeTheoKhoangNgay(SqlConnection conn, string TuNgay, string DenNgay);
    }
}
