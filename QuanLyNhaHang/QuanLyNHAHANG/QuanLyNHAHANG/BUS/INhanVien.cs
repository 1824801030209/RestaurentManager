using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNHAHANG.BUS
{
    interface INhanVien
    {
        string MaNV { get; set; }
        string HoNV { get; set; }
        string TenNV { get; set; }
        string GioiTinh { get; set; }
        string NgaySinh { get; set; }
        string SDT { get; set; }
        string DiaChi { get; set; }
        DataTable LoadNhanVien(SqlConnection conn);
        void InsertNhanVien(SqlConnection conn);
        void UpdateNhanVien(SqlConnection conn, string DieuKien);
        void DeleteNhanVien(SqlConnection conn, string Manv);
        DataTable TimKiemTheoMaNV(SqlConnection conn, string MaNV);
        DataTable TimKiemTheoTenNV(SqlConnection conn, string TenNV);
    }
}
