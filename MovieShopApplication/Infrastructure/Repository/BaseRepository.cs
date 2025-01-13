using ApplicationCore.Contracts;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class BaseRepository<T>: IRepository<T> where T: class
{
    private readonly MovieDbContext _movieDbContext;

    public BaseRepository(MovieDbContext movieDbContext)
    {
        this._movieDbContext = movieDbContext;
    }
    
    public int Delete(int id)
    {
        T obj = GetById(id);
        if (obj != null)
        {
            _movieDbContext.Set<T>().Remove(obj);
        }
        return _movieDbContext.SaveChanges();
    }
    
    public IEnumerable<T> GetAll()
    {
        return _movieDbContext.Set<T>().ToList();
    }

    public int Insert(T entity)
    {
        _movieDbContext.Set<T>().Add(entity);
        return _movieDbContext.SaveChanges();
    }

    public int Update(T entity, int id)
    {
        _movieDbContext.Set<T>().Entry(entity).State = EntityState.Modified;
        return _movieDbContext.SaveChanges();
    }

    public T GetById(int id)
    {
        return _movieDbContext.Set<T>().Find(id);
        // return movieDbContext.Set<T>().Where(x => x.Id == id).FirstOrDefault();
    }

    public IEnumerable<T> Search(Func<T, bool> predicate)
    {
        return _movieDbContext.Set<T>().Where(predicate);
    }
}