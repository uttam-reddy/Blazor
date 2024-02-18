using BlazorAppDemo.Models;

namespace BlazorAppDemo.Services
{
    interface IUserService
    {
        Task<List<User>> GetAllUsers();

    }
}
