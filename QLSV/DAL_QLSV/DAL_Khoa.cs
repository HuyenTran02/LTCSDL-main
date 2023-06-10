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
    public class DAL_Khoa :DBConnect
    {
        public DataTable getTKhoa()
        {
            SqlDataAdapter k = new SqlDataAdapter("SELECT * FROM dbo.Khoa", conn);
            DataTable dtKhoa = new DataTable();
            k.Fill(dtKhoa);
            return dtKhoa;
        }

        public DataTable getTKhoaById(string id)
        {
            string SQL = string.Format("SELECT * FROM dbo.Khoa WHERE id = '{0}'", id);
            SqlDataAdapter khoa = new SqlDataAdapter(SQL, conn);
            DataTable dtKhoa = new DataTable();
            khoa.Fill(dtKhoa);
            return dtKhoa;
        }

        public DataSet getKhoa()
        {
            SqlDataAdapter k = new SqlDataAdapter("SELECT * FROM dbo.Khoa", conn);
            DataSet dtKhoa = new DataSet();
            k.Fill(dtKhoa);
            return dtKhoa;
        }

        public DataSet getKhoaById(string id)
        {
            string SQL = string.Format("SELECT * FROM dbo.Khoa WHERE id = '{0}'", id);
            SqlDataAdapter khoa = new SqlDataAdapter(SQL, conn);
            DataSet dtKhoa = new DataSet();
            khoa.Fill(dtKhoa);
            return dtKhoa;
        }

        public bool ThemKhoa(DTO_Khoa khoa)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("INSERT INTO dbo.Khoa(id, Ten, Email, SDT) VALUES('{0}', N'{1}', '{2}')", khoa.Id_Khoa, khoa.Ten_Khoa, khoa.Email_Khoa, khoa.SDT_Khoa);

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

        public bool SuaKhoa(DTO_Khoa khoa)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("UPDATE dbo.Khoa SET Ten = N'{0}', Email = '{1}', SDT = '{2}' WHERE id = '{3}'", khoa.Ten_Khoa, khoa.Email_Khoa, khoa.SDT_Khoa, khoa.Id_Khoa);

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

        public bool XoaKhoa(string idkhoa)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("DELETE FROM dbo.Khoa WHERE id = '{0}'", idkhoa);

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
