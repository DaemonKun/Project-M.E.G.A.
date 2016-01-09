using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_IDE
{
    public static class mysqlCon
    {
        private static string connection =
            //"datasource=202.150.209.146;port=3306;username=u614761466_admin;password=TZyo6MkAe1;database=u614761466_mega";
            "datasource=localhost;port=3306;username=root;password=root;database=u614761466_mega";
        
        public static MySqlConnection conn()
        {
            return new MySqlConnection(connection);
        }
    }
}
