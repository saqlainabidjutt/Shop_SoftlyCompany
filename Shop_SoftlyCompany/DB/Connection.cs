using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Shop_TPV.DB;
namespace Shop_TPV.DB
{
    class Connection
    {
        static string MyConnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public MySqlConnection makeConn()
        {
                MySqlConnection conn = new MySqlConnection(MyConnection);
                return conn;
        }

    }
}
