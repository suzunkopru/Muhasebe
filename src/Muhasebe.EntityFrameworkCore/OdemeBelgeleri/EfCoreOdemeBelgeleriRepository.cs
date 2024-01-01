namespace Muhasebe.OdemeBelgeleri;
public class EfCoreOdemeBelgesiRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<OdemeBelgesi>(dbContextProvider), IOdemeBelgesiRepository
{
}