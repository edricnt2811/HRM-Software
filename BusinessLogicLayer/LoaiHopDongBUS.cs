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
    public class LoaiHopDongBUS
    {
        LoaiHopDongDAO dao = new LoaiHopDongDAO();

        public DataTable GetData()
        {
            return dao.GetTable();
        }

        public DataTable GetDataByID(string ID)
        {
            return dao.GetTableByID(ID);
        }

        public int Insert(LoaiHopDong obj)
        {
            return dao.Insert(obj);
        }

        public int Update(LoaiHopDong obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string ID)
        {
            return dao.Delete(ID);
        }
    }
}
