
namespace OVASOFT.NET.EF.Onion.Abstractions.DomainModel;

public class AEntity<TEntityId>: IEntity<TEntityId> where TEntityId : struct
{
    public TEntityId Id { get; set; }
}
public class AEntityChild<TEntityId, TParent>: 
    AEntity<TEntityId>, 
    IParent<TEntityId, TParent>
    where TEntityId : struct
    where TParent : class, IEntity
{
    public TEntityId ParentId { get; set; }
    public TParent Parent { get; set; }
}
public class AEntityChildCreated<TEntityId, TParent, TUserId,TUser>: 
    AEntityChild<TEntityId,TParent>, 
    ICreatedBy<TUserId,TUser>  
    where TUserId : struct
    where TUser : class, IEntity
    where TEntityId : struct
    where TParent : class, IEntity
{
    public DateTime CreationDate { get; set; }
    public TUserId CreatedByUserId { get; set; }
    public TUser CreatedByUser { get; set; }
}
public class AEntityChildCreatedModified<TEntityId, TParent, TUserId, TUser>:
    AEntityChildCreated<TEntityId, TParent, TUserId, TUser>,
    IModifiedBy<TUserId, TUser>
    where TUserId : struct
    where TUser : class, IEntity
    where TEntityId : struct
    where TParent : class, IEntity
{
    public DateTime ModificationDate { get; set; }
    public TUserId ModifiedByUserId { get; set; }
    public TUser ModifiedByUser { get; set; }
}
