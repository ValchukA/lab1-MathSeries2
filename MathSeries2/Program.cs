using System;

namespace MathSeries2
{
    class Program
    {
        static double Factorial(uint n)
        {
            double result = 1;

            for (uint i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        static void Main()
        {
            //Console.Write("Введите значение x и точность: ");
            //string[] input = Console.ReadLine().Split();

            //double x = Convert.ToDouble(input[0]);
            //double precision = Convert.ToDouble(input[1]);

            //double sum = 0;
            //double value;
            //uint n = 1;

            //do
            //{
            //    value = Math.Pow(x, n) / Factorial(n);

            //    if (Math.Abs(value) < precision)
            //    {
            //        sum += value;
            //    }

            //    n += 2;
            //} while (Math.Abs(value) > 0.0001);

            //Console.WriteLine($"Сумма значений, не превышающих заданной точности: {sum}");





            //Console.Write("Введите точность: ");
            //double precision = Convert.ToDouble(Console.ReadLine());

            //double sum = 0;
            //double value;
            //uint n = 0;

            //do
            //{
            //    value = Math.Pow(-1, n) / Math.Pow(2, n);

            //    if (Math.Abs(value) < precision)
            //    {
            //        sum += value;
            //    }

            //    n++;
            //} while (Math.Abs(value) > 0.0001);

            //Console.WriteLine($"Сумма значений, не превышающих заданной точности: {sum}");





            Console.Write("Введите точность: ");
            double precision = Convert.ToDouble(Console.ReadLine());

            double prevResult = Double.MaxValue;
            double result = 1;

            for (int i = 2; Math.Abs(prevResult - result) > precision; i++)
            {
                prevResult = result;

                double seriesResult = 0;

                for (int j = 1; j <= i; j++)
                {
                    seriesResult += j;
                }
                result = seriesResult / Math.Pow(i, 2);
            }

            Console.WriteLine($"Первый член, отличающийся от предыдущего не более чем на значение точности: {result}");
        }
    }
}
