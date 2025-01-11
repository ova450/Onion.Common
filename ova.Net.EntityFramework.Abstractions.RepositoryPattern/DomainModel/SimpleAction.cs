
namespace OVASOFT.NET.EF.Onion.Abstractions.DomainModel;

public interface IActionDate
{
    DateTime ActionDate { get; set; }
}

public interface IUser<TUserId, TUser>
    where TUserId : struct
    where TUser : class, IEntity
{
    TUserId UserId { get; set; }
    TUser User { get; set; }
}


//public interface IAction<TUserId, TUser>: IUser<TUserId, TUser>, IActionDate
//    where TUserId : struct
//    where TUser : class, IEntity
//{ }

public abstract class AAction<TEntityId, TEntity, TUserId, TUser>: 
    IEntity<TEntityId>, 
    IParent<TEntityId, TEntity>, 
    ICreatedBy<TUserId, TUser>, 
    IModifiedBy<TUserId, TUser>, 
    IChild<Chi>
    where TEntityId : struct
    where TUserId : struct
    where TUser : class, IEntity
    where TEntity : class, IEntity
{
    public TEntityId Id { get; set; }
    TEntityId IParent<TEntityId, TEntity>.ParentId { get; set; }
    TEntity IParent<TEntityId, TEntity>.Parent { get; set; }

    // Внешний ключ для связи с Foo
    public int FooId
    {
        get => ((IParent<int, Foo>) this).ParentId;
        set => ((IParent<int, Foo>) this).ParentId = value;
    }

    //public TEntityId Id { get; set; }
    //TEntityId IParent<TEntityId, TEntity>.ParentId { get; set; }
    //TEntity IParent<TEntityId, TEntity>.Parent { get; set; }

    //////IParent<TEntityId, TEntity>.ParentId
    ////public TEntityId NewparentId 
    ////{ 
    ////    get => IParent<TEntityId, TEntity>.ParentId; 
    ////    set => ParentId = value;
    ////}
    //////IParent<TEntityId, TEntity>. { get; set; }
    //////TEntity IParent<TEntityId, TEntity>.Parent { get; set; }
    public abstract DateTime CreationDate { get; set; }
    public abstract TUserId CreatedByUserId { get; set; }
    public abstract TUser CreatedByUser { get; set; }
    public abstract DateTime ModificationDate { get; set; }
    public abstract TUserId ModifiedByUserId { get; set; }
    public abstract TUser ModifiedByUser { get; set; }
    public abstract IList<Chi> Childs { get; set; }
}


public class Bar: AAction<int, Foo, int, Chi> 
{
    public override DateTime CreationDate { get; set; }
    public override int CreatedByUserId { get; set; }
    public override Chi CreatedByUser { get; set; }
    public override DateTime ModificationDate { get; set; }
    public override int ModifiedByUserId { get; set; }
    public override Chi ModifiedByUser { get; set; }
    public override IList<Chi> Childs { get; set; }
}

//class vv
//{
//    Bar bar;
//    void main()
//    {
//        bar.
//    }
//}


////public enum ActionEnum { Created, LastModified, Cleaned }
//public class User: IEntity { public int Id { get; set; } }
//public class Foo: IEntity { public int Id { get; set; } }
//public class Chi: IEntity { public int Id { get; set; } }

//public class Bar: IAction<int,Foo,int,Chi> //IEntity<int>,IParent<int,Foo>, ICreatedBy<int,User>,IModifiedBy<int,User>,IChild<Chi>
//{
//    public int Id { get; set; }
//    public int ParentId { get; set; }
//    public Foo Parent { get; set; }
//    public DateTime CreationDate { get; set; }
//    public int CreatedByUserId { get; set; }
//    public Chi CreatedByUser { get; set; }
//    public DateTime ModificationDate { get; set; }
//    public int ModifiedByUserId { get; set; }
//    public Chi ModifiedByUser { get; set; }
//    public IList<Chi> Childs { get; set; }
//    //public int Id { get; set; }
//    //public int ParentId { get; set; }
//    //public Foo Parent { get; set; }
//    //public int UserId { get; set; }
//    //public DateTime CreationDate { get; set; }
//    //public int CreatedByUserId { get; set; }
//    //public User CreatedByUser { get; set; }
//    //public DateTime ModificationDate { get; set; }
//    //public int ModifiedByUserId { get; set; }
//    //public User ModifiedByUser { get; set; }
//    //public IList<Chi> Childs { get; set; }
//}
