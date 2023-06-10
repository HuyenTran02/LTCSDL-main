using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_GV
    {
        private string id_GV;
        private string hoTen_GV;
        private string cccd_GV;
        private string gT_GV;
        private string nS_GV;
        private string hocVi_GV;
        private string chucVu_GV;
        private string que_GV;
        private string email_GV;
        private string sDT_GV;

        public string ID_GV
        {
            get { return id_GV; }
            set { id_GV = value; }
        }

        public string HoTen_GV
        {
            get { return hoTen_GV; }
            set { hoTen_GV = value; }
        }

        public string GT_GV
        {
            get { return gT_GV; }
            set { gT_GV = value; }
        }

        public string NS_GV
        {
            get { return nS_GV; }
            set { nS_GV = value; }
        }

        public string HocVi_GV
        {
            get { return hocVi_GV; }
            set { hocVi_GV = value; }
        }

        public string ChucVu_GV
        {
            get { return chucVu_GV; }
            set { chucVu_GV = value; }
        }

        public string Que_GV
        {
            get { return que_GV; }
            set { que_GV = value; }
        }

        public string Email_GV
        {
            get { return email_GV; }
            set { email_GV = value; }
        }

        public string Sdt_GV
        {
            get { return sDT_GV; }
            set { sDT_GV = value; }
        }

        public string CCCD_GV
        {
            get { return cccd_GV; }
            set { cccd_GV = value; }
        }

        public DTO_GV()
        { }

        public DTO_GV (string id_GV, string hoTen_GV, string cccd_GV, string gT_GV, string nS_GV, 
            string hocVi_GV, string chucVu_GV, string que_GV, string email_GV, string sDT_GV)
        {
            this.id_GV = id_GV;
            this.hoTen_GV = hoTen_GV;
            this.cccd_GV = cccd_GV;
            this.gT_GV= gT_GV;
            this.nS_GV = nS_GV;
            this.hocVi_GV = hocVi_GV;
            this.chucVu_GV = chucVu_GV;
            this.que_GV = que_GV;
            this.email_GV = email_GV;
            this.sDT_GV = sDT_GV;
        }
    }
}
