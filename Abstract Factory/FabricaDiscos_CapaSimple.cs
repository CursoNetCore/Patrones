namespace Abstract_Factory
{
    public class FabricaDiscos_CapaSimple : IFabricaDisco
    {
        public BlueRay CrearBluRay()
        {
            return new BlueRay_CapaSimple();
        }

        public DVD CrearDVD()
        {
            return new DVD_CapaSimple();
        }
    }
}
