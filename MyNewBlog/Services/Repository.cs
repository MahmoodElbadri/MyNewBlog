using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MyNewBlog.Data;

namespace MyNewBlog.Services;

public class Repository<T>:IRepository<T> where T : class
{
    private readonly ApplicationDbContext _db;
    internal readonly DbSet<T> _dbSet;
    public Repository(ApplicationDbContext db)
    {
        _db = db;
        _dbSet = _db.Set<T>();
    }

    public IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate = null, string? includeProperties = null)
    {
        IQueryable<T> query = _dbSet;
        if (predicate != null)
        {
            query = query.Where(predicate);
        }
        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var includeProperty in includeProperties
                         .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
        }
        return query.ToList();
    }

    public T Get(Expression<Func<T, bool>> predicate, string? includeProperties = null)
    {
        IQueryable<T> query = _dbSet;
        if (predicate != null)
        {
            query = query.Where(predicate);
        }
        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var includeProperty in includeProperties
                         .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
        }
        return query.FirstOrDefault();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity); 
    }

    public void Remove(T entity)
    {
        _dbSet.Remove(entity);      
    }
}