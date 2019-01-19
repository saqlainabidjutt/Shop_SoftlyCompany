using Shop_TPV.DB;
using System.Data;

namespace Shop_TPV.Classes
{
    class Catelog
    {
       // private static readonly ResourceManager rm = new ResourceManager("Shop_TPV.Resources", Assembly.GetExecutingAssembly());
        private CatelogDB cateDB=new CatelogDB();
        public Catelog()
        {
            this.ShopId = this.ShopId = (int)ShopIdValue.ShopId;
            this.Dto = 0;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SubFam { get; set; }
        public float Dto { get; set; }
        public string Status { get; set; }
        public int ShopId { get; set; }

        public DataTable Select()
        {
            return cateDB.Select(ShopId);
        }
        public bool Insert(Catelog c)
        {
            return cateDB.Insert(c);
        }
        public bool Update(Catelog c)
        {
            return cateDB.Update(c);
        }
        public DataTable Search(Catelog c)
        {
            return cateDB.Search(c);
        }
        public DataTable Search(string label, string keyword, string orderby)
        {
            return cateDB.Search(label, keyword, orderby);
        }

    }
}
