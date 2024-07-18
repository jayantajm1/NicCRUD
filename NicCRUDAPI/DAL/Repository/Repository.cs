using Microsoft.EntityFrameworkCore;
using NicCRUDAPI.DAL.IRepository;

namespace NicCRUDAPI.DAL.Repository
{
    public class Repository<T ,TContext> :IRepository <T> where T : class where TContext : DbContext
    {
        private readonly TContext _context;


        public Repository(TContext context) 
        {
            _context = context;
        }

      
        public async Task<T> AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity; 
        }
    }
    }

