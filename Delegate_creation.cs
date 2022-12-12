
using System;
class HelloWorld {
     public delegate int Addition(int a, int b);
  public static void Main(string[] args) {
  
   Addition a = new Addition(sum);
   Console.WriteLine(a(23,22));
  }
  static int sum(int a, int b){
      return a+b;
  }
}
