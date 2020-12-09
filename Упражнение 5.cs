using System;

namespace Упражнение_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double t1=0,t2=0;

            Console.WriteLine("Введите коэффициент a :");
            var a1 = Console.ReadLine();
            Console.WriteLine("Введите коэффициент b :");
            var b1 = Console.ReadLine();
            Console.WriteLine("Введите коэффициент c :");
            var c1 = Console.ReadLine();
            while (true) 
            {
                //проверка
                if ((int.TryParse(a1, out int a)) && (int.TryParse(b1, out int b)) && (int.TryParse(c1, out int c)))
                {
                    //Проверка и повторный ввод корректного коэф. a 
                    while (a == 0)
                    {
                        Console.WriteLine("a не может быть равным нулю в биквадратном уравнении ...");
                        Console.WriteLine("Введите коэффициент a :");
                        try
                        {
                            a = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Введите коэффициент корректно ");
                        }
                    }
                    // Решение
                    double D = b * b - 4 * a * c;
                    if (D == 0)
                    {
                        t1 = -b / (2 * a);
                        if (t1 < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Действительных корней нет... ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"x1 = {Math.Sqrt(t1)} и x2 = {-Math.Sqrt(t1)}  ");
                            Console.ResetColor();
                        }
                        return;
                    }
                    else if (D < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Действительных корней нет... ");
                        Console.ResetColor();
                        return;
                    }
                    else
                    {
                        t1 = (-b + Math.Sqrt(D)) / 2 * a;
                        t2 = (-b - Math.Sqrt(D)) / 2 * a;
                    }
                    if (t1 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("У x1 и x2 нет действительных корней ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"x1 = {Math.Sqrt(t1)} и x2 = {-Math.Sqrt(t1)}  ");
                        Console.ResetColor();
                    }
                    if (t2 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("У x3 и x4 нет действительных корней ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"x3 = {Math.Sqrt(t2)} и x4 = {-Math.Sqrt(t2)}  ");
                        Console.ResetColor();
                    }
                    return;
                }
                else // чтобы можно было вводить коэффициенты снова
                {
                    Console.WriteLine("Введите коэффициенты корректно ");
                    try
                    {
                        Console.WriteLine("Введите коэффициент a :");
                        a1 = Console.ReadLine();
                        Console.WriteLine("Введите коэффициент b :");
                        b1 = Console.ReadLine();
                        Console.WriteLine("Введите коэффициент c :");
                        c1 = Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Введите коэффициенты корректно ");
                    }
                }
            }
        }
    }
}
