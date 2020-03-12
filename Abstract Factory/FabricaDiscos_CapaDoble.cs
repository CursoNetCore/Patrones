namespace Abstract_Factory
{
    public class FabricaDiscos_CapaDoble : IFabricaDisco
    {
        public BlueRay CrearBluRay()
        {
            return new BlueRay_CapaDoble();
        }

        public DVD CrearDVD()
        {
            return new DVD_CapaDoble();
        }
    }
}
