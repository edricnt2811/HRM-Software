using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValueObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class LoaiKhenThuongDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("LoaiKhenThuong_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiKhenThuong",ID)
            };
            return db.GetData("LoaiKhenThuong_Select_By_ID", para);
        }

        public int Insert(LoaiKhenThuong obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiKhenThuong",obj.IDLoaiKhenThuong),
                new SqlParameter("TenLoaiKhenThuong",obj.TenLoaiKhenThuong),
                new SqlParameter("HinhThuc",obj.HinhThuc),
                new SqlParameter("SoTien",obj.SoTien),
                new SqlParameter("GhiChu",obj.GhiChu),
            };
            return db.ExecuteSQL("LoaiKhenThuong_Insert", para);
        }

        public int Update(LoaiKhenThuong obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiKhenThuong",obj.IDLoaiKhenThuong),
                new SqlParameter("TenLoaiKhenThuong",obj.TenLoaiKhenThuong),
                new SqlParameter("HinhThuc",obj.HinhThuc),
                new SqlParameter("SoTien",obj.SoTien),
                new SqlParameter("GhiChu",obj.GhiChu),
            };
            return db.ExecuteSQL("LoaiKhenThuong_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiKhenThuong",ID),
            };
            return db.ExecuteSQL("LoaiKhenThuong_Delete", para);
        }
    }
}
