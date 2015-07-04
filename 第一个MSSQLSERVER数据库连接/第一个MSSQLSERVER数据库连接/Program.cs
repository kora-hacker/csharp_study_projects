using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一个MSSQLSERVER数据库连接
{
    class Program
    {
        static void Main(string[] args)
        {
            // SqlConnection conn = new SqlConnection(@"SERVER=.\SQLEXPRESS;DATABASE=db_test;PWD=512china;UID=sa");
            SqlConnection conn = new SqlConnection(@"SERVER=.\SQLEXPRESS;DATABASE=db_test;Integrated Security=True");
            conn.Open();
        }
    }
}
