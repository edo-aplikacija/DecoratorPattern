﻿using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    class Vanilla : IceCream
    {
        public override double Cost()
        {
            return 1;
        }
    }
}
