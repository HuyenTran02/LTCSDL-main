using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSV
{
    public class DTO_Diem
    {
        private int id_Diem;
        private string idSV_Diem;
        private string idMH_Diem;
        private float diem_GK;
        private float diem_CK;
        private float diemHe_10;
        private float diemHe_4;
        private string loai_Diem;

        public int ID_Diem
        {
            get { return id_Diem; }
            set { id_Diem = value; }
        }

        public string IDSV_Diem
        {
            get { return idSV_Diem; }
            set { idSV_Diem = value; }
        }

        public string IDMH_Diem
        {
            get { return idMH_Diem; }
            set { idMH_Diem = value; }
        }

        public float GK_Diem
        {
            get { return diem_GK; }
            set { diem_GK = value; }
        }

        public float CK_Diem
        {
            get { return diem_CK; }
            set { diem_CK = value; }
        }

        public float He_10
        {
            get { return diemHe_10; }
            set { diemHe_10 = value; }
        }

        public float He_4
        {
            get { return diemHe_4; }
            set { diemHe_4 = value; }
        }

        public string Loai_Diem
        {
            get { return loai_Diem; }
            set { loai_Diem = value; }
        }

        public DTO_Diem()
        { }

        public DTO_Diem(int id_Diem, string idSV_Diem, string idMH_Diem, float diem_GK, float diem_CK, 
            float diemHe_10, float diemHe_4, string loai_Diem)
        { 
            this.id_Diem = id_Diem;
            this.idSV_Diem = idSV_Diem;
            this.idMH_Diem = idMH_Diem;
            this.diem_GK = diem_GK;
            this.diem_CK = diem_CK;
            this.diemHe_10 = diemHe_10;
            this.diemHe_4 = diemHe_4;
            this.loai_Diem = loai_Diem;
            
        }

        public DTO_Diem(string idSV_Diem, string idMH_Diem, float diem_GK, float diem_CK,
            float diemHe_10, float diemHe_4, string loai_Diem)
        {
            this.idSV_Diem = idSV_Diem;
            this.idMH_Diem = idMH_Diem;
            this.diem_GK = diem_GK;
            this.diem_CK = diem_CK;
            this.diemHe_10 = diemHe_10;
            this.diemHe_4 = diemHe_4;
            this.loai_Diem = loai_Diem;

        }
    }
}
