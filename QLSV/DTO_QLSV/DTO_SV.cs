using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_SV
    {
        private string mssv;
        private string hoTen_SV;
        private string cccd;
        private string ns_SV;
        private string que_SV;
        private string sdt_SV;
        private string email_SV;
        private string trangthai_SV;
        private string gt_SV;
        private int idLop_SV;

        public string MSSV
        {
            get { return mssv; }
            set { mssv = value; }
        }

        public string HoTen_SV
        {
            get { return hoTen_SV; }
            set { hoTen_SV = value; }
        }

        public string CCCD
        {
            get { return cccd; }
            set { cccd = value; }
        }

        public string Sdt_SV
        {
            get { return sdt_SV; }
            set { sdt_SV = value; }
        }

        public String Email_SV
        {
            get { return email_SV; }
            set { email_SV = value; }
        }

        public string TrangThai_SV
        {
            get { return trangthai_SV; }
            set { trangthai_SV = value; }
        }

        public string GT_SV
        {
            get { return gt_SV; }
            set { gt_SV = value; }
        }

        public int IdLop_SV
        {
            get { return idLop_SV; }
            set { idLop_SV = value; }
        }

        public string Que_SV
        {
            get { return que_SV; }
            set { que_SV = value; }
        }

        public string NS_SV
        {
            get { return ns_SV; }
            set { ns_SV = value; }
        }

        public DTO_SV()
        {

        }

        public DTO_SV(string mssv, string hoten, string cccd, string ns,
            string que, string sdt, string email, string tt, string gt, int idlop)
        {
            this.mssv = mssv;
            this.hoTen_SV = hoten;
            this.cccd = cccd;
            this.ns_SV = ns;
            this.que_SV = que;
            this.sdt_SV = sdt;
            this.email_SV = email;
            this.trangthai_SV = tt;
            this.gt_SV = gt;
            this.idLop_SV = idlop;
        }
    }
}
