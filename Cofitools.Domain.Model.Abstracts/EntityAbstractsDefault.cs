

using Ovasoft.Cofitools.Domain.Model;

namespace Ovasoft.Cofitools.Domain.Model.Abstracts;

public class AEntity: AEntity<int> { }

public class AEntityRoot<TChild>: AEntityRoot<int, TChild> where TChild : class, IEntityBase { }

public class AEntityChild<TParent>: AEntityChild<int, TParent> where TParent : class, IEntityBase { }

public class AEntityBetween<TParent, TChild>: AEntityBetween<int, TParent, TChild>
    where TParent : class, IEntityBase
    where TChild : class, IEntityBase
{ }