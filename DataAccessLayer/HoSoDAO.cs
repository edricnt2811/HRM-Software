using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValueObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class HoSoDAO : dbConnect
    {
        public DataTable GetData()
        {
            return base.GetData("HoSo_Select_All", null);
        }

        public DataTable GetDataByID(string IDHoSo)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDHoSo", IDHoSo)
            };
            return base.GetData("HoSo_Select_By_ID", para);
        }

        public int Insert(HoSo obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDHoSo",obj.IDHoSo),
                new SqlParameter("SoThe",obj.SoThe),
                new SqlParameter("HoDem",obj.HoDem),
                new SqlParameter("Ten",obj.Ten),
                new SqlParameter("NgaySinh",obj.NgaySinh),
                new SqlParameter("GioiTinh",obj.GioiTinh),
                new SqlParameter("SDT",obj.SDT),
                new SqlParameter("IDDanToc",obj.IDDanToc),
                new SqlParameter("IDTonGiao",obj.IDTonGiao),
                new SqlParameter("IDTrinhDoVH",obj.IDTrinhDoVH),
                new SqlParameter("IDTrinhDo",obj.IDTrinhDo),
                new SqlParameter("IDDonVi",obj.IDDonVi),
                new SqlParameter("IDDoiTuong",obj.IDDoiTuong),
                new SqlParameter("IDNgoaiNgu",obj.IDNgoaiNgu),
                new SqlParameter("ChieuCao",obj.ChieuCao),
                new SqlParameter("CanNang",obj.CanNang),
                new SqlParameter("LinkAnhCaNhan",obj.LinkAnhCaNhan),
                new SqlParameter("CMT",obj.CMT),
            };
            return base.ExecuteSQL("HoSo_Insert", para);
        }

        public int Update(HoSo obj)
        {
            SqlParameter[] para =
           {
                new SqlParameter("IDHoSo",obj.IDHoSo),
                new SqlParameter("SoThe",obj.SoThe),
                new SqlParameter("HoDem",obj.HoDem),
                new SqlParameter("Ten",obj.Ten),
                new SqlParameter("NgaySinh",obj.NgaySinh),
                new SqlParameter("GioiTinh",obj.GioiTinh),
                new SqlParameter("SDT",obj.SDT),
                new SqlParameter("IDDanToc",obj.IDDanToc),
                new SqlParameter("IDTonGiao",obj.IDTonGiao),
                new SqlParameter("IDTrinhDoVH",obj.IDTrinhDoVH),
                new SqlParameter("IDTrinhDo",obj.IDTrinhDo),
                new SqlParameter("IDDonVi",obj.IDDonVi),
                new SqlParameter("IDDoiTuong",obj.IDDoiTuong),
                new SqlParameter("IDNgoaiNgu",obj.IDNgoaiNgu),
                new SqlParameter("ChieuCao",obj.ChieuCao),
                new SqlParameter("CanNang",obj.CanNang),
                new SqlParameter("LinkAnhCaNhan",obj.LinkAnhCaNhan),
                new SqlParameter("CMT",obj.CMT),
            };
            return base.ExecuteSQL("HoSo_Update", para);
        }
        public int Delete(string IDHoSo)
        {
            SqlParameter[] para =
               {
                new SqlParameter("IDHoSo", IDHoSo)
            };
            return base.ExecuteSQL("HoSo_Delete", para);
        }

        public DataTable GetDataDanToc()
        {
            return base.GetData("DanToc_Select_All", null);
        }

        public DataTable GetDataTonGiao()
        {
            return base.GetData("TonGiao_Select_All", null);
        }

        public DataTable GetDataTrinhDoHV()
        {
            return base.GetData("TrinhDoVH_Select_All", null);
        }

        public DataTable GetDataTrinhDo()
        {
            return base.GetData("TrinhDo_Select_All", null);
        }

        public DataTable GetDataDonVi()
        {
            return base.GetData("Donvi_Select_All", null);
        }

        public DataTable GetDataDoiTuong()
        {
            return base.GetData("DoiTuong_Select_All", null);
        }

        public DataTable GetDataNgoaiNgu()
        {
            return base.GetData("NgoaiNgu_Select_All", null);
        }

        public DataTable GetDataCMT()
        {
            return base.GetData("ChiTietCMND_Select_All", null);
        }
    }
}
