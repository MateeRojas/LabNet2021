using LabSQLEF.Entities;
using LabSQLEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSQLEF
{
    class Program
    {
        static void Insert()
        {
            try
            {
               ProductLogic prod = new ProductLogic();
               Console.WriteLine();
               Console.WriteLine("Inserte nombre del producto");
               string name = Console.ReadLine();
                Console.WriteLine("Inserte el precio del pruducto");
                string priceString = Console.ReadLine();
                int price = Convert.ToInt32(priceString);
                prod.Add(new Products
               {
                   ProductName = name,
                   UnitPrice = price,
               });
               showProducts(prod.GetAll());
               Console.WriteLine();
            }
            catch(Exception ex)
            {
            Console.WriteLine($"Se detectó {ex.Message}");
            }
        }
        static void Update()
        {
            try
            { 
                ProductLogic prod = new ProductLogic();
                Console.WriteLine();
                Console.WriteLine("Inserte Id del producto a actualizar");
                string idString = Console.ReadLine();
                int id = Convert.ToInt32(idString);
                Console.WriteLine();
                Console.WriteLine("Inserte el nuevo precio del producto");
                string priceString = Console.ReadLine();
                int price = Convert.ToInt32(priceString);
                prod.Update(new Products
                {
                    ProductID = id,
                    UnitPrice = price
                });
                showProducts(prod.GetAll());
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Se detectó {ex.Message}");
            }

        }

        static void Delete()
        {
            try
            {
                ProductLogic prod = new ProductLogic();
                Console.WriteLine();
                Console.WriteLine("Inserte Id del producto a borrar");
                string idString = Console.ReadLine();
                int id = Convert.ToInt32(idString);
                prod.Delete(id);
                showProducts(prod.GetAll());
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Se detectó: {ex.Message}");
            }
        }

        static void showProducts(List<Products> list) {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.ProductID} {item.ProductName} ${item.UnitPrice}");
            }
        }

        static void Main(string[] args)
        {

            //4)
            Console.WriteLine("Punto 4, muestro la info de productos y empleados");
            Console.WriteLine();
            ProductLogic productLogic = new ProductLogic();
            EmployeeLogic employeeLogic = new EmployeeLogic();
            try
            {
                Console.WriteLine("Productos:");
               
                showProducts(productLogic.GetAll());
       

                Console.WriteLine();

                Console.WriteLine("Empleados:");
                foreach (Employees item in employeeLogic.GetAll())
                {
                    Console.WriteLine($"{item.EmployeeID} {item.FirstName} {item.LastName}");
                }

                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Se detectó {ex.Message}");
            }
            
            //5)
            Console.WriteLine("Punto 5, Hacer un insert, update y delete");
            Console.WriteLine();
            Console.WriteLine("Productos:");
            char choise = 'I';
            while (choise != 'Q')
            {
                Console.WriteLine("Inserte *I* si desea insertar producto, *U* si desea actualizar un producto, *D* si desea borrar un territoriproducto o *Q* si desea salir del programa");
                Console.WriteLine();
                choise = Console.ReadKey().KeyChar;

                switch (choise)
                {
                    case 'I':
                        Insert();
                        break;
                    case 'U':
                        Update();
                        break;
                    case 'D':
                        Delete();
                        break;
                    default:
                        Console.WriteLine("Comando Invalido");
                        break;
                }
            }      
            Console.ReadLine();   
            
        }
    }
}
