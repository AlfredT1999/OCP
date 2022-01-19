namespace OCPLibrary
{
    public class CuentaDirector : ICuentas
    {
        public ModeloEmpleado Crear(IModeloAplicante persona)
        {
            ModeloEmpleado resultado = new ModeloEmpleado();

            resultado.Nombre = persona.Nombre;
            resultado.Apellido = persona.Apellido;
            resultado.DireccionEmail = $"{persona.Nombre}.{persona.Apellido}@acmecorp.com";
            resultado.EsManager = true;
            resultado.EsDirector = true;

            return resultado;
        }
    }
}
