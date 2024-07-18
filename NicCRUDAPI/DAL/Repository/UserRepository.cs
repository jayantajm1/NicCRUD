using Microsoft.EntityFrameworkCore;
using NicCRUDAPI.DAL.DBContext;
using NicCRUDAPI.DAL.Entity;
using NicCRUDAPI.DAL.IRepository;

namespace NicCRUDAPI.DAL.Repository
{
    public class UserRepository : Repository<User, blogContext>, IUserRepository
    {
        //private readonly IRepository _iRepository;
        private readonly blogContext _context;
        public UserRepository(blogContext context) : base(context) 
        {
          _context=context;
        }
       
    }
}
