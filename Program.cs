using System;
/* не (не А и не В)и А
* не (не А или не В) или А
 * не (не А или не В) и В */
namespace ConsoleApplication5
{
    class Program
    {
        public static void Main (string[] args)
        {
            
            bool a;
            bool b;
            Console.WriteLine("Enter A");
             a = Convert.ToBoolean(Console.ReadLine());
            byte byteValue;
            byteValue = Convert.ToByte(a);
            Console.WriteLine("Enter B");
            b = Convert.ToBoolean(Console.ReadLine());
            byteValue = Convert.ToByte(b);
            Console.WriteLine("Значение равно: ", a, byteValue);
            Console.Write((!(!a && !b)) && a);
            Console.ReadKey();
        }
  
    }
}
