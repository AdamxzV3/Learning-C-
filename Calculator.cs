using System;

namespace Muj_Vyborny_Program
{
   class Program
   {
    static void Main(string[] args)
   {
 double num01;
 double num02;
 double num03;

Console.Write("Input a number: ");
num01 = Convert.ToDouble(Console.ReadLine() );

Console.Write("Input a second number: ");
num02 = Convert.ToDouble(Console.ReadLine() );

Console.Write("Input a number: ");
num03 = Convert.ToDouble(Console.ReadLine() );


double result = (num01 / num02 / num03)/3;
Console.WriteLine("The result is " + result);

 Console.ReadKey();
   }

   }

}