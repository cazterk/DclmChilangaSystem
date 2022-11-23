using Microsoft.EntityFrameworkCore;
using DclmChilangaSystem;
namespace DclmChilangaSystem.Models

{

    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }
        public DbSet<Adults> Adults => Set<Adults>();
        public DbSet<Youths> Youths => Set<Youths>();
        public DbSet<Children> Children => Set<Children>();
        public DbSet<Tithe> Tithe => Set<Tithe>();
        public DbSet<User> User => Set<User>();

    }
}