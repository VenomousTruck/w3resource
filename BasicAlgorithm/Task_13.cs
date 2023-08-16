using System;

namespace Task_13 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter temperature index, split by ',' ");
            var indexes = Console.ReadLine().Split(new[] { " ", ", " },
                StringSplitOptions.RemoveEmptyEntries);
            int firstTemp = Convert.ToInt32(indexes[0]);
            int secondTemp = Convert.ToInt32(indexes[1]);
            
            if (firstTemp < 0 && secondTemp > 100)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadLine();
        }
    }
}