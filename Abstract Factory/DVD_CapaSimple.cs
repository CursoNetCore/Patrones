namespace Abstract_Factory
{
    internal class DVD_CapaSimple : DVD
    {
        public override string Capacidad => "4.7GB";

        public override string Tipo => "DVD Capa simple";

        public override decimal Precio => 5;
    }
}