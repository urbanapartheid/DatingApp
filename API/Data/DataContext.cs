﻿using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        #region Properties
        public DbSet<AppUser> Users { get; set; }

        public DbSet<UserLike> Likes { get; set; }
        #endregion

        #region CTOR
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserLike>()
                .HasKey(k => new { k.SourceUserId, k.LikedUserId }); // create PK

            // Source user has many liked users
            // HasForeignKey => define FK
            // DeleteBehavio.NoAction => delete user -> delete related entity too.
            builder.Entity<UserLike>()
                .HasOne(s => s.SourceUser)
                .WithMany(l => l.LikedUsers)
                .HasForeignKey(s => s.SourceUserId)
                .OnDelete(DeleteBehavior.NoAction);

            // LikedUser: Collection of users who the currently logged in user likes
            // LikedByUser: Collection of users who like currently logged in user
            builder.Entity<UserLike>()
               .HasOne(s => s.LikedUser)
               .WithMany(l => l.LikedByUsers)
               .HasForeignKey(s => s.LikedUserId)
               .OnDelete(DeleteBehavior.NoAction);
        }
        #endregion
    }
}
