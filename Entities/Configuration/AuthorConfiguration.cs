using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
	public class AuthorConfiguration : IEntityTypeConfiguration<Author>
	{
		public void Configure(EntityTypeBuilder<Author> builder)
		{
			builder.HasData(
				new Author
				{
					Id = new Guid("c9d4c012-49b6-410c-bc78-2d54a9991870"),
					Username = "AliAhmed",
					Bio = "Software Developer",
					Image = "unspash.com"
				},
				new Author
				{
					Id = new Guid("c9d4c013-49b6-410c-bc78-2d54a9991870"),
					Username = "SamrahAkber",
					Bio = "Scheduling Coordinator",
					Image = "unspash.com"
				}
			);
		}
	}
}