using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
		{
			#region Assignment
                //1.publisher subscriber for a company, Products and suppliers.
                //2.Products: ID, Name.
                //3.Company: ID, Name, Dictionary<Product, Quantity>.
                //4.Suppliers: ID, Name.
                //5.The company dictionary is private and you need to implement Paying element to it 
                //6.If the element already exists add to its quantity.
                //7.If the element is new jut add it.
                //8.You should implement Sell function that decrease the amount, BUT if the amount is less than 5 you should notify that supplier.

		#endregion

		    #region Lab
			Company company = new Company();
                Product product = new Product(1, "OPOO");
                Product product2 = new Product(2, "Samsung");
                Suppliers suppliers = new Suppliers(company);

                company.Paying(product, 10);
                company.Sell(product, 6);
                Console.WriteLine("============================================");
                company.Sell(product2, 6); 
            #endregion
        }
    }
}