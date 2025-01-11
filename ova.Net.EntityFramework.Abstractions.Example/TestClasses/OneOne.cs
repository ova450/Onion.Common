
using OVASOFT.NET.EF.Onion.Abstractions.DomainModel;

namespace OVASOFT.NET.EF.Onion.Examples.TestClasses;


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
