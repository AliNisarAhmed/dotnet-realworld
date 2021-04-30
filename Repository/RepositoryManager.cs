using Contracts;
using Entities;

namespace Repository
{
	public class RepositoryManager : IRepositoryManager
	{
		private RepositoryContext _repositoryContext;
		private IArticleRepository _articleRepository;

		public RepositoryManager(RepositoryContext repositoryContext)
		{
			_repositoryContext = repositoryContext;
		}

		public IArticleRepository Article
		{
			get
			{
				if (_articleRepository == null)
					_articleRepository = new ArticleRepository(_repositoryContext);

				return _articleRepository;
			}
		}

		public void Save() => _repositoryContext.SaveChanges();
	}
}