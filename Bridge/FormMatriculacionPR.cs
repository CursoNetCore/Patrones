namespace Bridge
{
    public class FormMatriculacionPR : FormMatriculacion
    {
        public FormMatriculacionPR(IFormImpl impl) : base(impl) { }

        protected override bool ControlZona(string matricula) => matricula.Length == 6;
    }
}
