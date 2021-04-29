using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork1
{
    public class Shop
    {
        public List<Item> items = new List<Item>();
        public void Add(Item item)
        {
            if (item == null)
            {
                return;
            }
            items.Add(item);
        }
    }
}
