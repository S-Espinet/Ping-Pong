using System;
using System.Collections.Generic;
using PingPong.Models;

namespace StupidProgram {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter something already, jeez");
      Console.Write(":");

      
      string input = Console.ReadLine();
      int intInput;
      try
      {
        intInput = int.Parse(input);
      }
      catch (Exception ex)
      {
        if (ex is FormatException || ex is OverflowException)
        {
          Console.WriteLine(ex);
          Console.WriteLine("Do it right, ya dingus!");
          return;
        }
        throw;
      }

      if (intInput < 1) {
        Console.WriteLine("Please enter a positive number");
        return;
      }

      List<string> display = Pong.ping(intInput);

      foreach(string d in display) {
        Console.WriteLine(d);
      }
    }
  }
}