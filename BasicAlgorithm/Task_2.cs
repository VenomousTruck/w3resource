using System;

namespace Task_2 {
    internal class Program {
        public static void Main(string[] args) {
            const int CONST_NUMBER = 51;
            int difference = 0;
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= CONST_NUMBER)
                difference = CONST_NUMBER - num;
            else
                difference = (num - CONST_NUMBER) * 3;
            
            Console.WriteLine($"The difference is: {difference}");

            Console.ReadLine();
        }
    }
}