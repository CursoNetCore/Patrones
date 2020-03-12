using System;
using System.Text;

namespace Prototype
{
    public class Vehiculo : ICloneable
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Rueda TipoRueda { get; set; }
        public Carroceria TipoCarroceria { get; set; }

        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            b.Append("Marca: ").Append(Marca).Append(Environment.NewLine);
            b.Append("Modelo: ").Append(Modelo).Append(Environment.NewLine);
            b.Append("Color: ").Append(Color).Append(Environment.NewLine);
            b.Append("Reuda: ").Append(TipoRueda).Append(Environment.NewLine);
            b.Append("Carroceria: ").Append(TipoCarroceria).Append(Environment.NewLine);
            return b.ToString();
        }

        public object Clone()
        {
            Vehiculo v = new Vehiculo
            {
                Marca = this.Marca,
                Modelo = this.Modelo,
                Color = this.Color,

                TipoRueda = TipoRueda.Clone() as Rueda,
                TipoCarroceria = TipoCarroceria.Clone() as Carroceria
            };


            return v;
        }
    }
}
