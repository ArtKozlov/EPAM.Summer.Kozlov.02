using System;

namespace GCD
{
    public class SteinAlgorithm
    {
            public int GetGCD(int firstNumber, int secondNumber)
            {

                if (firstNumber == 0 || secondNumber == 0) throw new Exception("Недопустимые аргументы!");
                if (firstNumber == secondNumber) return firstNumber;
                if (firstNumber == 1 || secondNumber == 1) return 1;
                if ((firstNumber % 2 == 0) && (secondNumber % 2 == 0)) return 2 * GetGCD(firstNumber / 2, secondNumber / 2);
                if ((firstNumber % 2 == 0) && (secondNumber % 2 != 0)) return GetGCD(firstNumber / 2, secondNumber);
                if ((firstNumber % 2 != 0) && (secondNumber % 2 == 0)) return GetGCD(firstNumber, secondNumber / 2);
                return GetGCD(secondNumber, Math.Abs(firstNumber - secondNumber));
            }

            public int GetGCD(int firstNumber, int secondNumber, int thirdNumber)
            {
                firstNumber = GetGCD(firstNumber, secondNumber);
                return GetGCD(firstNumber, thirdNumber);
            }

            public int GetGCD(params int[] arrayOfNumbers)
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
