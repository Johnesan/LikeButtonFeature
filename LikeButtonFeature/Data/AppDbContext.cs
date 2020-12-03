﻿using LikeButtonFeature.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Like> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Like>()
            .HasIndex(x => new { x.ArticleId, x.UserId })
            .IsUnique();

            builder.Entity<Article>().HasIndex(x => x.Id);

            //Seed data...
            builder.Entity<Article>().HasData(
                new Article
                {
                    Id = 1,
                    Title = "Article One",
                    Message = "Message One",
                    DateCreated = DateTime.Now,
                    LikeCount = 0
                },
                new Article
                {
                    Id = 2,
                    Title = "Article Two",
                    Message = "Message Two",
                    DateCreated = DateTime.Now,
                    LikeCount = 0
                },
                new Article
                { 
                    Id = 3,
                    Title = "Article Three",
                    Message = "Message Three",
                    DateCreated = DateTime.Now,
                    LikeCount = 0
                },
                new Article
                {
                    Id = 4,
                    Title = "Article Four",
                    Message = "Message Four",
                    DateCreated = DateTime.Now,
                    LikeCount = 0
                });

            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "User One",
                    DateCreated = DateTime.Now,
                },
                new User
                {
                    Id = 2,
                    Username = "User Two",
                    DateCreated = DateTime.Now,
                });
        }
    }

}
