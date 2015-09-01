using System;

namespace Experiments
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello");
#if DEBUG
			Console.ReadLine();
#endif
		}
	}
}
