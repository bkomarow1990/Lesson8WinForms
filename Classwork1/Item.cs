using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork1
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, Author {Author}, Price: {Price}"; 
        }
        public Item(string name, string desc, string author, float price)
        {
            Name = name;
            Description = desc;
            Author = author;
            Price = price;
        }
    }
}
