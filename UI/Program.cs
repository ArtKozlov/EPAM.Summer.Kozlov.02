using System;
using LogicNewton;
using GCD;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            EuclideanAlgorithm obj = new EuclideanAlgorithm();
            Console.WriteLine(obj.GetGCD(3, 17));
            Console.WriteLine(obj.GetGCD(78, 294,570));
            Console.WriteLine(obj.GetGCD(78, 294, 570, 36));
              Console.WriteLine("Нахождение корня методом Ньютона:");
              double root = MathNewton.Sqrt(100, 3, 0.00000001);
              Console.WriteLine(root);
              Console.WriteLine("Проверка:");
              Console.WriteLine(Math.Pow(root, 2));   */

            EuclideanAlgorithm obj = new EuclideanAlgorithm();
            Console.WriteLine(obj.GetGCD(3, 17));
            Console.WriteLine("Runtime in Ticks: " + obj.RunTime);
            Console.WriteLine(obj.GetGCD(135, 972));
            Console.WriteLine("Runtime in Ticks: " + obj.RunTime);
            Console.WriteLine(obj.GetGCD(78, 294, 570));
            Console.WriteLine("Runtime in Ticks: " + obj.RunTime);
            Console.WriteLine(obj.GetGCD(78, 294, 570, 36));
            Console.WriteLine("Runtime in Ticks: " + obj.RunTime);


            Console.ReadKey();

        }
    }
}
