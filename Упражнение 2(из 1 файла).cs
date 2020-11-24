using System;

namespace Упражнение_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число (делимое): ");
            var Intnumber1 = Console.ReadLine();
            Console.Write("Введите второе целое число (делитель): ");
            var Intnumber2 = Console.ReadLine();
            if ((int.TryParse(Intnumber1, out int number1)) && (int.TryParse(Intnumber2, out int number2)))
            {
                while (number2 == 0)
                {
                    Console.WriteLine("На 0 делить нельзя ,попробуйте ещё раз ... ");
                    Console.Write("Попробуйте ввести другое число: ");
                    number2 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Результат деления : {number1 / number2}");
            }
            else Console.WriteLine("Вы ввели числа некорректно ");
        }
    }
}
