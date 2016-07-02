using System;

namespace GCD
{
    public class EuclideanAlgorithm
    {
        public static double GetGCD(int firstNumber, int secondNumber)
        {

            if (firstNumber%secondNumber != 0)
            {
                return GetGCD(secondNumber, firstNumber%secondNumber);
            }
            return Math.Abs(secondNumber);
        }
    }
}
