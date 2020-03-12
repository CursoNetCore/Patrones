using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class CondimentDecorator : ICoffee
    {
        private ICoffee Coffee { get; set; }

        protected string _name = "undefined condiment";
        protected double _price = 0;

        protected CondimentDecorator(ICoffee coffe) => this.Coffee = coffe;
        public string Description => string.Format("{0}, {1}", Coffee.Description, _name);
        public double Cost => Coffee.Cost + _price;
    }

    public sealed class ChocolateDecorator : CondimentDecorator
    {
        public ChocolateDecorator(ICoffee coffe) : base(coffe)
        {
            _name = "chocolate";
            _price = 0.10;
        }
    }
    public sealed class MilkDecorator : CondimentDecorator
    {
        public MilkDecorator(ICoffee coffe) : base(coffe)
        {
            _name = "Leche";
            _price = 0.05;
        }
    }

}
