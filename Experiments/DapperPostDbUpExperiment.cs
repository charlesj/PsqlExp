using System;
using System.Data;
using System.Linq;
using Dapper;

namespace Experiments
{
	public class DapperPostDbUpExperiment
	{
		public void Execute(IDbConnection connect)
		{
			var query = "select * from users";
			var results = connect.Query(query);
			var initialCount = results.Count();

			var name = Faker.NameFaker.Name();
			var insert = $"insert into users(name) values('{name}')";
			var result = connect.Execute(insert);

			var newResult = connect.Query(query);
			var newCount = newResult.Count();
			Console.WriteLine($"{initialCount} became {newCount}");
		}
	}
}
