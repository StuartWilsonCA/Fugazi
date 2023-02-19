using System;
using Fugazi.Models;
using Microsoft.EntityFrameworkCore;

namespace Fugazi.Data
{
	public class ApplicationDbContext: DbContext
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
		{

		}

		public DbSet<Person> testtb { get; set; }


	}
}

