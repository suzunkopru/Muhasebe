using Microsoft.EntityFrameworkCore;
using Muhasebe.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;

namespace Muhasebe.Commons;
public class EfCoreCommonRepository<TEntity> : EfCoreRepository<MuhasebeDbContext, TEntity, Guid>,
    ICommonRepository<TEntity> where TEntity : class, IEntity<Guid>
{
    public EfCoreCommonRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }
    public async Task<TEntity> GetAsync(object id, Expression<Func<TEntity, bool>>? predicate = null,
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var queryable = await WithDetailsAsync(includeProperties);
        TEntity entity = (await queryable.FirstOrDefaultAsync(predicate ?? (_ => true)))!;
        return entity ?? throw new EntityNotFoundException(typeof(TEntity), id);
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>>? predicate = null,
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var queryable = await WithDetailsAsync(includeProperties);
        return (await queryable.FirstOrDefaultAsync(predicate ?? (_ => true)))!;
    }

    public async Task<TEntity> GetAsync(object id, Expression<Func<TEntity, bool>>? predicate = null)
    {
        var queryable = await WithDetailsAsync();
        TEntity entity = (await queryable.FirstOrDefaultAsync(predicate ?? (_ => true)))!;
        return entity ?? throw new EntityNotFoundException(typeof(TEntity), id);
    }

    public async Task<List<TEntity>> GetPagedListAsync<TKey>(int skipCount, int maxResultCount,
        Expression<Func<TEntity, bool>>? predicate = null,
        Expression<Func<TEntity, TKey>>? orderBy = null,
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var queryable = await WithDetailsAsync(includeProperties);

        queryable = queryable.Where(predicate!) ?? queryable;
        queryable = queryable.OrderBy(orderBy!) ?? queryable;
        
        return await queryable
            .Skip(skipCount)
            .Take(maxResultCount)
            .ToListAsync();
    }

    public async Task<List<TEntity>> GetPagedListAsync<TKey>(int skipCount, int maxResultCount,
        Expression<Func<TEntity, bool>>? predicate = null,
        Expression<Func<TEntity, TKey>>? orderBy = null)
    {
        var queryable = await WithDetailsAsync();
        queryable = queryable.Where(predicate!) ?? queryable;
        queryable = queryable.OrderBy(orderBy!) ?? queryable;
        return await queryable
            .Skip(skipCount)
            .Take(maxResultCount)
            .ToListAsync();
    }

    public async Task<List<TEntity>> GetPagedLastListAsync<TKey>(int skipCount, int maxResultCount,
        Expression<Func<TEntity, bool>>? predicate = null,
        Expression<Func<TEntity, TKey>>? orderBy = null,
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var queryable = await WithDetailsAsync(includeProperties);
        queryable = predicate != null ? queryable.Where(predicate) : queryable;
        queryable = queryable.Where(predicate!) ?? queryable;
        queryable = queryable.OrderByDescending(orderBy!) ?? queryable;
        return await queryable
            .Skip(skipCount)
            .Take(maxResultCount)
            .ToListAsync();
    }

    public async Task<string> GetCodeAsync(Expression<Func<TEntity, string>> propertySelector,
        Expression<Func<TEntity, bool>>? predicate = null)
    {
        //static string CreateNewCode(string code)
        //{
        //    var number = "";
        //    foreach (var character in code)
        //    {
        //        number = char.IsDigit(character) ? number + character : "";
        //    }
        //    var newNumber = number == "" ? "1" : (long.Parse(number) + 1).ToString();
        //    var difference = code.Length - newNumber.Length;
        //    difference = difference < 0 ? 0 : difference;
        //    var newCode = code.Substring(0, difference);
        //    newCode += newNumber;
        //    return newCode;
        //}
        static string CreateNewCode(string kod)
        {
            int i = kod.Length; 
            while (i > 0 && char.IsDigit(kod[--i])) ;
            string onEk = kod.Substring(0, i + 1);
            string subStr = kod.Substring(i + 1);
            string rakamStr = string.IsNullOrEmpty(subStr) ? "1" : (long.Parse(subStr) + 1).ToString();
            return onEk + rakamStr;
        }
        var dbSet = await GetDbSetAsync();
        var maxCode = predicate == null ?
            await dbSet.MaxAsync(propertySelector) :
            await dbSet.Where(predicate).MaxAsync(propertySelector);
        return maxCode == null ? "0000000000000001" : CreateNewCode(maxCode);
    }

    public async Task<IList<TEntity>> FromSqlRawAsync(string sql, params object[] parameters)
    {
        var context = await GetDbContextAsync();
        return await context.Set<TEntity>().FromSqlRaw(sql, parameters).ToListAsync();
    }

    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? predicate = null)
    {
        var dbSet = await GetDbSetAsync();
        return predicate == null ? await dbSet.AnyAsync() : await dbSet.AnyAsync(predicate);
    }
}