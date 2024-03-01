using Muhasebe.Extensions;
using Muhasebe.OzelKodlar;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
namespace Muhasebe.Bankalar;
public class BankaManager
    (IBankaRepository _bankaRepository, IOzelKodRepository _ozelKodRepository) : DomainService
{
    public async Task CheckCreateAsync(string kod, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _bankaRepository.KodAnyAsync(kod, x => x.Kod == kod);

        //await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1,
        //KartTuru.Banka);

        //await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2,
        //    KartTuru.Banka);
    }
    public async Task CheckUpdateAsync(Guid id, string kod, Banka Entity,
        Guid? OzelKod1Id, Guid? OzelKod2Id)
    {

    }
    public async Task CheckDeleteAsync(Guid id)
    {

    }
}
