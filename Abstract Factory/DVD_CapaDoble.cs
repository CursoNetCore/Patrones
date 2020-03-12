namespace Abstract_Factory
{
    internal class DVD_CapaDoble : DVD
    {
        public override string Capacidad => "9.4GB";

        public override string Tipo => "DVD Capa doble";

        public override decimal Precio => 10;
    }
}