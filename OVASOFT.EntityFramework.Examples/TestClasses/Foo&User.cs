
using Ovasoft.Cofitools.Domain.Model.Abstracts;
using Ovasoft.Cofitools.Domain.Model;

namespace OVASOFT.EF.Examples.TestClasses;

public partial class User: AEntity { }

public partial class Foo: AEntityRoot<Guid, Bar>, ICreatedBy<User>
{
    public DateTime CreationDate { get; set; }
    public int CreatedByUserId { get; set; }
    public User CreatedByUser { get; set; }
}
