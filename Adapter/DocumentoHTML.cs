using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class DocumentoHTML : IDocumento
    {
        public string Contenido { set; private get; }

        public void Dibuja() => Console.WriteLine("Dibuja contenido html "+Contenido);

        public void Imprime() => Console.WriteLine("Imprime contenido html " + Contenido);
    }
}
