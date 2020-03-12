using System.Collections.Generic;

namespace Composite
{
    public sealed class EmpresaMadre : Empresa
    {
        readonly List<Empresa> filiales = new List<Empresa>();
        public override bool AgregaFilial(Empresa filial) 
        {
            filiales.Add(filial); 
            return true; 
        }
        public override double CalculaCosteMantenimiento()
        {
            double costo = 0;
            filiales.ForEach(filial => costo += filial.CalculaCosteMantenimiento()) ;
            return costo + nVehiculos * costeUnitarioVehiculo;
        }
    }
}
