namespace Composite
{
    public abstract class Empresa
    {
        protected static double costeUnitarioVehiculo = 5.0;
        protected int nVehiculos;
        public void AgregaVehiculo() => nVehiculos++;
        public abstract double CalculaCosteMantenimiento();
        public abstract bool AgregaFilial(Empresa filial);
    }
}
