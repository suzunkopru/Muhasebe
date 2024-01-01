namespace Muhasebe.Makbuzlar;
public class EfCoreMakbuzHareketRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Makbuz>(dbContextProvider), IMakbuzRepository
{
}