using System;

namespace Entities.DTO
{
	public class ArticleDTO
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Slug { get; set; }
		public string Body { get; set; }
		public string CreatedAt { get; set; }
		public string UpdatedAt { get; set; }
		public string Description { get; set; }

		public string[] TagList { get; set; }

		// public int Author { get; set; }
		// public bool Favorited { get; set; }
		// public int FavoritesCount { get; set; }

		// public int ArticlesCount { get; set; }
	}
}