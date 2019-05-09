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
    public class NgoaiNguDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("NgoaiNgu_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDNgoaiNgu",ID)
            };
            return db.GetData("NgoaiNgu_Select_By_ID", para);
        }

        public int Insert(NgoaiNgu obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDNgoaiNgu",obj.IDNgoaiNgu),
                new SqlParameter("TenNgoaiNgu",obj.TenNgoaiNgu),

            };
            return db.ExecuteSQL("NgoaiNgu_Insert", para);
        }

        public int Update(NgoaiNgu obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDNgoaiNgu",obj.IDNgoaiNgu),
                new SqlParameter("TenNgoaiNgu",obj.TenNgoaiNgu),

            };
            return db.ExecuteSQL("NgoaiNgu_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDNgoaiNgu",ID),
            };
            return db.ExecuteSQL("NgoaiNgu_Delete", para);
        }
    }
}
