﻿
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using BaikalNetHub.CodeFirst.Domain.Model;

namespace BaikalNetHub.CodeFirst.Domain.Service.Abstracts.Async;

/// <summary>
/// Универсальный абстрактный класс репозитория, реализующий асинхронные основные операции CRUD
/// путем имплементации универсального интерфейса IRepositoryAsync&lt;T&gt;.
/// Синхронные операции CRUD сохранены наследованием от другого абстрактного класса RepositoryAbstractAsync.
/// Предоставляет основные операции CRUD для объектов типа T.
/// </summary>
/// <typeparam name="T">Универсальный тип объектов в репозитории.</typeparam>
/// <typeparam name="TId">Тип идентификатора.</typeparam>
/// <param name="context">Контекст репозитория.</param>
public abstract class RepositoryAbstractAsync<TId, T>(DbContext context): RepositoryAbstract<TId, T>(context), IRepositoryAsync<TId, T>
    where T : class, IEntity<TId>
    where TId : struct
{
    /// <summary>
    /// Context
    /// </summary>
    protected DbContext _context = context;

    /// <summary>Асинхронно получает объект по идентификатору.</summary>
    /// <param name="id">Идентификатор объекта.</param>
    /// <returns>Объект или null, если не найден.</returns>
    public async Task<T?> GetAsync(TId id) => await GetAll().FirstOrDefaultAsync(d => d.Id.Equals(id));

    /// <summary>Асинхронно добавляет новый объект в репозиторий.</summary>
    /// <param name="entity">Добавляемый объект.</param>
    public async Task AddAsync(T entity) => await _context.AddAsync(entity);

    /// <summary>Асинхронно удаляет объект по идентификатору.</summary>
    /// <param name="id">Идентификатор удаляемого объекта.</param>
    public async Task DeleteAsync(TId id) => Delete(await GetAsync(id) ?? throw new ArgumentNullException(nameof(id), "Entity not found."));

    /// <summary>Асинхронно сохраняет изменения контекста в базу данных.</summary>
    public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
}