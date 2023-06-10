using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_MonHoc
    {
        private string id_MH;
        private string tenMH;
        private double soTinChi;
        private string Ngay_BD;
        private string Ngay_KT;
        private string buoi;
        private string diaDiem;
        private string phong;
        private string id_gv;


        public string ID_MH
        {
            get { return id_MH; }
            set { id_MH = value; }
        }

        public string TenMH
        {
            get { return tenMH; }
            set { tenMH = value; }
        }

        public string ID_gv
        {
            get { return id_gv; }
            set { id_gv = value; }
        }

        public double SoTinChi
        {
            get { return soTinChi; }
            set { soTinChi = value; }
        }

        public string Ngay_bD
        {
            get { return Ngay_BD; }
            set { Ngay_BD = value; }
        }

        public string Ngay_kT
        {
            get { return Ngay_KT; }
            set { Ngay_KT = value; }
        }

        public string Buoi
        {
            get { return buoi; }
            set { buoi = value; }
        }

        public string DiaDiem
        {
            get { return diaDiem; }
            set { diaDiem = value; }
        }

        public string Phong
        {
            get { return phong; }
            set { phong = value; }
        }

        public DTO_MonHoc()
        { }
        public DTO_MonHoc(string id_mh, string ten_mh, string id_gv, double stc, string ngay_BD, string ngay_Kt,
            string buoi, string diaDiem, string phong)
        {
            this.id_MH = id_mh;
            this.tenMH = ten_mh;
            this.id_gv = id_gv;
            this.soTinChi = stc;
            this.Ngay_BD = ngay_BD;
            this.Ngay_KT = ngay_Kt; 
            this.buoi = buoi;
            this.diaDiem = diaDiem;
            this.phong = phong;
        }
    }
}
