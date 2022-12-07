//Below code validate password matcher for given user password

using System;
using System.Text.RegularExpressions;
namespace passwordmatch{
    class passwordmatcher
    {
        public static Main(string[] args)
        {
            Console.WriteLine("Please Enter a Strong AlphaNumeric Password");
            var password = Console.ReadLine();
            var pattern="([A-Za-z0-9@!#$%]{12,})";
            Regex re = new Regex(pattern);
            if (re.IsMatch(password))
            Console.WriteLine("Password is Strong");
            else
            Console.WriteLine("Password is Not Strong");

        }
    }
}