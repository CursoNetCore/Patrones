namespace Builder
{
    public sealed class DocHtmlBuilder : DocBuilder
    {
        private const string ETIQUETA = "HTML";

        public DocHtmlBuilder()
        {
            documentacion = new HTML();
        }
        public override void GetSolicitudMatricula(string client)
        {
            string documento = string.Format("<{0}>Matricula de: {1}<{0}>", ETIQUETA, client);
            documentacion.AgregaDocumento(documento);
        }
        public override void GetSolicitudPedido(string client)
        {
            string documento = string.Format("<{0}>Pedido de: {1}<{0}>", ETIQUETA, client);
            documentacion.AgregaDocumento(documento);
        }
    }
}
