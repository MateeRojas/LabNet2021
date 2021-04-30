using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSQLEF.Logic
{
    interface ILogic<T,H>
    {
        List<T> GetAll();
        void Add(T newItem);
        void Update(T newItem);
        void Delete(H id);
    }
}
