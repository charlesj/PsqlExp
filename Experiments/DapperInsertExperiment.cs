using System;
using System.Data;
using System.Linq;
using Dapper;

namespace Experiments
{
	public class DapperInsertExperiment
	{
		public void Execute(IDbConnection connect)
		{
			var query = "select * from distributors";
			var results = connect.Query(query);
			var initialCount = results.Count();

			var name = Faker.NameFaker.Name();
			var insert = $"insert into distributors(name) values('{name}')";
			var result = connect.Execute(insert);

			var newResult = connect.Query(query);
			var newCount = newResult.Count();
			Console.WriteLine($"{initialCount} became {newCount}");
		}
	}
}
