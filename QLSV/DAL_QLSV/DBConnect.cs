using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSV
{
    public class DBConnect
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=huyentran;Initial Catalog=qlsv1;Integrated Security=True");
    }
}
