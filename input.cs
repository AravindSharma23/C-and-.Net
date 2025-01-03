using System;
class HelloWorld {
 public static  void Main() {
    int a,b,c;
    Console.WriteLine("Enter two nums :");
  // Input method-1
    a=int.Parse(Console.ReadLine());
    b=int.Parse(Console.ReadLine());
    c=a+b;
    
    Console.WriteLine("The total is :"+c);

  // Input method-2

  int i = Convert.ToInt32(Console.ReadLine());
double d = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("I " + i);
Console.WriteLine("D is " + d);
    
    }
}
