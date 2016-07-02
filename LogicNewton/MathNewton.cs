using System;


namespace LogicNewton
{
    public class MathNewton
    {

        public static double Sqrt(double number, double power, double e)
        {
            double root0 = 0;
            double root1 = power / number;

            while (Math.Abs(root1 - root0) > e)
            {
                root0 = root1;
                root1 = (1 / number) * ((number - 1) * root0 + power / Math.Pow(root0, number - 1));

            }

            return root1;
        }

    }
}
