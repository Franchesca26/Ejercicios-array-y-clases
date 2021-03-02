using System;

namespace Array_10
{
    class Program
    {
        static void Main(string[] args)
        {
            persona per1 = new persona();
            per1.Inicializar();
            per1.Imprimir();
            per1.EsMayorEdad();

        }

    }


    class persona
    {
        private string nombre;
        private int edad;

        public void Inicializar()
        {
            Console.Write("Ingrese el nombre:");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad:");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.Write("Nombre:");
            Console.WriteLine(nombre);
            Console.Write("Edad:");
            Console.WriteLine(edad);
        }

        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write("Es mayor de edad");
            }
            else
            {
                Console.Write("No es mayor de edad");
            }
            Console.ReadKey();

        }
    }
}
