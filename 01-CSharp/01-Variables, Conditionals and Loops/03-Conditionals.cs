/*using System;

namespace Studies_On_CSharp
{
    public class Conditionals
    {
        static void Main(string[] args)
        {
            string age = Console.ReadLine();
            bool personAge = (int.Parse(age)) >= 18;
            Console.WriteLine("Is this person an Adult?");
            if (personAge) Console.WriteLine("{0}, it's an adult", personAge);    
            else Console.WriteLine("{0} it's a youth", personAge);

            //Scope
            int outScope = 10;
            if (true) {
                outScope = 20;
                string innerScope = "Inner";
            }
            //Can not access this scope
            //innerScope = "Outer";
            Console.WriteLine(outScope);
        }
    }
}*/