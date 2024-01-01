namespace Muhasebe.BankaHesaplar;
public class EfCoreBankaHesapRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider) 
    : EfCoreCommonRepository<BankaHesap>(dbContextProvider), IBankaHesapRepository
{
}