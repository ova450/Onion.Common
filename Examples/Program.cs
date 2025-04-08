
using Examples;

using Microsoft.EntityFrameworkCore;

using ApplicationDbContext db = new ();

string dbName = db.Database.GetDbConnection().Database.ToString();

Console.WriteLine(db.Database.EnsureCreated() ? $"Database {dbName} created." : $"Database {dbName} exist.");

//// Добавление новых объекта Foo и Bar
//db.Foos.Add(new Foo() { Name = "first" });
//db.Foos.Add(new Foo =  { Name = "second" });
//db.Bars.Add(new Bar() { FooId = db.Foos.OrderBy(f => f.Id).LastOrDefault().Id, Name = "third" });
//db.Bars.Add(new Bar() { FooId = db.Foos.OrderBy(f => f.Id).LastOrDefault().Id, Name = "forth" });
//db.SaveChanges();

//FooRepo fooRepo = new(db);
//BarRepo barRepo = new(db);

////fooRepo.Add(,);


//// и вывод
//var foo = db.Foos.FirstOrDefault(f => f.Id == 1);
//if (foo != null) Console.WriteLine($"Id: {foo.Id}, Name: {foo.Name}");
//else Console.WriteLine("foo with Id 1 not found.");

//foo = db.Foos.FirstOrDefault(f => f.Id == 2);
//if (foo != null) Console.WriteLine($"Id: {foo.Id}, Name: {foo.Name}");
//else Console.WriteLine("foo with Id 2 not found.");

//var bar = db.Bars.FirstOrDefault(f => f.Id == 1);
//if (bar != null) Console.WriteLine($"FooId: {bar.FooId}, Id: {bar.Id}, Name: {bar.Name}");
//else Console.WriteLine("bar with Id 1 not found.");

//bar = db.Bars.FirstOrDefault(f => f.Id == 2);
//if (bar != null) Console.WriteLine($"FooId: {bar.FooId} , Id:  {bar.Id} : {bar.Name}");
//else Console.WriteLine("bar with Id 2 not found.");




//// и вывод
//foo = fooRepo.Get(1); // db.Foos.FirstOrDefault(f => f.Id == 1);
//if (foo != null) Console.WriteLine($"Id: {foo.Id}, Name: {foo.Name}");
//else Console.WriteLine("foo with Id 1 not found.");

//foo = fooRepo.Get(2);
//if (foo != null) Console.WriteLine($"Id: {foo.Id}, Name: {foo.Name}");
//else Console.WriteLine("foo with Id 2 not found.");

//bar = barRepo.Get(1);
//if (bar != null) Console.WriteLine($"FooId: {bar.FooId}, Id: {bar.Id}, Name: {bar.Name}");
//else Console.WriteLine("bar with Id 1 not found.");

//bar = barRepo.Get(2);
//if (bar != null) Console.WriteLine($"FooId: {bar.FooId} , Id:  {bar.Id} : {bar.Name}");
//else Console.WriteLine("bar with Id 2 not found.");


///// <summary>The entity mapped to the database.</summary>
///// <remarks>1. The IEntity interface, from which this entity inherits, is not required,
///// but it performs two very important functions: it checks the type of identifier and
///// separates classes mapped to the database from other classes. You may need it next time.
///// 2. If you don't need a frequently used property Name, you can use the IEntityBase interface
///// instead IEntity.
///// 3. Main form of IEntity or IEntityBase interfaces is universal and consider type parameter.
///// By default (w/o type parameter) supposed Id type is int.</remarks>
//public class Foo: IEntity                                           // by default, type not required if Id is int
//{
//    /// <summary>
//    /// Получает или задает идентификатор объекта.
//    /// </summary>
//    [Key]                                                           // Identity, not required if Id
//    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]           // Autoincrement, at the discretion of the developer
//    public int Id { get; set; }

//    /// <summary>Gets or sets the name.</summary>
//    /// <value>The name.</value>
//    public string Name { get; set; }                        
//    //public ICollection<Bar> Bars { get; set; } = new List<Bar>(); // Инициализация коллекции
//}

//public class Bar: IEntity<int>, IParent<int, Foo>
//{
//    [Key]
//    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Autoincrement
//    public int Id { get; set; }

//    public string Name { get; set; }

//    int IParent<int, Foo>.ParentId { get; set; }
//    Foo IParent<int, Foo>.Parent { get; set; }

//    //// Реализация интерфейса IParent
//    //int IParent<int, Foo>.ParentId { get; set; }
//    //IEntityBase<int> IParent<int, Foo>.Parent { get; set; }

//    // Внешний ключ для связи с Foo
//    public int FooId
//    {
//        get => ((IParent<int, Foo>) this).ParentId;
//        set => ((IParent<int, Foo>) this).ParentId = value;
//    }

//    public Foo Foo
//    {
//        get => (Foo) ((IParent<int, Foo>) this).Parent;
//        set => ((IParent<int, Foo>) this).Parent = value;
//    }
//}

//public class ApplicationDbContext: DbContext
//{
//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=dbCobra3; Integrated Security=True");

//    public DbSet<Foo> Foos { get; set; }
//    public DbSet<Bar> Bars { get; set; }
//}

//public class FooRepo(DbContext context): RepositoryAbstract<Foo, int>(context) { }
//public class BarRepo(DbContext context): RepositoryAbstract<Bar, int>(context) { }


//class Foo2 : IEntity { }
//class Bar2 : IEntity <long> { long IEntity<long>.Id { get; set; } } 
//class FooBar2
//{
//    Foo2 foo2;
//    Bar2 bar2;

//    void Autoconvers()
//    {
//        bar2 = foo2;
//    }  
//}
