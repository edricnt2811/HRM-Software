using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class UsersBUS
    {
        UsersDAO dao = new UsersDAO();

        public DataTable GetData()
        {
            return dao.GetTable();
        }

        public string CheckLogin(string Username, string Pass)
        {
            return dao.CheckLogin(Username, Pass);
        }

        public DataTable GetDataByUsername(string Username)
        {
            return dao.GetTableByUserName(Username);
        }

        public int Insert(Users obj)
        {
            return dao.Insert(obj);
        }

        public int Update_Pass(Users obj)
        {
            return dao.Update_Pass(obj);
        }

        public int Update(Users obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string Username)
        {
            return dao.Delete(Username);
        }
    }
}
