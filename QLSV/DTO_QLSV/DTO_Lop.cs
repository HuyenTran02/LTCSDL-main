using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Lop
    {
        private int id_Lop;
        private string ten_Lop;
        private string khoaHoc_Lop;
        private string idkhoa_Lop;

        public int ID_Lop
        {
            get { return id_Lop; }
            set { id_Lop = value; }
        }

        public string Ten_Lop
        {
            get { return ten_Lop; }
            set { ten_Lop = value; }
        }

        public string KhoaHoc_Lop
        {
            get { return khoaHoc_Lop; }
            set { khoaHoc_Lop = value; }
        }

        public string IDKhoa_Lop
        {
            get { return idkhoa_Lop; }
            set { idkhoa_Lop = value; }
        }

        public DTO_Lop()
        { }

        public DTO_Lop(string ten_Lop, string khoaHoc_Lop, string idkhoa_Lop)
        {
            this.ten_Lop = ten_Lop;
            this.khoaHoc_Lop = khoaHoc_Lop;
            this.idkhoa_Lop = idkhoa_Lop;
            
        }

        public DTO_Lop(int id_Lop, string ten_Lop, string khoaHoc_Lop, string idkhoa_Lop)
        {
            this.id_Lop = id_Lop;
            this.ten_Lop = ten_Lop;
            this.khoaHoc_Lop = khoaHoc_Lop;
            this.idkhoa_Lop = idkhoa_Lop;

        }
    }
}
