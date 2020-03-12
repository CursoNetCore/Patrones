using System;
using System.Text;

namespace Prototype
{
    public class Carroceria : ICloneable
    {
        public bool HabitaculoReforzado { get; set; }
        public string Material { get; set; }
        public string TipoCarroceria { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            b.Append("Material: ").Append(Material).Append(Environment.NewLine)
                .Append("Tipo Carroceria: ").Append(TipoCarroceria).Append(Environment.NewLine)
                .Append("habitaculo: ").Append(HabitaculoReforzado ? "Reforzado" : "No Reforzado").Append(Environment.NewLine);
            return b.ToString();
        }
    }
}