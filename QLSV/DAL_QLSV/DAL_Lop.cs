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
    public class DAL_Lop :DBConnect
    {
        public DataTable getTLop()
        {
            SqlDataAdapter l = new SqlDataAdapter("SELECT * FROM dbo.Lop", conn);
            DataTable dtlop = new DataTable();
            l.Fill(dtlop);
            return dtlop;
        }

        public DataSet getLop()
        {
            SqlDataAdapter l = new SqlDataAdapter("SELECT * FROM dbo.Lop", conn);
            DataSet dtlop = new DataSet();
            l.Fill(dtlop);
            return dtlop;
        }

        public bool ThemLop(DTO_Lop lop)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("INSERT INTO dbo.Lop(Ten, KhoaHoc, id_Khoa) VALUES('{0}', '{1}', '{2}')",
                    lop.Ten_Lop, lop.KhoaHoc_Lop, lop.IDKhoa_Lop);

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

        public bool SuaLop(DTO_Lop lop)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("UPDATE dbo.Lop SET Ten = '{0}', KhoaHoc = '{1}', id_Khoa = '{2}' WHERE id = '{3}'", 
                    lop.Ten_Lop, lop.KhoaHoc_Lop, lop.IDKhoa_Lop, lop.ID_Lop);

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

        public bool XoaLop(int idLop)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("DELETE FROM dbo.Lop WHERE id = '{0}'", idLop);

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
