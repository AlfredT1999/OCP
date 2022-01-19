namespace OCPLibrary
{
    public class ModeloPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoEmpleado TipoDeEmpleado { get; set; } = TipoEmpleado.General;
    }
}
