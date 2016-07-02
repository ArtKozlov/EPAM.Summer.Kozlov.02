using System;


namespace LogicNewton
{
    public class MathNewton
    {

        public static double Sqrt(double number, double power, double e)
        {
            double root0 = 0;
            double root1 = 1;

            if (number <= 0 && power%2!=0)
            {
                throw new Exception("Недопустимые аргументы!");
            }

            while (Math.Abs(root1 - root0) >= e)
            {
                root0 = root1;
                root1 = (1 / power) * ((power - 1) * root0 + number / Math.Pow(root0, power - 1));

            }

            return root1;
        }

    }
}
