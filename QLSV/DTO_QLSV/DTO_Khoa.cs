using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Khoa
    {
        private string id_Khoa;
        private string ten_Khoa;
        private string email_Khoa;
        private string sdt_Khoa;

        public string Id_Khoa
        {
            get { return id_Khoa; }
            set { id_Khoa = value; }
        }

        public string Ten_Khoa
        {
            get { return ten_Khoa; }
            set { ten_Khoa = value; }
        }

        public string Email_Khoa
        {
            get { return email_Khoa; }
            set { email_Khoa = value; }
        }

        public string SDT_Khoa
        {
            get { return sdt_Khoa; }
            set { sdt_Khoa = value; }
        }

        public DTO_Khoa()
        { }

        public DTO_Khoa(string id_Khoa, string ten_Khoa, string email_Khoa, string sdt_Khoa)
        {
            this.id_Khoa = id_Khoa;
            this.ten_Khoa = ten_Khoa;
            this.email_Khoa = email_Khoa;
            this.sdt_Khoa = sdt_Khoa;
        }
    }
}
