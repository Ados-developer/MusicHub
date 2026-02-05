using Microsoft.EntityFrameworkCore;
using MusicHub.Entities;
using MusicHub.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Data
{
    public class MusicHubDbContext : DbContext
    {
        public MusicHubDbContext(DbContextOptions<MusicHubDbContext> options)
        : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "Admin", PasswordHash = PasswordHelper.HashPassword("test"), Role = "Admin" },
                new User { Id = 2, UserName = "User", PasswordHash = PasswordHelper.HashPassword("test"), Role = "User" },
                new User { Id = 3, UserName = "PostMalone", PasswordHash = PasswordHelper.HashPassword("test"), Role = "Musician", ArtistName = "Post Malone" },
                new User { Id = 4, UserName = "Blink182", PasswordHash = PasswordHelper.HashPassword("test"), Role = "Musician", ArtistName = "Blink-182" },
                new User { Id = 5, UserName = "MachineGunKelly", PasswordHash = PasswordHelper.HashPassword("test"), Role = "Musician", ArtistName = "Machine Gun Kelly" }
                );
            modelBuilder.Entity<Album>().HasData(
                new Album { Id = 1, Title = "Hollywood's Bleeding", AuthorId = 3 },
                new Album { Id = 2, Title = "Beerbongs & Bentleys", AuthorId = 3 },
                new Album { Id = 3, Title = "Enema Of The State", AuthorId = 4 },
                new Album { Id = 4, Title = "Take Off Your Pants And Jacket", AuthorId = 4 },
                new Album { Id = 5, Title = "Lost Americana", AuthorId = 5 },
                new Album { Id = 6, Title = "Tickets To My Downfall", AuthorId = 5 }
                );
            modelBuilder.Entity<Song>().HasData(
                // Hollywood's Bleeding
                new Song { Id = 1, Title = "Hollywood’s Bleeding", AlbumId = 1 },
                new Song { Id = 2, Title = "Saint‑Tropez", AlbumId = 1 },
                new Song { Id = 3, Title = "Enemies (feat. DaBaby)", AlbumId = 1 },
                new Song { Id = 4, Title = "Allergic", AlbumId = 1 },
                new Song { Id = 5, Title = "A Thousand Bad Times", AlbumId = 1 },
                new Song { Id = 6, Title = "Circles", AlbumId = 1 },
                new Song { Id = 7, Title = "Die For Me (feat. Future & Halsey)", AlbumId = 1 },
                // Beerbongs & Bentleys
                new Song { Id = 8, Title = "Paranoid", AlbumId = 2 },
                new Song { Id = 9, Title = "Spoil My Night (feat. Swae Lee)", AlbumId = 2 },
                new Song { Id = 10, Title = "Rich & Sad", AlbumId = 2 },
                new Song { Id = 11, Title = "Zack and Codeine", AlbumId = 2 },
                new Song { Id = 12, Title = "Takin’ Shots", AlbumId = 2 },
                new Song { Id = 13, Title = "Rockstar (feat. 21 Savage)", AlbumId = 2 },
                new Song { Id = 14, Title = "Over Now", AlbumId = 2 },
                // Enema of the State
                new Song { Id = 15, Title = "Dumpweed", AlbumId = 3 },
                new Song { Id = 16, Title = "Don’t Leave Me", AlbumId = 3 },
                new Song { Id = 17, Title = "Aliens Exist", AlbumId = 3 },
                new Song { Id = 18, Title = "Going Away to College", AlbumId = 3 },
                new Song { Id = 19, Title = "What’s My Age Again?", AlbumId = 3 },
                new Song { Id = 20, Title = "Dysentery Gary", AlbumId = 3 },
                new Song { Id = 21, Title = "Adam’s Song", AlbumId = 3 },

                // Take Off Your Pants and Jacket
                new Song { Id = 22, Title = "Anthem Part Two", AlbumId = 4 },
                new Song { Id = 23, Title = "Online Songs", AlbumId = 4 },
                new Song { Id = 24, Title = "First Date", AlbumId = 4 },
                new Song { Id = 25, Title = "Happy Holidays, You Bastard", AlbumId = 4 },
                new Song { Id = 26, Title = "Story of a Lonely Guy", AlbumId = 4 },
                new Song { Id = 27, Title = "The Rock Show", AlbumId = 4 },

                // Tickets To My Downfall
                new Song { Id = 28, Title = "Title Song", AlbumId = 6 },
                new Song { Id = 29, Title = "Kiss Kiss", AlbumId = 6 },
                new Song { Id = 30, Title = "Drunk Face", AlbumId = 6 },
                new Song { Id = 31, Title = "Bloody Valentine", AlbumId = 6 },
                new Song { Id = 32, Title = "Forget Me Too (feat. Halsey)", AlbumId = 6 },
                new Song { Id = 33, Title = "All I Know (feat. Trippie Redd)", AlbumId = 6 },
                new Song { Id = 34, Title = "Lonely", AlbumId = 6 },
                // Lost Americana – Machine Gun Kelly
                new Song { Id = 35, Title = "Outlaw Overture", AlbumId = 5 },
                new Song { Id = 36, Title = "Cliché", AlbumId = 5 },
                new Song { Id = 37, Title = "Don’t Wait Run Fast", AlbumId = 5 },
                new Song { Id = 38, Title = "Goddamn", AlbumId = 5 },
                new Song { Id = 39, Title = "Vampire Diaries", AlbumId = 5 },
                new Song { Id = 40, Title = "Miss Sunshine", AlbumId = 5 },
                new Song { Id = 41, Title = "Sweet Coraline", AlbumId = 5 }
                );
        }
    }
}
