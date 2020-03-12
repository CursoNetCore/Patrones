using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ComponentePDF
    {
        protected string contenido;
        internal void PdfEnviarImpresora() => Console.WriteLine("Impresion contenido PDF: " + contenido);
        internal void PdfFinalizaVisualizacion() => Console.WriteLine("Visualizar PDF: Fin");
        internal void PdfFijaContenido(string value) => this.contenido = value;
        internal void PdfPrerarVisualizacion() => Console.WriteLine("Visualizar PDF: Comienzo");
        internal void PdfRefresca() => Console.WriteLine("Visualiza contenido PDF: " + contenido);
    }
}
