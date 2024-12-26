namespace ova.Net.EntityFramework.Abstractions.RepositoryPattern.Onion.Core.Domain.Model;

/// <summary>Универсальный базовый интерфейс объекта, содержащий идентификатор.</summary>
public interface IEntityBase<T> where T : struct
{
    /// <summary>Получает или задает идентификатор объекта.</summary>
    T Id { get; set; }
}

/// <summary>Расширяет IEntityBase и добавляет имя.</summary>
public interface IEntity<T>: IEntityBase<T> where T : struct
{
    /// <summary>Получает или задает имя объекта.</summary>
    string Name { get; set; }
}