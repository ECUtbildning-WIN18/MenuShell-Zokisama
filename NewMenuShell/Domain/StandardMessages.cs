using System;

namespace NewMenuShell.Domain
{
    public class StandardMessages
    {
        public static void LoginFail()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===============================\n" +
                              "\n" +
                              "========= Login Failed ========\n" +
                              "\n" +
                              "===============================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void RedMessage(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===============================\n" +
                              "\n" +
                              $" {message} " +
                              "\n" +
                              "\n" +
                              "===============================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}