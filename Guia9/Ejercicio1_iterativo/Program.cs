using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_iterativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE TERMINO DE LA SERIE DE FIBONNACI QUE DESEE");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            if (n == 0)
            {
                Console.WriteLine("EL NUMERO ES: 0");
            }
            else if (n == 1)
            {
                Console.WriteLine("EL NUMERO ES: 1");
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine($"EL NUMERO ES: {c}");
            }
        }
    }
}
