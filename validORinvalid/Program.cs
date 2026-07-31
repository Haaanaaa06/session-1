using System.ComponentModel.Design;

namespace ConsoleApp130
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 1 && num < 10)
            { Console.WriteLine("Valid"); }
            else
            {
                Console.WriteLine("invalid");

            }
        }
    }
}
