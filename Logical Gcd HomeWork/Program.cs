using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Gcd_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input NumberA : ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input NumberB : ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            if (numberB > numberA)
            {
                int tem = numberA;
                numberA = numberB;
                numberB = tem;
            }
            Console.WriteLine("GCD : {0} ", Gcd(numberA, numberB));
            Console.ReadLine();

        }
        static int Gcd(int numberA , int numberB) {
            if (numberB == 0)
                return numberA;
            return Gcd(numberB, numberA % numberB);
        }
    }
}
