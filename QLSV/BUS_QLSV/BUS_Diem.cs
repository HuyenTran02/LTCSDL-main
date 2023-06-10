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
    public class BUS_Diem
    {
        //private DTO_Diem dTO_Diem = new DTO_Diem();
        private DAL_Diem dAL_Diem = new DAL_Diem();

        public DataTable getTDiem()
        {
            return dAL_Diem.getTDiem();
        }

        public DataTable getTDiemByMSSV(string mssv)
        {
            return dAL_Diem.getTDiemByMSSV(mssv);
        }

        public DataTable getTDiemByIdMH(string idmh)
        {
            return dAL_Diem.getTDiemByIdMH(idmh);
        }

        public DataTable getTDiemByIdGV(string idgv)
        {
            return dAL_Diem.getTDiemByIdGV(idgv);
        }

        public DataTable getTDiemTBByMSSV(string mssv)
        {
            return dAL_Diem.getTDiemTBByMSSV(mssv);
        }

        public bool ThemDiem(DTO_Diem dTO_Diem)
        {
            return dAL_Diem.ThemDiem(dTO_Diem);
        }

        public bool SuaDiem(DTO_Diem dTO_Diem)
        {
            return dAL_Diem.SuaDiem(dTO_Diem);
        }

        public bool XoaDiem(int id)
        {
            return dAL_Diem.XoaDiem(id);
        }
    }
}
