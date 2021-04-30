using Entities.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
	public class RepositoryContext : DbContext
	{
		public RepositoryContext(DbContextOptions options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AuthorConfiguration());
			modelBuilder.ApplyConfiguration(new ArticleConfiguration());
		}

		public DbSet<Article> Article { get; set; }
		public DbSet<Author> Author { get; set; }
	}
}