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
    public class KhoiBUS
    {
        KhoiDAO dao = new KhoiDAO();

        public DataTable GetData()
        {
            return dao.GetTable();
        }

        public DataTable GetDataByID(string ID)
        {
            return dao.GetTableByID(ID);
        }

        public int Insert(Khoi obj)
        {
            return dao.Insert(obj);
        }

        public int Update(Khoi obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string ID)
        {
            return dao.Delete(ID);
        }
    }
}
