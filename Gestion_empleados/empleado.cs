using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace GestionEmpleados
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public bool Activo { get; internal set; }

        public Empleado(string nombre, string apellido, int edad, decimal salario, string cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Salario = salario;
            Cargo = cargo;
            Activo = true; // Todos los empleados están activos por defecto
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Cargo} - ${Salario}";
        }
    }

    public class Administrativo : Empleado
    {
        public Administrativo(string nombre, string apellido, int edad, decimal salario)
            : base(nombre, apellido, edad, salario, "Administrativo") { }
    }

    public class Tecnico : Empleado
    {
        public Tecnico(string nombre, string apellido, int edad, decimal salario)
            : base(nombre, apellido, edad, salario, "Técnico") { }
    }

    public class Empresa
    {
        public BindingList<Empleado> Empleados { get; set; }

        public Empresa()
        {
            Empleados = new BindingList<Empleado>();
        }

        public void RegistrarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
        }

        public void eliminarEmpleado(Empleado empleado)
        {
            if (empleado != null)
            {
                empleado.Activo = false; // Eliminación lógica
                Empleados.Remove(empleado);
            }
        }

        internal void eliminarEmpleado(int selectedIndex)
        {
            if (selectedIndex >= 0 && selectedIndex < Empleados.Count)
            {
                Empleados[selectedIndex].Activo = false; // logical deletion
                Empleados.RemoveAt(selectedIndex); // Physical removal
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(selectedIndex), "Index out of range");
            }
        }
    }
}