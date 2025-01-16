
using Ovasoft.Cofitools.Domain.Model.Abstracts;
using Ovasoft.Cofitools.Domain.Model;
using OVASOFT.EF.Examples.TestClasses;

namespace Cofitools.Examples.TestClasses;


public partial class OneOne: AEntity<Guid>, IParent<Guid, Bar>
{
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
