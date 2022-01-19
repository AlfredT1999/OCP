namespace OCPLibrary
{
    public class ModeloManager : IModeloAplicante
    {
        public string Apellido { get ; set ; }
        public string Nombre { get ; set; }
        public ICuentas ProcesoCuenta { get; set; } = new CuentaManager();
    }
}
