namespace Muhasebe.Depolar;
public class EfCoreDepoRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Depo>(dbContextProvider), IDepoRepository
{
}