using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
	public class Article
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Slug { get; set; }
		public string Body { get; set; }
		public DateTimeOffset CreatedAt { get; set; }
		public DateTimeOffset UpdatedAt { get; set; }
		public string Description { get; set; }

		public string[] TagList { get; set; }

		[ForeignKey(nameof(Author))]
		public Guid AuthorId { get; set; }
		public Author Author { get; set; }

		// public bool Favorited { get; set; }
		// public int FavoritesCount { get; set; }
	}
}