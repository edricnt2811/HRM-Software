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
    public class TrinhDoBUS
    {
        TrinhDoDAO dao = new TrinhDoDAO();

        public DataTable GetData()
        {
            return dao.GetTable();
        }

        public DataTable GetDataByID(string ID)
        {
            return dao.GetTableByID(ID);
        }

        public int Insert(TrinhDo obj)
        {
            return dao.Insert(obj);
        }

        public int Update(TrinhDo obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string ID)
        {
            return dao.Delete(ID);
        }
    }
}
