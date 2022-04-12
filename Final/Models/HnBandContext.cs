using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class HnBandContext : IdentityDbContext
    {
        public HnBandContext(DbContextOptions<HnBandContext> options) : base(options)
        {
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<BlogTags> BlogTags { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<AlbumTrack> Tracks { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tours> Tours { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<TourOrderItem> TourOrderItems { get; set; }
        public DbSet<TrackPlaylistItem> TrackPlaylistItems { get; set; }
    }
}
