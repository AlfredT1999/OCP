using System;
using System.Collections.Generic;

namespace OCPLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IModeloAplicante> aplicantes = new List<IModeloAplicante>
            {
                new ModeloPersona { Nombre = "Jose", Apellido = "Tapia"},
                new ModeloManager { Nombre = "Luis", Apellido = "Hernandez"},
                new ModeloDirector { Nombre = "Joe", Apellido = "Lara"}
            };

            List<ModeloEmpleado> empleados = new List<ModeloEmpleado>();

            foreach (var persona in aplicantes)
            {
                empleados.Add(persona.ProcesoCuenta.Crear(persona));
            }

            foreach (var emp in empleados)
            {
                Console.WriteLine($"{emp.Nombre} {emp.Apellido}: {emp.DireccionEmail}," +
                    $" es manager: {emp.EsManager}, es director: {emp.EsDirector}");
            }

            Console.ReadLine();
        }
    }
}



