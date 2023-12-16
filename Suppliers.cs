using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Suppliers
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Suppliers(Company company)
        {
            company.ProductDelaged += Notify;
        }

        public void Notify(object Sender,Product product)
        {
            Console.WriteLine("The Product id {0} and {1} is less Than 5 ",product.Id,product.Name);
        }
    }
}
