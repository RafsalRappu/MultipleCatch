using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fNumber = { 8, 3, 4 };
            int[] sNumber = { 2, 0 };
            for (int j=0;j<fNumber.Length;j++)
                try
                {
                    Console.WriteLine("First Number :" + fNumber[j]);
                    Console.WriteLine("Second Number :" + sNumber[j]);
                    Console.WriteLine("Division :" + fNumber[j] / sNumber[j]);
                    Console.WriteLine("\n");
                }
                //First catch block
                catch(DivideByZeroException )
                {
                    Console.WriteLine("Not possible to divide by Zero");
                    Console.WriteLine("\n");
                }
                //Second catch block
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of range or no first or second number for calculation");
                    Console.WriteLine("\n");
                }
            Console.ReadKey();
        }
    }
}
