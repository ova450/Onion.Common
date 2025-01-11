

namespace OVASOFT.NET.EF.Onion.Abstractions.DomainModel.TestClasses;

public class Bar:AEntityChildCreatedModified<Guid,Foo,int,User>, IChild<BarAdditional>
{
    public IList<BarAdditional> Childs { get; set; }
}
