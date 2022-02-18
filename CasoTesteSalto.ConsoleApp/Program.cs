using System;

namespace CasoTesteSalto.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k, casoAtual;
            int contador =0;

            casoAtual = 1;

            Console.Write("número de casos: ");
            int numeroCasos = int.Parse(Console.ReadLine());

            while (contador < numeroCasos)
            {
                Console.Write("número de elementos: ");
                n = int.Parse(Console.ReadLine());

                Console.Write("número de saltos: ");
                k = int.Parse(Console.ReadLine());

                Console.Write("entrada do caso: " + n + " " + k);
                Console.ReadKey();
                string caso = n + " " + k;

                string[] dividido = caso.Split(' ');
                n = int.Parse(dividido[0]);
                k = int.Parse(dividido[1]);


                // Random aleatorio = new Random();

                int vitima1 = 2;//aleatorio.Next(1,6);

                int[] roda = new int[n];

                for (int i = 0; i < n; i++) //id elementos
                {
                    roda[i] = i+1;
                }

                for (int i = 0; i < k; i++)
                {


                    for (int j = 0; j < n; j++)
                    {
                        if (roda[j] == vitima1)
                        {
                            roda[j] = 0;
                            for (int x = 0; x <= n; x++)
                            {
                                if (roda[x] == 0)
                                {
                                    if (x < n)
                                    {
                                        roda[x + k] = 0;
                                    }
                                }
                                else
                                    continue;
                            }
                        }
                    }
                }

                foreach (uint v in roda)
                {
                    if (v != 0)
                    {
                        Console.WriteLine("\nCaso " + casoAtual + ": " + v);
                    }
                }
                casoAtual++;
            }

            Console.ReadKey();
        }
    }
}
