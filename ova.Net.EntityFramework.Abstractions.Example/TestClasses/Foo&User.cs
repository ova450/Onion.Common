
using OVASOFT.NET.EF.Onion.Abstractions.DomainModel;
using OVASOFT.NET.EF.Onion.Abstractions.DomainModel.Abstracts;

namespace OVASOFT.NET.EF.Onion.Examples.TestClasses;

public partial class User: AEntity { }

public partial class Foo: AEntityRoot<Guid,Bar>, ICreatedBy<User>
    {
    public DateTime CreationDate { get; set; }
    public int CreatedByUserId { get; set; }
    public User CreatedByUser { get; set; }
}
