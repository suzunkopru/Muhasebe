namespace Muhasebe.Cariler;
public class EfCoreCariRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Cari>(dbContextProvider), ICariRepository
{
}