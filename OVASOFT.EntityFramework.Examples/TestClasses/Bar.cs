
using Ovasoft.Cofitools.Domain.Model.Abstracts;
using Ovasoft.Cofitools.Domain.Model;


namespace OVASOFT.EF.Examples.TestClasses;

public partial class Bar: AEntityRoot<Guid, ManyMany>, IParent<Guid, OneOne>, ICreatedBy<User>//, IModifiedBy<int,User>
{
    public DateTime CreationDate { get; set; }
    public int CreatedByUserId { get; set; }
    public User CreatedByUser { get; set; }
    Guid IParent<Guid, OneOne>.ParentId { get; set; }   // явная реализация части интерфейса IParent для связи One-One
    public OneOne Parent { get; set; }                  // неявная реализация части интерфейса IParent для связи One-One
}
