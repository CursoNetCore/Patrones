namespace Builder
{
    public class Director
    {
        protected DocBuilder constructor;

        public Director(DocBuilder constructor) => this.constructor = constructor;

        public Doc Construir(string client) 
        {
            constructor.GetSolicitudPedido(client);
            constructor.GetSolicitudMatricula(client);
            return constructor.Resultado;
        }
    }
}
