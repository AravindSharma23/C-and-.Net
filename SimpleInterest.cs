using System;
class HelloWorld {
 public static  void Main() {
    int p,n;
    float r = 0.80f,si ;
    Console.WriteLine("Enter a principle Amount :");
    p=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter a no of years :");
    n=Convert.ToInt32(Console.ReadLine());
    si = p*n*r/100;
    Console.WriteLine("The interest is "+si);
   
     
 }
}
