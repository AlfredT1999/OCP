namespace OCPLibrary
{
    public class ModeloDirector : IModeloAplicante
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public ICuentas ProcesoCuenta { get; set; } = new CuentaDirector();
    }
}
