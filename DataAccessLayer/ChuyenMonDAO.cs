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
    public class ChuyenMonDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("ChuyenMon_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDChuyenMon",ID)
            };
            return db.GetData("ChuyenMon_Select_By_ID", para);
        }

        public int Insert(ChuyenMon obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDChuyenMon",obj.IDChuyenMon),
                new SqlParameter("TenChuyenMon",obj.TenChuyenMon),

            };
            return db.ExecuteSQL("ChuyenMon_Insert", para);
        }

        public int Update(ChuyenMon obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDChuyenMon",obj.IDChuyenMon),
                new SqlParameter("TenChuyenMon",obj.TenChuyenMon),

            };
            return db.ExecuteSQL("ChuyenMon_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDChuyenMon",ID),
            };
            return db.ExecuteSQL("ChuyenMon_Delete", para);
        }
    }
}
