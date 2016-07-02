using System;
using LogicNewton;
using GCD;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Нахождение корня методом Ньютона:");
            double root = MathNewton.Sqrt(2, 2, 0.00000000001);
            Console.WriteLine(root);
            Console.WriteLine("Проверка:");
            Console.WriteLine(Math.Pow(root, 2));

            Console.ReadKey();

        }
    }
}
