using System;
using System.Configuration;
using Npgsql;

namespace Experiments
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var connection = GetConnection();
			var experiment = new DapperInsertExperiment();
			experiment.Execute(connection);

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
