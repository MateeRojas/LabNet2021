using LabSQLEF.Data;
using LabSQLEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSQLEF.Logic
{
    public class TerritoryLogic : BaseLogic, ILogic<Territories , string>
    {

        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }

        public void Add(Territories newTerritory)
        {
            context.Territories.Add(newTerritory);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var toDelete = context.Territories.Find(id);
            context.Territories.Remove(toDelete);
            context.SaveChanges();
        }

        public Territories Find(string id)
        {
            return context.Territories.Find(id);
        }

        public void Update(Territories ter)
        {
            var toUpdate = context.Territories.Find(ter.TerritoryID);
            toUpdate.TerritoryDescription = ter.TerritoryDescription;

            context.SaveChanges();
        }
    }
}
