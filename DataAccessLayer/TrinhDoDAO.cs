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
    public class TrinhDoDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("TrinhDo_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTrinhDo",ID)
            };
            return db.GetData("TrinhDo_Select_By_ID", para);
        }

        public int Insert(TrinhDo obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTrinhDo",obj.IDTrinhDo),
                new SqlParameter("TenTrinhDo",obj.TenTrinhDo),

            };
            return db.ExecuteSQL("TrinhDo_Insert", para);
        }

        public int Update(TrinhDo obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTrinhDo",obj.IDTrinhDo),
                new SqlParameter("TenTrinhDo",obj.TenTrinhDo)

            };
            return db.ExecuteSQL("TrinhDo_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTrinhDo",ID),
            };
            return db.ExecuteSQL("TrinhDo_Delete", para);
        }
    }
}
