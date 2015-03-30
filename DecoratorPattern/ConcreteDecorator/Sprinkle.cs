using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    class Sprinkle : Topping
    {
        public Sprinkle(IceCream iceCream)
            : base(iceCream)
        {

        }

        public override double Cost()
        {
            return 0.50 + IceCream.Cost();
        }
    }
}
