using LinQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class DataShowUi
    {
        public void showCustomers(List<Customers> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.CustomerID} {item.ContactName}");
            }
        }
        public void showProducts(List<Products> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductID} {item.ProductName}");
            }
        }
        public void showNames(IQueryable<string> query)
        {
            foreach (var item in query)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
