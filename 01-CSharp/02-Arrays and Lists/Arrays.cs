using System;
//C# Lists are packaged into Collections
using System.Collections.Generic;
class Arrays {

  public static void Main(string[] args) {

    //Declaring a list
     var names = new List<string>{"Edward", "Julia", "Kevin", "Sarah"}; 
      //For each to iterate through collections
     foreach (var name in names){
        Console.WriteLine($"{name}"); 
     } 
     //Adding in a list
     names.Add("Johnny Cash");
     //Removing from a list by index
     names.RemoveAt(1);
     //Explicit remove
     names.Remove("Edward");
     Console.WriteLine('\n');
     //Fiding an element index
     var index = names.IndexOf("Sarah");
     //for each lambda
     names.ForEach(name => Console.WriteLine(name));
     Console.WriteLine($"Found Sarah at: {index}");
     //Sorting Alphabeticaly
     names.Sort();
     names.ForEach(name => Console.WriteLine(name));
    
     var fibonnacci = new List<int>{0,1,1};
     for (int i = fibonnacci.Count;i <= 21; i++){
        fibonnacci.Add(fibonnacci[i-1] + fibonnacci[i-2]);
     }
     fibonnacci.ForEach(n => Console.WriteLine($"{n}"));
    //Array declaration 
    var array = {1,2,3,4,5};
    for (int i = array.Length -1;i>=0; i--)
    {
       Console.WriteLine(array[i]); 
    }
  }
}