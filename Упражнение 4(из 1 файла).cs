using System;

namespace Упражнение_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2; 

            Console.WriteLine("Введите коэффициент a :");
            var a1 = Console.ReadLine();
            Console.WriteLine("Введите коэффициент b :");
            var b1 = Console.ReadLine();
            Console.WriteLine("Введите коэффициент c :");
            var c1 = Console.ReadLine();
            if ((int.TryParse(a1, out int a)) && (int.TryParse(b1, out int b)) && (int.TryParse(c1, out int c)))
            {
                if (a == 0)
                {
                    Console.WriteLine("a не может быть равным нулю в квадратном уравнении ...");
                    return;
                }
                double D = b * b - 4 * a * c;
                if (D == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine($"Первый корень: {x1}");
                    Console.WriteLine($"Второй корень: {x1}");
                    return;
                }
                else if (D < 0)
                {
                    Console.WriteLine("Действительных корней нет... ");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(D)) / 2 * a;
                    x2 = (-b - Math.Sqrt(D)) / 2 * a;
                    Console.WriteLine($"Первый корень: {x1}");
                    Console.WriteLine($"Первый корень: {x2}");
                }
            }
            else Console.WriteLine("Введите коэффициенты корректно ");
        }
    }
}
