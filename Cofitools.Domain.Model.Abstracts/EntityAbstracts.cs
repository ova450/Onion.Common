

using System.Collections.Generic;

namespace Ovasoft.Cofitools.Domain.Model.Abstracts;

public class AEntity<TEntityId>: IEntity<TEntityId> where TEntityId : struct
{
    public TEntityId Id { get; set; }
}


public class AEntityRoot<TEntityId, TChild>: AEntity<TEntityId>, IChild<TChild>
    where TEntityId : struct
    where TChild : class, IEntityBase
{
    public ICollection<TChild> Childs { get; set; }
}

public class AEntityChild<TEntityId, TParent>: AEntity<TEntityId>, IParent<TEntityId, TParent>
    where TEntityId : struct
    where TParent : class, IEntityBase
{
    public TEntityId ParentId { get; set; }
    public TParent Parent { get; set; }
}
public class AEntityBetween<TEntityId, TParent, TChild>: AEntityChild<TEntityId, TParent>, IChild<TChild>
    where TEntityId : struct
    where TParent : class, IEntityBase
    where TChild : class, IEntityBase
{
    public ICollection<TChild> Childs { get; set; }
}