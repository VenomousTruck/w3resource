using System;

namespace Task_7 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Type your string: ");
            string str = Console.ReadLine();
            if (str.Length == 1)
                Console.WriteLine(str);
            else {
                char firstLetter = str[0];
                char lastLetter = str[str.Length - 1];
                string newStr = str.Remove(0, 1);
                string newNewStr = lastLetter + newStr.Remove(newStr.Length - 1, 1) + firstLetter;
                Console.WriteLine(newNewStr);
            }
        }
    }
}