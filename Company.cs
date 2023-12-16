using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Dictionary<Product, int> Dict = new Dictionary<Product, int>();

        public event Action<object,Product> ProductDelaged; 




        public void Paying(Product p ,int Quantity)
        {
            foreach (var item in Dict)
            {
                if (item.Key.Id == p.Id)
                {
                    Dict[item.Key] += Quantity;
                }
            }
              Dict.Add(p, Quantity);
        }

        public void Sell(Product product,int Quantity)
        {
            foreach (var item in Dict)
            {
                if (item.Key.Id == product.Id)
                {
                    if (Quantity < Dict[item.Key])
                    {
                        Dict[item.Key] -= Quantity;
                        if (Dict[item.Key] < 5)
                        {
                            ProductDelaged(this, product);
                        }
                    }
                }

            }

        }
    }
}
