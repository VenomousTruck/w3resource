using System;

namespace Task_17 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter your string: ");
            string str = Console.ReadLine();

            if (str[1] == 'y' && str[2] == 't') {
                string newStr = str.Remove(1, 2);
                Console.WriteLine(newStr);
            }
            else
                Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}