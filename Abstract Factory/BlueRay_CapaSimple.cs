namespace Abstract_Factory
{
    internal class BlueRay_CapaSimple : BlueRay
    {
        public override string Capacidad => "20GB";

        public override string Tipo => nameof(BlueRay_CapaSimple);

        public override decimal Precio => 50;
    }
}