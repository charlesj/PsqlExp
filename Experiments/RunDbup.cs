using System;
using System.Configuration;
using System.Reflection;
using DbUp;

namespace Experiments
{
	public class RunDbup
	{
		public static void Execute()
		{
			var upgrader = DeployChanges.To
							.PostgresqlDatabase(ConfigurationManager.ConnectionStrings["calculus"].ConnectionString)
							.WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
							.LogToConsole()
							.Build();

			var result = upgrader.PerformUpgrade();
			Console.WriteLine(result.ToJson(true));
		}
	}
}
