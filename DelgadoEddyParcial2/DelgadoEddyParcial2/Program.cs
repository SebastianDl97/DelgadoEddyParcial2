using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgadoEddyParcial2
{
    class Program
    {
        const int max = 100;
        static void Main(string[] args)
        {
            int[] vector = new int[max];
            llenarvector(vector);
            ordenarVector(vector);
            imprimirVector(vector);
            Console.WriteLine("Valor maximo: {0}", vector[0]);
            Console.WriteLine("Valor minimo: {0}", vector[max-1]);
            Console.WriteLine("Sumatoria {0}",sumatoria(vector));
            Console.WriteLine("Promedio {0}", promedio(vector));
            Console.WriteLine("Total de decenas: {0}", ContarDecenas(vector));
            Console.WriteLine("Desv. Estamdar: {0}", DesvEstandar(vector));
            Console.ReadKey();
        }
        public static double DesvEstandar(int []x)
        {
            double res = 0;
            double Pro = promedio(x);
            for(int i=0;i<max;i++)
            {
                res=res+(x[i] - Pro) * (x[i] - Pro);
            }
            return Math.Sqrt(res / (max * 1));
        }
        public static int ContarDecenas(int []x)
        {
            int c = 0;
            for (int i=0;i<max;i++)
            {
                if(x[i]>=10 && x[i]<=90)
                {
                    if (x[i] % 10 == 0)
                        c++;
                }
            }
            return c;
        }
        public static double promedio(int []x)
        {
            double suma = sumatoria(x);
            return (suma / max);
        }
        public static int sumatoria(int []x)
        {
            int suma = 0;
            for (int i = 0; i < max; i++)
                suma = suma + x[i];
            return suma;
        }
        public static void llenarvector(int[]x)

        {
            Random r = new Random();
            for (int i=0;i<max;i++)
            {
                int numero = r.Next(1, 100);
                x[i]= numero;
            }
            
        }
        public static void imprimirVector(int[]x)
        {
            Console.WriteLine("Elementos del vector: ");
            for(int i=0;i<max;i++)
            {
                Console.WriteLine("{0} ", x[i]);
            }
            Console.WriteLine();
        }
        public static void ordenarVector(int[]x)
        {
            int aux = 0;
            for(int i=0;i<max;i++)
            for(int j=i+1;j<max;j++)
            {
                if (x[i]<x[j])
                {
                    aux = x[i];
                    x[i] = x[j];
                    x[j] = aux;

                }
            }
        }
    }
}
