using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

while (true)
{
    Console.WriteLine("1)сложение");
    Console.WriteLine("2)вычетание");
    Console.WriteLine("3)умножение");
    Console.WriteLine("4)деление");
    Console.WriteLine("5)возвести в степень");
    Console.WriteLine("6)квадратный корень");
    Console.WriteLine("7)процент");
    Console.WriteLine("8)факториал");
    Console.WriteLine("9) выход");
    Console.WriteLine("введите число");
    float a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите действие");
    int b = Convert.ToInt32(Console.ReadLine());
    if (b < 1 || b > 9)
    {
        Console.WriteLine("Ты Кирилл! ввёл (ввела) не то число!");
        Environment.Exit(0);
    }
    if (b == 1 || b == 2 || b == 2 || b == 3 || b == 4 || b == 5 || b == 7)
    {
     Console.WriteLine("введите число");
     float c = Convert.ToInt32(Console.ReadLine());
        if (b == 1)
        {
            Console.Write("итог:");
            Console.WriteLine(a + c);
        }
        else if (b == 2)
        {
            Console.Write("итог:");
            Console.WriteLine(a - c);
        }
        else if (b == 3)
        {
            Console.Write("итог:");
            Console.WriteLine(a * c);
        }
        else if (b == 4)
        {
            Console.Write("итог:");
            Console.WriteLine(a / c);
        }
        else if (b == 5)
        {
            double pow = Math.Pow(a, c);
            Console.Write("итог:");
            Console.WriteLine(pow);
        }
        else if (b == 7)
        {
            Console.Write("итог:");
            Console.WriteLine((a / 100) * c);
        }
    }
    if (b == 6)
        {
            double pow = Math.Pow(a, 0.5);
            Console.Write("итог:");
            Console.WriteLine(pow);
        }
        else if (b == 8)
        {
            for (float i = 1; i <= a; i++)
            {

                Console.Write("итог:");
                Console.Write(i);
            }
        }
    if (b == 9);
    {
     Environment.Exit(0);
    }
}