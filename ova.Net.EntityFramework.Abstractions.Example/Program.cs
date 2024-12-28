
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using ova.Net.EntityFramework.Abstractions.RepositoryPattern.Onion.Core.Domain.Model;

using ApplicationDbContext db = new ApplicationDbContext();

Console.WriteLine("using ApplicationDbContext db = new ApplicationDbContext();");

db.Database.EnsureCreated();
Console.WriteLine("db.Database.EnsureCreated();");

// Добавление нового объекта Foo
db.Foos.Add(new Foo() { Name = "first" });
db.Foos.Add(new Foo() { Name = "second" });
db.SaveChanges();

db.Bars.Add(new Bar() { FooId = db.Foos.OrderBy(f => f.Id).LastOrDefault().Id, Name = "third" });
db.Bars.Add(new Bar() { FooId = db.Foos.OrderBy(f => f.Id).LastOrDefault().Id, Name = "forth" });
db.SaveChanges();

Console.WriteLine("db.SaveChanges();");

// и вывод
var foo = db.Foos.FirstOrDefault(f => f.Id == 1);
if (foo != null) Console.WriteLine($"Id: {foo.Id}, Name: {foo.Name}");
else Console.WriteLine("foo with Id 1 not found.");

foo = db.Foos.FirstOrDefault(f => f.Id == 2);
if (foo != null) Console.WriteLine($"Id: {foo.Id}, Name: {foo.Name}");
else Console.WriteLine("foo with Id 2 not found.");

var bar = db.Bars.FirstOrDefault(f => f.Id == 1);
if (bar != null) Console.WriteLine($"FooId: {bar.FooId}, Id: {bar.Id}, Name: {bar.Name}");
else Console.WriteLine("bar with Id 1 not found.");

bar = db.Bars.FirstOrDefault(f => f.Id == 2);
if (bar != null) Console.WriteLine($"FooId: {bar.FooId} , Id:  {bar.Id} : {bar.Name}");
else Console.WriteLine("bar with Id 2 not found.");

public class Foo: IEntity<int>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Автоинкремент
    public int Id { get; set; }
    public string Name { get; set; }

    //public ICollection<Bar> Bars { get; set; } = new List<Bar>(); // Инициализация коллекции
}

public class Bar: IEntity<int>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Автоинкремент
    public int Id { get; set; }
    public string Name { get; set; }

    // Внешний ключ для связи с Foo
    public int FooId { get; set; }
    public Foo Foo { get; set; }
}

public class ApplicationDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=dbCobra1; Integrated Security=True");

    public DbSet<Foo> Foos { get; set; }
    public DbSet<Bar> Bars { get; set; }
}


//public interface IParent1<TId>: IEntityBase<TId> where TId : struct{    IEntity<TId> Parent { get; set; }}

//public interface IParent2<T, TId> where TId : struct where T : class, IEntityBase<TId> //: IParent1<T> 
//{
//    public TId NewParentId { get; set; }
//    public IParent1<TId> NewParent { get; set; }
//}


//public class Bar: IEntity<int>, IParent2<Foo, int>
//{
//    public string Name { get; set; }
//    public int Id { get; set; }

//    int IParent2<Foo, int>.NewParentId { get; set; }
//    IParent1<int> IParent2<Foo, int>.NewParent { get; set; }

//    public int NewParentId { get=>Newp; set; }
//    public IParent1<int> IParent2<Foo, int>.NewParent { get; set; }

//}
