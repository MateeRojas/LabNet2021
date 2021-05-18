using LabSQLEF.Data;
using LabSQLEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSQLEF.Logic
{
    public class ProductLogic : BaseLogic, ILogic<Products, int>
    {
        public void Add(Products newItem)
        {
            context.Products.Add(newItem);
            context.SaveChanges();
        }

        public List<Products> GetAll()
        {
            
            return context.Products.ToList();
        }

        public void Update(Products prod)
        {
            var toUpdate = context.Products.Find(prod.ProductID);
                toUpdate.UnitPrice = prod.UnitPrice;
                context.SaveChanges();
        }      

        public Products Find(int id)
        {
            return context.Products.Find(id);
        }

        public void Delete(int id)
        {
            var toDelete = context.Products.Find(id);
            context.Products.Remove(toDelete);
            context.SaveChanges();
        }
    }
}
