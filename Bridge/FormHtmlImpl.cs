using System;

namespace Bridge
{
    public class FormHtmlImpl : IFormImpl
    {
        public string AdministrarZonaIndicada() => Console.ReadLine();
        public void DibujarTexto(string texto) => Console.WriteLine("HTML: " + texto);
    }
}
