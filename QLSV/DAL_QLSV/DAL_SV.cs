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
    public class DAL_SV : DBConnect
    {
        public DataTable getTSV()
        {
            SqlDataAdapter sv = new SqlDataAdapter("SELECT * FROM dbo.SV", conn);
            DataTable dtSV = new DataTable();
            sv.Fill(dtSV);
            return dtSV;
        }

        public DataTable getTSVById(string id)
        {
            string SQL = string.Format("SELECT * FROM dbo.SV WHERE MSSV = '{0}'", id);
            SqlDataAdapter sv = new SqlDataAdapter(SQL, conn);
            DataTable dtSV = new DataTable();
            sv.Fill(dtSV);
            return dtSV;
        }

        public bool ThemSV(DTO_SV sv)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("INSERT INTO dbo.SV(MSSV, HoTen, CCCD, NgaySinh, GioiTinh, Que, SDT, Email, TrangThai, id_Lop) VALUES('{0}', N'{1}', '{2}', '{3}', N'{4}', N'{5}', '{6}', '{7}', N'{8}', '{9}')",
                   sv.MSSV, sv.HoTen_SV, sv.CCCD, sv.NS_SV, sv.GT_SV, sv.Que_SV, sv.Sdt_SV, sv.Email_SV, sv.TrangThai_SV, sv.IdLop_SV);

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

        public bool SuaSV(DTO_SV sv)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("UPDATE dbo.SV SET HoTen = N'{0}', CCCD = '{1}', NgaySinh = '{2}', GioiTinh = N'{3}', Que = N'{4}', SDT = '{5}', Email = '{6}', TrangThai = N'{7}', id_Lop = '{8}' WHERE MSSV = '{9}'",
                   sv.HoTen_SV, sv.CCCD, sv.NS_SV, sv.GT_SV, sv.Que_SV, sv.Sdt_SV, sv.Email_SV, sv.TrangThai_SV, sv.IdLop_SV, sv.MSSV);

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

        public bool XoaSV(string sv)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("DELETE FROM dbo.SV WHERE MSSV = '{0}'", sv);

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
