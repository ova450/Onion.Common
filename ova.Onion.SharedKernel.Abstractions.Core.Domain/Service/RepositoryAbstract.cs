


using Cobra.Core.SharedKernel.Abstractions.Domain.Model;

using Microsoft.EntityFrameworkCore;

namespace Cobra.Core.SharedKernel.Abstractions.Domain.Service
{
    /// <summary>
    /// Абстрактный класс репозитория, реализующий универсальный интерфейс IRepository.
    /// Предоставляет основные операции CRUD для объектов типа T.
    /// </summary>
    /// <typeparam name="T">Универсальный тип объекта в репозитории.</typeparam>
    /// <param name="context"></param>
    public abstract class RepositoryAbstract<T, TId>(DbContext context): IRepository<T,TId> 
        where T : class, IEntityBase<TId> 
        where TId : struct
    {
        protected DbContext _dbContext = context;

        /// <summary>Получает IQueryable<T> коллекцию всех объектов из репозитория.</summary>
        /// <returns>IQueryable<T> коллекция объектов.</returns>
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
}
