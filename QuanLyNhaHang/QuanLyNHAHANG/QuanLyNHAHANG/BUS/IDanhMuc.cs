using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNHAHANG.BUS
{
    interface IDanhMuc
    {
        string TenDM { get; set; }
        DataTable LoadDanhMuc(SqlConnection conn);
        DataTable LoadDSDanhMuc(SqlConnection conn);
        void InsertDanhMuc(SqlConnection conn);
        void UpdateDanhMuc(SqlConnection conn, int id);
        void DeleteDanhMuc(SqlConnection conn, int id);
    }
}
