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
    public class DAL_GV : DBConnect
    {
        public DataTable getTGV()
        {
            SqlDataAdapter gv = new SqlDataAdapter("SELECT * FROM dbo.GV", conn);
            DataTable dtGV = new DataTable();
            gv.Fill(dtGV);
            return dtGV;
        }

        public DataTable getTGVbByid(string id)
        {
            string SQL = string.Format("SELECT * FROM dbo.GV WHERE id = '{0}'", id);
            SqlDataAdapter gv = new SqlDataAdapter(SQL, conn);
            DataTable dtGV = new DataTable();
            gv.Fill(dtGV);
            return dtGV;
        }

        public bool ThemGV(DTO_GV gv)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("INSERT INTO dbo.GV(id, HoTen, NgaySinh, CCCD, GioiTinh, HocVi, ChucVu, Que, Email, SDT) VALUES('{0}', N'{1}', '{2}', '{3}', N'{4}', N'{5}', N'{6}', N'{7}', '{8}', '{9}')",
                    gv.ID_GV, gv.HoTen_GV, gv.NS_GV, gv.CCCD_GV, gv.GT_GV, gv.HocVi_GV, gv.ChucVu_GV, gv.Que_GV, gv.Email_GV, gv.Sdt_GV);

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

        public bool SuaGV(DTO_GV gv)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("UPDATE dbo.GV SET HoTen = N'{0}', NgaySinh = '{1}', CCCD = '{2}', GioiTinh = N'{3}', HocVi = N'{4}', ChucVu = N'{5}', Que = N'{6}', Email = '{7}', SDT = '{8}' WHERE id = '{9}'",
                   gv.HoTen_GV, gv.NS_GV, gv.CCCD_GV, gv.GT_GV, gv.HocVi_GV, gv.ChucVu_GV, gv.Que_GV, gv.Email_GV, gv.Sdt_GV, gv.ID_GV);

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

        public bool XoaGV(string gv)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("DELETE FROM dbo.GV WHERE id = '{0}'", gv);

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
