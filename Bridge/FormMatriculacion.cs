namespace Bridge
{
    public abstract class FormMatriculacion
    {
        protected string contenido;
        protected IFormImpl implementacion;

        public FormMatriculacion(IFormImpl implementacion) => this.implementacion = implementacion;

        public void Visualiza() => implementacion.DibujarTexto("numero de matricula existente: ");

        public void GenerarDocumento()
        {
            implementacion.DibujarTexto("solicitud de matriculacion");
            implementacion.DibujarTexto("numero matricula: "+contenido);
        }

        public bool AdministrarZona()
        {
            contenido = implementacion.AdministrarZonaIndicada();
            return ControlZona(contenido);
        }

        protected abstract bool ControlZona(string matricula);
        
    }
}
