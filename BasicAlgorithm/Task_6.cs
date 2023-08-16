using System;

namespace Task_6 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Type your string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Type the character number you want to delete (starting with 0): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice <= str.Length)
                Console.WriteLine(str.Remove(choice, 1));
            else
                Console.WriteLine("Invalid choice");

            Console.ReadLine();
        }
    }
}