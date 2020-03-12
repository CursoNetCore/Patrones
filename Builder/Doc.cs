using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class Doc
    {
        protected List<string> contenido = new List<string>();

        public abstract void AgregaDocumento(string documento);
        public abstract void Imprime();
    }
}
