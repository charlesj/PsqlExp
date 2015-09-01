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
			var upgrader = DeployChanges.To
				.PostgresqlDatabase(ConfigurationManager.ConnectionStrings["calculus"].ConnectionString)
				.WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
				.LogToConsole()
				.Build();

			var result = upgrader.PerformUpgrade();
			Console.WriteLine(result.ToJson(true));
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
