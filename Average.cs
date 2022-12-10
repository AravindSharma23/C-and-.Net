using System;
class HelloWorld {
 public static  void Main() {
   string name;
   int tam,eng,mat,sci,soc,avg;
   Console.WriteLine("Enter your Name :");
   name = Console.ReadLine();
   Console.WriteLine("Enter your subjects marks :");
   tam = int.Parse(Console.ReadLine());
   eng = int.Parse(Console.ReadLine());
   mat = int.Parse(Console.ReadLine());
   sci = int.Parse(Console.ReadLine());
   soc = int.Parse(Console.ReadLine());
   avg = (tam+eng+mat+sci+soc)/5;
   Console.WriteLine("I am "+name+" and average is "+avg);
 }
}
