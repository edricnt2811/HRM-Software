using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;
using System.Data;
using ValueObject;

namespace BusinessLogicLayer
{
    public class ChucvuCQBUS
    {
        ChucvuCQDAO dao = new ChucvuCQDAO();

        public DataTable GetData()
        {
            return dao.GetTable();
        }

        public DataTable GetDataByID(string ID)
        {
            return dao.GetTableByID(ID);
        }

        public int Insert(ChucvuCQ obj)
        {
            return dao.Insert(obj);
        }

        public int Update(ChucvuCQ obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string ID)
        {
            return dao.Delete(ID);
        }
    }
}
