using Microsoft.EntityFrameworkCore;

using BaikalNetHub.NET.EF.Onion.Examples.TestClasses;

namespace Examples;

public class ApplicationDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=dbCobra.9.6.36.6; Integrated Security=True");

    public DbSet<Foo> Foos { get; set; }
    public DbSet<Bar> Bars { get; set; }
    public DbSet<Foo1> Foo1s { get; set; }
    public DbSet<Bar1> Bar1s { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<OneOne> OO { get; set; }
    public DbSet<ManyMany> MM { get; set; }
}
