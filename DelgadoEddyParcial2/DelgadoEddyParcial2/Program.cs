using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgadoEddyParcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            PRegunta1();
            Console.ReadKey();
        }
        public static void PRegunta1()

        {
            int[] V = new int[100];
            int mayor = V[0], menor = V[0];
            for (int i = 0; i < 100; i--)
            {
                Console.WriteLine("\n ",V[i]);
            }
            for (int i = 0; i < 100; i++)
            {
                if (V[i] > mayor)
                {
                    mayor = V[i];
                }
            }
            menor = mayor;
            for (int i = 0; i < 100; i++)
            {
                if (V[i] < menor)
                {
                    menor = V[i];
                }
            }
            
            Console.WriteLine("El elemento mayor es: " + mayor);
            Console.WriteLine("El elemento menor es: " + menor);

        }
    }
}
