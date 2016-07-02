using System;

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

        public static int GetGCD(int firstNumber, int secondNumber, int thirdNumber)
        {
            firstNumber = GetGCD(firstNumber, secondNumber);
            return GetGCD(firstNumber, thirdNumber);
        }

        public static int GetGCD(params int[]arrayOfNumbers)
        {
            int result = arrayOfNumbers[0];
            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                result = GetGCD(result, arrayOfNumbers[i++]);
            }
            return result;
        }
    }

}
