using Muhasebe.Faturalar;
namespace Muhasebe.FaturaHareketler;
public class EfCoreFaturaHareketRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<FaturaHareket>(dbContextProvider), IFaturaHareketRepository
{
}