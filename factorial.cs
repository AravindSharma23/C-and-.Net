
using System;
class HelloWorld {
  static void Main() {
   Console.WriteLine("Enter a number :");
   int n = int.Parse(Console.ReadLine());
   int x = 1;
   for(int i = 1;i<=n;i++){
       x=x*i;
       
   }
   Console.WriteLine(x);
  }
}
