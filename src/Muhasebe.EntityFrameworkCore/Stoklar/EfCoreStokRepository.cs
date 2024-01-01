namespace Muhasebe.Stoklar;
public class EfCoreStokRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Stok>(dbContextProvider), IStokRepository
{
}