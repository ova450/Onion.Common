
namespace OVASOFT.NET.EntityFramework.RepositoryPattern.Abstractions.OnionCore.DomainModel;

/// <summary>Универсальный базовый интерфейс объекта, содержащий идентификатор.</summary>
/// <typeparam name="T">Тип идентификатора, структура. Например int, long, Guid</typeparam>
public abstract class EntityAbstractBase<T> : IEntityBase<T> where T : struct
{
    /// <summary>Получает или задает идентификатор объекта.</summary>
    public T Id { get; set; }
}

/// <summary>Расширяет IEntityBase и добавляет имя.</summary>
/// <typeparam name="T">Тип идентификатора, структура. Например int, long, Guid</typeparam>
public abstract class EntityAbstract<T> : IEntity<T> where T : struct
{
    /// <summary>Получает или задает идентификатор объекта.</summary>
    public T Id { get; set; }

    /// <summary>Получает или задает имя объекта.</summary>
    public string Name { get; set; }
}

/// <summary>Базовый интерфейс объекта, содержащий идентификатор. Тип идентификатора - int, по умолчанию.</summary>
public abstract class EntityAbstractBase: IEntityBase 
{
    /// <summary>Получает или задает идентификатор объекта.</summary>
    public int Id { get; set; }
}

/// <summary>Расширяет IEntityBase и добавляет имя. Тип идентификатора - int, по умолчанию.</summary>
public abstract class EntityAbstract: EntityAbstractBase, IEntity
{
    /// <summary>Получает или задает имя объекта.</summary>
    public string Name { get; set; }
}
