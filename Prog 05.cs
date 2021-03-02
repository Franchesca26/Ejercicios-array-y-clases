using System;

namespace Array_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = new string[3];
            int K = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Escribe un nombre:");
                Nombres[i] = Console.ReadLine();
                K++;
                if (Nombres[i] == "") { break; }

            }
            Console.WriteLine("\nLista de los nombres:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Nombres[i]);
            }



            Console.ReadLine();

        }
    }
}
