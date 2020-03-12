using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director builder = new Director(new DocHtmlBuilder());
            Doc doc = builder.Construir("adrian");
            doc.Imprime();

            builder = new Director(new DocPdfBuilder());
            doc = builder.Construir("juan");
            doc.Imprime();
        }
    }
}
