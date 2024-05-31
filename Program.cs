using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Bir proqram yazın ki, istifadəçinin daxil etdiyi rəqəmin faktorialını hesablasın.(while ilə)
                Console.WriteLine("Please enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            while (a > 0)
            {
                fact *= a;
                a--;
            }
            Console.WriteLine($" ededin faktoriali {fact}");









        }

    }
}
