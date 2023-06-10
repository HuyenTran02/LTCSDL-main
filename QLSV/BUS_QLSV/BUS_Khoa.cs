using DAL_QLSV;
using DTO_QLSV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLSV
{
    public class BUS_Khoa
    {
        private DTO_Khoa dTO_Khoa = new DTO_Khoa();
        private DAL_Khoa dAL_Khoa = new DAL_Khoa();

        public DataTable getTKhoa()
        {
            return dAL_Khoa.getTKhoa();
        }

        public DataTable getTKhoaById(string id)
        {
            return dAL_Khoa.getTKhoaById(id);
        }

        public DataSet getKhoa()
        {
            return dAL_Khoa.getKhoa();
        }

        public DataSet getKhoaById(string id)
        {
            return dAL_Khoa.getKhoaById(id);
        }

        public bool ThemKhoa()
        {
            return dAL_Khoa.ThemKhoa(dTO_Khoa);
        }

        public bool SuaKhoa()
        {
            return dAL_Khoa.SuaKhoa(dTO_Khoa);
        }

        public bool XoaKhoa(string id)
        {
            return dAL_Khoa.XoaKhoa(id);
        }
    }
}
