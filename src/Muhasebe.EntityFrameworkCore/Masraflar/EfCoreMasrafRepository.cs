namespace Muhasebe.Masraflar;
public class EfCoreMasrafRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Masraf>(dbContextProvider), IMasrafRepository
{
}