namespace Muhasebe.Faturalar;
public class EfCoreFaturaRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Fatura>(dbContextProvider), IFaturaRepository
{
}