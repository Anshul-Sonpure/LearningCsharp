// Code demo to demonstrate switch Statement 

using System;
namespace calc
{
    class Calculator
    {
        public static Main(string[] args)
        {
            Console.WriteLine("Please provide any following operation(+,-,/,*)");
            string symbol = Console.ReadLine();
            Console.WriteLine("Please provide values to a and b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int res;
            switch (symbol)
            {
                case "+":
                    res = a + b;
                    Console.WriteLine("Addition of a and b "+res);
                    break;
                case "-":
                    res = a-b;
                    Console.WriteLine("Substraction of a and b "+res);
                    break;
                case "/":
                    res = a/b;
                    Console.WriteLine("Division of a and b "+res);
                    break;
                case "*":
                    res = a*b;
                    Console.WriteLine("Multiplication of a and b "+res);
                    break;
                default:
                    Console.WriteLine("Invalid Operation selected");
                    break;
            }
        }
    }
}
