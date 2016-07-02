using System;
using LogicNewton;
using GCD;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine(EuclideanAlgorithm.GetGCD(3, 17));
            Console.WriteLine(EuclideanAlgorithm.GetGCD(78, 294,570));
            Console.WriteLine(EuclideanAlgorithm.GetGCD(78, 294, 570, 36));*/
              Console.WriteLine("Нахождение корня методом Ньютона:");
              double root = MathNewton.Sqrt(100, 3, 0.00000001);
              Console.WriteLine(root);
              Console.WriteLine("Проверка:");
              Console.WriteLine(Math.Pow(root, 2));
              
            Console.ReadKey();

        }
    }
}
