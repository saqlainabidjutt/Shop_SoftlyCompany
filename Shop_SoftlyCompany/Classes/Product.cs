using Shop_TPV.DB;
using System.Data;


namespace Shop_TPV.Classes
{
    class Product
    {
        private DBProduct prodDB = new DBProduct();
        public Product()
        {
            this.Tex = 0;
            this.Price = 0;
            this.Stock = 0;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public float Price { get; set; }
        public float Dto { get; set; }
        public float Tex { get; set; }
        public int Stock { get; set; }
        public string Status { get; set; }
        public int FamiID { get; set; }
        public DataTable Select()
        {
            return prodDB.Select();
        }
        public bool Insert(Product c)
        {
            return prodDB.Insert(c);
        }
        public bool Update(Product c)
        {
            return prodDB.Update(c);
        }
        public DataTable Search(Product c)
        {
            return prodDB.Search(c);
        }
        public DataTable Search(string label, string keyword, string orderby)
        {
            return prodDB.Search(label, keyword, orderby);
        }

    }
}
