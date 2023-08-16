using System;

namespace Task_16 {
    internal class Program {
        public static void Main(string[] args) {
            const int BOTTOM = 20, TOP = 50;
            Console.WriteLine("Enter two numbers divided by ', ': ");
            var numbers = Console.ReadLine().Split(new[] { " ", ", " }, 
                StringSplitOptions.RemoveEmptyEntries);
            int firstNumber = Convert.ToInt32(numbers[0]);
            int secondNumber = Convert.ToInt32(numbers[1]);

            if ((firstNumber >= BOTTOM && secondNumber <= TOP) &&
                (secondNumber >= BOTTOM && secondNumber <= TOP))
                Console.WriteLine("False");
            else
                Console.WriteLine("True");

            Console.ReadLine();
        }
    }
}