
namespace OVASOFT.NET.EntityFramework.RepositoryPattern.Abstractions.OnionCore.DomainModel;

/// <summary>Универсальный базовый интерфейс объекта, содержащий идентификатор.</summary>
/// <typeparam name="T">Тип идентификатора, структура. Например int, long, Guid</typeparam>
public interface IEntityBase<T> where T : struct
{
    /// <summary>Получает или задает идентификатор объекта.</summary>
    T Id { get; set; }
}

/// <summary>Расширяет IEntityBase и добавляет имя.</summary>
/// <typeparam name="T">Тип идентификатора, структура. Например int, long, Guid</typeparam>
public interface IEntity<T>: IEntityBase<T> where T : struct
{
    /// <summary>Получает или задает имя объекта.</summary>
    string Name { get; set; }
}

/// <summary>Базовый интерфейс объекта, содержащий идентификатор. Тип идентификатора - int, по умолчанию.</summary>
public interface IEntityBase: IEntityBase<int>{}

/// <summary>Расширяет IEntityBase и добавляет имя. Тип идентификатора - int, по умолчанию.</summary>
public interface IEntity: IEntity<int> { }
