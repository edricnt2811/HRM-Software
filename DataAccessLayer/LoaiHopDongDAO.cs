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
    public class LoaiHopDongDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("LoaiHopDong_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiHopDong",ID)
            };
            return db.GetData("LoaiHopDong_Select_By_ID", para);
        }

        public int Insert(LoaiHopDong obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiHopDong",obj.IDLoaiHopDong),
                new SqlParameter("TenLoaiHopDong",obj.TenLoaiHopDong),
                new SqlParameter("HeSoluong",obj.HeSoluong),
            };
            return db.ExecuteSQL("LoaiHopDong_Insert", para);
        }

        public int Update(LoaiHopDong obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiHopDong",obj.IDLoaiHopDong),
                new SqlParameter("TenLoaiHopDong",obj.TenLoaiHopDong),
                new SqlParameter("HeSoluong",obj.HeSoluong),
            };
            return db.ExecuteSQL("LoaiHopDong_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiHopDong",ID),
            };
            return db.ExecuteSQL("LoaiHopDong_Delete", para);
        }
    }
}
