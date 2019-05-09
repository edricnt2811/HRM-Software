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
    public class HanHDBUS
    {
        HanHopDong dao = new HanHopDong();

        public DataTable GetData()
        {
            return dao.GetTable();
        }

        public DataTable GetDatabynam(string nam)
        {
            return dao.GetDataBynam(nam);
        }
        
    }
}
