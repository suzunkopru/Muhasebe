namespace Muhasebe.Bankalar;
public class EfCoreBankaRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Banka>(dbContextProvider), IBankaRepository
{
}