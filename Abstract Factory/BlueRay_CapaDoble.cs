namespace Abstract_Factory
{
    internal class BlueRay_CapaDoble : BlueRay
    {
        public override string Capacidad => "40GB";

        public override string Tipo => nameof(BlueRay_CapaDoble);

        public override decimal Precio => 100;
    }
}