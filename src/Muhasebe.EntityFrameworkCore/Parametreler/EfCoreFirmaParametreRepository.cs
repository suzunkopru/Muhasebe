namespace Muhasebe.Parametreler;
public class EfCoreFirmaParametreRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<FirmaParametre>(dbContextProvider), IFirmaParametreRepository
{
}