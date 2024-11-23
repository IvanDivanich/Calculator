using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpecialFuns specialFuns = new SpecialFuns();
            Math1 math1 = new Math1();
            int x, y, operand;

            while (true)
            {
                Console.WriteLine("Выберите действие\n1 - Сложение\n2 - Вычитание\n3 - Умножение\n4 - Деление\n5 - Степень");

                operand = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите первое число:");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                y = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (operand)
                {
                    case 1:
                        Console.WriteLine(math1.Summary(x, y));
                        break;
                    case 2:
                        Console.WriteLine(math1.Diference(x, y));
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine(specialFuns.Pow(x, y));
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
