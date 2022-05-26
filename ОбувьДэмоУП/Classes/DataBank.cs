using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОбувьДэмоУП
{
    public static class DataBank
    {
        public static SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-TL7NP8K\SQLEXPRESS;Initial Catalog=ДэмоОбувьУП;Integrated Security=True;");
        public static int ContextMen = 0;
    }
}
