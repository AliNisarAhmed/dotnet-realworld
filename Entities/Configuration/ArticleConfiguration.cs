using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
	public class ArticleConfiguration : IEntityTypeConfiguration<Article>
	{
		public void Configure(EntityTypeBuilder<Article> builder)
		{
			builder.HasData(
				new Article
				{
					Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
					Title = "Article 1",
					Body = "Article 1 body",
					CreatedAt = DateTimeOffset.UtcNow,
					UpdatedAt = DateTimeOffset.UtcNow,
					Description = "Article 1 description",
					Slug = "article / 1",
					TagList = new[] { "Tag1", "Tag2" },
				},
				new Article
				{
					Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
					Title = "Article 2",
					Body = "Article 2 body",
					CreatedAt = DateTimeOffset.UtcNow,
					UpdatedAt = DateTimeOffset.UtcNow,
					Description = "Article 2 description",
					Slug = "article / 2",
					TagList = new[] { "Tag3", "Tag4" },
				}
			);
		}
	}
}