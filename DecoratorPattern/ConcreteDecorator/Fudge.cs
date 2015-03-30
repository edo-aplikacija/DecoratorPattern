using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    class Fudge : Topping
    {
        public Fudge(IceCream iceCream)
            : base(iceCream)
        {

        }

        public override double Cost()
        {
            return 0.70 + IceCream.Cost();
        }
    }
}
