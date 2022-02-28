using System;
using System.Collections.Generic;


namespace CasoTesteSalto.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 1;

            List<int> listaSoldados = new List<int>() {1,2,3,4,5};

            while (listaSoldados.Count != 1)
            {
                if (i < listaSoldados.Count)
                {
                    listaSoldados.Remove(listaSoldados[j]);
                    i++;
                    j++;

                    if (i >= listaSoldados.Count)
                    {
                        i = 0;
                    }

                    if (j >= listaSoldados.Count)
                    {
                        j = 0;
                    }
                }
                else i = 0;
            }

        Console.Write("Restou o elemento {0}", listaSoldados[0]);
        Console.ReadKey();
        }
    }
}

