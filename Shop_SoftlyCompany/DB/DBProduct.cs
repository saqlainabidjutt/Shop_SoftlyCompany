using Shop_TPV.Classes;
using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Shop_TPV.DB
{
    class DBProduct
    {
        private Connection db = new Connection();
        private static readonly string sFields = "P.ID as Id,P.NAME as Name,P.ISBN_CODE as ISBN,P.PRICE as Price,P.TEX as Tex,P.STOCK as Stock,P.DTO as DTO,P.STATUS as Status,C.NAME as Catelog";
        private static readonly string selectData = "select " + sFields + " from PRODUCTES P,FAMILIAS C,USERS S WHERE C.SHOP_ID=@S.SHOP_ID AND C.ID=P.FAMI_ID";
        private readonly Catelog c = new Catelog();
        private DataTable Query(String sql)
        {
            MySqlConnection conn = db.makeConn();
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@S.SHOP_ID", c.ShopId);
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
                string sql = selectData;
                dt = Query(sql);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public bool Insert(Product p)
        {

            bool isSuccess = false;
            MySqlConnection conn = db.makeConn();
            try
            {
                conn.Open();
                //ID as Id,NAME as Name,ISBN_CODE as ISBN,PRICE as Price,TEX as Tex,STOCK as Stock,DTO as DTO,STATUS as Status
                string sql = "insert into PRODUCTES (NAME, ISBN_CODE, PRICE, TEX, DTO, STOCK, STATUS, FAMI_ID) Values (@NAME, @ISBN_CODE, @PRICE, @TEX, @DTO, @STOCK, @STATUS, @FAMI_ID)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NAME", p.Name);
                cmd.Parameters.AddWithValue("@ISBN_CODE", p.ISBN);
                cmd.Parameters.AddWithValue("@PRICE", p.Price);
                cmd.Parameters.AddWithValue("@TEX", p.Tex);
                cmd.Parameters.AddWithValue("@DTO", p.Dto);
                cmd.Parameters.AddWithValue("@STOCK", p.Stock);
                cmd.Parameters.AddWithValue("@STATUS", p.Status);
                cmd.Parameters.AddWithValue("@FAMI_ID", p.FamiID);
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
        public bool Update(Product p)
        {
            bool isSuccess = false;
            MySqlConnection conn = db.makeConn();
            try
            {
                conn.Open();
                //NAME, ISBN_CODE, PRICE, TEX, DTO, STOCK, STATUS, FAMI_ID
                string sqlShop = "UPDATE PRODUCTES SET NAME=@NAME, ISBN_CODE=@ISBN_CODE, PRICE=@PRICE, TEX=@TEX, DTO=@DTO, STOCK=@STOCK, STATUS=@STATUS, FAMI_ID=@FAMI_ID WHERE ID=@ID";
                MySqlCommand cmd = new MySqlCommand(sqlShop, conn);
                cmd.Parameters.AddWithValue("@NAME", p.Name);
                cmd.Parameters.AddWithValue("@ISBN_CODE", p.ISBN);
                cmd.Parameters.AddWithValue("@PRICE", p.Price);
                cmd.Parameters.AddWithValue("@TEX", p.Tex);
                cmd.Parameters.AddWithValue("@DTO", p.Dto);
                cmd.Parameters.AddWithValue("@STOCK", p.Stock);
                cmd.Parameters.AddWithValue("@STATUS", p.Status);
                cmd.Parameters.AddWithValue("@FAMI_ID", p.FamiID);
                cmd.Parameters.AddWithValue("@ID", p.Id);
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
        public DataTable Search(Product p)
        {
            DataTable dt = new DataTable();
            string search = "";
            //NAME, ISBN_CODE, PRICE, TEX, DTO, STOCK, STATUS, FAMI_ID
            if (p.Name != "")
            {
                search += " AND P.NAME like '%" + p.Name + "%'";
            }
            if (p.ISBN != "")
            {
                search += " AND P.ISBN_CODE like '%" + p.ISBN + "%'";
            }
            if (p.Price > 0)
            {
                search += " AND P.PRICE like '%" + p.Price + "%'";
            }
            if (p.Tex > 0)
            {
                search += " AND P.TEX like '%" + p.Tex + "%'";
            }
            if (p.Stock > 0)
            {
                search += " AND P.STOCK like '%" + p.Stock + "%'";
            }
            if (p.Status !="")
            {
                search += " AND P.STATUS like '%" + p.Status + "%'";
            }
            if (p.FamiID > 0)
            {
                search += " AND P.FAMI_ID like '%" + p.FamiID + "%'";
            }
            try
            {
                if (search != "")
                {

                    string sql = selectData;
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
        //string label, string keyword, string orderby
        public DataTable Search(string label, string keyword, string orderby)
        {
            DataTable dt = new DataTable();
            string search = "";
            if (label != "" && keyword != "")
            {
                if (label == "P.FAMI_ID") { 
                    search += " AND C.Name like '%" + keyword + "%'";
                }
                else
                {
                    search += " AND " + label + " like '%" + keyword + "%'";
                }
            }
            if (label != "" && orderby != "")
            {
                search += " ORDER BY " + label + " " + orderby;
            }
            ////NAME, ISBN_CODE, PRICE, TEX, DTO, STOCK, STATUS, FAMI_ID
            
            if (label == "" && keyword != "")
            {
                search += " AND (P.NAME like '%" + keyword + "%'";
                search += " OR P.ISBN_CODE like '%" + keyword + "%'";
                search += " OR P.PRICE like '%" + keyword + "%'";
                search += " OR P.TEX like '%" + keyword + "%'";
                search += " OR P.DTO like '%" + keyword + "%'";
                search += " OR P.STOCK like '%" + keyword + "%'";
                search += " OR P.STATUS like '%" + keyword + "%'";
                search += " OR C.NAME like '%" + keyword + "%')";
            }
            try
            {
                if (search != "")
                {

                    string sql = selectData;
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
