using System.Linq.Expressions;

namespace MyNewBlog;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll
        (Expression<Func<T, bool>>? predicate = null, string? includeProperties = null);

    T Get
        (Expression<Func<T, bool>> predicate, string? includeProperties = null);

    void Add(T entity);
    void Remove(T entity);
}