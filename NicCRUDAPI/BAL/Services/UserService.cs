using NicCRUDAPI.DAL.IRepository;
using AutoMapper;
using NicCRUDAPI.BAL.IServices;
using NicCRUDAPI.Models;
using NicCRUDAPI.DAL.Entity;
namespace NicCRUDAPI.BAL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        public async Task<bool> CreateUserAsync(UserModel user)
        {
            User abc = _mapper.Map<User>(user);
            await _userRepository.AddAsync(abc);
            return true;
        }
    }
}
