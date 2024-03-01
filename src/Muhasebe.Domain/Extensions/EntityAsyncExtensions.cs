using Muhasebe.Exceptions;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Muhasebe.Extensions;
public static class EntityAsyncExtensions
{
    public static async Task KodAnyAsync<TEntity>(this IReadOnlyRepository<TEntity> repository,
        string kod, Expression<Func<TEntity, bool>> predicate, bool check = true)
        where TEntity : class, IEntity, new()
    {
        if (check && await repository.AnyAsync(predicate))
            throw new DuplicateCodeException(kod);
    }
    public static async Task EntityAnyAsync<TEntity>(
           this IReadOnlyRepository<TEntity> repository, object id,
           Expression<Func<TEntity, bool>> predicate, bool check = true)
           where TEntity : class, IEntity
    {
        if (check && id != null)
        {
            var anyAsync = await repository.AnyAsync(predicate);

            if (!anyAsync)
                throw new EntityNotFoundException(typeof(TEntity), id);
        }
    }
}
