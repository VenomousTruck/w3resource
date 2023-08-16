using System;

namespace Task_14 {
    internal class Program {
        public static void Main(string[] args) {
            const int BOTTOM = 100, TOP = 200;
            Console.WriteLine("Enter your numbers divided by ', ': ");
            var numbers = Console.ReadLine().Split(new[] {" ", ", "}, 
                StringSplitOptions.RemoveEmptyEntries);
            int firstNumber = Convert.ToInt32(numbers[0]);
            int secondNumber = Convert.ToInt32(numbers[1]);

            if ((firstNumber >= BOTTOM && firstNumber <= TOP) ||
                (secondNumber >= BOTTOM && secondNumber <= TOP)) {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");

            Console.ReadLine();
        }
    }
}