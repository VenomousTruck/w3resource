using System;

namespace Task_9 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Type your string: ");
            string str = Console.ReadLine();
            if (str.Length == 1)
                Console.WriteLine(str + str + str);
            else {
                char letter = str[str.Length - 1];
                string newStr = letter + str + letter;
                Console.WriteLine(newStr);
            }
        }
    }
}