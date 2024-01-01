namespace Muhasebe.OzelKodlar;
public class EfCoreOzelKodRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<OzelKod>(dbContextProvider), IOzelKodRepository
{
}