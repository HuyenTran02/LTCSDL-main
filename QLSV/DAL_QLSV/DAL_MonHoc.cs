using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLSV;

namespace DAL_QLSV
{
    public class DAL_MonHoc : DBConnect
    {
        public DataTable getTMHById(string id)
        {
            string SQL = string.Format("SELECT * FROM dbo.MonHoc WHERE id = '{0}'", id);
            SqlDataAdapter mh = new SqlDataAdapter(SQL, conn);
            DataTable dtMH = new DataTable();
            mh.Fill(dtMH);
            return dtMH;
        }

        public DataTable getTMHByMGV(string idGV)
        {
            string SQL = string.Format("SELECT * FROM dbo.MonHoc WHERE id_GV = '{0}'", idGV);
            SqlDataAdapter mh = new SqlDataAdapter(SQL, conn);
            DataTable dtMH = new DataTable();
            mh.Fill(dtMH);
            return dtMH;
        }

        public DataSet getMH()
        {
            SqlDataAdapter mh = new SqlDataAdapter("SELECT * FROM dbo.MonHoc", conn);
            DataSet dtMH = new DataSet();
            mh.Fill(dtMH);
            return dtMH;
        }

        public DataSet getMHByMGV(string idGV)
        {
            string SQL = string.Format("SELECT * FROM dbo.MonHoc WHERE id_GV = '{0}'", idGV);
            SqlDataAdapter mh = new SqlDataAdapter(SQL, conn);
            DataSet dtMH = new DataSet();
            mh.Fill(dtMH);
            return dtMH;
        }

        public bool ThemMH(DTO_MonHoc mh)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("INSERT INTO dbo.MonHoc(id, Ten, SoTinChi, NgayBatDau, NgayKetThuc, Buoi, DiaDiem, Phong, id_GV) VALUES('{0}', N'{1}', '{2}', '{4}', N'{5}', N'{6}', '{7}', '{8}')",
                    mh.ID_MH, mh.TenMH, mh.SoTinChi, mh.Ngay_bD, mh.Ngay_kT, mh.Buoi, mh.DiaDiem, mh.Phong, mh.ID_gv);

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

        public bool SuaMH(DTO_MonHoc mh)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("UPDATE dbo.MonHoc SET Ten = N'{0}', SoTinChi = '{1}', NgayBatDau = '{2}', NgayKetThuc = '{3}', Buoi = N'{4}', DiaDiem = N'{5}, Phong = '{6}', id_GV = '{7}'' WHERE id = '{8}'",
                    mh.TenMH, mh.SoTinChi, mh.Ngay_bD, mh.Ngay_kT, mh.Buoi, mh.DiaDiem, mh.Phong, mh.ID_gv, mh.ID_MH);

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

        public bool XoaMH(string mh)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("DELETE FROM dbo.MonHoc WHERE id = '{0}'", mh);

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
