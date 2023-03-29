using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random die = new Random();
            int n = int.Parse(Console.ReadLine());
            int sum;

            // for (int i = 0 ; i < n ; i++)
            // {
            //     sum += die.Next(1, 7);
            // }
            sum = die.Next(1.7);
            Console.WriteLine($"Dice add up to {sum}.");



                
        }
    }
}
