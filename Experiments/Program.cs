using System;
using System.Configuration;
using System.Reflection;
using DbUp;
using Npgsql;

namespace Experiments
{
	public class Program
	{
		public static void Main(string[] args)
		{

#if DEBUG
			Console.ReadLine();
#endif
		}

		private static NpgsqlConnection GetConnection()
		{
			var connString = ConfigurationManager.ConnectionStrings["calculus"].ConnectionString;
			return new NpgsqlConnection(connString);
		}
	}
}
