﻿using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoListApi.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; }
        
    }
}
