using System;
using System.Diagnostics;

namespace GCD
{
    public class SteinAlgorithm
    {

        Stopwatch stopWatch = new Stopwatch();
        private long runTime;
        public long RunTime
        {
            get
            {
                return runTime;
            }
        }

        public int GetGCD(int firstNumber, int secondNumber)
        {
            stopWatch.Start();
            runTime = 0;
            return GCD(firstNumber, secondNumber);

        }

        public int GetGCD(int firstNumber, int secondNumber, int thirdNumber)
        {
            stopWatch.Start();
            runTime = 0;
            firstNumber = GCD(firstNumber, secondNumber);
            return GCD(firstNumber, thirdNumber);
        }

        public int GetGCD(params int[] arrayOfNumbers)
        {
            stopWatch.Start();
            runTime = 0;
            int result = arrayOfNumbers[0];
            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                result = GCD(result, arrayOfNumbers[i++]);
            }
            return result;
        }

        public int GCD(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0) throw new Exception("Недопустимые аргументы!");
            if (firstNumber == secondNumber)
            {
                SaveRunTime();
                return firstNumber;
            }
            if (firstNumber == 1 || secondNumber == 1)
            {
                SaveRunTime();
                return 1;
            }
            if ((firstNumber % 2 == 0) && (secondNumber % 2 == 0))
            {
                return 2 * GCD(firstNumber / 2, secondNumber / 2);
            }
            if ((firstNumber % 2 == 0) && (secondNumber % 2 != 0))
            {
                return GCD(firstNumber / 2, secondNumber);
            }
            if ((firstNumber % 2 != 0) && (secondNumber % 2 == 0))
            {
                return GCD(firstNumber, secondNumber / 2);
            }
            return GCD(secondNumber, Math.Abs(firstNumber - secondNumber));
        }

        private void SaveRunTime()
        {
            stopWatch.Stop();
            runTime += stopWatch.ElapsedTicks;
            stopWatch.Reset();
        }


    }
}
