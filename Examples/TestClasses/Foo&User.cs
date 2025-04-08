
using BaikalNetHub.CodeFirst.Domain.Model;
using BaikalNetHub.CodeFirst.Domain.Model.Abstracts;

namespace BaikalNetHub.NET.EF.Onion.Examples.TestClasses;

public partial class User: AEntity { }

public partial class Foo: AEntityRoot<Guid, Bar>, ICreatedBy<User>
{
    public DateTime CreationDate { get; set; }
    public int CreatedByUserId { get; set; }
    public User CreatedByUser { get; set; }
}
