using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            FormMatriculacion formES = new FormMatriculacionES(new FormHtmlImpl());
            formES.Visualiza();
            if (formES.AdministrarZona())
                formES.GenerarDocumento();
            FormMatriculacion formPR = new FormMatriculacionPR(new FormAppletImpl());
            formPR.Visualiza();
            if (formPR.AdministrarZona())
                formPR.GenerarDocumento();
            Console.ReadLine();

        }
    }
}
