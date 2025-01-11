

using Microsoft.EntityFrameworkCore;

namespace OVASOFT.NET.EF.Onion.Abstractions.DomainModel.TestClasses;

public class ApplicationDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=dbCobra3; Integrated Security=True");

    public DbSet<Foo> Foos { get; set; }
    public DbSet<Bar> Bars { get; set; }
}
 