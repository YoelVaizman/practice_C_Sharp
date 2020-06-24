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

    }
  }
}
