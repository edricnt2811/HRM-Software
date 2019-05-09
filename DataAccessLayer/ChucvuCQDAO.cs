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
    public class ChucvuCQDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("ChucvuCQ_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDChucVuCQ",ID)
            };
            return db.GetData("ChucvuCQ_Select_By_ID", para);
        }

        public int Insert(ChucvuCQ obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDChucVuCQ",obj.IDChucVuCQ),
                new SqlParameter("TenChucVu",obj.TenChucVu),
            };
            return db.ExecuteSQL("ChucvuCQ_Insert", para);
        }

        public int Update(ChucvuCQ obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDChucVuCQ",obj.IDChucVuCQ),
                new SqlParameter("TenChucVu",obj.TenChucVu),
            };
            return db.ExecuteSQL("ChucvuCQ_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDChucVuCQ",ID),
            };
            return db.ExecuteSQL("ChucvuCQ_Delete", para);
        }
    }
}
