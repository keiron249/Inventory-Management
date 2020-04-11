using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    public class Item
    {
        private int itemID;
        private string itemDescription;
        private int quantityStored;
        private int supplierID;
        private bool material;
        private string location;
        private float unitValue;

        public int ItemID { get => itemID; set => itemID = value; }
        public string ItemDescription { get => itemDescription; set => itemDescription = value; }
        public int QuantityStored { get => quantityStored; set => quantityStored = value; }
        public int SupplierID { get => supplierID; set => supplierID = value; }
        public bool Material { get => material; set => material = value; }
        public string Location { get => location; set => location = value; }
        public float UnitValue { get => unitValue; set => unitValue = value; }

    }
}
