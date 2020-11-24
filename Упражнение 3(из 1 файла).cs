using System;

namespace Упражнение_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char MyChar = Convert.ToChar(Console.ReadLine());
            int index = (int)MyChar;
            index++;
            MyChar = (char)index;
            Console.WriteLine($"Следующий символ: {MyChar}");
        }
    }
}
