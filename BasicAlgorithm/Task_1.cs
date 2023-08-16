using System;

namespace Task_1 {
    internal class Program {
        public static void Main(string[] args) {
            const int COEFFICIENT = 3;

            Console.WriteLine("Enter two numbers in one line to calculate the sum" +
                              "\nRemember: if two numbers are similar, then it returns triple their sum");

            var numbers = Console.ReadLine().Split(new[] { " ", ",", ";" },
                StringSplitOptions.RemoveEmptyEntries);

            var sum = 0;

            foreach (var t in numbers) {
                if (numbers[0] == numbers[1])
                    sum = Convert.ToInt32(numbers[0]) * Convert.ToInt32(numbers[1]) * COEFFICIENT;
                else
                    sum = Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]);
            }

            Console.WriteLine($"The result is: {sum}");
        }
    }
}