using System;

namespace Task_15 {
    internal class Program {
        public static void Main(string[] args) {
            const int BOTTOM = 20, TOP = 50;
            Console.WriteLine("Enter three numbers divided by ', ': ");
            
            var numbers = Console.ReadLine().Split(new[] { " ", ", " },
                StringSplitOptions.RemoveEmptyEntries);
            int firstNumber = Convert.ToInt32(numbers[0]);
            int secondNumber = Convert.ToInt32(numbers[1]);
            int thirdNumber = Convert.ToInt32(numbers[2]);

            if ((firstNumber >= BOTTOM && firstNumber <= TOP) ||
                (secondNumber >= BOTTOM && secondNumber <= TOP) ||
                (thirdNumber >= BOTTOM && thirdNumber <= TOP))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadLine();
        }
    }
}