using System;

namespace LatihanOverloadingMethod
{
	public class Program
	{
		static void Main(string[] args)
		{
			Numbers numbers = new Numbers();

			Console.WriteLine("Minimum #1: {0}", numbers.FindMinimum(3, 1));
			Console.WriteLine("Minimum #2: {0}", numbers.FindMinimum(3, 2, 4));
			Console.WriteLine();
			Console.WriteLine("Minimum #1: {0}", numbers.FindMaximum(3, 1));
			Console.WriteLine("Minimum #2: {0}", numbers.FindMaximum(3, 2, 4));

		}
	}

}