
using System.Linq;
using System.Threading.Tasks;

using BaikalNetHub.CodeFirst.Domain.Model;

//using Ovasoft.Cofitools.Domain.Model;

namespace BaikalNetHub.CodeFirst.Domain.Service;

/// <summary>Универсальный интерфейс репозитория, предоставляющего базовые методы основных операции CRUD.</summary>
/// <typeparam name="T">Универсальный тип объектов репозитория.</typeparam>
/// <typeparam name="TId">Тип идентификатора.</typeparam>
public interface IRepository<TId, T> where T : class, IEntity<TId> where TId : struct
{
    /// <summary>Получает IQueryable&lt;T&gt; коллекцию всех объектов из репозитория.</summary>
    /// <returns>IQueryable&lt;T&gt; коллекция объектов.</returns>
    IQueryable<T> GetAll();

    /// <summary>Добавляет объект в репозиторий.</summary>
    /// <param name="entity">Добавляемый объект.</param>
    void Add(T entity);

    /// <summary>Удаляет объект из репозитория.</summary>
    /// <param name="entity">Удаляемый объект.</param>
    void Delete(T entity);

    /// <summary>Обновляет объект.</summary>
    /// <param name="entity">Обновляемый объект.</param>
    void Update(T entity);

    /// <summary>Сохраняет изменения в базу данных.</summary>
    void SaveChanges();

    /// <summary>Получает объект репозитория по идентификатору.</summary>
    /// <param name="id">Идентификатор объекта.</param>
    /// <returns>Объект репозитория или null, если не найден.</returns>
    T? Get(TId id);

    /// <summary>Удаляет объект из репозитория по идентификатору.</summary>
    /// <param name="id">Идентификатор удаляемого объекта.</param>
    void Delete(TId id);
}

/// <summary>Универсальный интерфейс репозитория, предоставляющего асинхронные базовые методы основных операции CRUD.</summary>
/// <typeparam name="T">Универсальный тип объектов репозитория.</typeparam>
/// <typeparam name="TId">Тип идентификатора объекта.</typeparam>
public interface IRepositoryAsync<TId, T>: IRepository<TId, T> where T : class, IEntity<TId> where TId : struct
{
    /// <summary>Асинхронно получает объект по идентификатору.</summary>
    /// <param name="id">Идентификатор объекта</param>
    /// <returns>Асинхронная задача, возвращающая объект или null.</returns>
    Task<T?> GetAsync(TId id);

    /// <summary>Асинхронно добавляет новый объект в репозиторий.</summary>
    /// <param name="entity">Добавляемый объект.</param>
    /// <returns>Асинхронная задача, добавляющая объект в репозиторий.</returns>
    Task AddAsync(T entity);

    /// <summary>Асинхронно удаляет объект по идентификатору.</summary>
    /// <param name="id">Идентификатор удаляемого объекта.</param>
    /// <returns>Асинхронная задача, удаляющая объект из репозитория.</returns>
    Task DeleteAsync(TId id);

    /// <summary>Сохраняет изменения в контексте базы данных асинхронно.</summary>
    /// <returns>Асинхронная задача, сохраняющая изменения в базу данных.</returns>
    Task SaveChangesAsync();
}

