using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
	{
	class Cember
		{
		static void Main(string[] args)
		{
		const double piii = 3.14;
		double r = new double();
		double alan = new double();
		double cevre = new double();
		Console.Write("Yarı çap = ");
		r = Convert.ToDouble(Console.ReadLine());
		alan = piii * r * r;
		cevre = 2 * piii * r;
		Console.Write("\nAlan = {0}\n", alan);
		Console.Write("\nÇevre = {0}", cevre);
		Console.ReadKey();
		}
		}
	}
