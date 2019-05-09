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
    public class HoSoBUS
    {
        HoSoDAO dao = new HoSoDAO();

        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetDataByID(string IDSanPham)
        {
            return dao.GetDataByID(IDSanPham);
        }

        public int Insert(HoSo obj)
        {
            return dao.Insert(obj);
        }

        public int Update(HoSo obj)
        {
            return dao.Update(obj);
        }
        public int Delete(string IDLop)
        {
            return dao.Delete(IDLop);
        }

        public DataTable GetDataDantoc()
        {
            return dao.GetDataDanToc();
        }

        public DataTable GetDataTonGiao()
        {
            return dao.GetDataTonGiao();
        }

        public DataTable GetDataTrinhDoHV()
        {
            return dao.GetDataTrinhDoHV();
        }

        public DataTable GetDataTrinhDo()
        {
            return dao.GetDataTrinhDo();
        }

        public DataTable GetDataDonVi()
        {
            return dao.GetDataDonVi();
        }

        public DataTable GetDataDoiTuong()
        {
            return dao.GetDataDoiTuong();
        }

        public DataTable GetDataNgoaiNgu()
        {
            return dao.GetDataNgoaiNgu();
        }

        public DataTable GetDataCMT()
        {
            return dao.GetDataCMT();
        }
    }
}
