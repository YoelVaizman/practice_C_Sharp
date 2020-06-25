using System;

namespace HelloWorld
{
  class Program
  {
    
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("Enter something please:");
      string result = Console.ReadLine();
      Console.WriteLine("You entered: {0}",result);
      Console.WriteLine("Do you want To leave the program (yes): ");
      result = Console.ReadLine();
      while (result != "yes")
        {
            Console.WriteLine("Invalid input! ");
            Console.WriteLine("Do you want To leave the program (yes): ");
            result = Console.ReadLine();
        }
     

    }
  }
}
