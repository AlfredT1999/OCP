namespace OCPLibrary
{
    public class Cuentas
    {
        public ModeloEmpleado Crear(ModeloPersona persona)
        {
            ModeloEmpleado resultado = new ModeloEmpleado();

            resultado.Nombre = persona.Nombre;
            resultado.Apellido = persona.Apellido;
            resultado.DireccionEmail = $"{persona.Nombre.Substring(0, 1)}{persona.Apellido}@acme.com";

            return resultado;
        }
    }
}
