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

            // Lo siguiente viola la regla OCP:
            if(persona.TipoDeEmpleado == TipoEmpleado.Manager)
            {
                resultado.EsManager = true;
            }

            return resultado;
        }
    }
}
