using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Classes
{
    public class Supplier
    {
        int supplierID;
        string name, phone, website;

        public int SupplierID { get => supplierID; set => supplierID = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Website { get => website; set => website = value; }
    }
}
