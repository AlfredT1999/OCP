namespace OCPLibrary
{
    public class ModeloPersona : IModeloAplicante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public ICuentas ProcesoCuenta { get; set; } = new Cuentas();
    }
}
