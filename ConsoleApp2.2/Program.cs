using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /* //Базовый уровень
                Console.WriteLine("Введите число a: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число c: ");
                int c = int.Parse(Console.ReadLine());
                if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                    Console.WriteLine("Числа являются тройкой Пифагора");
                else
                    Console.WriteLine("Числа не являются тройкой Пифагора");
                */ //Высокий уровень
                decimal a = 1.1m; //ребро кирпича
                decimal b = 2.2m; //ребро кирпича
                decimal c = 3.3m; //ребро кирпича
                decimal x = 4.4m; //отверстие
                decimal y = 5.5m; //отверстие
                if ((x == a && y == b) || (y == a && x == b) || (x == b && y == c) || (x == c && y == a) || (x == c && y == b) || (x == a && y == c))
                    Console.WriteLine("Кирпич пройдёт в отверсвтие");
                else Console.WriteLine("Кирпич не проходит в отверстие");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}