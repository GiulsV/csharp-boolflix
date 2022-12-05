﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using csharp_boolflix.Models;

namespace csharp_boolflix.Data
{
    public class BoolflixDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<TVSeries> TvSeries { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<MediaInfo> MediaInfos { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Feature> Features { get; set; }

        public BoolflixDbContext(DbContextOptions<BoolflixDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
