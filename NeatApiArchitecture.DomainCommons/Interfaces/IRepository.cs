namespace NeatApiArchitecture.DomainCommons.Interfaces;

public interface IRepository<T>
{
	Task<T> AddAsync(T entity);
	T UpdateAsync(T entity);
	void Delete(T entity);
	Task<T?> GetByIdAsync(int id);
	Task<IEnumerable<T>> GetAllAsync();
}