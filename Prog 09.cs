using System;

namespace Array_9
{
    class Program
    {
        static void Main(string[] args)
        {
            TablaMultiplicar tm = new TablaMultiplicar();
            Console.WriteLine("escribe un numero entero:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Tabla de multiplicacion de " + num);
            tm.Calcular(num);
            tm.CargarValor();

        }

    }
    class TablaMultiplicar
    {
        public void CargarValor()
        {
            int valor;
            string linea;

            do
            {
                Console.Write("Ingrese un valor (-1 para finalizar):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != -1)
                {
                    Calcular(valor);
                }
            } while (valor != -1);
        }

        public void Calcular(int v)
        {

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(v + "x" + i + "=" + (i * v));
            }

            Console.WriteLine();

        }
    }
}
