using System;
using MyCalc;

namespace helloapp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello User!");
			Console.WriteLine("Welcome to Jenkins");

			Calc calc = new Calc();

			Console.WriteLine($"Sum = {calc.Add(70, 80)}");
			Console.WriteLine($"Multiply = {calc.Multiply(4, 5)}");
			Console.WriteLine($"Subtract={calc.subtract(7,4)}");
			Console.ReadLine();
		}
	}
}
