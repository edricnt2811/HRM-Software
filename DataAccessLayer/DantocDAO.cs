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
    public class DantocDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("DanToc_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDanToc",ID)
            };
            return db.GetData("DanToc_Select_By_ID", para);
        }

        public int Insert(dantoc obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDanToc",obj.IDDanToc),
                new SqlParameter("TenDanToc",obj.TenDanToc)
            };
            return db.ExecuteSQL("DanToc_Insert", para);
        }

        public int Update(dantoc obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDanToc",obj.IDDanToc),
                new SqlParameter("TenDanToc",obj.TenDanToc)
            };
            return db.ExecuteSQL("DanToc_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDanToc",ID),
            };
            return db.ExecuteSQL("DanToc_Delete", para);
        }
    }
}
