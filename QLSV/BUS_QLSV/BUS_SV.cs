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
    public class BUS_SV
    {
        private DAL_SV dAL_SV = new DAL_SV();

        public DataTable getTSV()
        {
            return dAL_SV.getTSV();
        }

        public DataTable getTSVByID(string id)
        {
            return dAL_SV.getTSVById(id);
        }

        public bool ThemSV(DTO_SV dTO_SV)
        {
            return dAL_SV.ThemSV(dTO_SV);
        }

        public bool SuaSV(DTO_SV dTO_SV)
        {
            return dAL_SV.SuaSV(dTO_SV);
        }

        public bool XoaSV(string id)
        {
            return dAL_SV.XoaSV(id);
        }
    }
}
