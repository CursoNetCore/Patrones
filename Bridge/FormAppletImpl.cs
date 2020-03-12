using System;

namespace Bridge
{
    public class FormAppletImpl : IFormImpl
    {
        public string AdministrarZonaIndicada() => Console.ReadLine();
        public void DibujarTexto(string texto) => Console.WriteLine("APPLET: " + texto);
    }
}
