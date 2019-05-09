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
    public class KhoiDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("Khoi_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDKhoi",ID)
            };
            return db.GetData("Khoi_Select_By_ID", para);
        }

        public int Insert(Khoi obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDKhoi",obj.IDKhoi),
                new SqlParameter("TenKhoi",obj.TenKhoi),
            };
            return db.ExecuteSQL("Khoi_Insert", para);
        }

        public int Update(Khoi obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDKhoi",obj.IDKhoi),
                new SqlParameter("TenKhoi",obj.TenKhoi),
            };
            return db.ExecuteSQL("Khoi_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDKhoi",ID),
            };
            return db.ExecuteSQL("Khoi_Delete", para);
        }
    }
}
