using System;

namespace Task_12 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter your string here: ");
            string str = Console.ReadLine();
            
            if (str[0] == 'C' && str[1] == '#')
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadLine();
        }
    }
}