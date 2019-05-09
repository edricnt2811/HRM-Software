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
    public class TonGiaoDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("TonGiao_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTonGiao",ID)
            };
            return db.GetData("TonGiao_Select_By_ID", para);
        }

        public int Insert(TonGiao obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTonGiao",obj.IDTonGiao),
                new SqlParameter("TenTonGiao",obj.TenTonGiao),

            };
            return db.ExecuteSQL("TonGiao_Insert", para);
        }

        public int Update(TonGiao obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTonGiao",obj.IDTonGiao),
                new SqlParameter("TenTonGiao",obj.TenTonGiao)

            };
            return db.ExecuteSQL("TonGiao_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDTonGiao",ID),
            };
            return db.ExecuteSQL("TonGiao_Delete", para);
        }
    }
}
