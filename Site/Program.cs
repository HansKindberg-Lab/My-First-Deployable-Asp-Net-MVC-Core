﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Site
{
	public class Program
	{
		#region Methods

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build();

		public static void Main(string[] args)
		{
			BuildWebHost(args).Run();
		}

		#endregion
	}
}