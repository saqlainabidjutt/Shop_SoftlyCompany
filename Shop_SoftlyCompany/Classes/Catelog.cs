using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_SoftlyCompany.Classes
{
    class Catelog
    {

        public int CatelogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        static string MyConnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public DataTable Select()
        {
            MySqlConnection conn = new MySqlConnection(MyConnection);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from catelogs";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                conn.Open();
                adp.Fill(dt);
            }
            catch(Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool Insert(Catelog c)
        {
            bool isSuccess = false;
            MySqlConnection conn = new MySqlConnection(MyConnection);
            try
            {
                conn.Open();
                string sql = "insert into catelogs (Name, description) Values (@Name, @description)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name",c.Name);
                cmd.Parameters.AddWithValue("@description", c.Description);            
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
    }
}
