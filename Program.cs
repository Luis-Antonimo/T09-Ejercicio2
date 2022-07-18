using System;

namespace T09Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.ImprimeDatos();
            empleado1.MayorEdad();
        }

        class Empleado
        {
            private int sueldo;
            private string nombre;
            private int limite;

            public Empleado()
            {
                limite = 3000;
                Console.WriteLine("Escriba el nombre del empleado:");
                nombre = Console.ReadLine();
                Console.WriteLine("Escriba el sueldo del empleado:");
                sueldo = Convert.ToInt32(Console.ReadLine());

            }

            public void ImprimeDatos()
            {
                Console.WriteLine("El empleado " + nombre + " tiene un sueldo de " + sueldo + "€.");
            }

            public void MayorEdad()
            {
                if (sueldo > limite)
                {
                    Console.WriteLine("El empleado " + nombre + " debe pagar impuestos.");
                }
                else
                {
                    Console.WriteLine("El empleado " + nombre + " no debe pagar impuestos.");
                }
            }
        }
    }
}