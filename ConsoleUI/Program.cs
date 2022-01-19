using System;
using System.Collections.Generic;

namespace OCPLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ModeloPersona> aplicantes = new List<ModeloPersona>
            {
                new ModeloPersona { Nombre = "Jose", Apellido = "Tapia", TipoDeEmpleado = TipoEmpleado.Manager},
                new ModeloPersona { Nombre = "Luis", Apellido = "Hernandez"},
                new ModeloPersona { Nombre = "Joe", Apellido = "Lara"}
            };

            List<ModeloEmpleado> empleados = new List<ModeloEmpleado>();

            Cuentas procesoCuenta = new Cuentas();

            foreach (var persona in aplicantes)
            {
                empleados.Add(procesoCuenta.Crear(persona));
            }

            foreach (var emp in empleados)
            {
                Console.WriteLine($"{emp.Nombre} {emp.Apellido}: {emp.DireccionEmail}," +
                    $" is manager: {emp.EsManager}, es director: {emp.EsDirector}");
            }

            Console.ReadLine();
        }
    }
}



