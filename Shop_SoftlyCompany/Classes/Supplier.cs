using Shop_TPV.Classes;
using Shop_TPV.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_TPV.Classes
{
    class Supplier
    {
        public Supplier()
        {
            this.Role = UserStatus.Supplier.ToString();
            this.ShopId = (int)ShopIdValue.ShopId;
        }
        private DBSuppliers suppDB = new DBSuppliers();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public string UserIdentity { get; set; }
        public string Gender { get; set; }
        public int ShopId { get; set; }
        public int AddrId { get; set; }
        public bool Insert(Supplier s)
        {
            return suppDB.Insert(s);
        }
        public bool Update(Supplier s)
        {
            return suppDB.Update(s);
        }
        public DataTable Select()
        {
            return suppDB.Select();
        }
        public DataTable Search(Supplier s, Address a)
        {
            return suppDB.Search(s, a);
        }
        public DataTable Search(string label, string keyword, string orderby)
        {
            return suppDB.Search(label, keyword, orderby);
        }
    }
}
