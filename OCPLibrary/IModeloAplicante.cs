namespace OCPLibrary
{
    public interface IModeloAplicante
    {
        string Apellido { get; set; }
        string Nombre { get; set; }
        ICuentas ProcesoCuenta { get; set; }
    }
}