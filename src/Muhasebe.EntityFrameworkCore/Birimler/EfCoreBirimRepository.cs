namespace Muhasebe.Birimler;
public class EfCoreBirimRepository(IDbContextProvider<MuhasebeDbContext> dbContextProvider)
    : EfCoreCommonRepository<Birim>(dbContextProvider), IBirimRepository
{
}