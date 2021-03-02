using System;

namespace Array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Num = new int[10];
            Console.WriteLine("Escribe 10 numeros");
            for (int i = 0; i < 10; i++)
            {
                Num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("el numero mayor");


            Console.WriteLine(Num.Max());



            Console.ReadLine();

        }
    }
}
