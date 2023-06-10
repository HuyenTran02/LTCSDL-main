using DTO_QLSV;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSV
{
    public class DAL_Diem : DBConnect
    {
        public DataTable getTDiem()
        {
            SqlDataAdapter diem = new SqlDataAdapter("SELECT * FROM dbo.Diem", conn);
            DataTable dtDiem = new DataTable();
            diem.Fill(dtDiem);
            return dtDiem;
        }

        public DataTable getTDiemByMSSV(string mssv)
        {
            string SQL = string.Format("SELECT * FROM dbo.Diem WHERE MSSV = '{0}'", mssv);
            SqlDataAdapter diem = new SqlDataAdapter(SQL, conn);
            DataTable dtDiem = new DataTable();
            diem.Fill(dtDiem);
            return dtDiem;
        }

        public DataTable getTDiemByIdMH(string MSSV)
        {
            string SQL = string.Format("SELECT * FROM dbo.Diem d join dbo.MonHoc mh ON d.id_MH = mh.id WHERE d.MSSV = '{0}'", MSSV);
            SqlDataAdapter diem = new SqlDataAdapter(SQL, conn);
            DataTable dtDiem = new DataTable();
            diem.Fill(dtDiem);
            return dtDiem;
        }

        public DataTable getTDiemByIdGV(string id_GV)
        {
            string SQL = string.Format("SELECT * FROM dbo.Diem d join dbo.MonHoc mh ON d.id_MH = mh.id WHERE mh.id_GV = '{0}'", id_GV);
            SqlDataAdapter diem = new SqlDataAdapter(SQL, conn);
            DataTable dtDiem = new DataTable();
            diem.Fill(dtDiem);
            return dtDiem;
        }

        public DataTable getTDiemTBByMSSV(string mssv)
        {
            string SQL = string.Format("SELECT AVG(DiemHe_10) FROM dbo.Diem d JOIN dbo.SV s ON d.MSSV = s.MSSV WHERE d.MSSV = '{0}'", mssv);
            SqlDataAdapter diem = new SqlDataAdapter(SQL, conn);
            DataTable dtDiem = new DataTable();
            diem.Fill(dtDiem);
            return dtDiem;
        }

        public bool ThemDiem(DTO_Diem diem)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("INSERT INTO dbo.Diem(MSSV, id_MH, GK_Diem, CK_Diem, DiemHe_10, DiemHe_4, Loai) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                   diem.IDSV_Diem, diem.IDMH_Diem, diem.GK_Diem, diem.CK_Diem, diem.He_10, diem.He_4, diem.Loai_Diem);
                SqlCommand cmd = new SqlCommand(SQL, conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool SuaDiem(DTO_Diem diem)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("UPDATE dbo.Diem SET MSSV = '{0}', id_MH = '{1}', GK_Diem = '{2}', CK_Diem = '{3}', DiemHe_10 = '{4}', DiemHe_4 = '{5}', Loai = '{6}' WHERE id = '{7}'",
                   diem.IDSV_Diem, diem.IDMH_Diem, diem.GK_Diem, diem.CK_Diem, diem.He_10, diem.He_4, diem.Loai_Diem, diem.ID_Diem);
                SqlCommand cmd = new SqlCommand(SQL, conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool XoaDiem(int idDiem)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("DELETE FROM dbo.Diem WHERE id = '{0}'", idDiem);
                SqlCommand cmd = new SqlCommand(SQL, conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
