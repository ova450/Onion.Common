
using OVASOFT.NET.EF.Onion.Abstractions.DomainModel;

namespace OVASOFT.NET.EF.Onion.Examples.TestClasses;


public partial class ManyMany: IEntity<Guid>, IChild<Bar>
{
    public Guid Id { get; set; }
    public ICollection<Bar> Childs { get; set; }
}
