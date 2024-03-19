
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.DataRepository
{
    public class Repository : IRepository
    {
        private readonly DbContext context;

        public Repository(ApplicationDbContext _context)
        {
            context = _context;
        }

        private DbSet<T> DbSet<T>() where T : class 
            => context.Set<T>();

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        public void Add<T>(T entity) where T : class
        {
            context.Add<T>(entity);
        }

        public async Task SaveChangesAsync<T>() where T : class
        {
            await context.SaveChangesAsync();
        }
    }
}
