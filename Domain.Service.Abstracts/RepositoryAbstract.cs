
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using BaikalNetHub.CodeFirst.Domain.Model;

namespace BaikalNetHub.CodeFirst.Domain.Service.Abstracts;

/// <summary>
/// An abstract repository class that implements the IRepository universal interface. 
/// Provides basic CRUD operations for type T objects.
///   <br />
/// </summary>
/// <typeparam name="T">The universal type of the object</typeparam>
/// <typeparam name="TId">The type of the identifier.</typeparam>
public abstract class RepositoryAbstract<TId, T>(DbContext context): IRepository<TId, T>
    where T : class, IEntity<TId>
    where TId : struct
{
    /// <summary>
    /// The database context.
    /// </summary>
    protected DbContext _dbContext = context;

    /// <summary>Gets an IQueryable&lt;T&gt; collection of all objects from the repository.</summary>
    /// <returns>IQueryable&lt;T&gt; collection of all objects</returns>
    public IQueryable<T> GetAll() => _dbContext.Set<T>();

    /// <summary>Получает объект из репозитория по идентификатору.</summary>
    /// <param name="id">Идентификатор объекта.</param>
    /// <returns>Объект или null, если не найден.</returns>
    public T? Get(TId id) => GetAll().FirstOrDefault(d => d.Id.Equals(id));

    /// <summary>Добавляет новый объект в репозиторий.</summary>
    /// <param name="entity">Добавляемый объект.</param>
    public void Add(T entity) => _dbContext.Add(entity);


    /// <summary>Удаляет объект из репозитория.</summary>
    /// <param name="entity">Удаляемый объект.</param>
    public void Delete(T? entity) { if (entity != null) _dbContext.Remove(entity); }

    /// <summary>Удаляет объект из репозитория по идентификатору.</summary>
    /// <param name="id">Идентификатор удаляемого объекта.</param>
    public void Delete(TId id) => Delete(Get(id) ?? throw new ArgumentNullException(nameof(id), "Entity not found."));

    /// <summary>Обновляет существующий объект в репозитории.</summary>
    /// <param name="entity">Обновляемый объект.</param>
    public void Update(T entity) => _dbContext.Update(entity);

    /// <summary>Сохраняет изменения контекста в базу данных.</summary>
    public void SaveChanges() => _dbContext.SaveChanges();
}
