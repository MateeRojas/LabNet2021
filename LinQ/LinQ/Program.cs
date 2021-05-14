using LinQ.Data;
using LinQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinQ
{
    
    class Program
    {
        static void Main(string[] args)
        {
            DataShowUi showData = new DataShowUi();
            var db = new NorthWindContext();
            //db.Database.Log = Console.WriteLine;
            //Comentado para la legibilidad del resultado

            //1. Query para devolver objeto customer
            Console.WriteLine("Objeto customer");
            var customer = db.Customers.First();
            Console.WriteLine($"{customer.CustomerID} {customer.ContactName}");
            Console.WriteLine();

            //2. Query para devolver todos los productos sin stock
            Console.WriteLine($"Todos los productos sin stock");
            var sinStock = db.Products.Where(p => p.UnitsInStock == 0);
            showData.showProducts(sinStock.ToList());
            Console.WriteLine();

            //3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 unidad
            Console.WriteLine($"Todos los productos que tienen stock y que cuestan más de 3 unidad");
            var stock = db.Products.Where(p => p.UnitsInStock == 0 & p.UnitPrice > 3);
            showData.showProducts(stock.ToList());
            Console.WriteLine();

            //4. Query para devolver todos los customers de Washington
            Console.WriteLine($"Todos los customers de Washington");
            var customerWa = from cus in db.Customers
                         where cus.Region == "WA"
                         select cus;
            showData.showCustomers(customerWa.ToList());
            Console.WriteLine();

            //5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID producto sea igual a 789
            Console.WriteLine();
            var prodId = db.Products.Where(p => p.ProductID == 789).Any();
            if (!prodId)
            {
                Console.WriteLine("Se ha devuelto NULL");
                
            }
            Console.WriteLine();

            //6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.
            Console.WriteLine("Customers en Mayúscula");
            var mayus = from cus in db.Customers                   
                         select cus.ContactName.ToUpper();
            showData.showNames(mayus);
            Console.WriteLine();

            Console.WriteLine("Customers en Minúscula");
            var minus = from cus in db.Customers                   
                         select cus.ContactName.ToLower();
            showData.showNames(minus);
            Console.WriteLine();

            //7. Query para devolver Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1 / 1 / 1997.
            Console.WriteLine("Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1 / 1 / 1997.");
            DateTime DT = new DateTime(1977, 01, 01, 0, 0, 0);
            var cusDate = from cus in db.Customers
                      join ord in db.Orders on cus.CustomerID  equals ord.CustomerID
                      where ord.OrderDate > DT
                      select new { cus.CustomerID, cus.ContactName, ord.OrderID};
            foreach (var item in cusDate)
            {
                Console.WriteLine($"{item.CustomerID} {item.ContactName} {item.OrderID}");
            }
            Console.WriteLine();

            //8. Query para devolver los primeros 3 Customers de Washington
            Console.WriteLine("Primeros 3 Customers de Washington");
            var customersWa3 = db.Customers.Where(c => c.Region == "WA").Take(3);
            showData.showCustomers(customersWa3.ToList());
            Console.WriteLine();

            //9. Query para devolver lista de productos ordenados por nombre
            Console.WriteLine("Lista de productos ordenados por nombre");
            var prodName = db.Products.OrderBy(p => p.ProductName).ToList();
            showData.showProducts(prodName);
            Console.WriteLine();

            //10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.
            Console.WriteLine("Lista de productos ordenados por unit in stock de mayor a menor.");
            var prodUnit = db.Products.OrderByDescending(p => p.UnitsInStock).ToList();
            showData.showProducts(prodUnit);
            Console.WriteLine();

            //11. Query para devolver las distintas categorías asociadas a los productos
            Console.WriteLine("Las distintas categorías asociadas a los productos");
            var prodCat = from prod in db.Products 
                         from cat in db.Categories
                         where( prod.CategoryID == cat.CategoryID)
                         select new { prod.ProductName, cat.CategoryName };
            foreach (var item in prodCat)
            {
                Console.WriteLine($"{item.CategoryName} {item.ProductName}");
            }
            Console.WriteLine();

            //12. Query para devolver el primer elemento de una lista de productos
            Console.WriteLine("Primer elemento de una lista de productos");
            var firstProduct = db.Products.ToList().FirstOrDefault();
            Console.WriteLine(firstProduct.ProductName);
            Console.WriteLine();

            //13. Query para devolver los customer con la cantidad de ordenes asociadas
            Console.WriteLine("Los customer con la cantidad de ordenes asociadas");
            var auxilliar = from order in db.Orders
                          group order by order.CustomerID into grouped
                          select new { CustomerId = grouped.Key, Count = grouped.Count()};
            var customerOrder = from aux in auxilliar
                          join cust in db.Customers on aux.CustomerId equals cust.CustomerID
                          select new { Customer = cust.ContactName, Count = aux.Count };
            foreach (var item in customerOrder)
            {
                Console.WriteLine($"{item.Customer} {item.Count}");
            }
            Console.WriteLine();
          
            Console.ReadLine();
        }

        
    }
}
