namespace Composite
{
    public class EmpresaSinFilial : Empresa
    {
        public override bool AgregaFilial(Empresa filial) => false;

        public override double CalculaCosteMantenimiento() => nVehiculos * costeUnitarioVehiculo;
    }
}
