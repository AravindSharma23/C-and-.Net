using System;
class HelloWorld {
  static void Main() {
      int tam,eng,mat,sci,soc;
      float avg;
      string Name;
    Console.WriteLine("Enter your Name :");
    Name = Console.ReadLine();
    Console.WriteLine("Enter your marks :");
    tam=int.Parse(Console.ReadLine());
    eng=int.Parse(Console.ReadLine());
    mat=int.Parse(Console.ReadLine());
    sci=int.Parse(Console.ReadLine());
    soc=int.Parse(Console.ReadLine());
    avg = (tam+eng+mat+sci+soc)/5;
    if((tam & eng & mat & sci & soc) >= 50){
        if(avg>= 90){
            Console.WriteLine($"{Name} scored {avg} percentage with O Grade");
        }
        else if(avg>90 && avg <= 80){
            Console.WriteLine($"{Name} scored {avg} percentage with A+ Grade");
    }
     else if(avg>80 && avg <= 70){
            Console.WriteLine($"{Name} scored {avg} percentage with A Grade");
    }
     else if(avg>70 && avg <= 60){
            Console.WriteLine($"{Name} scored {avg} percentage with B+ Grade");
    }
     else if(avg>60 && avg <= 50){
            Console.WriteLine($"{Name} scored {avg} percentage with B Grade");
    }
    
    
  }
    else{
        Console.WriteLine($"{Name} scored {avg} percentage and Fail");
    }
}
}

