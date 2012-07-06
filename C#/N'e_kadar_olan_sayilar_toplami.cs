using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = new int();
            int T = new int();
            Console.Write("N =");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= N; i++)
                T = T + i;
            Console.Write("\nToplam = {0}", T);
            Console.ReadKey();
        }
    }
}
