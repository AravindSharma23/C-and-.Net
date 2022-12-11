
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter any nums between 1 to 5 :");
    string x = Console.ReadLine();
    switch (x){
        case "one":
        Console.WriteLine("1");
        break;
        case "two":
        Console.WriteLine("2");
        break;
        case "three":
        Console.WriteLine("3");
        break;
        case "four":
        Console.WriteLine("4");
        break;
        case "five":
        Console.WriteLine("5");
        break;
        default:
        Console.WriteLine("Entered wrong");
        break;
    }
  }
}
