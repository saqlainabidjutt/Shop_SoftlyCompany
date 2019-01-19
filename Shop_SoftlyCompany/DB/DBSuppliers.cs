using Shop_TPV.Classes;
using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Shop_TPV.DB
{
    class DBSuppliers
    {
        private Connection db = new Connection();
        //// //, , , NAME, FIRSTNAME, LASTNAME, GENDER, EMAIL, ADDR_ID, SHOP_ID
        private static readonly string sFields = "S.ID,S.NAME as Name,S.FIRSTNAME as FirstName,S.LASTNAME as LastName,S.USER_IDENTITY,S.EMAIL as Email,S.STATUS,A.TELEFON,A.STREET,A.BUILDINGNUM,A.FLOOR,A.DOORNUM,A.POSTALCODE,A.CITY,A.PROVENCE,A.COUNTRY,A.ID as Address_Id";
        private static readonly string sData = "select " + sFields + " from users S,Address A where S.ADDR_ID=A.ID AND S.ROLE='Supplier'";
        private DataTable Query(String sql)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = db.makeConn();
            try
            {
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
        public DataTable Select()
        {
            
            DataTable dt = new DataTable();
            try
            {
                dt = Query(sData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public bool Insert(Supplier s)
        {
            bool isSuccess = false;
            MySqlConnection conn = db.makeConn();
            try
            {
                conn.Open();
                string sqlShop = "insert into USERS (ROLE, STATUS, USER_IDENTITY, NAME, FIRSTNAME, LASTNAME, EMAIL, ADDR_ID, SHOP_ID) Values (@ROLE, @STATUS, @USER_IDENTITY, @NAME, @FIRSTNAME, @LASTNAME, @EMAIL, @ADDR_ID, @SHOP_ID)";
                MySqlCommand cmd = new MySqlCommand(sqlShop, conn);
                cmd.Parameters.AddWithValue("@ROLE", s.Role);
                cmd.Parameters.AddWithValue("@STATUS", s.Status);
                cmd.Parameters.AddWithValue("@USER_IDENTITY", s.UserIdentity);
                cmd.Parameters.AddWithValue("@NAME", s.Name);
                cmd.Parameters.AddWithValue("@FIRSTNAME", s.Fname);
                cmd.Parameters.AddWithValue("@LASTNAME", s.Lname);
                cmd.Parameters.AddWithValue("@EMAIL", s.Email);
                cmd.Parameters.AddWithValue("@ADDR_ID", s.AddrId);
                cmd.Parameters.AddWithValue("@SHOP_ID", s.ShopId);
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
        public bool Update(Supplier s)
        {
            bool isSuccess = false;
            MySqlConnection conn = db.makeConn();
            try
            {
                conn.Open();
                string sqlShop = "UPDATE USERS SET ROLE=@ROLE, STATUS=@STATUS, USER_IDENTITY=@USER_IDENTITY, NAME=@NAME, FIRSTNAME=@FIRSTNAME, LASTNAME=@LASTNAME, EMAIL=@EMAIL WHERE ID=@ID";
                MySqlCommand cmd = new MySqlCommand(sqlShop, conn);
                cmd.Parameters.AddWithValue("@ROLE", s.Role);
                cmd.Parameters.AddWithValue("@STATUS", s.Status);
                cmd.Parameters.AddWithValue("@USER_IDENTITY", s.UserIdentity);
                cmd.Parameters.AddWithValue("@NAME", s.Name);
                cmd.Parameters.AddWithValue("@FIRSTNAME", s.Fname);
                cmd.Parameters.AddWithValue("@LASTNAME", s.Lname);
                cmd.Parameters.AddWithValue("@EMAIL", s.Email);
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
        public DataTable Search(Supplier s, Address a)
        {
            DataTable dt = new DataTable();
            string search = "";
            if (s.Name != "")
            {
                search += " AND S.NAME like '%" + s.Name + "%'";
            }
            if (s.Fname != "")
            {
                search += " AND S.FIRSTNAME like '%" + s.Fname + "%'";
            }
            if (s.Lname != "")
            {
                search += " AND S.LASTNAME like '%" + s.Lname + "%'";
            }
            if (s.Email != "")
            {
                search += " AND S.EMAIL like '%" + s.Email + "%'";
            }
            if (s.UserIdentity != "")
            {
                search += " AND S.USER_IDENTITY like '%" + s.UserIdentity + "%'";
            }
            if (s.Status != "")
            {
                search += " AND S.STATUS like '%" + s.Status + "%'";
            }
            // //, , , NAME, FIRSTNAME, LASTNAME, GENDER, EMAIL, ADDR_ID, SHOP_ID


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
                    dt = Query(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable Search(string label, string keyword, string orderby)
        {
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
                //, STATUS, USER_IDENTITY, NAME, FIRSTNAME, LASTNAME, GENDER, EMAIL, ADDR_ID, SHOP_ID
                search += " AND (S.NAME like '%" + keyword + "%'";
                search += " OR S.FIRSTNAME like '%" + keyword + "%'";
                search += " OR S.LASTNAME like '%" + keyword + "%'";
                search += " OR S.EMAIL like '%" + keyword + "%'";
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
                    dt = Query(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
