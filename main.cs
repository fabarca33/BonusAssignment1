using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("What is the length of side A?");

    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("What is the lenght of side B?");

    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("What is the lenght of side C?");

    int c = Convert.ToInt32(Console.ReadLine());

    if((a+b)>c && (a+c)>b && (b+c)>a)
    {
      Console.WriteLine("Triangle can be form.");

      if(a==b && b==c)
      {
        Console.WriteLine("The triangle is Equilateral.");
      }

      else if(a!=b && b!=c && a!=c)
      {
        Console.WriteLine("The triangle is Scalene.");
      }

      else
      {
        Console.WriteLine("The triangle is Isoceles.");
      }

    }

    else
    {
      Console.WriteLine("Triangle cannot be formed.");
    }
  }
}