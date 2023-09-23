using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Start typing... :");
    string count = Console.ReadLine();

    if (count.Length <= 140){
      Console.WriteLine("Posted.");
      }
    else {
      Console.WriteLine("Rejected");
      }
  }
}