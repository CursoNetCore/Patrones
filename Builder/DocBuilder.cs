namespace Builder
{
    public abstract class DocBuilder
    {
        protected Doc documentacion;
        public abstract void GetSolicitudPedido(string client);
        public abstract void GetSolicitudMatricula(string client);
        public Doc Resultado => documentacion;
    }
}
