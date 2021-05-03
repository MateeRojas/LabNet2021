using LinQ.Data;
using LinQ.Entities;
using LinQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.Logic
{
    public class DataShowingLogic
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
