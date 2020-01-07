using System;

namespace Studies_On_CSharp
{
public class Loops
{
   public static void Main(string[] args) { 
      //Do while
      int i = 10;
      do {
         Console.WriteLine("Always Prints");
         --i;
      } while (i > 0);

      string input = Console.ReadLine();
      int num = int.Parse(input);
      int factorial = 1;
      //for i
      for (int j = 1 ; j <= num ; j++) {
         factorial=factorial * j;
      }
      Console.WriteLine(factorial);
   }       
}
}