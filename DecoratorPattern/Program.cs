using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCream IceCream = new Chocolate();

            IceCream = new Sprinkle(IceCream);
            IceCream = new Fudge(IceCream);

            Console.WriteLine(IceCream.Cost());

            Console.ReadKey();
        }
    }
}
