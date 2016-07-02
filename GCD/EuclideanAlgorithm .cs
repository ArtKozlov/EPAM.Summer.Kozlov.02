using System;
using System.Diagnostics;
using System.Threading;

namespace GCD
{
    public class EuclideanAlgorithm
    {
      /*  Stopwatch stopWatch = new Stopwatch();
        private string runTime = null;
        public string RunTime
        {
            get
            {
                return runTime;
            }
        }*/
        public int GetGCD(int firstNumber, int secondNumber)
        {
            /*  if (stopWatch.ElapsedMilliseconds == 0)
              {
                  stopWatch.Start();
              } */
            if (firstNumber == secondNumber) return firstNumber;
            if (firstNumber == 1 || secondNumber == 1) return 1;
            if (firstNumber == 0 || secondNumber == 0)
            {
                throw new Exception("Недопустимые аргументы!");
            }
                if (firstNumber%secondNumber != 0)
            {
                return GetGCD(secondNumber, firstNumber%secondNumber);
            }

           /* stopWatch.Stop();
            runTime = "Runtime in Milliseconds: " + Convert.ToString(stopWatch.ElapsedMilliseconds);*/

            return Math.Abs(secondNumber);
        }

        public int GetGCD(int firstNumber, int secondNumber, int thirdNumber)
        {
            firstNumber = GetGCD(firstNumber, secondNumber);
            return GetGCD(firstNumber, thirdNumber);
        }

        public int GetGCD(params int[]arrayOfNumbers)
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
