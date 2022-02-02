using System;
using System.Collections.Generic;

namespace AleatoriosNoRepetidos
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int units = 0;
            Console.WriteLine("How many units do you want?");
            units = int.Parse(Console.ReadLine());
            int ammount = 0;
            Console.WriteLine("How many numbers do you want?");
            ammount = int.Parse(Console.ReadLine());
            Console.Clear();
            Random random = new Random();
            for (int i = 0; i < ammount; i++)
            {
                AddNumber(random, units, numbers);
            }

            Console.WriteLine("Finished!");
        }
        public static void AddNumber(Random random, int units, List<int> numbers)
        {
            int number = random.Next(10 * units);
            if (numbers.Contains(number))
            {
                AddNumber(random, units, numbers);
            }
            else
            {
                numbers.Add(number);
                Console.WriteLine(number);
            }
        }
    }
}
