using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cl = new ClienteContado();
            cl.NuevoPedido(100);
            cl.NuevoPedido(1000);
            cl = new ClienteCredito();
            cl.NuevoPedido(2000);
            cl.NuevoPedido(3000);
        }
    }
}
