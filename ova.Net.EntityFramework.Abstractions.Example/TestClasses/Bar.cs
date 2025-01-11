
using OVASOFT.NET.EF.Onion.Abstractions.DomainModel;

namespace OVASOFT.NET.EF.Onion.Examples.TestClasses;

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
