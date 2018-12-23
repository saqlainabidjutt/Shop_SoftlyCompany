using Shop_SoftlyCompany.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_SoftlyCompany.Classes
{
    class Address
    {
        private DBAddress addressDB = new DBAddress();
        public int Id { get; set; }
        public string telefone { get; set; }
        public string street { get; set; }
        public string buildingNo { get; set; }
        public string floor { get; set; }
        public string door { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string provenc { get; set; }
        public string country { get; set; }
        public long Insert(Address s)
        {
            return addressDB.Insert(s);
        }
        public bool Update(Address s)
        {
            return addressDB.Update(s);
        }
    }
}
