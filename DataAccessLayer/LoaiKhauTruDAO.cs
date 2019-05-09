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
    public class LoaiKhauTruDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("LoaiKhauTru_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiKhauTru",ID)
            };
            return db.GetData("LoaiKhauTru_Select_By_ID", para);
        }

        public int Insert(LoaiKhauTru obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiKhauTru",obj.IDLoaiKhauTru),
                new SqlParameter("TenLoaiKhauTru",obj.TenLoaiKhauTru),
                new SqlParameter("SoTien",obj.SoTien),
            };
            return db.ExecuteSQL("LoaiKhauTru_Insert", para);
        }

        public int Update(LoaiKhauTru obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiKhauTru",obj.IDLoaiKhauTru),
                new SqlParameter("TenLoaiKhauTru",obj.TenLoaiKhauTru),
                new SqlParameter("SoTien",obj.SoTien),
            };
            return db.ExecuteSQL("LoaiKhauTru_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiKhauTru",ID),
            };
            return db.ExecuteSQL("LoaiKhauTru_Delete", para);
        }
    }
}
