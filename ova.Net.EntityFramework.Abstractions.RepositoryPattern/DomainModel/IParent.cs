namespace OVASOFT.NET.EF.Onion.Abstractions.DomainModel;

//public interface IParent<T, TId> where TId : struct where T : class, IEntityBase<TId>
//{
//    public TId ParentId { get; set; }
//    public T Parent { get; set; }
//}

public interface IParent<TId, T> where TId : struct where T : class, IEntity
    //public interface IParent<TId, IEntityBase> where TId : struct // where T : class, IEntityBase<TId>
{
    public TId ParentId { get; set; }
    public T Parent { get; set; }


    //// Реализация интерфейса IParent
    //int IParent<int, T>.ParentId { get; set; }
    //IEntityBase<int> IParent<int, T>.Parent { get; set; }

    //// Внешний ключ для связи с Foo
    //public int FooId
    //{
    //    get => ((IParent<int, T>) this).ParentId;
    //    set => ((IParent<int, T>) this).ParentId = value;
    //}


}
