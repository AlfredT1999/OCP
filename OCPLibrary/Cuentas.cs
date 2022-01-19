namespace OCPLibrary
{
    public class Cuentas : ICuentas
    {
        public ModeloEmpleado Crear(IModeloAplicante persona)
        {
            ModeloEmpleado resultado = new ModeloEmpleado();

            resultado.Nombre = persona.Nombre;
            resultado.Apellido = persona.Apellido;
            resultado.DireccionEmail = $"{persona.Nombre.Substring(0, 1)}{persona.Apellido}@acme.com";

            return resultado;
        }
    }
}
