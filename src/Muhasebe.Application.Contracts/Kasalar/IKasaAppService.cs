namespace Muhasebe.Kasalar;

public interface IKasaAppService : Services.ICrudAppService<SelectKasaDto, ListKasaDto,
    KasaListParameterDto, CreateKasaDto, UpdateKasaDto, KasaCodeParameterDto>
{
}