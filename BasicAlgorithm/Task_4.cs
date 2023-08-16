using System;

namespace Task_4 {
    internal class Program {
        public static void Main(string[] args) {
            const int ONE_HUNDRED = 100;
            const int TWO_HUNDRED = 200;
            const int TEN = 10;
            Console.WriteLine("Enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (Math.Abs(ONE_HUNDRED - num) <= TEN || Math.Abs(TWO_HUNDRED - num) <= TEN)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadLine();
        }
    }
}