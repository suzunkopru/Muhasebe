namespace Muhasebe.OzelKodlar;

public interface IOzelKodAppService : Services.ICrudAppService<SelectOzelKodDto, ListOzelKodDto,
    OzelKodListParameterDto, CreateOzelKodDto, UpdateOzelKodDto, OzelKodCodeParameterDto>
{
}