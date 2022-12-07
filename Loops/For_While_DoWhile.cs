//Nothing fancy just syntax for for and while

using System;
class HelloWorld {
  static void Main() {
     for(int j=1;j<20;j++)
           {
               Console.WriteLine(j*2); //prints multiple of 2
           }
    Console.WriteLine("Enter number < 15");
    int a = Convert.ToInt32(Console.ReadLine());
    while(a<15)
    {
        Console.WriteLine("In while loop "+a);
        a++;
    }
    
  }
}