namespace Abstract_Factory
{
    public abstract class Disco
    {
        public abstract string Capacidad { get; }
        public abstract string Tipo { get; }
        public abstract decimal Precio { get; }
        public override string ToString() => string.Format("{0} {1} {2}", Tipo, Capacidad, Precio);
    }
}
