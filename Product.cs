using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Product
    {
        public string Name;
        public string Category;
        public int Id;

        public Product(string name, string category, int id)
        {
            Name = name;
            Category = category;
            Id = id;
        }
    }
}
