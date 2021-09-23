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

        public DbSet<FE_FinalProject.Models.About> Abouts { get; set; }

        public DbSet<FE_FinalProject.Models.Resume> Resume { get; set; }

        public DbSet<FE_FinalProject.Models.Portofolio> Portofolio { get; set; }

        public DbSet<FE_FinalProject.Models.Technologies> Technologies { get; set; }
    }
}