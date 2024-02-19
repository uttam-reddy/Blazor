﻿using BlazorAppDemo.Data;
using BlazorAppDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppDemo.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<Users> CreateUser(Users user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<List<Users>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
    }
}
