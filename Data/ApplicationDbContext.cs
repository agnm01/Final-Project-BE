// <copyright file="ApplicationDbContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FE_FinalProject
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<FE_FinalProject.Models.Profile> Profile { get; set; }

        public DbSet<FE_FinalProject.Models.Skill> Skill { get; set; }

        public DbSet<FE_FinalProject.Models.Tool> Tool { get; set; }

        public DbSet<FE_FinalProject.Models.Workplace> Workplace { get; set; }
    }
}