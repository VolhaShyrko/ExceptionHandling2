using System;

namespace ExceptionHandling2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "234", "", "This is Sparta", "1234.8", "23 " };

            foreach (var item in items)
            {
                Console.Write("Parsing '{0}' ... ", item);

                try
                {
                    Console.Write("Result is '{0}'", item.CustomIntParse());
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
