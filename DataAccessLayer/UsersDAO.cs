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
    public class UsersDAO
    {
        dbConnect db = new dbConnect();

        public string CheckLogin(string Username,string Pass)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Username",Username),
                new SqlParameter("Pass",Pass)
            };
            return db.ExecuteScalar("User_CheckLogin", para);
        }

        public DataTable GetTable()
        {
            return db.GetData("User_Select_All", null);
        }

        public DataTable GetTableByUserName(string Username)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Username",Username)
            };
            return db.GetData("User_Select_By_Username", para);
        }

        public DataTable CheckStatus(string Username)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Username",Username)
            };
            return db.GetData("User_CheckStatus", para);
        }

        public int Insert(Users obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Username",obj.Username),
                new SqlParameter("Pass",obj.Pass),
                new SqlParameter("StatusLogin",obj.StatusLogin)
            };
            return db.ExecuteSQL("insert_user", para);
        }

        public int Update(Users obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Username",obj.Username),
                new SqlParameter("Pass",obj.Pass),
                new SqlParameter("StatusLogin",obj.StatusLogin)
            };
            return db.ExecuteSQL("User_Update", para);
        }

        public int Update_Pass(Users obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Username",obj.Username),
                new SqlParameter("Pass",obj.Pass),
            };
            return db.ExecuteSQL("Update_pass", para);
        }

        public int Delete(string Username)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Username",Username),
            };
            return db.ExecuteSQL("User_Delete", para);
        }
    }
}
