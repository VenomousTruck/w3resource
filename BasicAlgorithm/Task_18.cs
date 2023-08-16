using System;

namespace Task_18 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter three numbers divided by ',': ");
            var numbers = Console.ReadLine().Split(new[] { "," },
                StringSplitOptions.RemoveEmptyEntries);
            int maximum = -100000000;
            for (int i = 0; i < numbers.Length; i++) {
                if (Convert.ToInt32(numbers[i]) > maximum)
                    maximum = Convert.ToInt32(numbers[i]);
            }
            Console.WriteLine($"The maximum number among these is: {maximum}");

            Console.ReadLine();
        }
    }
}