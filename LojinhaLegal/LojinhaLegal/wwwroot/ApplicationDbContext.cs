﻿namespace LojinhaLegal.wwwroot
{
	using Microsoft.EntityFrameworkCore;

	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Produto> Produtos { get; set; }
	}

}
