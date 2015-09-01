using System;
using System.Data;
using Dapper;

namespace Experiments
{
	public class SimpleDapperExperiment
	{
		public void Execute(IDbConnection connect)
		{
			var query = "select * from distributors";
			var results = connect.Query(query);
			foreach (var result in results)
			{
				Console.WriteLine($"{result.id} - {result.name}");
			}
		}
	}
}
