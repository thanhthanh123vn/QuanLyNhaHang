using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.dao
{
    internal class DBUtils
    {
        public  MySqlConnection GetMySqlConnection()
        {
            string host = "127.0.0.1";
            int post = 3306;
            string database = "quanlynhahang";
            string name = "root";
            string password = "";

            return DBMySqlUtils.getDBconnection(host, post, database, name, password);
        }
    }
}
