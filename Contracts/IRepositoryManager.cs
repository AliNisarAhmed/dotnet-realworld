namespace Contracts
{
	public interface IRepositoryManager
	{
		IArticleRepository Article { get; }
		void Save();
	}
}