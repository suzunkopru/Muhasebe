namespace Muhasebe.Subeler;
public class EfCoreSubeRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Sube>(dbContextProvider), ISubeRepository
{
}