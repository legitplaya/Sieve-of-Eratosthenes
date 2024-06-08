using System;

public class MainClass
{
    public static void Main()
    {
        Console.Write("Введите первое значение: ");
        int startValue = int.Parse(Console.ReadLine());
        Console.Write("Введите второе значение: ");
        int endValue = int.Parse(Console.ReadLine());

        bool[] prime = new bool[endValue + 1];

        for (int i = 0; i <= endValue; i++)
            prime[i] = true;

        for (int p = 2; p * p <= endValue; p++)
        {
            if (prime[p])
            {
                for (int i = p * p; i <= endValue; i += p)
                {
                    prime[i] = false;
                }
            }
        }

        int sum = 0;

        for (int i = Math.Max(2, startValue); i <= endValue; i++)
        {
            if (prime[i])
            {
                sum += i;
            }
        }

        Console.WriteLine($"Сумма простых чисел = {sum}");
    }
}
