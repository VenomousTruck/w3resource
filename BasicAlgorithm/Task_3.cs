using System;

namespace Task_3 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter two numbers: ");
            var numbers = Console.ReadLine().Split(new[] { " ", ", " },
                StringSplitOptions.RemoveEmptyEntries);
            int firstNumber = Convert.ToInt32(numbers[0]);
            int secondNumber = Convert.ToInt32(numbers[1]);
            int sum = 30;
            
            if (firstNumber + secondNumber == sum)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadKey();
        }
    }
}