namespace Muhasebe.Kasalar;
public class EfCoreKasaRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Kasa>(dbContextProvider), IKasaRepository
{
}