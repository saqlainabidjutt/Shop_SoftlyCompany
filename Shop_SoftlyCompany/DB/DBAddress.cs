using Shop_TPV.Classes;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Shop_TPV.DB;
using Shop_TPV.Classes;
using System.Windows.Forms;

namespace Shop_TPV.DB
{
    class DBAddress
    {
        private Connection db = new Connection();
        public long Insert(Address a)
        {
            long isSuccess = 0;
            MySqlConnection conn = db.makeConn();
            try
            {
                conn.Open();
                string sql = "insert into ADDRESS (TELEFON, BUILDINGNUM, STREET, DOORNUM, FLOOR, POSTALCODE, CITY, PROVENCE, COUNTRY) Values (@TELEFON, @BUILDINGNUM, @STREET, @DOORNUM, @FLOOR, @POSTALCODE, @CITY, @PROVENCE, @COUNTRY)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TELEFON", a.telefone);
                cmd.Parameters.AddWithValue("@BUILDINGNUM", a.buildingNo);
                cmd.Parameters.AddWithValue("@STREET", a.street);
                cmd.Parameters.AddWithValue("@DOORNUM", a.door);
                cmd.Parameters.AddWithValue("@FLOOR", a.floor);
                cmd.Parameters.AddWithValue("@POSTALCODE", a.postalCode);
                cmd.Parameters.AddWithValue("@CITY", a.city);
                cmd.Parameters.AddWithValue("@PROVENCE", a.provenc);
                cmd.Parameters.AddWithValue("@COUNTRY", a.country);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = cmd.LastInsertedId;
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
        public bool Update(Address a)
        {
            bool isSuccess = false;
            MySqlConnection conn = db.makeConn();
            try
            {
                conn.Open();
                string sql = "UPDATE ADDRESS SET TELEFON=@TELEFON, BUILDINGNUM=@BUILDINGNUM, STREET=@STREET, DOORNUM=@DOORNUM, FLOOR=@FLOOR, POSTALCODE=@POSTALCODE, CITY=@CITY, PROVENCE=@PROVENCE, COUNTRY=@COUNTRY WHERE ID=@ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TELEFON", a.telefone);
                cmd.Parameters.AddWithValue("@BUILDINGNUM", a.buildingNo);
                cmd.Parameters.AddWithValue("@STREET", a.street);
                cmd.Parameters.AddWithValue("@DOORNUM", a.door);
                cmd.Parameters.AddWithValue("@FLOOR", a.floor);
                cmd.Parameters.AddWithValue("@POSTALCODE", a.postalCode);
                cmd.Parameters.AddWithValue("@CITY", a.city);
                cmd.Parameters.AddWithValue("@PROVENCE", a.provenc);
                cmd.Parameters.AddWithValue("@COUNTRY", a.country);
                cmd.Parameters.AddWithValue("@ID", a.Id);
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
    }
}
