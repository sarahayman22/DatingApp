using API.Entities;
using Microsoft.EntityFrameworkCore;
//when using a class in deffrent namespace we use using key world

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
   public DbSet<AppUser> Users { get; set; }
}
