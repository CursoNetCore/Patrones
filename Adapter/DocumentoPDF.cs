using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class DocumentoPDF : IDocumento
    {
        protected ComponentePDF pdfTool = new ComponentePDF();

        public string Contenido { set { pdfTool.PdfFijaContenido(value); } }

        public void Dibuja()
        {
            pdfTool.PdfPrerarVisualizacion();
            pdfTool.PdfRefresca();
            pdfTool.PdfFinalizaVisualizacion();
        }

        public void Imprime()
        {
            pdfTool.PdfEnviarImpresora();
        }
    }
}
