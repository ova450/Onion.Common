using OVASOFT.NET.EF.Onion.Abstractions.DomainModel;

public interface ICreatedBy<TUserId, TUser>
  where TUserId : struct
  where TUser : class, IEntityBase
{
    DateTime CreationDate { get; set; }
    TUserId CreatedByUserId { get; set; }
    TUser CreatedByUser { get; set; }
}

public interface ICreatedBy<TUser>: ICreatedBy<int,TUser>  where TUser : class, IEntityBase { }

public interface IModifiedBy<TUserId, TUser>
    where TUserId : struct
    where TUser : class, IEntityBase
{
    DateTime ModificationDate { get; set; }
    TUserId ModifiedByUserId { get; set; }
    TUser ModifiedByUser { get; set; }
}

public interface IModifiedBy<TUser> : IModifiedBy<int,TUser>  where TUser : class, IEntityBase { }

