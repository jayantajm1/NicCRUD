using NicCRUDAPI.Models;

namespace NicCRUDAPI.BAL.IServices
{
    public interface IUserService
    {
        Task<bool> CreateUserAsync(UserModel user);
    }
}
