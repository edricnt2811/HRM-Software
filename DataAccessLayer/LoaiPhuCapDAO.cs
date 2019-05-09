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
    public class LoaiPhuCapDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("LoaiPhuCap_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiPhuCap",ID)
            };
            return db.GetData("LoaiPhuCap_Select_By_ID", para);
        }

        public int Insert(LoaiPhuCap obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiPhuCap",obj.IDLoaiPhuCap),
                new SqlParameter("TenLoaiPhuCap",obj.TenLoaiPhuCap),
                new SqlParameter("SoTien",obj.SoTien),
            };
            return db.ExecuteSQL("LoaiPhuCap_Insert", para);
        }

        public int Update(LoaiPhuCap obj)
        {
            SqlParameter[] para =
            {
                 new SqlParameter("IDLoaiPhuCap",obj.IDLoaiPhuCap),
                new SqlParameter("TenLoaiPhuCap",obj.TenLoaiPhuCap),
                new SqlParameter("SoTien",obj.SoTien),
            };
            return db.ExecuteSQL("LoaiPhuCap_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiPhuCap",ID),
            };
            return db.ExecuteSQL("LoaiPhuCap_Delete", para);
        }
    }
}
