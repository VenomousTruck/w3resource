using System;

namespace Task_5 {
    internal class Program {
        public static void Main(string[] args) {
            string str = Console.ReadLine();
            
            if (str[0] == 'i' && str[1] == 'f')
                Console.WriteLine(str);
            else {
                string newStr = "if ";
                Console.WriteLine(newStr + str);
            }

            Console.ReadLine();
        }
    }
}