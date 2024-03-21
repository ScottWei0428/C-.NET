using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class InventoryItem
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } 

        public InventoryItem(int itemNumber, string description, decimal price)
        {
            this.ItemNo = itemNumber;
            this.Description = description;
            this.Price = price;
        }
        public InventoryItem()
        {

        }

    }
}
