using System;
using System.Configuration;
using Npgsql;

namespace Experiments
{
	public class Program
	{
		public static void Main(string[] args)
		{
			RunDbup.Execute();
			var experiment = new DapperPostDbUpExperiment();
			experiment.Execute(GetConnection());
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
