using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
       static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else if (n < 0)
                return 0;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE TERMINO DE LA SERIE DE FIBONNACI QUE DESEE");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"EL NUMERO ES: {Fibonacci(n)}");
        }
    }
}
