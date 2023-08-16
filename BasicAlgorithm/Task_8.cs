using System;

namespace Task_8 {
    internal class Program {
        public static void Main(string[] args) {
            const int LIMIT = 4;
            Console.WriteLine("Type your string: ");
            string str = Console.ReadLine();
            if (str.Length < 2)
                Console.WriteLine(str);
            else {
                string newStr = "";
                for (int i = 0; i < LIMIT; i++) {
                     newStr += Convert.ToString(str[0]) + Convert.ToString(str[1]);
                }
                Console.WriteLine(newStr);
            }

            Console.ReadLine();
        }
    }
}