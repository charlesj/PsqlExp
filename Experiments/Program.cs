﻿using System;
using Npgsql;

namespace Experiments
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var query = "select * from distributors";

			var connstring = "Server=localhost;Port=5432;User Id=newton;Password=apple;Database=calculus;";

			var conn = new NpgsqlConnection(connstring);
			conn.Open();

			var command = new NpgsqlCommand(query, conn);
			var result = command.ExecuteReader();
			Console.WriteLine("result {0}", result.HasRows);
			conn.Close();

#if DEBUG
			Console.ReadLine();
#endif
		}
	}
}
