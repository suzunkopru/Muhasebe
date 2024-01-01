namespace Muhasebe.Hizmetler;
public class EfCoreHizmetRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Hizmet>(dbContextProvider), IHizmetRepository
{
}