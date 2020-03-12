using System;
using System.Text;

namespace Prototype
{
    public class Rueda : ICloneable
    {
        public int Diametro { get; set; }
        public string Llanta { get; set; }
        public string Neumatico { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            b.Append("Diametro: ").Append(Diametro).Append(Environment.NewLine)
                .Append("Llanta: ").Append(Llanta).Append(Environment.NewLine)
                .Append("Neumatico: ").Append(Neumatico).Append(Environment.NewLine);
            return b.ToString();
        }
    }
}