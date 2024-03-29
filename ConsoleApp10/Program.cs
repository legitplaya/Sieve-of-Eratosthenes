using System;

public class MainClass
{
    public static void Main()
    {
        Console.Write("Введите первое значение: ");
        int startValue = int.Parse(Console.ReadLine());
        Console.Write("Введите первое значение: ");
        int endValue = int.Parse(Console.ReadLine());

        bool[] prime = new bool[endValue+1];

        for (int i = 0; i<=endValue; i++)
            prime[i] = true;

        for (int i = 2; i * 2 <=endValue; i++)
        {

            if (prime[i])
            {
                for(int p = 2 * i; p<=endValue; p+=i)
                {
                    prime[p] = false;
                }
                
            }

        }
        int sum = 0;

        for (int i = Math.Max(2,startValue); i <= endValue; i++)
        {
            if (prime[i])
            {
                sum += i;
            }
        }

        Console.WriteLine($"Сумма простых чисел = {sum}");
    }
}