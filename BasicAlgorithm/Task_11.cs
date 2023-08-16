using System;

namespace Task_11 {
    internal class Program {
        public static void Main(string[] args) {
            const int LIMIT = 3;
            Console.WriteLine("Enter your string here: ");
            string str = Console.ReadLine();

            if (str.Length < 3) {
                Console.WriteLine(str + str + str);
            }
            else {
                string newStr = str.Substring(0, 3);
                string result = newStr + str + newStr;
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}