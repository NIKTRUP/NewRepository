using System;

namespace Упражнение_3__2lvl_
{
    class Program
    {
        
        public struct Работник
        {
            public string имя;
            public string Фамилия;
            public double ЗП;
            public enum ВУЗ { КФУ, МГУ, МИФИ, МФТИ, ИТМО }
        }
        static void Main(string[] args)
        {
            Работник работник;
            работник.имя = "Сергей";
            работник.Фамилия = "Тимохин";
            работник.ЗП = 300000;

            Console.WriteLine($"Имя - {работник.имя}\nФамилия - {работник.Фамилия}\nЗаработная плата: {работник.ЗП} рублей");

        }
    }
}
