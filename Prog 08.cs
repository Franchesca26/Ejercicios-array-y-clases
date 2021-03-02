using System;

namespace Array_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] alturas;
            float promedio;

            alturas = new float[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese la altura de la persona: " + (f + 1) + ": ");
                string linea = Console.ReadLine();
                alturas[f] = float.Parse(linea);
            }
            float suma;
            suma = 0;
            for (int f = 0; f < 5; f++)
            {
                suma = suma + alturas[f];
            }
            promedio = suma / 5;
            Console.WriteLine("Promedio de alturas es:" + promedio);
            int may, men;
            may = 0;
            men = 0;
            for (int f = 0; f < 5; f++)
            {
                if (alturas[f] > promedio)
                {
                    may++;
                }
                else
                {
                    if (alturas[f] < promedio)
                    {
                        men++;
                    }
                }
            }
            Console.WriteLine("Cantidad de personas mayores al promedio:" + may);
            Console.WriteLine("Cantidad de personas menores al promedio:" + men);


            Console.ReadLine();

        }
    }
}
