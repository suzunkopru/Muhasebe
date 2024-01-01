namespace Muhasebe.BankaSubeler;
public class EfCoreBankaSubeRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<BankaSube>(dbContextProvider), IBankaSubeRepository
{
}