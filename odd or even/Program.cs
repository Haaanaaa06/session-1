namespace assesment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("EVEN");

            }
            else
            {
                Console.WriteLine("ODD");
            }
        }
    }
}