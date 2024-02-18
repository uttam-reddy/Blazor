﻿using BlazorAppDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppDemo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        public DbSet<Users> Users { get; set; }
    }
}
