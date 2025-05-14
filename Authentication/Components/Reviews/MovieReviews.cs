using System;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Components.Reviews;

internal class MovieReviews : DbContext
{
	public DbSet<Movie> movies { get; set; }
	public MovieReviews()
	{
		Database.EnsureCreated();
	}
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite(@"Data Source=Reviews.db");
	}
}
