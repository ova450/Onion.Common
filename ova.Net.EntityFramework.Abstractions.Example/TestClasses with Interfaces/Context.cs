

using Microsoft.EntityFrameworkCore;

namespace OVASOFT.NET.EF.Onion.Examples.TestClasses.WithInterfaces;

public class ApplicationDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=dbCobra.9.1.25.2; Integrated Security=True");

    public DbSet<Foo> Foos { get; set; }
    public DbSet<Bar> Bars { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<OneOne> OO { get; set; }
    public DbSet<ManyMany> MM { get; set; }
}
