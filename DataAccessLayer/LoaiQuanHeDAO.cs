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
    public class LoaiQuanHeDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("LoaiQuanHe_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiQuanHe",ID)
            };
            return db.GetData("LoaiQuanHe_Select_By_ID", para);
        }

        public int Insert(LoaiQuanHe obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiQuanHe",obj.IDLoaiQuanHe),
                new SqlParameter("TenLoaiQuanHe",obj.TenLoaiQuanHe),
            };
            return db.ExecuteSQL("LoaiQuanHe_Insert", para);
        }

        public int Update(LoaiQuanHe obj)
        {
            SqlParameter[] para =
            {
                 new SqlParameter("IDLoaiQuanHe",obj.IDLoaiQuanHe),
                new SqlParameter("TenLoaiQuanHe",obj.TenLoaiQuanHe),
            };
            return db.ExecuteSQL("LoaiQuanHe_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiQuanHe",ID),
            };
            return db.ExecuteSQL("LoaiQuanHe_Delete", para);
        }
    }
}
