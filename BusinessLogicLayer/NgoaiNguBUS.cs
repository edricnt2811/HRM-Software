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
    public class NgoaiNguBUS
    {
        NgoaiNguDAO dao = new NgoaiNguDAO();

        public DataTable GetData()
        {
            return dao.GetTable();
        }

        public DataTable GetDataByID(string ID)
        {
            return dao.GetTableByID(ID);
        }

        public int Insert(NgoaiNgu obj)
        {
            return dao.Insert(obj);
        }

        public int Update(NgoaiNgu obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string ID)
        {
            return dao.Delete(ID);
        }
    }
}
