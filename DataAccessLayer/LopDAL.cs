using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValueObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class LopDAL : dbConnect
    {

        public DataTable GetData()
        {
            return base.GetData("Lop_Select_All", null);
        }
        public DataTable GetDataByID(string IDLop)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLop", IDLop)
            };
            return base.GetData("Lop_Select_By_ID", para);
        }

        public int Insert(lop obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLop",obj.IDLop),
                new SqlParameter("TenLop",obj.TenLop),
                new SqlParameter("IDKhoi",obj.IDKhoi),
            };
            return base.ExecuteSQL("Lop_Insert", para);
        }

        public int Update(lop obj)
        {
            SqlParameter[] para =
           {
                new SqlParameter("IDLop",obj.IDLop),
                new SqlParameter("TenLop",obj.TenLop),
                new SqlParameter("IDKhoi",obj.IDKhoi),
            };
            return base.ExecuteSQL("Lop_Update", para);
        }
        public int Delete(string IDLop)
        {
            SqlParameter[] para =
               {
                new SqlParameter("IDLop", IDLop)
            };
            return base.ExecuteSQL("Lop_Delete", para);
        }

        public DataTable GetDataKhoi()
        {
            return base.GetData("Khoi_Select_All", null);
        }
    }
}
