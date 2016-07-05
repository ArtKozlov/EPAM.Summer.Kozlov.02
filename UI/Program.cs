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
            double root = MathNewton.Sqrt(100, 2, 0.000001);
            
            Console.WriteLine(root);
            Console.WriteLine("Проверка:");
            Console.WriteLine(Math.Pow(root, 2));   
            long time;
            Console.WriteLine(AlgorithmGCD.GetGCD(out time, 78, 294, 570));
            Console.WriteLine(time);
            Console.WriteLine(AlgorithmGCD.GetSteinGCD(out time, 78, 294, 570));
            Console.WriteLine(time);

            Console.WriteLine(AlgorithmGCD.GetGCD(out time, 78, 294));
            Console.WriteLine(time);
            Console.WriteLine(AlgorithmGCD.GetSteinGCD(out time, 78, 294));
            Console.WriteLine(time);

            Console.WriteLine(AlgorithmGCD.GetGCD(out time, 78, 294, 570, 36));
            Console.WriteLine(time);
            Console.WriteLine(AlgorithmGCD.GetSteinGCD(out time, 78, 294, 570, 36));
            Console.WriteLine(time);

            Console.ReadKey();

        }
    }
}
