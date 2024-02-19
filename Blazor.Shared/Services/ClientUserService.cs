using Blazor.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Shared.Services
{
    public class ClientUserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public ClientUserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Users> CreateUser(Users user)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/users",user);
            return await result.Content.ReadFromJsonAsync<Users>();

        }

        public Task<List<Users>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
