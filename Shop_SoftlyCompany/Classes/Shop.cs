using Shop_SoftlyCompany.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace Shop_SoftlyCompany.Classes
{
    class Shop
    {
        private DBShop shopDB = new DBShop();
        public int Id { get; set; }
        public string name { get; set; }
        public string identity { get; set; }
        public string status { get; set; }
        public string role { get; set; }
        public int addrId { get; set; }
        public bool Insert(Shop s)
        {
            return shopDB.Insert(s);
        }
        public bool Update(Shop s)
        {
            return shopDB.Update(s);
        }
        public DataTable Select()
        {
            return shopDB.Select();
        }
        public DataTable Search(Shop s,Address a)
        {
            return shopDB.Search(s,a);
        }
        public DataTable Search(string label, string keyword, string orderby)
        {
            return shopDB.Search(label, keyword, orderby);
        }
    }
}
