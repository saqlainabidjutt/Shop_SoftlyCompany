using Shop_TPV.Classes;
using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Shop_TPV.DB
{

    class CatelogDB
    {
        private Connection db =new Connection();
        private static string sFields = "ID as Id,NAME as Name,STATUS as Status,DTO as Dto,DESCRIPTION as Description";
        private static string selectData = "select " + sFields + " from FAMILIAS WHERE SHOP_ID=@SHOP_ID";
        public DataTable Select(int shopId)
        {
            MySqlConnection conn = db.makeConn();
            DataTable dt = new DataTable();
            try
            {
                string sql = selectData;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SHOP_ID", shopId);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                conn.Open();
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            MySqlConnection conn = db.makeConn();
            try
            {
                conn.Open();
                string sql = "insert into FAMILIAS (NAME, DESCRIPTION, STATUS, DTO, SHOP_ID) Values (@NAME, @DESCRIPTION, @STATUS, @DTO, @SHOP_ID)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NAME", c.Name);
                cmd.Parameters.AddWithValue("@DESCRIPTION", c.Description);
                cmd.Parameters.AddWithValue("@STATUS", c.Status);
                cmd.Parameters.AddWithValue("@DTO", c.Dto);
                cmd.Parameters.AddWithValue("@SHOP_ID", c.ShopId);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Update
        public bool Update(Catelog c)
        {
            bool isSuccess = false;
            MySqlConnection conn = db.makeConn();
            try
            {
                conn.Open();
                //NAME, DESCRIPTION, STATUS, DTO, SHOP_ID
                string sqlShop = "UPDATE FAMILIAS SET NAME=@NAME, DESCRIPTION=@DESCRIPTION, STATUS=@STATUS, DTO=@DTO WHERE ID=@ID";
                MySqlCommand cmd = new MySqlCommand(sqlShop, conn);
                cmd.Parameters.AddWithValue("@NAME", c.Name);
                cmd.Parameters.AddWithValue("@DESCRIPTION", c.Description);
                cmd.Parameters.AddWithValue("@STATUS", c.Status);
                cmd.Parameters.AddWithValue("@DTO", c.Dto);
                cmd.Parameters.AddWithValue("@ID", c.Id);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public DataTable Search(Catelog c)
        {
            MySqlConnection conn = db.makeConn();
            DataTable dt = new DataTable();
            string search = "";
            if (c.Name != "")
            {
                search += " AND NAME like '%" + c.Name + "%'";
            }
            if (c.Description != "")
            {
                search += " AND DESCRIPTION like '%" + c.Description + "%'";
            }
            if (c.Dto >0)
            {
                search += " AND DTO like '%" + c.Dto + "%'";
            }
            if (c.Status != "")
            {
                search += " AND STATUS like '%" + c.Status + "%'";
            }
            try
            {
                if (search != "")
                {

                    string sql = selectData;
                    sql += search;
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@SHOP_ID", c.ShopId);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                    conn.Open();
                    adp.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //string label, string keyword, string orderby
        public DataTable Search(string label, string keyword, string orderby)
        {
            MySqlConnection conn = db.makeConn();
            Catelog c = new Catelog();
            DataTable dt = new DataTable();
            string search = "";
            if (label != "" && keyword != "")
            {
                search += " AND " + label + " like '%" + keyword + "%'";
            }
            if (label != "" && orderby != "")
            {
                search += " ORDER BY " + label + " " + orderby;
            }
            if (label == "" && keyword != "")
            {
                search += " AND (NAME like '%" + keyword + "%'";
                search += " OR DESCRIPTION like '%" + keyword + "%'";
                search += " OR DTO like '%" + keyword + "%'";
                search += " OR STATUS like '%" + keyword + "%')";
            }
            try
            {
                if (search != "")
                {

                    string sql = selectData;
                    sql += search;
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@SHOP_ID", c.ShopId);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    conn.Open();
                    adp.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
