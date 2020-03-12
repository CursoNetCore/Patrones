using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDocumento html = new DocumentoHTML();
            IDocumento pdf = new DocumentoPDF();

            string contenido = "hello world";

            pdf.Contenido = html.Contenido = contenido;

            html.Dibuja();
            html.Imprime();

            pdf.Dibuja();
            pdf.Imprime();

        }
    }
}
