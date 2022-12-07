using System;
using System.Text.RegularExpressions;
namespace JumpStatement{
    class JumpStatement
    {
        public static int add()
           {
            Console.WriteLine("Enter x and y");
               int x = Convert.ToInt32(Console.ReadLine());
               int y = Convert.ToInt32(Console.ReadLine());
               return x+y ;
           
            }
        public static void Main(string[] args)
        {
           for(int i=0;i<10;i++)
           {
               if(i==6)
                break;
            Console.WriteLine(i);
           }
           for(int j=11;j<20;j++)
           {
               if(j==13)
               continue;
               Console.WriteLine(j);
           }
           Console.WriteLine("Please provide number in between 1-5");
           int a = Convert.ToInt32(Console.ReadLine());
           switch(a)
           {
               case 1:
               case 2:
               case 3:Console.WriteLine("in Case 3"); goto default;
               case 4:
               case 5:goto case 3;
               default:
                    Console.WriteLine("print from default");
                    break;
           }
            int res = add();
           Console.WriteLine("Sum of given number is: "+res);
        }
}
}
