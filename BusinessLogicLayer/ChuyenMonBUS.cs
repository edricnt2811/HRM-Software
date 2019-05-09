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
    public class ChuyenMonBUS
    {
        ChuyenMonDAO dao = new ChuyenMonDAO();

        public DataTable GetData()
        {
            return dao.GetTable();
        }

        public DataTable GetDataByID(string ID)
        {
            return dao.GetTableByID(ID);
        }

        public int Insert(ChuyenMon obj)
        {
            return dao.Insert(obj);
        }

        public int Update(ChuyenMon obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string ID)
        {
            return dao.Delete(ID);
        }
    }
}
