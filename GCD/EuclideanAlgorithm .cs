using System;
using System.Runtime.Serialization;

namespace GCD
{
    public class EuclideanAlgorithm
    {
        public static int GetGCD(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                throw new Exception("Недопустимые аргументы!");
            }
                if (firstNumber%secondNumber != 0)
            {
                return GetGCD(secondNumber, firstNumber%secondNumber);
            }
            return Math.Abs(secondNumber);
        }
    }

}
