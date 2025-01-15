
//using Ovasoft. OVASOFT.NET.EF.Onion.Abstractions.DomainModel;

using Ovasoft.Cofitools.Domain.Model;

namespace OVASOFT.NET.EF.Onion.Examples.TestClasses.WithInterfaces;

public partial class User: IEntity { public int Id { get; set; } }

public partial class Foo: IEntity<Guid>, IChild<Bar>, ICreatedBy<User>
    {
    public Guid Id { get; set; }
    public ICollection<Bar> Childs { get; set; }
    public DateTime CreationDate { get; set; }
    public int CreatedByUserId { get; set; }
    public User CreatedByUser { get; set; }
}

public partial class Bar: IEntity<Guid>, IChild<ManyMany>, IParent<Guid, OneOne>, ICreatedBy<User>//, IModifiedBy<int,User>
{
    public Guid Id { get; set; }
    public ICollection<ManyMany> Childs { get; set; }
    public DateTime CreationDate { get; set; }
    public int CreatedByUserId { get; set; }
    public User CreatedByUser { get; set; }
    Guid IParent<Guid, OneOne>.ParentId { get; set; }   // явная реализация части интерфейса IParent для связи One-One
    public OneOne Parent { get; set; }                  // неявная реализация части интерфейса IParent для связи One-One
}

public partial class OneOne: IEntity<Guid>, IParent<Guid, Bar>
{
    public Guid Id { get; set; }

    public Bar Bars
    {
        get => ((IParent<Guid, Bar>) this).Parent;
        set => ((IParent<Guid, Bar>) this).Parent = value;
    }
    public Guid BarId
    {
        get => ((IParent<Guid, Bar>) this).ParentId;
        set => ((IParent<Guid, Bar>) this).ParentId = value;
    }

    Bar IParent<Guid, Bar>.Parent { get; set; }
    Guid IParent<Guid, Bar>.ParentId { get; set; }
}

public partial class ManyMany: IEntity<Guid>, IChild<Bar>
{
    public Guid Id { get; set; }
    public ICollection<Bar> Childs { get; set; }
}
