﻿//Timespan é uma duracao, um intervalo entre dois instantes
namespace exTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(9000000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t7);

            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t8);

            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t9);

            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t10);

            TimeSpan t11 = TimeSpan.FromTicks(9000000000L);
            Console.WriteLine(t11);
        }
    }
}