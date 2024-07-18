namespace NicCRUDAPI.DAL.IRepository
{
    public interface IRepository<T>
    {
       Task<T> AddAsync(T entity);
    }
}
