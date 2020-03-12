using System;

namespace Builder
{
    public sealed class HTML : Doc
    {
        public override void AgregaDocumento(string documento)
        {
            if (!Valid(documento))
                throw new Exception("Formato invalido para html");
            contenido.Add(documento);
        }

        public override void Imprime() => contenido.ForEach(a => Console.WriteLine(a));
        private static bool Valid(string documento) => documento.StartsWith("<HTML>");
    }
}
