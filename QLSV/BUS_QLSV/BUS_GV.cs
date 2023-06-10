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
    public class BUS_GV
    {
        private DAL_GV dAL_GV = new DAL_GV();

        public DataTable getTGV()
        {
            return dAL_GV.getTGV();
        }

        public DataTable getTGVById(string id)
        {
            return dAL_GV.getTGVbByid(id);
        }

        public bool ThemGV(DTO_GV dTO_GV)
        {
            return dAL_GV.ThemGV(dTO_GV);
        }

        public bool SuaGV(DTO_GV dTO_GV)
        {
            return dAL_GV.SuaGV(dTO_GV);
        }

        public bool XoaGV(string id)
        {
            return dAL_GV.XoaGV(id);
        }
    }
}
