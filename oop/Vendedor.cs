﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Vendedor : Empleado
    {
        public double ventas { get; set; }
        public override void setSueldo(double s)
        {
            Sueldo = s + (ventas*0.01);
        }
    }
}
