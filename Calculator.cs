using System;

namespace Muj_Vyborny_Program
{
   class Program
   {
    static void Main(string[] args)
   {
 double num01;
 double num02; //You can put anything like int num02; etc.. or even add num 03;

Console.Write("Input a number: ");
num01 = Convert.ToDouble(Console.ReadLine() );

Console.Write("Input a second number: ");
num02 = Convert.ToDouble(Console.ReadLine() );


double result = (num01 / num02); //you can change the '/' to anything else, you can change the double etc.. i will be making better calculator soon
Console.WriteLine("The result is " + result);

 Console.ReadKey();
   }

   }

}
