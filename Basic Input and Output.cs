// In this code we demo how to print and take user inputs in C#

using System;
namespace I/O
{
    class InputOutput{
        public static Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            var pwd=Console.ReadLine();
            Console.WriteLine("Hi {0}, you password is {1}",name,pwd);
        }
    }
}