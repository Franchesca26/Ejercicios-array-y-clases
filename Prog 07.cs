using System;

namespace Array_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre:");
            string nombre = Console.ReadLine();
            int longitud = nombre.Length;
            Console.WriteLine("La division del nombre de {0} tiene {1} caracteres:", nombre, longitud);
            for (int i = 0; i < longitud; i++)
            {
                Console.Write(" {0}", nombre[i]);
            }

            Console.ReadLine();

        }
    }
}
