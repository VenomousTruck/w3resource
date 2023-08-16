using System;

namespace Task_19 {
    internal class Program {
        public static void Main(string[] args) {
            const int LIMIT = 100;
            Console.WriteLine("Enter two numbers divided by ', ': ");
            var numbers = Console.ReadLine().Split(new[] { ", " },
                StringSplitOptions.RemoveEmptyEntries);
            if (LIMIT - Convert.ToInt32(numbers[0]) < LIMIT - Convert.ToInt32(numbers[1]))
                Console.WriteLine(Convert.ToInt32(numbers[0]));
            else if (LIMIT - Convert.ToInt32(numbers[0]) > LIMIT - Convert.ToInt32(numbers[1]))
                Console.WriteLine(Convert.ToInt32(numbers[1]));
            else
                Console.WriteLine("0");

            Console.ReadLine();
        }
    }
}