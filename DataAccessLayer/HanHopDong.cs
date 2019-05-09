using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class HanHopDong
    {
        dbConnect db = new dbConnect();

        public DataTable GetTable()
        {
            return db.GetData("HanHopDong", null);
        }

        public DataTable GetDataBynam(string nam)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ThoiHanHopDong", nam)
            };
            return db.GetData("HanHopDong_By_nam", para);
        }
    }
}
