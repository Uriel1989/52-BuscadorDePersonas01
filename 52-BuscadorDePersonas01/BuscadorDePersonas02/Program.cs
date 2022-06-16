using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscadorDePersonas02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, primero indique la cantidad de personas que va a ingresar y luego sus nombres y apellidos:");
            int CantidadDePersonas = Convert.ToInt32(Console.ReadLine());

            List<Persona> RegistroDePersonas = new List<Persona>();

            for (int i=0; i < CantidadDePersonas; i++)
            {
                Persona a1 = new Persona();

                Console.WriteLine("Ingrese el nombre de la persona:");
                a1.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido de la persona:");
                a1.Apellido = Console.ReadLine();

                Console.Clear();

                RegistroDePersonas.Add(a1);
            }

            Console.WriteLine("Escriba el nombre de la persona que desea buscar:");
            string NombreBuscado = Convert.ToString(Console.ReadLine());

            bool NoEncontrado = true;

            for ( int i=0; i < RegistroDePersonas.Count; i++)
            {
                Persona b1 = RegistroDePersonas[i];

                if (b1.Nombre == NombreBuscado)
                {
                    Console.WriteLine("Coincidencia: " + b1.Nombre + " en la posicion:" + i);
                    NoEncontrado = false;
                    
                }
               

            }
            
            if (NoEncontrado)
            {
                Console.WriteLine("Persona no encontrada");
            }

            Console.ReadKey();
        }
    }
}
