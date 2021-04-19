using ExtensionMethods___Exceptions___Unit_Test.Excepcions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods___Exceptions___Unit_Test.Extensions
{
    public static class LogicExtensions
    {
        public static void TirarExcepcion(this Logic logic)
        {
            var array = new int[6];
            int i = array[7];
        }

        public static void TirarExcepcionPersonalizada(this Logic logic)
        {
            throw new ExcepcionPersonalizada();
        }
    }
}
