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
    public class TrinhDoVHDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("TrinhDoVH_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTrinhDoVH",ID)
            };
            return db.GetData("TrinhDoVH_Select_By_ID", para);
        }

        public int Insert(TrinhDoVH obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTrinhDoVH",obj.IDTrinhDoVH),
                new SqlParameter("TenTrinhDoVH",obj.TenTrinhDoVH),

            };
            return db.ExecuteSQL("TrinhDoVH_Insert", para);
        }

        public int Update(TrinhDoVH obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTrinhDoVH",obj.IDTrinhDoVH),
                new SqlParameter("TenTrinhDoVH",obj.TenTrinhDoVH)

            };
            return db.ExecuteSQL("TrinhDoVH_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTrinhDoVH",ID),
            };
            return db.ExecuteSQL("TrinhDoVH_Delete", para);
        }
    }
}
