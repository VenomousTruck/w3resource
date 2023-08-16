using System;

namespace Task_20 {
    internal class Program {
        public static void Main(string[] args) {
            const int FIRST_BOTTOM = 40, FIRST_TOP = 50;
            const int SECOND_BOTTOM = 50, SECOND_TOP = 60;
            Console.WriteLine("Enter two numbers divided by ', ': ");
            var numbers = Console.ReadLine().Split(new[] { ", " },
                StringSplitOptions.RemoveEmptyEntries);
            int firstNumber = Convert.ToInt32(numbers[0]);
            int secondNumber = Convert.ToInt32(numbers[1]);

            if (((firstNumber >= FIRST_BOTTOM && firstNumber <= FIRST_TOP)
                && (secondNumber >= FIRST_BOTTOM && secondNumber <= FIRST_TOP))
                || ((firstNumber >= SECOND_BOTTOM && firstNumber <= SECOND_TOP)
                && (secondNumber >= SECOND_BOTTOM && secondNumber <= SECOND_TOP)))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadLine();
        }
    }
}