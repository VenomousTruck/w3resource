using System;

namespace Task_10 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num % 3 == 0 || num % 7 == 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadLine();
        }
    }
}