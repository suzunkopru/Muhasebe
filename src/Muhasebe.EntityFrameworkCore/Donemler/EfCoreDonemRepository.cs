namespace Muhasebe.Donemler;
public class EfCoreDonemRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Donem>(dbContextProvider), IDonemRepository
{
}