using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aaa");
            Singleton s1 = Singleton.Instance;
            s1.Mensaje = "chau";
            Singleton s2 = Singleton.Instance;
            s2.Mensaje = "hola";
            Console.WriteLine(s1.Mensaje);
            Console.WriteLine(s2.Mensaje);
        }
    }
}
