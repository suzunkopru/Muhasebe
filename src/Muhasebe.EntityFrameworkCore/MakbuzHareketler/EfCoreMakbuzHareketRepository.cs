using Muhasebe.Makbuzlar;

namespace Muhasebe.MakbuzHareketler;
public class EfCoreMakbuzHareketRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<MakbuzHareket>(dbContextProvider), IMakbuzHareketRepository
{
}