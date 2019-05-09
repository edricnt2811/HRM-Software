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
    public class DonviDAO
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("Donvi_Select_All", null);
        }

        public DataTable GetTableByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDonvi",ID)
            };
            return db.GetData("Donvi_Select_By_ID", para);
        }

        public int Insert(Donvi obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDonvi",obj.IDDonvi),
                new SqlParameter("TenDonvi",obj.TenDonvi),
                new SqlParameter("Soluong",obj.Soluong),
            };
            return db.ExecuteSQL("Donvi_Insert", para);
        }

        public int Update(Donvi obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDonvi",obj.IDDonvi),
                new SqlParameter("TenDonvi",obj.TenDonvi),
                new SqlParameter("Soluong",obj.Soluong),
            };
            return db.ExecuteSQL("Donvi_Update", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDDonvi",ID),
            };
            return db.ExecuteSQL("Donvi_Delete", para);
        }
    }
}
