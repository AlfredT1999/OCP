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

            //// Lo siguiente viola la regla OCP:
            //if(persona.TipoDeEmpleado == TipoEmpleado.Manager)
            //{
            //    resultado.EsManager = true;
            //}
            switch (persona.TipoDeEmpleado)
            {
                case TipoEmpleado.General:
                    break;
                case TipoEmpleado.Manager:
                    resultado.EsManager = true;
                    break;
                case TipoEmpleado.Director:
                    resultado.EsManager = true;
                    resultado.EsDirector = true;
                    break;
                default:
                    break;
            }

            return resultado;
        }
    }
}
