namespace Bridge
{
    public sealed class FormMatriculacionES : FormMatriculacion
    {
        public FormMatriculacionES(IFormImpl impl) : base(impl) { }

        protected override bool ControlZona(string matricula) => matricula.Length == 7;
    }
}
