using Shop_TPV.Classes;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Shop_TPV.DB;
using Shop_SoftlyCompany.Classes;
using System.Windows.Forms;

namespace Shop_SoftlyCompany.DB
{
    class DBShop
    {
        private Connection db = new Connection();
        private static string sFields = "S.ID,S.NAME as Name,S.USER_IDENTITY,S.STATUS,A.TELEFON,A.STREET,A.BUILDINGNUM,A.FLOOR,A.DOORNUM,A.POSTALCODE,A.CITY,A.PROVENCE,A.COUNTRY,A.ID as Address_Id";
        private static string sData = "select "+ sFields + " from users S,Address A where S.ADDR_ID=A.ID AND S.ROLE='Shop'";
        public DataTable Select()
        {
            MySqlConnection conn = db.makeConn();
            DataTable dt = new DataTable();
            try
            {
                string sql = sData;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
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
        public bool Insert(Shop s)
        {
            bool isSuccess = false;
            MySqlConnection conn = db.makeConn();
            try
            {
                conn.Open();
                string sqlShop = "insert into USERS (ROLE, STATUS, USER_IDENTITY, NAME, ADDR_ID) Values (@ROLE, @STATUS, @USER_IDENTITY, @NAME, @ADDR_ID)";
                MySqlCommand cmd = new MySqlCommand(sqlShop, conn);
                cmd.Parameters.AddWithValue("@ROLE", s.role);
                cmd.Parameters.AddWithValue("@STATUS", s.status);
                cmd.Parameters.AddWithValue("@USER_IDENTITY", s.identity);
                cmd.Parameters.AddWithValue("@NAME", s.name);
                cmd.Parameters.AddWithValue("@ADDR_ID", s.addrId);
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
        public bool Update(Shop s)
        {
            bool isSuccess = false;
            MySqlConnection conn = db.makeConn();
            try
            {
                conn.Open();
                string sqlShop = "UPDATE USERS SET ROLE=@ROLE, STATUS=@STATUS, USER_IDENTITY=@USER_IDENTITY, NAME=@NAME WHERE ID=@ID";
                MySqlCommand cmd = new MySqlCommand(sqlShop, conn);
                cmd.Parameters.AddWithValue("@ROLE", s.role);
                cmd.Parameters.AddWithValue("@STATUS", s.status);
                cmd.Parameters.AddWithValue("@USER_IDENTITY", s.identity);
                cmd.Parameters.AddWithValue("@NAME", s.name);
                cmd.Parameters.AddWithValue("@ID", s.Id);
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
        public DataTable Search(Shop s,Address a)
        {
            MySqlConnection conn = db.makeConn();
            DataTable dt = new DataTable();
            string search = "";
            if (s.name != "")
            {
                search += " AND S.NAME like '%" + s.name + "%'";
            }
            if (s.identity != "")
            {
                search += " AND S.USER_IDENTITY like '%" + s.identity + "%'";
            }
            if (s.status != "")
            {
                search += " AND S.STATUS like '%" + s.status + "%'";
            }
            if (a.telefone != "")
            {
                search += " AND A.TELEFON like '%" + a.telefone + "%'";
            }
            if (a.street != "")
            {
                search += " AND A.STREET like '%" + a.street + "%'";
            }
            if (a.buildingNo != "")
            {
                search += " AND A.BUILDINGNUM like '%" + a.buildingNo + "%'";
            }
            if (a.floor != "")
            {
                search += " AND A.FLOOR like '%" + a.buildingNo + "%'";
            }
            if (a.door != "")
            {
                search += " AND A.DOORNUM like '%" + a.door + "%'";
            }
            if (a.postalCode != "")
            {
                search += " AND A.POSTALCODE like '%" + a.postalCode + "%'";
            }
            if (a.city != "")
            {
                search += " AND A.CITY like '%" + a.city + "%'";
            }
            if (a.provenc != "")
            {
                search += " AND A.PROVENCE like '%" + a.provenc + "%'";
            }
            if (a.country != "")
            {
                search += " AND A.COUNTRY like '%" + a.country + "%'";
            }
            try
            {
                if (search != "")
                {

                    string sql = sData;
                    sql += search;
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
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
            DataTable dt = new DataTable();
            string search = "";
            if (label != "" && keyword !="")
            {
                search += " AND "+ label + " like '%" + keyword + "%'";
            }
            if (label != "" && orderby != "")
            {
                search += " ORDER BY "+ label+" "+ orderby;
            }if(label=="" && keyword != "")
            {
                search += " AND (S.NAME like '%" + keyword + "%'";
                search += " OR S.USER_IDENTITY like '%" + keyword + "%'";
                search += " OR S.STATUS like '%" + keyword + "%'";
                search += " OR A.TELEFON like '%" + keyword + "%'";
                search += " OR A.STREET like '%" + keyword + "%'";
                search += " OR A.BUILDINGNUM like '%" + keyword + "%'";
                search += " OR A.FLOOR like '%" + keyword + "%'";
                search += " OR A.DOORNUM like '%" + keyword + "%'";
                search += " OR A.POSTALCODE like '%" + keyword + "%'";
                search += " OR A.CITY like '%" + keyword + "%'";
                search += " OR A.PROVENCE like '%" + keyword + "%'";
                search += " OR A.COUNTRY like '%" + keyword + "%')";
            }
            try
            {
                if (search != "")
                {

                    string sql = sData;
                    sql += search;
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
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
