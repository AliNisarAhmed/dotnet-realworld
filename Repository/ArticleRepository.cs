using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
	public class ArticleRepository : RepositoryBase<Article>, IArticleRepository
	{
		public ArticleRepository(RepositoryContext repositoryContext) : base(repositoryContext)
		{
		}

		public IEnumerable<Article> GetAllArticles(bool trackChanges) =>
			FindAll(trackChanges)
			.OrderBy(article => article.UpdatedAt)
			.ToList();
	}
}