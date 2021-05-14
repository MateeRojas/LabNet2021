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
        static void showTerritories(List<Territories> list) {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.TerritoryID} {item.TerritoryDescription}");
            }
        }
        static void Main(string[] args)
        {

            //4)
            Console.WriteLine("Punto 4, muestro la info de productos y empleados");
            Console.WriteLine();
            Console.WriteLine("Productos:");
            ProductLogic productLogic = new ProductLogic();
            foreach (Products item in productLogic.GetAll())
            {
                Console.WriteLine($"{item.ProductID} {item.ProductName}");  
            }

            Console.WriteLine();
            
            Console.WriteLine("Empleados:");
            EmployeeLogic employeeLogic = new EmployeeLogic();
            foreach (Employees item in employeeLogic.GetAll())
            {
                Console.WriteLine($"{item.EmployeeID} {item.FirstName} {item.LastName}");
            }

            Console.WriteLine();

            //5)
            Console.WriteLine("Punto 5, Hacer un insert, update y delete");
            Console.WriteLine();
            Console.WriteLine("Agrego el Territorio Lomas de Zamora y vemos si cambió:");
            
            TerritoryLogic ter = new TerritoryLogic();
            ter.Add(new Territories
            {
                TerritoryDescription = "Lomas de Zamora",
                TerritoryID = "85252",
                RegionID = 2
            });
            showTerritories(ter.GetAll());

            Console.WriteLine();
            Console.WriteLine("Ahora actualizo su descripcion y vemos si cambió:");

            ter.Update(new Territories
            {
                TerritoryDescription = "Lomas",
                TerritoryID = "85252",
                RegionID = 2
            });
            showTerritories(ter.GetAll());

            Console.WriteLine();
            Console.WriteLine("Por último la elimino y vemos si cambió:");

            ter.Delete("85252");
            showTerritories(ter.GetAll());

            Console.ReadLine();   
            
        }
    }
}
