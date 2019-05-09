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
    public class TinhThanhDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("TinhThanh_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTinhThanh",ID)
            };
            return db.GetData("TinhThanh_Select_By_ID", para);
        }

        public int Insert(TinhThanh obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTinhThanh",obj.IDTinhThanh),
                new SqlParameter("TenTinhThanh",obj.TenTinhThanh),

            };
            return db.ExecuteSQL("TinhThanh_Insert", para);
        }

        public int Update(TinhThanh obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTinhThanh",obj.IDTinhThanh),
                new SqlParameter("TenTinhThanh",obj.TenTinhThanh)

            };
            return db.ExecuteSQL("TinhThanh_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTinhThanh",ID),
            };
            return db.ExecuteSQL("TinhThanh_Delete", para);
        }
    }
}
