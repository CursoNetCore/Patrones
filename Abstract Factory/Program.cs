using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabricaDisco fabrica = new FabricaDiscos_CapaDoble();
            
            Disco b = fabrica.CrearBluRay();
            Console.WriteLine(b);
            Disco d = fabrica.CrearDVD();
            Console.WriteLine(d);

            fabrica = new FabricaDiscos_CapaSimple();

            b = fabrica.CrearBluRay();
            Console.WriteLine(b);
            d = fabrica.CrearDVD();
            Console.WriteLine(d);
        }
    }
}
