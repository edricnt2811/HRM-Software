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
    public class DoituongDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("DoiTuong_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDoiTuong",ID)
            };
            return db.GetData("DoiTuong_Select_By_ID", para);
        }

        public int Insert(Doituong obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDoiTuong",obj.IDDoiTuong),
                new SqlParameter("TenDoiTuong",obj.TenDoiTuong),
            };
            return db.ExecuteSQL("DoiTuong_Insert", para);
        }

        public int Update(Doituong obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDoiTuong",obj.IDDoiTuong),
                new SqlParameter("TenDoiTuong",obj.TenDoiTuong),
            };
            return db.ExecuteSQL("DoiTuong_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDoiTuong",ID),
            };
            return db.ExecuteSQL("DoiTuong_Delete", para);
        }
    }
}
