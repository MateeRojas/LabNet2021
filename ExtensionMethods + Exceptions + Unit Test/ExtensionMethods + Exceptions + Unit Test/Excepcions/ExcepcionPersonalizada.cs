﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods___Exceptions___Unit_Test.Excepcions
{
    public class ExcepcionPersonalizada : Exception
    {
        public ExcepcionPersonalizada() : base("Error personalizado (todo era personalizado viste)")
        {

        }
    }
}