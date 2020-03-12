using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new MilkDecorator(new ChocolateDecorator(new Espresso()));
            Console.WriteLine(coffee.Description);
        }
    }
}
