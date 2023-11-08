using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double sum1;
            double sum2;
            while (true)
            {
                try
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Введите первое число");
                    sum1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    sum2 = Convert.ToDouble(Console.ReadLine());
                    Calc calc = new Calc(sum1, sum2);
                    double mainResult = calc.Summ();
                    calc.ColorChange();
                    Console.WriteLine($"Сумма двух чисел:{mainResult}");
                }
                catch(FormatException ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                }
            }
                    Console.ReadKey();
        }
    }

    public interface ILogger
    {
        void ColorChange();
    }
    public interface ICalc
    {
        double Summ();
    }

    public class Calc : ICalc, ILogger
    {
        public double X; public double Y;
        public Calc(double x = 0, double y = 0) 
        {
            X = x;
            Y = y;
        }

        public void ColorChange()
        {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
        }

        public double Summ()
        {
            double result = X + Y;
            return result;
        }
    }
}

