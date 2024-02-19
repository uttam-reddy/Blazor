using BlazorAppDemo.Models;

namespace BlazorAppDemo.Services
{
    interface IUserService
    {
        Task<List<Users>> GetAllUsers();
        Task<Users> CreateUser(Users user);
    }
}
