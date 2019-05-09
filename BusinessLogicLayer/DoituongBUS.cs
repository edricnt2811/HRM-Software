using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using ValueObject;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DoituongBUS
    {
        DoituongDAO dao = new DoituongDAO();

        public DataTable GetData()
        {
            return dao.GetTable();
        }
        public DataTable GetDataByID(string ID)
        {
            return dao.GetTableByID(ID);
        }

        public int Insert(Doituong obj)
        {
            return dao.Insert(obj);
        }

        public int Update(Doituong obj)
        {
            return dao.Update(obj);
        }
        public int Delete(string ID)
        {
            return dao.Delete(ID);
        }
    }
}
