using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v = new Vehiculo();

            v.Marca = "Peugeot";
            v.Modelo = "306";
            v.Color = "Negro";

            v.TipoCarroceria = new Carroceria();
            v.TipoCarroceria.Material = "Acero";
            v.TipoCarroceria.HabitaculoReforzado = true;
            v.TipoCarroceria.TipoCarroceria = "Monovolumen";

            v.TipoRueda = new Rueda();
            v.TipoRueda.Neumatico = "Bridgestone";
            v.TipoRueda.Llanta = "Aluminio";
            v.TipoRueda.Diametro = 17;

            Vehiculo v2 = v.Clone() as Vehiculo;

            Console.WriteLine(v);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(v2);
            Console.WriteLine("--------------------------------------");
            v2.Marca = "Ford";
            v.TipoRueda.Neumatico = "Micheline";
            Console.WriteLine(v);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(v2);
            Console.ReadLine();
        }
    }
}
