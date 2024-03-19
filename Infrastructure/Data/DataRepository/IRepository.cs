namespace Infrastructure.Data.DataRepository
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;

        IQueryable<T> AllReadOnly<T>() where T : class;

        void Add<T>(T entity) where T : class;

        Task SaveChangesAsync<T>() where T : class;
    }
}
