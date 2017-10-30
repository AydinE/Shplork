using System;

namespace ConsoleAppjeMaandag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PrintMethod();            

            String result = Console.ReadLine();

            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static void PrintMethod()
        {
            Console.WriteLine("Hai");
        }
    }
}
