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
    public class BUS_MonHoc
    {
        private DAL_MonHoc dAL_MH = new DAL_MonHoc();
        private DTO_MonHoc dTO_MH = new DTO_MonHoc();

        public DataTable getTMHById(string id)
        {
            return dAL_MH.getTMHById(id);
        }

        public DataTable getTMHByMGV(string idGV)
        {
            return dAL_MH.getTMHByMGV(idGV);
        }

        public DataSet getMH()
        {
            return dAL_MH.getMH();
        }

        public DataSet getMHByMGV(string idGV)
        {
            return dAL_MH.getMHByMGV(idGV);
        }

        public bool ThemMH()
        {
            return dAL_MH.ThemMH(dTO_MH);
        }

        public bool SuaMH()
        {
            return dAL_MH.SuaMH(dTO_MH);
        }

        public bool XoaMH(string id)
        {
            return dAL_MH.XoaMH(id);
        }
    }
}
