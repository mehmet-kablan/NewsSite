﻿using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options) : base(options)
        {
        }

        public DbSet<News> News { get; set; }
    }
}