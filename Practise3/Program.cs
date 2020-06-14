using System;

namespace Practice3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x = 0;
            double y = 0;

            x = InputDouble("Введите x: ");
            y = InputDouble("Введите y: ");

            if (IsBelong(x, y) == true)
            {
                Console.WriteLine("Точка принадлежит области. x + y = {0}", x + y);
            }
            else
            {
                Console.WriteLine("Точка не принадлежит области. x - y = {0}", x - y);
            }

            Console.WriteLine("\nPress something to exit");
            Console.ReadKey();
        }
        public static bool IsBelong(double x, double y)
        {
            if (Math.Pow(x, 2) <= y && Math.Exp(x) >= y && Math.Exp(-1 * x) >= y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double InputDouble(string msg, string errorMsg = "Необходимо ввести число или десятичную дробь через запятую")
        {
            double result = 0;

            Console.Write(msg);
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine(errorMsg);
            }

            return result;
        }
    }
}

