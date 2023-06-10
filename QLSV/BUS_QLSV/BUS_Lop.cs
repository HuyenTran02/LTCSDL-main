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
    public class BUS_Lop
    {
        private DAL_Lop dAL_Lop = new DAL_Lop();

        public DataTable getTLop()
        {
            return dAL_Lop.getTLop();
        }

        public DataSet getLop()
        {
            return dAL_Lop.getLop();
        }

        public bool ThemLop(DTO_Lop dTO_Lop)
        {
            return dAL_Lop.ThemLop(dTO_Lop);
        }

        public bool SuaLop(DTO_Lop dTO_Lop)
        {
            return dAL_Lop.SuaLop(dTO_Lop);
        }

        public bool XoaLop(int id)
        {
            return dAL_Lop.XoaLop(id);
        }
    }
}
