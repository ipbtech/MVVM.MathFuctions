using System;

namespace MVVM.MathFunctions.Models
{
    public static class MathFuncModel
    {
        public static double GetSumOf(double num1, double num2)
        {
            return Math.Round(num1 + num2, 2);
        }
        public static double GetDifferenceOf(double num1, double num2)
        {
            return Math.Round(num1 - num2, 2);
        }
        public static double GetDifferenceInProcent(double num1, double num2)
        {
            double complete = 100;
            if (num1 >= num2) { return Math.Round((num1 - num2) / num1 * complete, 2); }
            else { return Math.Round((num2 - num1) / num1 * complete, 2); }
        }
    }
}
