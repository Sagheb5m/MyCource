using System;
namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
            Console.WriteLine("Enter Num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Additional:" + (num1 + num2));
            Console.ReadKey();
    }
  }
}
