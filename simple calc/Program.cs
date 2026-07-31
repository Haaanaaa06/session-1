namespace simple_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result;
            Console.WriteLine(" Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
           double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter the operator(+, -,*, or /)");
            char op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
            {
                result = num1 + num2;
                Console.WriteLine("the result =" + result);
            }
             else if (op == '-')
            {
                result = num1 - num2;
                Console.WriteLine("the result =" + result);
            }
            else if (op == '*')
            {
                result = num1 * num2;
                Console.WriteLine("the result =" + result);
            }
            else if (op == '/')
            {
                if (num2 == 0)
                { Console.WriteLine("Can't divide by zero "); }

                else

                {
                    result = num1 / num2;
                    Console.WriteLine("the result =" + result);
                }

            }
            else
            { Console.WriteLine("invalid operator"); }
        }
    }
}
        
