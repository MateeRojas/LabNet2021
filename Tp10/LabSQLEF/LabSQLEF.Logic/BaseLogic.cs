using LabSQLEF.Data;
using LabSQLEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSQLEF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthWindContext context;

        public BaseLogic()
        {
            context = new NorthWindContext();
        }
    }
}
