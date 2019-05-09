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
    public class LopBUS
    {
        LopDAL dao = new LopDAL();

        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetDataByID(string IDSanPham)
        {
            return dao.GetDataByID(IDSanPham);
        }

        public int Insert(lop obj)
        {
            return dao.Insert(obj);
        }

        public int Update(lop obj)
        {
            return dao.Update(obj);
        }
        public int Delete(string IDLop)
        {
            return dao.Delete(IDLop);
        }

        public DataTable GetDataKhoi()
        {
            return dao.GetDataKhoi();
        }
    }
}
