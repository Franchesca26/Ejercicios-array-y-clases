using System;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];

            Console.WriteLine("Escribe 5 numero");

            for (int i = 0; i < 5; i++)
            {
                numeros[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("La forma inversa");

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.ReadLine();

        }
    }
}
