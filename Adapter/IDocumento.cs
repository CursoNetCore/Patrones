namespace Adapter
{
    interface IDocumento
    {
        string Contenido { set; }

        void Dibuja();
        void Imprime();
    }
}
