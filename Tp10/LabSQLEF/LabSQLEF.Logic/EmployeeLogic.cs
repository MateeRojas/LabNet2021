using LabSQLEF.Data;
using LabSQLEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSQLEF.Logic
{
    public class EmployeeLogic : BaseLogic, ILogic<Employees, int>
    {

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Add(Employees newEmployee)
        {
            context.Employees.Add(newEmployee);
            context.SaveChanges();
        }

        public void Update(Employees emp)
        {
            var toUpdate = context.Employees.Find(emp.EmployeeID);
            if (toUpdate == null)
            {
                throw new Exception();
            }
            toUpdate.City = emp.City;
                toUpdate.Address = emp.Address;
                toUpdate.Country = emp.Country;
                toUpdate.HomePhone = emp.HomePhone;
                toUpdate.Region = emp.Region;
                context.SaveChanges();
        }

        public Employees Find(int id)
        {
            return context.Employees.Find(id);
        }

        public void Delete(int id)
        {
            var toDelete = context.Employees.Find(id);
            if(toDelete == null)
            {
                throw new Exception();
            }
            context.Employees.Remove(toDelete);
            context.SaveChanges();
        }
    }
}
