using System;

class Program
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());

        long min = N;
        for (long i = 2; i*i <= N; i++)
        {
            if (N % i == 0)
            {
                min = i;
                break;
            }
        }


        Console.WriteLine(min);
    }
}