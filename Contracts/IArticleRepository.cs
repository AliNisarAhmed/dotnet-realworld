using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
	public interface IArticleRepository
	{
		IEnumerable<Article> GetAllArticles(bool trackChanges);
	}
}