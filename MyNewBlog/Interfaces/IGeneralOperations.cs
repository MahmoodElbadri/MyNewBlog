namespace MyNewBlog;

public interface IGeneralOperations<T>
{
    Task<T> GetByIDAsync<T>(Guid id);
    Task<IEnumerable<T>>GetAllAsync<T>();
    Task AddAsync<T>(T entity);
    Task UpdateAsync<T>(T entity);
    Task DeleteAsync<T>(T entity);
}