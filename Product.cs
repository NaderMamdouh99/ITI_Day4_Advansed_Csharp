using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product(int _Id,string _Name)
        {
            Id = _Id;
            Name = _Name;
        }
    }
}
