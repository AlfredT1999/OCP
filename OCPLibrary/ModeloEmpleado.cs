namespace OCPLibrary
{
    public class ModeloEmpleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DireccionEmail { get; set; }
        public bool EsManager { get; set; } = false;
    }
}
