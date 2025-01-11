using OVASOFT.NET.EF.Onion.Abstractions.DomainModel;

public interface ICreatedBy<TUserId, TUser>
  where TUserId : struct
  where TUser : class, IEntity
{
    DateTime CreationDate { get; set; }
    TUserId CreatedByUserId { get; set; }
    TUser CreatedByUser { get; set; }
}

public interface ICreatedBy<TUser>
  where TUser : class, IEntity
{
    DateTime CreationDate { get; set; }
    int CreatedByUserId { get; set; }
    TUser CreatedByUser { get; set; }
}

public interface IModifiedBy<TUserId, TUser>
    where TUserId : struct
    where TUser : class, IEntity
{
    DateTime ModificationDate { get; set; }
    TUserId ModifiedByUserId { get; set; }
    TUser ModifiedByUser { get; set; }
}

public interface IModifiedBy< TUser>
    where TUser : class, IEntity
{
    DateTime ModificationDate { get; set; }
    int ModifiedByUserId { get; set; }
    TUser ModifiedByUser { get; set; }
}

