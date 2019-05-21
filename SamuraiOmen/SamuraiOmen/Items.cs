using SamuraiOmen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiOmen
{
    class Items
    {
       
        public Item CreateItem(string name, int price)
        {
            Item item = new Item();

            item.Name = name;
            item.Price = price;
            return item;


        }
    }
}
