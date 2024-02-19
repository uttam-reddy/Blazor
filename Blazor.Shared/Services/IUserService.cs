using Blazor.Shared.Models;

namespace Blazor.Shared.Services
{
    public interface IUserService
    {
        Task<List<Users>> GetAllUsers();
        Task<Users> CreateUser(Users user);
    }
}
