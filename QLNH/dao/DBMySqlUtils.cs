using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.dao
{
    internal class DBMySqlUtils
    {
        public static MySqlConnection getDBconnection(string host, int port, string database, string username, string password)
        {
            string connecString = "Server=" + host + ";database=" + database + ";port=" + port + ";UserId=" + username +
                 ";password=" + password + ";CharSet=utf8";
            Console.WriteLine(connecString);
            MySqlConnection connec = new MySqlConnection(connecString);
            return connec;
        }
    }
}
